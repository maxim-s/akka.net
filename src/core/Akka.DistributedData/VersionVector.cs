// -----------------------------------------------------------------------
//  <copyright file="VersionVector.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Lightbend Inc. <http://www.lightbend.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;

using Akka.Cluster;
using Akka.Util.Internal;
using Akka.Util.Internal.Collections;

namespace Akka.DistributedData
{
    /// <summary>
    ///     Representation of a Vector-based clock (counting clock), inspired by Lamport logical clocks.
    ///     Based on code from <see cref="Akka.Cluster.VectorClock" />
    ///     This class is immutable, i.e. "modifying" methods return a new instance.
    /// </summary>
    /// <remarks>
    ///     Reference:
    ///     1) Leslie Lamport (1978). "Time, clocks, and the ordering of events in a distributed system". Communications of the
    ///     ACM 21 (7): 558-565.
    ///     2) Friedemann Mattern (1988). "Virtual Time and Global States of Distributed Systems". Workshop on Parallel and
    ///     Distributed Algorithms: pp. 215-226
    /// </remarks>
    public abstract class VersionVector : AbstractReplicatedData<VersionVector>, IRemovedNodePruning<VersionVector>
    {
        protected const long Zero = 0;

        public static readonly VersionVector Empty =
            new ManyVersionVector(ImmutableDictionary<UniqueAddress, long>.Empty);

        private static readonly KeyValuePair<UniqueAddress, long> CmpEndMarker =
            new KeyValuePair<UniqueAddress, long>(null, long.MinValue);

        protected VersionVector(IImmutableDictionary<UniqueAddress, long> versions)
        {
            Versions = versions;
        }

        public abstract bool IsEmpty { get; }

        public abstract int Size { get; }

        public IImmutableDictionary<UniqueAddress, long> Versions { get; }

        protected abstract Iterator<KeyValuePair<UniqueAddress, long>> VersionsIterator { get; }

        public static VersionVector Create(IImmutableDictionary<UniqueAddress, long> elements = null)
        {
            if (elements == null || elements.Count == 0)
            {
                return Empty;
            }
            if (elements.Count == 1)
            {
                var head = elements.First();
                return new OneVersionVector(head.Key, head.Value);
            }
            return new ManyVersionVector(elements);
        }

        /// <summary>
        ///     Increment the version for the node passed as argument.
        /// </summary>
        /// <returns>a new VersionVector</returns>
        public VersionVector Add(Cluster.Cluster node)
        {
            return Increment(node);
        }

        /// <summary>
        ///     INTERNAL API
        ///     Increment the version for the node passed as argument.
        /// </summary>
        /// <returns>a new VersionVector</returns>
        public VersionVector Add(UniqueAddress node)
        {
            return Increment(node);
        }

        /// <summary>
        ///     Returns true if this VersionVector has the same history as the 'that' VersionVector else false.
        /// </summary>
        public bool IsSame(VersionVector that)
        {
            return CompareOnlyTo(that, Ordering.Same) == Ordering.Same;
        }

        public VersionVector Increment(Cluster.Cluster node)
        {
            return Increment(node.SelfUniqueAddress);
        }

        /// <summary>
        ///     INTERNAL API
        ///     Increment the version for the node passed as argument. Returns a new VersionVector.
        /// </summary>
        public abstract VersionVector Increment(UniqueAddress node);

        /// <summary>
        ///     Returns true if <code>this</code> is after <code>that</code> else false.
        /// </summary>
        public bool IsAfter(VersionVector that)
        {
            return CompareOnlyTo(that, Ordering.After) == Ordering.After;
        }

        /// <summary>
        ///     Returns true if <code>this</code> is before <code>that</code> else false.
        /// </summary>
        public bool IsBefore(VersionVector that)
        {
            return CompareOnlyTo(that, Ordering.Before) == Ordering.Before;
        }

        /// <summary>
        ///     Returns true if <code>this</code> and <code>that</code> are concurrent else false.
        /// </summary>
        public bool IsConcurent(VersionVector that)
        {
            return CompareOnlyTo(that, Ordering.Concurent) == Ordering.Concurent;
        }

        public abstract bool NeedPruningFrom(UniqueAddress removedNode);

        public abstract VersionVector Prune(UniqueAddress removedNode, UniqueAddress collapseInto);

        public abstract VersionVector PruningCleanup(UniqueAddress removedNode);

        /// <summary>
        ///     INTERNAL API
        /// </summary>
        public abstract bool Contains(UniqueAddress node);

        /// <summary>
        ///     INTERNAL API
        /// </summary>
        public abstract long VersionAt(UniqueAddress node);

