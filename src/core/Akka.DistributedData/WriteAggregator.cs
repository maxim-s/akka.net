// -----------------------------------------------------------------------
//  <copyright file="WriteAggregator.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Immutable;
using Akka.Actor;
using Akka.DistributedData.Internal;

namespace Akka.DistributedData
{
    internal class WriteAggregator<T> : ReadWriteAggregator where T : IReplicatedData
    {
        readonly IWriteConsistency _consistency;
        readonly DataEnvelope _envelope;
        readonly Key<T> _key;
        readonly IActorRef _replyTo;
        readonly object _req;
        readonly Write _write;

        public WriteAggregator(Key<T> key, DataEnvelope envelope, IWriteConsistency consistency, object req, IImmutableSet<Address> nodes, IActorRef replyTo)
            : base(nodes, consistency.Timeout)
        {
            _key = key;
            _envelope = envelope;
            _consistency = consistency;
            _req = req;
            _replyTo = replyTo;
            _write = new Write(key.Id, envelope);
        }

        protected override int DoneWhenRemainingSize
        {
            get
            {
                if (_consistency is WriteTo)
                {
                    var wt = (WriteTo)_consistency;
                    return Nodes.Count - wt.N - 1;
                }
                if (_consistency is WriteAll)
                {
                    return 0;
                }
                if (_consistency is WriteMajority)
                {
                    var N = Nodes.Count + 1;
                    var w = N / 2 + 1;
                    return N - w;
                }
                if (_consistency is WriteLocal)
                {
                    throw new ArgumentException("WriteAggregator does not support ReadLocal");
                }
                throw new ArgumentException("Invalid consistency level");
            }
        }

        public static Props GetProps<T>(Key<T> key, DataEnvelope envelope, IWriteConsistency consistency, object req, IImmutableSet<Address> nodes, IActorRef replyTo) where T : IReplicatedData
        {
            return Props.Create(() => new WriteAggregator<T>(key, envelope, consistency, req, nodes, replyTo)).WithDeploy(Deploy.Local);
        }

        protected override void PreStart()
        {
            var primaryNodes = _primaryAndSecondaryNodes.Value.Item1;
            foreach(var n in primaryNodes)
            {
                Replica(n).Tell(_write);
            }
            if(_remaining.Count == DoneWhenRemainingSize)
            {
                Reply(true);
            }
            else if(DoneWhenRemainingSize < 0 || _remaining.Count < DoneWhenRemainingSize)
            {
                Reply(false);
            }
        }

        protected override bool Receive(object message)
        {
            return message.Match()
                          .With<WriteAck>(x =>
                          {
                              _remaining = _remaining.Remove(Sender.Path.Address);
                              if (_remaining.Count == DoneWhenRemainingSize)
                              {
                                  Reply(true);
                              }
                          })
                          .With<SendToSecondary>(x =>
                          {
                              foreach (var n in _primaryAndSecondaryNodes.Value.Item2)
                              {
                                  Replica(n).Tell(_write);
                              }
                          })
                          .With<ReceiveTimeout>(x => Reply(false))
                          .WasHandled;
        }

        private void Reply(bool ok)
        {
            if(ok && _envelope.Data == DeletedData.Instance)
            {
                _replyTo.Tell(new DeleteSuccess<T>(_key), Context.Parent);
            }
            else if(ok)
            {
                _replyTo.Tell(new UpdateSuccess<T>(_key, _req), Context.Parent);
            }
            else if(_envelope.Data == DeletedData.Instance)
            {
                _replyTo.Tell(new ReplicationDeletedFailure<T>(_key), Context.Parent);
            }
            else
            {
                _replyTo.Tell(new UpdateTimeout<T>(_key, _req), Context.Parent);
            }
            Context.Stop(Self);
        }
    }
}
