﻿// -----------------------------------------------------------------------
//  <copyright file="FlagSpec.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using Xunit;

namespace Akka.DistributedData.Tests
{
    public class FlagSpec
    {
        [Fact]
        public void Flag_must_be_able_to_switch_on_once()
        {
            var f1 = new Flag();
            var f2 = f1.SwitchOn();
            var f3 = f2.SwitchOn();

            Assert.Equal(false, f1.Enabled);
            Assert.Equal(true, f2.Enabled);
            Assert.Equal(true, f3.Enabled);
        }

        [Fact]
        public void Flag_must_merge_by_picking_true()
        {
            var f1 = new Flag(false);
            var f2 = f1.SwitchOn();

            var m1 = f1.Merge(f2);
            Assert.Equal(true, m1.Enabled);

            var m2 = f2.Merge(f1);
            Assert.Equal(true, m2.Enabled);
        }
    }
}