        private Ordering Compare(
            Iterator<KeyValuePair<UniqueAddress, long>> firstIterator,
            Iterator<KeyValuePair<UniqueAddress, long>> secondIterator,
            Ordering requestedOrder)
        {
            var firstPair = NextOrElse(firstIterator, CmpEndMarker);
            var secondPair = NextOrElse(secondIterator, CmpEndMarker);
            Ordering currentOrder = Ordering.Same;

            Ordering result = Ordering.Default;
            while (result == Ordering.Default)
            {
                if (requestedOrder != Ordering.FullOrder && currentOrder != Ordering.Same
                    && requestedOrder != currentOrder)
                {
                    result = currentOrder;
                } else if (firstPair.Equals(CmpEndMarker) && secondPair.Equals(CmpEndMarker))
                {
                    result = currentOrder;
                }
                // firstIterator is empty but secondIterator is not, so firstIterator can only be Before
                else if (firstPair.Equals(CmpEndMarker))
                {
                    result = currentOrder == Ordering.After ? Ordering.Concurent : Ordering.Before;
                }
                // secondIterator is empty but firstIterator is not, so firstIterator can only be After
                else if (secondPair.Equals(CmpEndMarker))
                {
                    result = currentOrder == Ordering.Before ? Ordering.Concurent : Ordering.After;
                }
                else
                {
                    // compare the nodes
                    var nc = firstPair.Key.CompareTo(secondPair.Key);
                    if (nc == 0)
                    {
                        // both nodes exist compare the timestamps
                        // same timestamp so just continue with the next nodes
                        if (firstPair.Value == secondPair.Value)
                        {
                            firstPair = NextOrElse(firstIterator, CmpEndMarker);
                            secondPair = NextOrElse(secondIterator, CmpEndMarker);
                        }
                        else if (firstPair.Value < secondPair.Value)
                        {
                            // fisrstAndress is less than secondAdress, so i1 can only be Before
                            if (currentOrder == Ordering.After)
                            {
                                result = Ordering.Concurent;
                            }
                            else
                            {
                                firstPair = NextOrElse(firstIterator, CmpEndMarker);
                                secondPair = NextOrElse(secondIterator, CmpEndMarker);
                                currentOrder = Ordering.Before;
                            }
                        }
                        else
                        {
                            // t2 is less than t1, so i1 can only be After
                            if (currentOrder == Ordering.Before)
                            {
                                result = Ordering.Concurent;
                            }
                            else
                            {
                                firstPair = NextOrElse(firstIterator, CmpEndMarker);
                                secondPair = NextOrElse(secondIterator, CmpEndMarker);
                                currentOrder = Ordering.After;
                            }
                        }
                    }
                    else if (nc < 0)
                    {
                        // this node only exists in i1 so i1 can only be After
                        if (currentOrder == Ordering.Before)
                        {
                            result = Ordering.Concurent;
                        }
                        else
                        {
                            firstPair = NextOrElse(firstIterator, CmpEndMarker);
                            currentOrder = Ordering.After;
                        }
                    }
                    else
                    {
                        // this node only exists in i2 so i1 can only be Before

                        if (currentOrder == Ordering.After)
                        {
                            result = Ordering.Concurent;
                        }
                        else
                        {
                            secondPair = NextOrElse(secondIterator, CmpEndMarker);
                            currentOrder = Ordering.Before;
                        }
                    }
                }
            }
            return result;
            //return CompareNext(firstPair, secondPair, new Same(), requestedOrder, firstIterator, secondIterator);
        }

        /// <summary>
        ///     Version vector comparison according to the semantics described by compareTo, with the ability to bail
        ///     out early if the we can't reach the Ordering that we are looking for.
        ///     The ordering always starts with Same and can then go to Same, Before or After
        ///     If we're on After we can only go to After or Concurrent
        ///     If we're on Before we can only go to Before or Concurrent
        ///     If we go to Concurrent we exit the loop immediately
        ///     If you send in the ordering FullOrder, you will get a full comparison.
        /// </summary>
        private Ordering CompareOnlyTo(VersionVector that, Ordering order)
        {
            if (this.Equals(that))
            {
                return Ordering.Same;
            }

            var requestedOrder = order == Ordering.Concurent ? Ordering.FullOrder : order;
            return Compare(VersionsIterator, that.VersionsIterator, requestedOrder);
        }

        private T NextOrElse<T>(Iterator<T> iter, T defaultValue)
        {
            return iter.IsEmpty() ? defaultValue : iter.Next();
        }

        public override bool Equals(object obj)
        {
            var other = obj as VersionVector;
            if (other != null)
            {
                return Versions.SequenceEqual(other.Versions);
            }
            return false;
        }

        public class Timestamp
        {
            private static readonly Timestamp _instance = new Timestamp();

            private readonly AtomicCounterLong _counter = new AtomicCounterLong(1);

            private Timestamp()
            {
                
            }

            public static Timestamp Instance
            {
                get
                {
                    return _instance;
                }
            }

            public AtomicCounterLong Counter
            {
                get
                {
                    return _counter;
                }
            }
        }
    }

    public enum Ordering
    {
        FullOrder,

        Same,

        After,

        Before,

        Concurent,

        Default
    }

