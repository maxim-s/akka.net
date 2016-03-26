// -----------------------------------------------------------------------
//  <copyright file="ReadWriteAggregator.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Immutable;
using System.Linq;
using Akka.Actor;

namespace Akka.DistributedData
{
    public abstract class ReadWriteAggregator : ActorBase
    {
        private static readonly int MaxSecondaryNodes = 10;
        readonly IImmutableSet<Address> _nodes;
        private readonly Random _random = new Random();
        readonly TimeSpan _timeout;

        protected Lazy<Tuple<IImmutableSet<Address>, IImmutableSet<Address>>> _primaryAndSecondaryNodes;

        protected IImmutableSet<Address> _remaining;

        private readonly ICancelable sendToSecondarySchedule;
        private readonly ICancelable timeoutSchedule;

        public ReadWriteAggregator(IImmutableSet<Address> nodes, TimeSpan timeout)
        {
            _timeout = timeout;
            _nodes = nodes;
            _remaining = _nodes;
            sendToSecondarySchedule = Context.System.Scheduler.ScheduleTellOnceCancelable((int)Timeout.TotalMilliseconds / 5, Self, new SendToSecondary(), Self);
            timeoutSchedule = Context.System.Scheduler.ScheduleTellOnceCancelable(Timeout, Self, ReceiveTimeout.Instance, Self);
            _primaryAndSecondaryNodes = new Lazy<Tuple<IImmutableSet<Address>, IImmutableSet<Address>>>(() =>
            {
                var primarySize = _nodes.Count - DoneWhenRemainingSize;
                if(primarySize >= nodes.Count)
                {
                    return Tuple.Create(nodes, (IImmutableSet<Address>)ImmutableHashSet<Address>.Empty);
                }
                var n = _nodes.OrderBy(x => _random.Next());
                var p = n.Take(primarySize);
                var s = p.Skip(primarySize).Take(MaxSecondaryNodes);
                return Tuple.Create((IImmutableSet<Address>)p.ToImmutableHashSet(), (IImmutableSet<Address>)s.ToImmutableHashSet());
            });
        }

        protected TimeSpan Timeout { get { return _timeout; } }
        protected abstract int DoneWhenRemainingSize { get; }

        protected IImmutableSet<Address> Nodes
        {
            get { return _nodes; }
        }

        protected override void PostStop()
        {
            sendToSecondarySchedule.Cancel();
            timeoutSchedule.Cancel();
        }

        protected ActorSelection Replica(Address address)
        {
            return Context.ActorSelection(Context.Parent.Path.ToStringWithAddress(address));
        }

        protected class SendToSecondary {}
    }
}
