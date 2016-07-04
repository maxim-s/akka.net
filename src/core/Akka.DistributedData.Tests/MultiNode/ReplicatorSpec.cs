﻿// -----------------------------------------------------------------------
//  <copyright file="ReplicatorSpec.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Immutable;
using Akka.Actor;
using Akka.Configuration;
using Akka.Remote.TestKit;

namespace Akka.DistributedData.Tests.MultiNode
{
    public class ReplicatorSpecConfig : MultiNodeConfig
    {
        readonly RoleName _first;
        readonly RoleName _second;
        readonly RoleName _third;

        public ReplicatorSpecConfig()
        {
            _first = Role("first");
            _second = Role("second");
            _third = Role("third");

            CommonConfig = DebugConfig(true).WithFallback(ConfigurationFactory.ParseString(@"
                akka.actor.provider=""Akka.Cluster.ClusterActorRefProvider, Akka.Cluster""
                akka.test.timefactor=1.0
                akka.test.calling-thread-dispatcher.type=""Akka.TestKit.CallingThreadDispatcherConfigurator, Akka.TestKit""
                akka.test.calling-thread-dispatcher.throughput=2147483647
                akka.test.test-actor.dispatcher.type=""Akka.TestKit.CallingThreadDispatcherConfigurator, Akka.TestKit""
                akka.test.test-actor.dispatcher.throughput=2147483647
                akka.cluster.distributed-data.gossip-interval=2s
            ")).WithFallback(ReplicatorSettings.DefaultConfig());

            TestTransport = true;
        }

        public RoleName First { get { return _first; } }
        public RoleName Second { get { return _second; } }
        public RoleName Third { get { return _third; } }
    }

    public abstract class ReplicatorSpec : MultiNodeSpec
    {
        readonly Cluster.Cluster _cluster;
        readonly ReplicatorSpecConfig _config;
        readonly ReadAll _readAll;
        readonly ReadFrom _readFrom;
        readonly ReadMajority _readMajority;

        readonly IActorRef _replicator;

        readonly TimeSpan _timeOut;
        readonly WriteAll _writeAll;
        readonly WriteMajority _writeMajority;
        readonly WriteTo _writeTwo;

        readonly GCounterKey KeyA = new GCounterKey("A");
        readonly GCounterKey KeyB = new GCounterKey("B");
        readonly GCounterKey KeyC = new GCounterKey("C");
        readonly GCounterKey KeyD = new GCounterKey("D");
        readonly GCounterKey KeyE = new GCounterKey("E");
        readonly GCounterKey KeyE2 =new GCounterKey("E2");
        readonly GCounterKey KeyF = new GCounterKey("F");
        //readonly ORSetKey KeyG = new ORSetKey[String]("G")
        //readonly GCounterKey KeyH = new ORMapKey[Flag]("H")
        //readonly GCounterKey KeyI = new GSetKey[String]("I")
        readonly GSetKey<string> KeyJ = new GSetKey<string>("J");
        readonly GCounterKey KeyX = new GCounterKey("X");
        readonly GCounterKey KeyY = new GCounterKey("Y");
        readonly GCounterKey KeyZ = new GCounterKey("Z");

        int afterCounter;

        public ReplicatorSpec()
            : this(new ReplicatorSpecConfig())
        { }

        public ReplicatorSpec(ReplicatorSpecConfig config)
            : base(config)
        {
            _config = config;
            _cluster = Cluster.Cluster.Get(Sys);
            var settings = new ReplicatorSettings(Sys).WithGossipInterval(TimeSpan.FromSeconds(1.0)).WithMaxDeltaElements(10);
            var props = Replicator.GetProps(settings);
            _replicator = Sys.ActorOf(props, "replicator");

            _timeOut = Dilated(TimeSpan.FromSeconds(2.0));
            _writeTwo = new WriteTo(2, _timeOut);
            _writeMajority = new WriteMajority(_timeOut);
            _writeAll = new WriteAll(_timeOut);
            _readFrom = new ReadFrom(2, _timeOut);
            _readMajority = new ReadMajority(_timeOut);
            _readAll = new ReadAll(_timeOut);
        }

        protected override int InitialParticipantsValueFactory
        {
            get { return Roles.Count; }
        }

        private void EnterBarrierAfterTestStep()
        {
            afterCounter++;
            EnterBarrier("after-" + afterCounter);
        }

        private void Join(RoleName from, RoleName to)
        {
            RunOn(() =>
                {
                    _cluster.Join(Node(to).Address);
                }, from);
            EnterBarrier(from.Name + "-joined");
        }

        [MultiNodeFact]
        public void ReplicatorSpecTests()
        {
            ClusterCRDTMustWorkInSingleNodeCluster();
            MergeTheUpdateWithExistingValue();
            ReplyWithModifyFailureIfExceptionIsThrownByModifyFunction();
        }

        public void ClusterCRDTMustWorkInSingleNodeCluster()
        {
            Join(_config.First, _config.First);

            RunOn(() =>
                {
                    Within(TimeSpan.FromSeconds(5.0), () =>
                        {
                            _replicator.Tell(new GetReplicaCount());
                            ExpectMsg<ReplicaCount>();
                        });

                    var changedProbe = CreateTestProbe();
                    _replicator.Tell(new Subscribe<GCounter>(KeyA, changedProbe.Ref));
                    _replicator.Tell(new Subscribe<GCounter>(KeyX, changedProbe.Ref));

                    Within(TimeSpan.FromSeconds(5.0), () =>
                        {
                            _replicator.Tell(new Get<GCounter>(KeyA, ReadLocal.Instance));
                            ExpectMsg(new NotFound<GCounter>(KeyA, null));
                        });

                    var c3 = GCounter.Empty.Increment(_cluster.SelfUniqueAddress, 3);
                    var update = new Update<GCounter>(KeyA, GCounter.Empty, WriteLocal.Instance, x => ((GCounter)x).Increment(_cluster.SelfUniqueAddress, 3));
                    _replicator.Tell(update);
                    ExpectMsg(new UpdateSuccess<GCounter>(KeyA, null));
                    changedProbe.ExpectMsg(new Changed<GCounter>(KeyA, c3));
                    _replicator.Tell(new Get<GCounter>(KeyA, ReadLocal.Instance));
                    ExpectMsg(new GetSuccess<GCounter>(KeyA, null, c3));

                    var changedProbe2 = CreateTestProbe();
                    _replicator.Tell(new Subscribe<GCounter>(KeyA, changedProbe2.Ref));
                    changedProbe2.ExpectMsg(new Changed<GCounter>(KeyA, c3));


                    var c4 = c3.Increment(_cluster.SelfUniqueAddress);
                    _replicator.Tell(new Update<GCounter>(KeyA, _writeTwo, x => ((GCounter)x).Increment(_cluster.SelfUniqueAddress)));
                    ExpectMsg(new UpdateTimeout<GCounter>(KeyA, null));
                    _replicator.Tell(new Get<GCounter>(KeyA, ReadLocal.Instance));
                    ExpectMsg(new GetSuccess<GCounter>(KeyA, null, c4));
                    changedProbe.ExpectMsg(new Changed<GCounter>(KeyA, c4));

                    var c5 = c4.Increment(_cluster.SelfUniqueAddress);
                    _replicator.Tell(new Update<GCounter>(KeyA, _writeMajority, x => ((GCounter)x).Increment(_cluster.SelfUniqueAddress)));
                    ExpectMsg(new UpdateSuccess<GCounter>(KeyA, null));
                    _replicator.Tell(new Get<GCounter>(KeyA, _readMajority));
                    ExpectMsg(new GetSuccess<GCounter>(KeyA, null, c5));
                    changedProbe.ExpectMsg(new Changed<GCounter>(KeyA, c5));

                    var c6 = c5.Increment(_cluster.SelfUniqueAddress);
                    _replicator.Tell(new Update<GCounter>(KeyA, _writeAll, x => ((GCounter)x).Increment(_cluster.SelfUniqueAddress)));
                    ExpectMsg(new UpdateSuccess<GCounter>(KeyA, null));
                    _replicator.Tell(new Get<GCounter>(KeyA, _readAll));
                    ExpectMsg(new GetSuccess<GCounter>(KeyA, null, c6));
                    changedProbe.ExpectMsg(new Changed<GCounter>(KeyA, c6));

                    var c9 = GCounter.Empty.Increment(_cluster.SelfUniqueAddress, 9);
                    _replicator.Tell(new Update<GCounter>(KeyX, GCounter.Empty, WriteLocal.Instance, x => ((GCounter)x).Increment(_cluster.SelfUniqueAddress, 9)));
                    ExpectMsg(new UpdateSuccess<GCounter>(KeyX, null));
                    changedProbe.ExpectMsg(new Changed<GCounter>(KeyX, c9));
                    _replicator.Tell(new Delete<GCounter>(KeyX, WriteLocal.Instance));
                    ExpectMsg(new DeleteSuccess<GCounter>(KeyX));
                    changedProbe.ExpectMsg(new DataDeleted<GCounter>(KeyX), TimeSpan.FromMinutes(5.0));
                    _replicator.Tell(new Get<GCounter>(KeyX, ReadLocal.Instance));
                    ExpectMsg(new DataDeleted<GCounter>(KeyX));
                    _replicator.Tell(new Get<GCounter>(KeyX, _readAll));
                    ExpectMsg(new DataDeleted<GCounter>(KeyX));
                    _replicator.Tell(new Update<GCounter>(KeyX, WriteLocal.Instance, x => ((GCounter)x).Increment(_cluster.SelfUniqueAddress)));
                    ExpectMsg(new DataDeleted<GCounter>(KeyX));
                    _replicator.Tell(new Delete<GCounter>(KeyX, WriteLocal.Instance));
                    ExpectMsg(new DataDeleted<GCounter>(KeyX));

                    _replicator.Tell(GetKeyIds.Instance);
                    ExpectMsg(new GetKeysIdsResult(ImmutableHashSet<string>.Empty.Add("A")));
                }, _config.First);

            EnterBarrierAfterTestStep();
        }

        private void MergeTheUpdateWithExistingValue()
        {
            RunOn(() =>
                {
                    var update = new Update<GSet<string>>(KeyJ, new GSet<string>(), WriteLocal.Instance, x => ((GSet<string>)x).Add("a").Add("b"));
                    _replicator.Tell(update);
                    ExpectMsg(new UpdateSuccess<GSet<string>>(KeyJ, null));
                    var update2 = new Update<GSet<string>>(KeyJ, new GSet<string>(), WriteLocal.Instance, x => ((GSet<string>)x).Add("c"));
                    _replicator.Tell(update2);
                    ExpectMsg(new UpdateSuccess<GSet<string>>(KeyJ, null));
                    _replicator.Tell(new Get<GSet<string>>(KeyJ, ReadLocal.Instance));
                    ExpectMsg<GetSuccess<GSet<string>>>(x => x.Data.Equals(new GSet<string>(new[] { "a", "b", "c" }.ToImmutableHashSet())));
                }, _config.First);

            EnterBarrierAfterTestStep();
        }

        private void ReplyWithModifyFailureIfExceptionIsThrownByModifyFunction()
        {
            RunOn(() =>
                {
                    var exception = new Exception("Test exception");
                    Func<IReplicatedData, IReplicatedData> update = x => 
                    {
                        throw exception;
                    };
                    _replicator.Tell(new Update<GCounter>(KeyA, GCounter.Empty, WriteLocal.Instance, update));
                    ExpectMsg<ModifyFailure<GCounter>>(x => x.Cause.Equals(exception));
                }, _config.First);

            EnterBarrierAfterTestStep();
        }
    }

    public class ReplicatorSpecNode1 : ReplicatorSpec
    {}

    public class ReplicatorSpecNode2 : ReplicatorSpec
    {}

    public class ReplicatorSpecNode3 : ReplicatorSpec
    {}
}