    public class OneVersionVector : VersionVector
    {
        public OneVersionVector(UniqueAddress node, long version)
            : base(ImmutableDictionary<UniqueAddress, long>.Empty.Add(node, version))
        {
            Node = node;
            Version = version;
        }

        public override bool IsEmpty
        {
            get
            {
                return false;
            }
        }

        public UniqueAddress Node { get; }

        public long Version { get; }

        public override int Size
        {
            get
            {
                return 1;
            }
        }

        protected override Iterator<KeyValuePair<UniqueAddress, long>> VersionsIterator
        {
            get
            {
                return
                    new Iterator<KeyValuePair<UniqueAddress, long>>(
                        new[] { new KeyValuePair<UniqueAddress, long>(Node, Version) });
            }
        }

        public override VersionVector Increment(UniqueAddress node)
        {
            var v = Timestamp.Instance.Counter.GetAndIncrement();
            return Node == node
                       ? Copy(null, v)
                       : new ManyVersionVector(
                             ImmutableDictionary<UniqueAddress, long>.Empty.Add(Node, Version).Add(node, v));
        }

        public override VersionVector Merge(VersionVector other)
        {
            if (other is OneVersionVector)
            {
                var one = (OneVersionVector)other;
                if (Node == one.Node)
                {
                    return Version >= one.Version ? this : new OneVersionVector(one.Node, one.Version);
                }
                return
                    new ManyVersionVector(
                        ImmutableDictionary<UniqueAddress, long>.Empty.Add(Node, Version).Add(one.Node, one.Version));
            }
            if (other is ManyVersionVector)
            {
                var many = (ManyVersionVector)other;
                var v2 = many.Versions.GetValueOrDefault(Node, Zero);
                return VersionVector.Create(v2 >= Version ? many.Versions : many.Versions.SetItem(Node, Version));
            }

            return other;
        }

        public override bool NeedPruningFrom(UniqueAddress removedNode)
        {
            return Node == removedNode;
        }

        public override VersionVector Prune(UniqueAddress removedNode, UniqueAddress collapseInto)
        {
            return (Node == removedNode ? Empty : this).Add(collapseInto);
        }

        public override VersionVector PruningCleanup(UniqueAddress removedNode)
        {
            return Node == removedNode ? Empty : this;
        }

        public override bool Contains(UniqueAddress node)
        {
            return Node == node;
        }

        public override long VersionAt(UniqueAddress node)
        {
            return Node == node ? Version : Zero;
        }

        private VersionVector Copy(UniqueAddress node = null, long? version = null)
        {
            return new OneVersionVector(node ?? Node, version ?? Version);
        }
    }

    public class ManyVersionVector : VersionVector
    {
        public ManyVersionVector(IImmutableDictionary<UniqueAddress, long> versions)
            : base(versions)
        {
        }

        public override bool IsEmpty
        {
            get
            {
                return Versions.Count == 0;
            }
        }

        public override int Size
        {
            get
            {
                return Versions.Count;
            }
        }

        protected override Iterator<KeyValuePair<UniqueAddress, long>> VersionsIterator
        {
            get
            {
                return Versions.Iterator();
            }
        }

        public override VersionVector Increment(UniqueAddress node)
        {
            var version = Timestamp.Instance.Counter.GetAndIncrement();
            return Create(Versions.SetItem(node, version));
        }

        public override VersionVector Merge(VersionVector other)
        {
            IImmutableDictionary<UniqueAddress, long> mergedVersions = null;
            if (other is ManyVersionVector)
            {
                var many = (ManyVersionVector)other;
                mergedVersions = many.Versions;
                foreach (var keyValuePair in Versions)
                {
                    var mergedVersionsCurrentTime = mergedVersions.GetValueOrDefault(keyValuePair.Key, Zero);
                    if (keyValuePair.Value > mergedVersionsCurrentTime)
                    {
                        mergedVersions = mergedVersions.SetItem(keyValuePair.Key, keyValuePair.Value);
                    }
                }
            }
            if (other is OneVersionVector)
            {
                var one = (OneVersionVector)other;
                var v1 = Versions.GetValueOrDefault(one.Node, Zero);
                mergedVersions = v1 >= one.Version ? Versions : Versions.Add(one.Node, one.Version);
            }
            return Create(mergedVersions);
        }

        public override bool NeedPruningFrom(UniqueAddress removedNode)
        {
            return Versions.ContainsKey(removedNode);
        }

        public override VersionVector Prune(UniqueAddress removedNode, UniqueAddress collapseInto)
        {
            return Create(Versions.Remove(removedNode)).Increment(collapseInto);
        }

        public override VersionVector PruningCleanup(UniqueAddress removedNode)
        {
            return Create(Versions.Remove(removedNode));
        }

        public override bool Contains(UniqueAddress node)
        {
            return Versions.ContainsKey(node);
        }

        public override long VersionAt(UniqueAddress node)
        {
            long version;
            if (Versions.TryGetValue(node, out version))
            {
                return version;
            }
            return Zero;
        }
    }
}