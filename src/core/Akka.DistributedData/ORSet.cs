// -----------------------------------------------------------------------
//  <copyright file="ORSet.cs" company="Akka.NET Project">
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

namespace Akka.DistributedData
{
    internal interface IORSet<T>
    {
        IImmutableSet<T> Elements { get; }
    }

    public static class ORSet
    {
        public static ORSet<T> Create<T>(IImmutableSet<T> elements)
        {
            return new ORSet<T>(elements);
        }

        /// <summary>
        ///     INTERNAL API
        ///     Subtract the `vvector` from the `dot`.
        ///     What this means is that any (node, version) pair in
        ///     `dot` that is &lt;= an entry in `vvector` is removed from `dot`.
        ///     Example [{a, 3}, {b, 2}, {d, 14}, {g, 22}] -
        ///     [{a, 4}, {b, 1}, {c, 1}, {d, 14}, {e, 5}, {f, 2}] =
        ///     [{b, 2}, {g, 22}]
        /// </summary>
        public static VersionVector SubtractDots(VersionVector dot, VersionVector versionVector)
        {
            if (dot.IsEmpty)
            {
                return VersionVector.Empty;
            }
            if (dot is OneVersionVector)
            {
                // if dot is dominated by version vector, drop it
                var one = (OneVersionVector) dot;
                return versionVector.VersionAt(one.Node) >= one.Version ? VersionVector.Empty : dot;
            }
            if (dot is ManyVersionVector)
            {
                var many = (ManyVersionVector) dot;
                return VersionVector.Create(DropDots(many.Versions, null, versionVector));
            }
            return VersionVector.Empty;
        }

        private static IImmutableDictionary<UniqueAddress, long> DropDots(
            IImmutableDictionary<UniqueAddress, long> remaining,
            IImmutableDictionary<UniqueAddress, long> acc, VersionVector versionVector)
        {
            if (remaining == null || remaining.Count == 0)
            {
                return acc;
            }
            var head = remaining.First();
            var v2 = versionVector.VersionAt(head.Key);
            if (v2 >= head.Value)
            {
                // dot is dominated by version vector, drop it
                return DropDots(remaining.Skip(1).ToImmutableDictionary(), acc, versionVector);
            }
            return DropDots(remaining.Skip(1).ToImmutableDictionary(), acc.Add(head.Key, head.Value), versionVector);
        }

        public static IImmutableDictionary<T, VersionVector> MergeCommonKeys<T>(ISet<T> commonKeys, ORSet<T> lhs,
            ORSet<T> rhs)
        {
            return commonKeys.Aggregate(
                ImmutableDictionary<T, VersionVector>.Empty,
                (acc, k) =>
                {
                    var lhsDots = lhs.ElementsMap[k];
                    var rhsDots = rhs.ElementsMap[k];
                    if (lhsDots is OneVersionVector && rhsDots is OneVersionVector)
                    {
                        var lhsOneVersionVector = (OneVersionVector) lhsDots;
                        var rhsOneVersionVector = (OneVersionVector) rhsDots;
                        if (lhsOneVersionVector.Version == rhsOneVersionVector.Version &&
                            lhsOneVersionVector.Node == rhsOneVersionVector.Node)
                        {
                            // one single common dot
                            return acc.SetItem(k, lhsDots);
                        }
                        // no common, lhsUniqueDots == lhsDots, rhsUniqueDots == rhsDots
                        var lhsKeep = SubtractDots(lhsDots, rhs.VersionVector);
                        var rhsKeep = SubtractDots(rhsDots, lhs.VersionVector);
                        var merged = lhsKeep.Merge(rhsKeep);
                        // Perfectly possible that an item in both sets should be dropped
                        return merged.IsEmpty ? acc : acc.SetItem(k, merged);
                    }
                    if (lhsDots is ManyVersionVector && rhsDots is ManyVersionVector)
                    {
                        var lhsVs = (ManyVersionVector) lhsDots;
                        var rhsVs = (ManyVersionVector) rhsDots;
                        var commonDots =
                            lhsVs.Versions.Where(thisDotNode => rhsVs.VersionAt(thisDotNode.Key) == thisDotNode.Value)
                                .ToImmutableDictionary();
                        var commonDotsKeys = commonDots.Select(cd => cd.Key);
                        var lhsUniqueDots = lhsVs.Versions.RemoveRange(commonDotsKeys);
                        var rhsUniqueDots = rhsVs.Versions.RemoveRange(commonDotsKeys);
                        var lhsKeep = SubtractDots(VersionVector.Create(lhsUniqueDots), rhs.VersionVector);
                        var rhsKeep = SubtractDots(VersionVector.Create(rhsUniqueDots), lhs.VersionVector);
                        var merged = lhsKeep.Merge(rhsKeep).Merge(VersionVector.Create(commonDots));
                        // Perfectly possible that an item in both sets should be dropped
                        return merged.IsEmpty ? acc : acc.SetItem(k, merged);
                    }
                    if (lhsDots is ManyVersionVector && rhsDots is OneVersionVector)
                    {
                        var lhsVs = (ManyVersionVector) lhsDots;
                        var rhsVs = (OneVersionVector) rhsDots;
                        var commonDots =
                            lhsVs.Versions.Where(thisDotNode => rhsVs.VersionAt(thisDotNode.Key) == thisDotNode.Value)
                                .ToImmutableDictionary();
                        var commonDotsKeys = commonDots.Select(cd => cd.Key);
                        var lhsUniqueDots = lhsVs.Versions.RemoveRange(commonDotsKeys);
                        var rhsUnique = commonDotsKeys.Any() ? rhsDots : VersionVector.Empty;
                        var lhsKeep = SubtractDots(VersionVector.Create(lhsUniqueDots), rhs.VersionVector);
                        var rhsKeep = SubtractDots(rhsUnique, lhs.VersionVector);
                        var merged = lhsKeep.Merge(rhsKeep).Merge(VersionVector.Create(commonDots));
                        // Perfectly possible that an item in both sets should be dropped
                        return merged.IsEmpty ? acc : acc.SetItem(k, merged);
                    }
                    else
                    {
                        var lhsVs = (OneVersionVector) lhsDots;
                        var rhsVs = (ManyVersionVector) rhsDots;
                        var commonDots =
                            lhsVs.Versions.Where(thisDotNode => rhsVs.VersionAt(thisDotNode.Key) == thisDotNode.Value)
                                .ToImmutableDictionary();
                        var commonDotsKeys = commonDots.Select(cd => cd.Key);
                        var rhsUniqueDots = lhsVs.Versions.RemoveRange(commonDotsKeys);
                        var lhsUnique = commonDotsKeys.Any() ? rhsDots : VersionVector.Empty;
                        var lhsKeep = SubtractDots(lhsUnique, rhs.VersionVector);
                        var rhsKeep = SubtractDots(VersionVector.Create(rhsUniqueDots), lhs.VersionVector);
                        var merged = lhsKeep.Merge(rhsKeep).Merge(VersionVector.Create(commonDots));
                        // Perfectly possible that an item in both sets should be dropped
                        return merged.IsEmpty ? acc : acc.SetItem(k, merged);
                    }
                }
                );
        }

