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
        public void AGCounterMustBeAbleToIncrementEachNodesRecordByOne()
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
    }
}
