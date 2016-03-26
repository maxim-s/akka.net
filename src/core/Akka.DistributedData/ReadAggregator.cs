// -----------------------------------------------------------------------
//  <copyright file="ReadAggregator.cs" company="Akka.NET Project">
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
    internal class ReadAggregator<T> : ReadWriteAggregator where T : IReplicatedData
    {
        readonly IReadConsistency _consistency;
        readonly Key<T> _key;
        readonly DataEnvelope _localValue;
        readonly Read _read;
        readonly IActorRef _replyTo;
        readonly object _req;

        DataEnvelope _result;

        public ReadAggregator(Key<T> key, IReadConsistency consistency, object req, IImmutableSet<Address> nodes, DataEnvelope localValue, IActorRef replyTo)
            : base(nodes, consistency.Timeout)
        {
            _key = key;
            _consistency = consistency;
            _req = req;
            _localValue = localValue;
            _replyTo = replyTo;
            _result = _localValue;
        }

        protected override int DoneWhenRemainingSize
        {
            get
            {
                if(_consistency is ReadFrom)
                {
                    var wt = (ReadFrom)_consistency;
                    return Nodes.Count - wt.N - 1;
                }
                if(_consistency is ReadAll)
                {
                    return 0;
                }
                if(_consistency is ReadMajority)
                {
                    var N = Nodes.Count + 1;
                    var w = N / 2 + 1;
                    return N - w;
                }
                if (_consistency is ReadLocal)
                {
                    throw new ArgumentException("ReadAggregator does not support ReadLocal");
                }
                throw new ArgumentException("Invalid consistency level");
            }
        }

        public static Props GetProps<T>(Key<T> key, IReadConsistency consistency, object req, IImmutableSet<Address> nodes, DataEnvelope localValue, IActorRef replyTo) where T : IReplicatedData
        {
            return Props.Create(() => new ReadAggregator<T>(key, consistency, req, nodes, localValue, replyTo)).WithDeploy(Deploy.Local);
        }

        protected override void PreStart()
        {
            foreach(var n in _primaryAndSecondaryNodes.Value.Item1)
            {
                Replica(n).Tell(_read);
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
                .With<ReadResult>(x =>
                {
                    if (_result != null && x.Envelope != null)
                    {
                        _result = _result.Merge(x.Envelope.Data);
                    }
                    else if(_result == null && x.Envelope != null)
                    {
                        _result = x.Envelope;
                    }
                    else if(_result != null && x.Envelope == null)
                    {
                        _result = _result;
                    }
                    else
                    {
                        _result = null;
                    }
                    _remaining = _remaining.Remove(Sender.Path.Address);
                    if(_remaining.Count == DoneWhenRemainingSize)
                    {
                        Reply(true);
                    }
                })
                .With<SendToSecondary>(x =>
                    {
                        foreach(var n in _primaryAndSecondaryNodes.Value.Item2)
                        {
                            Replica(n).Tell(_read);
                        }
                    })
                .WasHandled;
        }

        private void Reply(bool ok)
        {
            if(ok && _result != null)
            {
                Context.Parent.Tell(new ReadRepair(_key.Id, _result));
                var res = WaitRepairAck(_result);
                Context.Become(new Receive(WaitRepairAck(_result)));
            }
            if(ok && _result == null)
            {
                _replyTo.Tell(new NotFound<T>(_key, _req), Context.Parent);
                Context.Stop(Self);
            }
            else
            {
                _replyTo.Tell(new GetFailure<T>(_key, _req), Context.Parent);
                Context.Stop(Self);
            }
        }

        private Func<object, bool> WaitRepairAck(DataEnvelope envelope)
        {
            return msg =>
            {
                return msg.Match()
                    .With<ReadRepairAck>(x =>
                    {
                        if (envelope.Data == DeletedData.Instance)
                        {
                            _replyTo.Tell(new DataDeleted<T>(_key), Context.Parent);
                        }
                        else
                        {
                            _replyTo.Tell(new GetSuccess<T>(_key, _req, (T)envelope.Data));
                        }
                        Context.Stop(Self);
                    })
                    .With<ReadResult>(x => _remaining = _remaining.Remove(Sender.Path.Address))
                    .With<SendToSecondary>(_ => { })
                    .With<ReceiveTimeout>(_ => { })
                    .WasHandled;
            };
        }
    }
}