        public static IImmutableDictionary<T, VersionVector> MergeDisjointKeys<T>(IImmutableSet<T> keys,
            IImmutableDictionary<T, VersionVector> elementsMap, VersionVector versionVector,
            IImmutableDictionary<T, VersionVector> accumulator)
        {
            return keys.Aggregate(accumulator, (acc, k) =>
            {
                var dots = elementsMap[k];
                if (versionVector.IsAfter(dots) || versionVector.IsConcurent(dots))
                {
                    return acc;
                }
                // Optimise the set of stored dots to include only those unseen
                var newDots = SubtractDots(dots, versionVector);
                return acc.SetItem(k, newDots);
            });
        }
    }


    public sealed class ORSet<T> : IReplicatedDataSerialization, IORSet<T>, IRemovedNodePruning<ORSet<T>>, IFastMerge
    {
        private readonly VersionVector _dot = VersionVector.Create();
        private readonly IImmutableSet<T> _elements;

        public ORSet(IImmutableDictionary<T, VersionVector> elementsMap, VersionVector versionVector)
            : this(ImmutableHashSet<T>.Empty)
        {
            ElementsMap = elementsMap;
            VersionVector = versionVector;
        }

        public ORSet(IImmutableSet<T> elements)
        {
            _elements = elements;
        }

        public IImmutableDictionary<T, VersionVector> ElementsMap { get; set; }
        public VersionVector VersionVector { get; set; }

        public IImmutableSet<T> Elements
        {
            get { return _elements; }
        }

        public bool IsEmpty
        {
            get { return _elements.Count == 0; }
        }

        public int Count
        {
            get { return _elements.Count; }
        }

        public IFastMerge Ancestor { get; set; }

        IImmutableSet<T> IORSet<T>.Elements
        {
            get { return _elements.ToImmutableHashSet(); }
        }


