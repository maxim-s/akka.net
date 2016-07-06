// -----------------------------------------------------------------------
//  <copyright file="ORMap.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Lightbend Inc. <http://www.lightbend.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Akka.Cluster;
using Akka.DistributedData.Proto;
using Akka.Pattern;
using Akka.Util.Internal;

namespace Akka.DistributedData
{
    /// <summary>
    /// Implements a 'Observed Remove Map' CRDT, also called a 'OR-Map'.
    /// 
    /// It has similar semantics as an <see cref="ORSet"/>, but in case of concurrent updates
    /// the values are merged, and must therefore be <see cref="IReplicatedData"/> types themselves.
    /// 
    /// This class is immutable, i.e. "modifying" methods return a new instance.
    /// </summary>
    public sealed class ORMap<T> : IRemovedNodePruning<ORMap<T>> where T : IReplicatedData
    {
        private readonly ORSet<string> _keys;
        private readonly IImmutableDictionary<string, T> _values;
        public static readonly ORMap<T> Empty = new ORMap<T>(ORSet<string>.Empty, ImmutableDictionary<string, T>.Empty);

        public ORMap(ORSet<string> keys, IImmutableDictionary<string, T> values)
        {
            _keys = keys;
            _values = values;
        }


        /// <summary>
        /// All entries of the map.
        /// </summary>
        public IImmutableDictionary<string, T> Entires
        {
            get { return _values; }
        }


        public T Get(string key)
        {
            return _values[key];
        }

        /// <summary>
        /// Get the value associated with the key if there is one, else return the given default.
        /// </summary>
        public T GetOrElse(string key, T defaultValue)
        {
            return _values.GetValueOrDefault(key, defaultValue);
        }

        public bool Contains(string key)
        {
            return _values.ContainsKey(key);
        }

        public bool IsEmpty
        {
            get { return _values.Count == 0; }
        }

        public int Count
        {
            get { return _values.Count; }
        }

        public ORSet<string> Keys
        {
            get { return _keys; }
        }


        /// <summary>
        /// Adds an entry to the map.
        /// Note that the new `value` will be merged with existing values
        /// on other nodes and the outcome depends on what `ReplicatedData`
        /// type that is used.
        /// 
        /// Consider using [[#updated]] instead of `put` if you want modify
        /// existing entry.
        /// 
        /// `IllegalArgumentException` is thrown if you try to replace an existing `ORSet`
        /// value, because important history can be lost when replacing the `ORSet` and
        /// undesired effects of merging will occur.Use <see cref="Messages.ORMultiMap"/> or[[#updated]] instead.
        /// </summary>

        public ORMap<T> Put(Cluster.Cluster node, string key, T value)
        {
            return Put(node.SelfUniqueAddress, key, value);

        }

        public ORMap<T> Put(UniqueAddress node, string key, T value)
        {
            if (value is IORSet && _values.ContainsKey(key))
            {
                throw new ArgumentException("`ORMap.Put` must not be used to replace an existing `ORSet` " +
          "value, because important history can be lost when replacing the `ORSet` and " +
          "undesired effects of merging will occur. Use `ORMultiMap` or `ORMap.updated` instead.");
            }
            return new ORMap<T>(_keys.Add(node, key), _values.SetItem(key, value));

        }


        /// <summary>
        /// Removes an entry from the map.
        /// Note that if there is a conflicting update on another node the entry will
        /// not be removed after merge.
        /// </summary>
        public ORMap<T> Remove(Cluster.Cluster node, string key)
        {
            return Remove(node.SelfUniqueAddress, key);
        }

        public ORMap<T> Remove(UniqueAddress node, string key)
        {
            return new ORMap<T>(_keys.Remove(node, key), _values.Remove(key));
        }
        /// <summary>
        /// Replace a value by applying the `modify` function on the existing value.
        ///
        /// If there is no current value for the `key` the `initial` value will be
        /// passed to the `modify` function.
        /// </summary>
        public ORMap<T> Updated(UniqueAddress node, string key, T initial, Func<T, T> modify)
        {
            T newValue = modify(_values.TryGetValue(key, out newValue) ? newValue : initial);

            return new ORMap<T>(_keys.Add(node, key), _values.SetItem(key, newValue));

        }

