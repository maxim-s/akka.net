// -----------------------------------------------------------------------
//  <copyright file="Replicator.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Lightbend Inc. <http://www.lightbend.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System;
using Akka.Actor;
using Akka.Cluster.TestKit;
using Akka.Configuration;
using Akka.Remote.TestKit;

namespace Akka.DistributedData.Tests.MultiNode
{
    public class ReplicatorSpecConfig : MultiNodeConfig
    {
        public ReplicatorSpecConfig()
        {
            First = Role("first");
            Second = Role("second");
            Third = Role("third");

            CommonConfig = ConfigurationFactory.ParseString(@"
akka.loglevel = INFO
    akka.actor.provider = ""Akka.Cluster.ClusterActorRefProvider, Akka.Cluster""
    akka.log-dead-letters-during-shutdown = off
");
            TestTransport = true;
        }

        public RoleName Third { get; }

        public RoleName Second { get; }

        public RoleName First { get; }
    }

    public abstract class ReplicatorSpec : MultiNodeClusterSpec
    {
        private readonly ReplicatorSpecConfig _config;

        private int _afterCounter;
        private readonly GCounterKey _keyA;
        private GCounterKey _keyB;
        private GCounterKey _keyC;
        private GCounterKey _keyD;
        private GCounterKey _keyE;
        private GCounterKey _keyE2;
        private GCounterKey _keyF;
        private ORSetKey<string> _keyG;
        private ORMapKey<Flag> _keyH;
        private GSetKey<string> _keyI;
        private GSetKey<string> _keyJ;
        private readonly GCounterKey _keyX;
        private GCounterKey _keyY;

        private GCounterKey _keyZ
            ;

        private readonly ReadAll _readAll;
        private readonly ReadMajority _readMajority;
        private ReadFrom _readTwo;
        protected IActorRef _replicator;
        private readonly TimeSpan _timeout;
        private readonly WriteAll _writeAll;
        private readonly WriteMajority _writeMajority;
        private readonly WriteTo _writeTo;

        protected ReplicatorSpec() : this(new ReplicatorSpecConfig())
        {
        }

        protected ReplicatorSpec(ReplicatorSpecConfig config) : base(config)
        {
            _config = config;
            _replicator =
                Sys.ActorOf(
                    Props.Create(
                        () =>
                            new Replicator(
                                new ReplicatorSettings(Sys).WithGossipInterval(TimeSpan.FromSeconds(1))
                                    .WithMaxDeltaElements(10))), "replicator");
            _timeout = Dilated(TimeSpan.FromSeconds(2));
            _writeTo = new WriteTo(2, _timeout);
            _writeMajority = new WriteMajority(_timeout);
            _writeAll = new WriteAll(_timeout);
            _readTwo = new ReadFrom(2, _timeout);
            _readAll = new ReadAll(_timeout);
            _readMajority = new ReadMajority(_timeout);
            _keyA = new GCounterKey("A");
            _keyB = new GCounterKey("B");
            _keyC = new GCounterKey("C");
            _keyD = new GCounterKey("D");
            _keyE = new GCounterKey("E");
            _keyE2 = new GCounterKey("E2");
            _keyF = new GCounterKey("F");
            _keyG = new ORSetKey<string>("G");
            _keyH = new ORMapKey<Flag>("H");
            _keyI = new GSetKey<string>("I");
            _keyJ = new GSetKey<string>("J");
            _keyX = new GCounterKey("X");
            _keyY = new GCounterKey("Y");
            _keyZ = new GCounterKey("Z");
            _afterCounter = 0;
        }

        protected override int InitialParticipantsValueFactory
        {
            get { return Roles.Count; }
        }

        protected void Join(RoleName from, RoleName to)
        {
            RunOn(() => { Cluster.Join(Node(to).Address); }, from);
            EnterBarrier(from.Name + "-joined");
        }

        protected void EnterBarrierAfterTestStep()
        {
            _afterCounter++;
            EnterBarrier("after-" + _afterCounter);
        }

        [MultiNodeFact]
        public void ReplicatorSpecTests()
        {
            Cluster_CRDT_must_work_in_single_node_cluster();
        }

