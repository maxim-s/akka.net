﻿// -----------------------------------------------------------------------
//  <copyright file="ReplicatorMessageSerializerSpec.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Immutable;
using Akka.Actor;
using Akka.Cluster;
using Akka.Configuration;
using Akka.DistributedData.Internal;
using Akka.DistributedData.Proto;
using Akka.IO;
using Xunit;

namespace Akka.DistributedData.Tests.Serialization
{
    public class ReplicatorMessageSerializerSpec : TestKit.Xunit2.TestKit
    {
        readonly UniqueAddress _address1;
        readonly UniqueAddress _address2;
        readonly UniqueAddress _address3;

        readonly GSetKey<string> _keyA;
        readonly ReplicatorMessageSerializer _serializer;
        readonly ActorSystem _system;

        public ReplicatorMessageSerializerSpec()
            : this(ActorSystem.Create("ReplicatorMessageSerializerSpec", ConfigurationFactory.ParseString(@"
                akka.actor.provider=""Akka.Cluster.ClusterActorRefProvider, Akka.Cluster""
                akka.remote.helios.tcp.port=3398
                akka.remote.helios.tcp.hostname=localhost
                akka.cluster.seed-nodes = [""akka.tcp://ReplicatorMessageSerializerSpec@127.0.0.1:3398"" ]
                akka.test.timefactor=1.0
                akka.test.calling-thread-dispatcher.type=""Akka.TestKit.CallingThreadDispatcherConfigurator, Akka.TestKit""
                akka.test.calling-thread-dispatcher.throughput=2147483647
                akka.test.test-actor.dispatcher.type=""Akka.TestKit.CallingThreadDispatcherConfigurator, Akka.TestKit""
                akka.test.test-actor.dispatcher.throughput=2147483647
            ").WithFallback(ReplicatorSettings.DefaultConfig())))
        {   
        }

        private ReplicatorMessageSerializerSpec(ActorSystem system)
            : base(system)
        {

            _keyA = new GSetKey<string>("A");

            _serializer = new ReplicatorMessageSerializer((ExtendedActorSystem)system);
            _system = system;

            _address1 = new UniqueAddress(new Address("akka.tcp", system.Name, "some.host.org", 4711), 1);
            _address2 = new UniqueAddress(new Address("akka.tcp", system.Name, "other.host.org", 4711), 2);
            _address3 = new UniqueAddress(new Address("akka.tcp", system.Name, "some.host.org", 4712), 3);
        }

        private void CheckSerialization(object any)
        {
            var blob = _serializer.ToBinary(any);
            var @ref = _serializer.FromBinary(blob, _serializer.Manifest(any));
            Assert.Equal(any, @ref);
        }

        [Fact]
        public void ReplicatorMessageSerializerMustSerializeReplicatorMessages()
        {
            var ref1 = _system.ActorOf(Props.Empty, "ref1");
            var data1 = new GSet<string>().Add("a");
            CheckSerialization(new Get<GSet<string>>(_keyA, ReadLocal.Instance));
            CheckSerialization(new Get<GSet<string>>(_keyA, new ReadMajority(TimeSpan.FromSeconds(2.0)), "x"));
            CheckSerialization(new GetSuccess<GSet<string>>(_keyA, null, data1));
            CheckSerialization(new GetSuccess<GSet<string>>(_keyA, "x", data1));
            CheckSerialization(new NotFound<GSet<string>>(_keyA, "x"));
            CheckSerialization(new GetFailure<GSet<string>>(_keyA, "x"));
            CheckSerialization(new Subscribe<GSet<string>>(_keyA, ref1));
            CheckSerialization(new Unsubscribe<GSet<string>>(_keyA, ref1));
            CheckSerialization(new Changed<GSet<string>>(_keyA, data1));
            CheckSerialization(new DataEnvelope(data1));

            var pruning = ImmutableDictionary<UniqueAddress, PruningState>.Empty
                                        .SetItem(_address1, new PruningState(_address2, PruningPerformed.Instance))
                                        .SetItem(_address3, new PruningState(_address2, new PruningInitialized(ImmutableHashSet<Address>.Empty.Add(_address1.Address))));
            CheckSerialization(new DataEnvelope(data1, pruning));
            CheckSerialization(new Write("A", new DataEnvelope(data1)));
            CheckSerialization(WriteAck.Instance);
            CheckSerialization(new Read("A"));
            CheckSerialization(new ReadResult(new DataEnvelope(data1)));
            CheckSerialization(new ReadResult(null));
            var status = ImmutableDictionary<string, ByteString>.Empty
                                .SetItem("A", ByteString.FromString("a"))
                                .SetItem("B", ByteString.FromString("b"));
            CheckSerialization(new Internal.Status(status, 3, 10));
            var gossip = ImmutableDictionary<string, DataEnvelope>.Empty
                .SetItem("A", new DataEnvelope(data1))
                .SetItem("B", new DataEnvelope(new GSet<string>().Add("b").Add("c")));
            CheckSerialization(new Gossip(gossip, true));
        }

        protected override void AfterAll()
        {
            _system.Shutdown();
        }
    }
}
