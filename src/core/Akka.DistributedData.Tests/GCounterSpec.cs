// -----------------------------------------------------------------------
//  <copyright file="GCounterSpec.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System.Numerics;
using Akka.Cluster;
using Xunit;

namespace Akka.DistributedData.Tests
{
    public class GCounterSpec
    {
        private static readonly UniqueAddress Node1 = new UniqueAddress(new Actor.Address("akka.tcp", "Sys", "localhost", 2551), 1);
        private static readonly UniqueAddress Node2 = new UniqueAddress(Node1.Address.WithPort(2552), 2);
        private static UniqueAddress Node3 = new UniqueAddress(Node1.Address.WithPort(2553), 3);

        [Fact]
        public void GCounter_must_be_able_to_increment_each_nodes_record_by_one()
        {
            var c1 = new GCounter();
            var c2 = c1.Increment(Node1);
            var c3 = c2.Increment(Node1);
            var c4 = c3.Increment(Node2);
            var c5 = c4.Increment(Node2);
            var c6 = c5.Increment(Node2);

            Assert.Equal(new BigInteger(2), c6.State[Node1]);
            Assert.Equal(new BigInteger(3), c6.State[Node2]);
        }

        [Fact]
        public void GCounter_must_be_able_to_increment_each_nodes_record_by_arbitrary_delta()
        {
            var c1 = new GCounter();
            var c2 = c1.Increment(Node1, 3);
            var c3 = c2.Increment(Node1 , 4);

            var c4 = c3.Increment(Node2,2);
            var c5 = c4.Increment(Node2 , 7);
            var c6 = c5.Increment(Node2);

            Assert.Equal(new BigInteger(7), c6.State[Node1]);
            Assert.Equal(new BigInteger(10), c6.State[Node2]);
        }

        [Fact]
        public void GCounter_must_be_able_to_summarize_the_history_to_the_correct_aggregated_value()
        {
            var c1 = new GCounter();
            var c2 = c1.Increment(Node1, 3);
            var c3 = c2.Increment(Node1, 4);

            var c4 = c3.Increment(Node2, 2);
            var c5 = c4.Increment(Node2, 7);
            var c6 = c5.Increment(Node2);

            Assert.Equal(new BigInteger(7), c6.State[Node1]);
            Assert.Equal(new BigInteger(10), c6.State[Node2]);
            Assert.Equal(new BigInteger(17), c6.Value);
        }

        [Fact]
        public void GCounter_must_be_able_to_have_its_history_correctly_merged_with_another_GCounter_1()
        {
            //counter 1
            var c11 = new GCounter();
            var c12 = c11.Increment(Node1, 3);
            var c13 = c12.Increment(Node1, 4);
            var c14 = c13.Increment(Node2, 2);
            var c15 = c14.Increment(Node2, 7);
            var c16 = c15.Increment(Node2);

            Assert.Equal(new BigInteger(7), c16.State[Node1]);
            Assert.Equal(new BigInteger(10), c16.State[Node2]);
            Assert.Equal(new BigInteger(17), c16.Value);

            //counter 2
            var c21 = new GCounter();
            var c22 = c21.Increment(Node1, 2);
            var c23 = c22.Increment(Node1, 2);
            var c24 = c23.Increment(Node2, 3);
            var c25 = c24.Increment(Node2, 2);
            var c26 = c25.Increment(Node2);

            Assert.Equal(new BigInteger(4), c26.State[Node1]);
            Assert.Equal(new BigInteger(6), c26.State[Node2]);
            Assert.Equal(new BigInteger(10), c26.Value);

            // merge both ways
            var merged1 = c16.Merge(c26);
            Assert.Equal(new BigInteger(7), merged1.State[Node1]);
            Assert.Equal(new BigInteger(10), merged1.State[Node2]);
            Assert.Equal(new BigInteger(17), merged1.Value);

            var merged2 = c26.Merge(c16);
            Assert.Equal(new BigInteger(7), merged2.State[Node1]);
            Assert.Equal(new BigInteger(10), merged2.State[Node2]);
            Assert.Equal(new BigInteger(17), merged2.Value);
        }

        [Fact]
        public void GCounter_must_be_able_to_have_its_history_correctly_merged_with_another_GCounter_2()
        {
            //counter 1
            var c11 = new GCounter();
            var c12 = c11.Increment(Node1, 2);
            var c13 = c12.Increment(Node1, 2);
            var c14 = c13.Increment(Node2, 2);
            var c15 = c14.Increment(Node2, 7);
            var c16 = c15.Increment(Node2);

            Assert.Equal(new BigInteger(4), c16.State[Node1]);
            Assert.Equal(new BigInteger(10), c16.State[Node2]);
            Assert.Equal(new BigInteger(14), c16.Value);

            //counter 1
            var c21 = new GCounter();
            var c22 = c21.Increment(Node1, 3);
            var c23 = c22.Increment(Node1, 4);
            var c24 = c23.Increment(Node2, 3);
            var c25 = c24.Increment(Node2, 2);
            var c26 = c25.Increment(Node2);

            Assert.Equal(new BigInteger(7), c26.State[Node1]);
            Assert.Equal(new BigInteger(6), c26.State[Node2]);
            Assert.Equal(new BigInteger(13), c26.Value);

            // merge both ways
            var merged1 = c16.Merge(c26);
            Assert.Equal(new BigInteger(7), merged1.State[Node1]);
            Assert.Equal(new BigInteger(10), merged1.State[Node2]);
            Assert.Equal(new BigInteger(17), merged1.Value);

            var merged2 = c26.Merge(c16);
            Assert.Equal(new BigInteger(7), merged2.State[Node1]);
            Assert.Equal(new BigInteger(10), merged2.State[Node2]);
            Assert.Equal(new BigInteger(17), merged2.Value);
        }

        [Fact]
        public void GCounter_must_have_support_for_pruning()
        {
            var c1 = new GCounter();
            var c2 = c1.Increment(Node1);
            var c3 = c2.Increment(Node2);

            Assert.True(c2.NeedPruningFrom(Node1));
            Assert.False(c2.NeedPruningFrom(Node2));
            Assert.True(c3.NeedPruningFrom(Node1));
            Assert.True(c3.NeedPruningFrom(Node2));
            Assert.Equal(new BigInteger(2), c3.Value);

            var c4 = c3.Prune(Node1, Node2);
            Assert.True(c4.NeedPruningFrom(Node2));
            Assert.False(c4.NeedPruningFrom(Node1));
            Assert.Equal(new BigInteger(2), c4.Value);

            var c5 = c4.Increment(Node1).PruningCleanup(Node1);
            Assert.False(c5.NeedPruningFrom(Node1));
            Assert.Equal(new BigInteger(2), c4.Value);
        }
    }
}