        public void Cluster_CRDT_must_work_in_single_node_cluster()
        {
            Join(_config.First, _config.First);
            RunOn(() =>
            {
                Within(TimeSpan.FromSeconds(5), () =>
                {
                    AwaitAssert(() =>
                    {
                        _replicator.Tell(new GetReplicaCount());
                        ExpectMsg<ReplicaCount>(m => m.N == 1);
                    });
                });

                var changedProbe = CreateTestProbe();
                _replicator.Tell(new Subscribe<GCounter>(_keyA, changedProbe.Ref));
                _replicator.Tell(new Subscribe<GCounter>(_keyX, changedProbe.Ref));

                _replicator.Tell(new Get<GCounter>(_keyA, ReadLocal.Instance));
                ExpectMsg<NotFound<GCounter>>();

                var c3 = new GCounter().Increment(Cluster, 3);
                _replicator.Tell(new Update<GCounter>(_keyA, new GCounter(), WriteLocal.Instance,
                    data => ((GCounter) data).Increment(Cluster, 3)));

                ExpectMsg<UpdateSuccess<GCounter>>();

                _replicator.Tell(new Get<GCounter>(_keyA, ReadLocal.Instance));
                ExpectMsg<GetSuccess<GCounter>>(m => m.Data.Equals(c3));
                changedProbe.ExpectMsg<Changed<GCounter>>(m => m.Data.Equals(c3));

                var changedProbe2 = CreateTestProbe();

                _replicator.Tell(new Subscribe<GCounter>(_keyA, changedProbe2.Ref));
                changedProbe2.ExpectMsg<Changed<GCounter>>(m => m.Data.Equals(c3));

                var c4 = c3.Increment(Cluster, 1);
                // too strong consistency level
                _replicator.Tell(new Update<GCounter>(_keyA, new GCounter(), _writeTo,
                    data => ((GCounter) data).Increment(Cluster, 1)));

                ExpectMsg<UpdateTimeout<GCounter>>(m => m.Key.Equals(_keyA) && m.Request == null);
                _replicator.Tell(new Get<GCounter>(_keyA, ReadLocal.Instance));
                ExpectMsg<GetSuccess<GCounter>>(m => m.Data.Equals(c4));
                changedProbe.ExpectMsg<Changed<GCounter>>(m => m.Data.Equals(c4));

                var c5 = c4.Increment(Cluster, 1);
                // too strong consistency level
                _replicator.Tell(new Update<GCounter>(_keyA, new GCounter(), _writeMajority, data =>
                    ((GCounter) data).Increment(Cluster, 1)));
                ExpectMsg<UpdateSuccess<GCounter>>(m => m.Key.Equals(_keyA));
                _replicator.Tell(new Get<GCounter>(_keyA, _readMajority));
                ExpectMsg<GetSuccess<GCounter>>(m => m.Key.Equals(_keyA));
                changedProbe.ExpectMsg<Changed<GCounter>>(m => m.Key.Equals(_keyA) && m.Data.Equals(c5));


                var c6 = c5.Increment(Cluster, 1);
                _replicator.Tell(new Update<GCounter>(_keyA, new GCounter(), _writeAll, data =>
                    ((GCounter) data).Increment(Cluster, 1))
                    );

                ExpectMsg<UpdateSuccess<GCounter>>(m => m.Key.Equals(_keyA));
                _replicator.Tell(new Get<GCounter>(_keyA, _readAll));
                ExpectMsg<GetSuccess<GCounter>>(m => m.Key.Equals(_keyA) && m.Data.Equals(c6));
                changedProbe.ExpectMsg<Changed<GCounter>>(m => m.Key.Equals(_keyA) && m.Data.Equals(c6));

                var c9 = new GCounter().Increment(Cluster, 9);
                _replicator.Tell(new Update<GCounter>(_keyX, new GCounter(), WriteLocal.Instance, data =>
                    ((GCounter) data).Increment(Cluster, 9))
                    );

                ExpectMsg<UpdateSuccess<GCounter>>(m => m.Key.Equals(_keyX));

                changedProbe.ExpectMsg<Changed<GCounter>>(m => m.Key.Equals(_keyX) && m.Data.Equals(c9));

                _replicator.Tell(new Delete<GCounter>(_keyX, WriteLocal.Instance));
                ExpectMsg<DeleteSuccess<GCounter>>(m => m.Key.Equals(_keyX));
                changedProbe.ExpectMsg<DataDeleted<GCounter>>(m => m.Key.Equals(_keyX));
                _replicator.Tell(new Get<GCounter>(_keyX, ReadLocal.Instance));
                ExpectMsg<DataDeleted<GCounter>>(m => m.Key.Equals(_keyX));
                _replicator.Tell(new Get<GCounter>(_keyX, _readAll));
                ExpectMsg<DataDeleted<GCounter>>(m => m.Key.Equals(_keyX));
                _replicator.Tell(new Update<GCounter>(_keyX, new GCounter(), WriteLocal.Instance, data =>
                    ((GCounter) data).Increment(Cluster, 1))
                    );
                ExpectMsg<DataDeleted<GCounter>>(m => m.Key.Equals(_keyX));
                _replicator.Tell(new Delete<GCounter>(_keyX, WriteLocal.Instance));
                ExpectMsg<DataDeleted<GCounter>>(m => m.Key.Equals(_keyX));
                _replicator.Tell(GetKeyIds.Instance);
                ExpectMsg<GetKeysIdsResult>(m => m.Keys.Contains("A") && m.Keys.Count == 1);
            }, _config.First);
        }
    }

    public class ReplicatorSpecMultiNode1 : ReplicatorSpec
    {
    }

    public class ReplicatorSpecMultiNode2 : ReplicatorSpec
    {
    }

    public class ReplicatorSpecMultiNode3 : ReplicatorSpec
    {
    }
}