        public ORMap<T> Merge(ORMap<T> that)
        {
            var mergedKeys = _keys.Merge(that.Keys);
            var mergedValues = ImmutableDictionary<string, T>.Empty;
            foreach (var key in mergedKeys.ElementsMap.Keys)
            {

                T thisValue;
                var hasThisValue = _values.TryGetValue(key, out thisValue);
                T thatValue;
                var hasThatValue = that.Entires.TryGetValue(key, out thatValue);
                if (hasThisValue && hasThatValue)
                {
                    if (thisValue.GetType() != thatValue.GetType())
                    {
                        var message =
                            string.Format("Wrong type for merging [{0}] in [{1}], existing type [{2}], got [{3}]",
                                key, GetType(), thisValue.GetType(), thatValue.GetType());
                        throw new ArgumentException(message);
                    }
                    // TODO can we get rid of these (safe) casts?
                    mergedValues = mergedValues.SetItem(key, (T)thisValue.Merge(thatValue));
                }
                if (hasThisValue && !hasThatValue)
                {
                    mergedValues = mergedValues.SetItem(key, thisValue);
                }
                if (hasThatValue && !hasThisValue)
                {
                    mergedValues = mergedValues.SetItem(key, thatValue);
                }
                if (!hasThatValue && !hasThisValue)
                {
                    throw new IllegalStateException("missing value for " + key);
                }
            }

            return new ORMap<T>(mergedKeys, mergedValues);
        }

        public IReplicatedData Merge(IReplicatedData other)
        {
            return Merge((ORMap<T>)other);
        }

        public bool NeedPruningFrom(UniqueAddress removedNode)
        {
            if (_keys.NeedPruningFrom(removedNode))
            {
                return true;
            }
            foreach (var value in _values.Values)
            {
                if (value is IRemovedNodePruning)
                {
                    return ((IRemovedNodePruning) value).NeedPruningFrom(removedNode);
                }
            }
            return false;
        }

        public ORMap<T> Prune(UniqueAddress removedNode, UniqueAddress collapseInto)
        {
            var prunedKeys = _keys.Prune(removedNode, collapseInto);
            var prunedValues = _values.Aggregate(_values, (pairs, pair) =>
            {
                if (pair.Value is IRemovedNodePruning)
                {
                    var data = (IRemovedNodePruning) pair.Value;
                    if (data.NeedPruningFrom(removedNode))
                    {
                        return pairs.SetItem(pair.Key, (T) data.Prune(removedNode, collapseInto));
                    }
                }
                return pairs;
            });
            return new ORMap<T>(prunedKeys, prunedValues);
        }

        public ORMap<T> PruningCleanup(UniqueAddress removedNode)
        {
            var pruningCleanupedKeys = _keys.PruningCleanup(removedNode);
            var pruningCleanupedValues = _values.Aggregate(_values, (pairs, pair) =>
            {
                if (pair.Value is IRemovedNodePruning)
                {
                    var data = (IRemovedNodePruning)pair.Value;
                    if (data.NeedPruningFrom(removedNode))
                    {
                        return pairs.SetItem(pair.Key, (T)data.PruningCleanup(removedNode));
                    }
                }
                return pairs;
            });

            return new ORMap<T>(pruningCleanupedKeys, pruningCleanupedValues);
        }
    }

    public sealed class ORMapKey<T> : Key<ORMap<T>>, IKeyWithGenericType, IORSetKey, IReplicatedDataSerialization where T : IReplicatedData
    {
        private readonly Type _type;

        public ORMapKey(string id)
            : base(id)
        {
            _type = typeof(T);
        }

        public Type Type
        {
            get { return _type; }
        }
    }



}