        /// <summary>
        ///     When element is in this Set but not in that Set:
        ///     Compare the "birth dot" of the present element to the version vector in the Set it is absent from.
        ///     If the element dot is not "seen" by other Set version vector, that means the other set has yet to
        ///     see this add, and the element is to be in the merged Set.
        ///     If the other Set version vector dominates the dot, that means the other Set has removed
        ///     the element already, and the element is not to be in the merged Set.
        ///     When element in both this Set and in that Set:
        ///     Some dots may still need to be shed. If this Set has dots that the other Set does not have,
        ///     and the other Set version vector dominates those dots, then we need to drop those dots.
        ///     Keep only common dots, and dots that are not dominated by the other sides version vector
        /// </summary>
        public ORSet<T> Merge(ORSet<T> that)
        {
            if (Equals(that) || that.IsAncestorOf(this))
            {
                return (ORSet<T>) this.ClearAncestor();
            }
            if (this.IsAncestorOf(that))
            {
                return (ORSet<T>) that.ClearAncestor();
            }
            var commonKeys = ElementsMap.Count < that.ElementsMap.Count
                ? ElementsMap.Where(e => that.ElementsMap.Contains(e)).Select(i => i.Key).ToImmutableHashSet()
                : that.ElementsMap.Where(e => ElementsMap.Contains(e)).Select(i => i.Key).ToImmutableHashSet();


            var entries00 = ORSet.MergeCommonKeys(commonKeys, this, that);
            var thisUniqueKeys =
                ElementsMap.Where(e => !that.ElementsMap.Contains(e)).Select(i => i.Key).ToImmutableHashSet();
            var entries0 = ORSet.MergeDisjointKeys(thisUniqueKeys, ElementsMap, that.VersionVector, entries00);
            var thatUniqueKeys =
                that.ElementsMap.Where(e => !ElementsMap.Contains(e)).Select(i => i.Key).ToImmutableHashSet();
            var entries = ORSet.MergeDisjointKeys(thatUniqueKeys, that.ElementsMap, VersionVector, entries0);
            var mergedVvector = VersionVector.Merge(that.VersionVector);

            this.ClearAncestor();
            return new ORSet<T>(entries, mergedVvector);
        }

        public bool NeedPruningFrom(UniqueAddress removedNode)
        {
            return VersionVector.NeedPruningFrom(removedNode);
        }


        ORSet<T> IRemovedNodePruning<ORSet<T>>.Prune(UniqueAddress removedNode, UniqueAddress collapseInto)
        {
            var pruned = ElementsMap.Aggregate(ImmutableDictionary<T, VersionVector>.Empty,
                (acc, k) =>
                    k.Value.NeedPruningFrom(removedNode)
                        ? acc.SetItem(k.Key, k.Value.Prune(removedNode, collapseInto))
                        : acc);
            if (pruned.IsEmpty)
            {
                return Copy(null, VersionVector.Prune(removedNode, collapseInto));
            }
            // re-add elements that were pruned, to bump dots to right vvector
            var newSet = new ORSet<T>(ElementsMap.AddRange(pruned), VersionVector.Prune(removedNode, collapseInto));
            return pruned.Keys.Aggregate(newSet,
                (acc, k) => acc.Add(collapseInto, k));
        }

        ORSet<T> IRemovedNodePruning<ORSet<T>>.PruningCleanup(UniqueAddress removedNode)
        {
            var updated = ElementsMap.Aggregate(ElementsMap, (acc, k) => k.Value.NeedPruningFrom(removedNode)
                ? acc.SetItem(k.Key, k.Value.PruningCleanup(removedNode))
                : acc);

            return new ORSet<T>(updated, VersionVector.PruningCleanup(removedNode));
        }

        private ORSet<T> Copy(IImmutableDictionary<T, VersionVector> elementsMap = null,
            VersionVector versionVector = null)
        {
            return new ORSet<T>(elementsMap ?? ElementsMap, versionVector ?? VersionVector);
        }

        public bool Contains(T element)
        {
            return _elements.Contains(element);
        }


        /// <summary>
        ///     Adds an element to the set
        /// </summary>
        public ORSet<T> Add(T element)
        {
            return new ORSet<T>(_elements.Add(element));
        }

        private ORSet<T> Add(UniqueAddress node, T element)
        {
            var newVector = VersionVector.Add(node);
            var newDot =
                VersionVector.Create(ImmutableDictionary<UniqueAddress, long>.Empty.Add(node, newVector.VersionAt(node)));
            return (ORSet<T>) this.AssignAncestor(new ORSet<T>(ElementsMap.SetItem(element, newDot), newVector));
        }


        public ORSet<T> Remove(UniqueAddress node, T element)
        {
            return (ORSet<T>) this.AssignAncestor(Copy(ElementsMap.Remove(element)));
        }

        public ORSet<T> Clear()
        {
            return (ORSet<T>) this.AssignAncestor(Copy(ImmutableDictionary<T, VersionVector>.Empty));
        }

        public override bool Equals(object obj)
        {
            var other = obj as ORSet<T>;
            if (other != null)
            {
                var elementsEqual = _elements.SetEquals(other.Elements);
                return elementsEqual;
            }
            return false;
        }

        public IReplicatedData Merge(IReplicatedData other)
        {
            return Merge((ORSet<T>) other);
        }
    }

    internal interface IORSetKey
    {
    }

    public sealed class ORSetKey<T> : Key<ORSet<T>>, IKeyWithGenericType, IORSetKey, IReplicatedDataSerialization
    {
        private readonly Type _type;

        public ORSetKey(string id)
            : base(id)
        {
            _type = typeof (T);
        }

        public Type Type
        {
            get { return _type; }
        }
    }
}