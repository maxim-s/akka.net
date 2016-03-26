// -----------------------------------------------------------------------
//  <copyright file="PNCounter.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System.Numerics;
using Akka.Cluster;
using Akka.DistributedData.Proto;

namespace Akka.DistributedData
{
    public sealed class PNCounter : AbstractReplicatedData<PNCounter>, IRemovedNodePruning<PNCounter>, IReplicatedDataSerialization
    {
        readonly GCounter _decrements;
        readonly GCounter _increments;

        public PNCounter()
            : this(GCounter.Empty, GCounter.Empty)
        { }

        public PNCounter(GCounter increments, GCounter decrements)
        {
            _increments = increments;
            _decrements = decrements;
        }

        public BigInteger Value
        {
            get { return _increments.Value - _decrements.Value; }
        }

        public GCounter Increments
        {
            get { return _increments; }
        }

        public GCounter Decrements
        {
            get { return _decrements; }
        }

        public override PNCounter Merge(PNCounter other)
        {
            return new PNCounter(_increments.Merge(other._increments), _decrements.Merge(other._decrements));
        }

        public bool NeedPruningFrom(UniqueAddress removedNode)
        {
            return _increments.NeedPruningFrom(removedNode) || _decrements.NeedPruningFrom(removedNode);
        }

        public PNCounter Prune(UniqueAddress removedNode, UniqueAddress collapseInto)
        {
            return new PNCounter(_increments.Prune(removedNode, collapseInto), _decrements.Prune(removedNode, collapseInto));
        }

        public PNCounter PruningCleanup(UniqueAddress removedNode)
        {
            return new PNCounter(_increments.PruningCleanup(removedNode), _decrements.PruningCleanup(removedNode));
        }

        public PNCounter Increment(Cluster.Cluster node, long delta = 1)
        {
            return Increment(node.SelfUniqueAddress, new BigInteger(delta));
        }

        public PNCounter Decrement(Cluster.Cluster node, long delta = 1)
        {
            return Decrement(node.SelfUniqueAddress, delta);
        }

        public PNCounter Increment(UniqueAddress address, long delta = 1)
        {
            return Increment(address, new BigInteger(delta));
        }

        public PNCounter Decrement(UniqueAddress address, long delta = 1)
        {
            return Decrement(address, new BigInteger(delta));
        }

        public PNCounter Increment(UniqueAddress address, BigInteger delta)
        {
            return Change(address, delta);
        }

        public PNCounter Decrement(UniqueAddress address, BigInteger delta)
        {
            return Change(address, -delta);
        }

        private PNCounter Change(UniqueAddress key, BigInteger delta)
        {
            if(delta > 0)
            {
                return new PNCounter(_increments.Increment(key, delta), _decrements);
            }
            if(delta < 0)
            {
                return new PNCounter(_increments, _decrements.Increment(key, -delta));
            }
            return this;
        }

        public override string ToString()
        {
            return string.Format("PNCounter({0})", Value);
        }

        public override bool Equals(object obj)
        {
            var other = obj as PNCounter;
            if(other != null)
            {
                return other._increments == _increments && other._decrements == _decrements;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _increments.GetHashCode() ^ _decrements.GetHashCode();
        }
    }

    public sealed class PNCounterKey : Key<PNCounter>
    {
        public PNCounterKey(string id)
            : base(id)
        { }
    }
}
