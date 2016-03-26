// -----------------------------------------------------------------------
//  <copyright file="PruningState.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Immutable;
using Akka.Actor;
using Akka.Cluster;

namespace Akka.DistributedData
{
    internal interface IPruningPhase {}

    internal sealed class PruningInitialized : IPruningPhase
    {
        readonly IImmutableSet<Address> _seen;

        public PruningInitialized(IImmutableSet<Address> seen)
        {
            _seen = seen;
        }

        public IImmutableSet<Address> Seen
        {
            get { return _seen; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as PruningInitialized;
            if(other != null)
            {
                return _seen.SetEquals(other._seen);
            }
            return false;
        }
    }

    internal sealed class PruningPerformed : IPruningPhase
    {
        static readonly PruningPerformed _instance = new PruningPerformed();

        private PruningPerformed()
        { }

        public static PruningPerformed Instance { get { return _instance; } }

        public override bool Equals(object obj)
        {
            return obj != null && obj is PruningPerformed;
        }
    }

    internal sealed class PruningState
    {
        readonly UniqueAddress _owner;
        readonly IPruningPhase _phase;

        public PruningState(UniqueAddress owner, IPruningPhase phase)
        {
            _owner = owner;
            _phase = phase;
        }

        public UniqueAddress Owner
        {
            get { return _owner; }
        }

        public IPruningPhase Phase
        {
            get { return _phase; }
        }

        internal PruningState AddSeen(Address node)
        {
            if(_phase is PruningPerformed)
            {
                return this;
            }
            if(_phase is PruningInitialized)
            {
                var p = (PruningInitialized)_phase;
                if(p.Seen.Contains(node) || _owner.Address == node)
                {
                    return this;
                }
                return new PruningState(Owner, new PruningInitialized(p.Seen.Add(node)));
            }
            throw new Exception("Invalid pruning phase provided");
        }

        internal PruningState Merge(PruningState that)
        {
            if(Phase is PruningPerformed)
            {
                return this;
            }
            if(that.Phase is PruningPerformed)
            {
                return that;
            }
            if(Phase is PruningInitialized && that.Phase is PruningInitialized)
            {
                var p1 = (PruningInitialized)Phase;
                var p2 = (PruningInitialized)that.Phase;
                if(Owner == that.Owner)
                {
                    return new PruningState(Owner, new PruningInitialized(p1.Seen.Union(p2.Seen)));
                }
                if(Member.AddressOrdering.Compare(Owner.Address, that.Owner.Address) > 0)
                {
                    return that;
                }
                return this;
            }
            throw new Exception("Invalid pruning state provided");
        }

        public override bool Equals(object obj)
        {
            var other = obj as PruningState;
            if(other != null)
            {
                var equal = _owner.Equals(other._owner) && _phase.Equals(other._phase);
                return equal;
            }
            return false;
        }
    }
}
