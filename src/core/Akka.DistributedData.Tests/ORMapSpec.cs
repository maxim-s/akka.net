// -----------------------------------------------------------------------
//  <copyright file="VersionVectorSpec.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Lightbend Inc. <http://www.lightbend.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System;
using System.Linq;
using Akka.Actor;
using Akka.Cluster;
using Akka.TestKit;

using Xunit;
using Xunit.Sdk;

namespace Akka.DistributedData.Tests
{
    public class ORMapSpec
    {
        private readonly UniqueAddress _node1 = new UniqueAddress(new Address("akka.tcp", "Sys", "localhost", 2551), 1);

        private readonly UniqueAddress _node2 = new UniqueAddress(new Address("akka.tcp", "Sys", "localhost", 2552), 2);


        [Fact]
        public void ORMap_must_be_able_to_add_entries()
        {
            var m = ORMap<IReplicatedData>.Empty.Put(_node1, "a", new GSet<string>().Add("A"))
                .Put(_node1, "b", new GSet<string>().Add("B"));

            var a = (GSet<string>)m.Entires["a"];
            a.Elements.Contains("A").ShouldBeTrue();

            var b = (GSet<string>)m.Entires["b"];
            b.Elements.Contains("B").ShouldBeTrue();

            var m2 = m.Put(_node1, "a", new GSet<string>().Add("C"));
            var a2 = (GSet<string>)m2.Entires["a"];
            a2.Elements.Contains("C").ShouldBeTrue();
        }

        [Fact]
        public void ORMap_must_be_able_to_remove_entry()
        {
            var m = ORMap<IReplicatedData>.Empty.Put(_node1, "a", new GSet<string>().Add("A"))
                .Put(_node1, "b", new GSet<string>().Add("B")).Remove(_node1, "a");

            m.Entires.Keys.ToList().Contains("a").ShouldBeFalse();
            m.Entires.Keys.ToList().Contains("b").ShouldBeTrue();
           
        }

        [Fact]
        public void ORMap_be_able_to_add_removed()
        {
            var m = ORMap<IReplicatedData>.Empty.Put(_node1, "a", new GSet<string>().Add("A"))
                .Put(_node1, "b", new GSet<string>().Add("B")).Remove(_node1, "a");

            m.Entires.Keys.ToList().Contains("a").ShouldBeFalse();
            m.Entires.Keys.ToList().Contains("b").ShouldBeTrue();

            var m2 = m.Put(_node1, "a", new GSet<string>().Add("C"));

            m2.Entires.Keys.ToList().Contains("a").ShouldBeTrue();
            m2.Entires.Keys.ToList().Contains("b").ShouldBeTrue();

        }

        [Fact]
        public void ORMap_be_able_to_have_its_entries_orrectly_merged_with_another_ORMap_with_other_entries()
        {
            var m1 = ORMap<IReplicatedData>.Empty.Put(_node1, "a", new GSet<string>().Add("A"))
                .Put(_node1, "b", new GSet<string>().Add("B"));
            var m2 = ORMap<IReplicatedData>.Empty.Put(_node2, "c", new GSet<string>().Add("C"));

            // merge both ways
            var merged1 = m1.Merge(m2);
            merged1.Entires.Keys.ToList().Contains("a").ShouldBeTrue();
            merged1.Entires.Keys.ToList().Contains("b").ShouldBeTrue();
            merged1.Entires.Keys.ToList().Contains("c").ShouldBeTrue();


            var merged2 = m2.Merge(m1);
            merged2.Entires.Keys.ToList().Contains("a").ShouldBeTrue();
            merged2.Entires.Keys.ToList().Contains("b").ShouldBeTrue();
            merged2.Entires.Keys.ToList().Contains("c").ShouldBeTrue();

        }

        [Fact]
        public void ORMap_be_able_to_have_its_entries_correctly_merged_with_another_ORMap_with_overlapping_entries()
        {
            var m1 =
                ORMap<IReplicatedData>.Empty.Put(_node1, "a", new GSet<string>().Add("A1"))
                    .Put(_node1, "b", new GSet<string>().Add("B1"))
                    .Remove(_node1, "a")
                    .Put(_node1, "d", new GSet<string>().Add("D1"));
            var m2 =
                ORMap<IReplicatedData>.Empty.Put(_node2, "c", new GSet<string>().Add("C2"))
                    .Put(_node2, "a", new GSet<string>().Add("A2"))
                    .Put(_node2, "b", new GSet<string>().Add("B2"))
                    .Remove(_node2, "b")
                    .Put(_node2, "d", new GSet<string>().Add("D2"));

            // merge both ways
            var merged1 = m1.Merge(m2);
            merged1.Entires.Keys.ToList().Contains("a").ShouldBeTrue();
            ((GSet<string>)merged1.Entires["a"]).Contains("A2").ShouldBeTrue();
            merged1.Entires.Keys.ToList().Contains("b").ShouldBeTrue();
            ((GSet<string>)merged1.Entires["b"]).Contains("B1").ShouldBeTrue();
            merged1.Entires.Keys.ToList().Contains("c").ShouldBeTrue();
            merged1.Entires.Keys.ToList().Contains("d").ShouldBeTrue();
            var d1 = ((GSet<string>)merged1.Entires["d"]);
            d1.Contains("D1").ShouldBeTrue();
            d1.Contains("D2").ShouldBeTrue();

            var merged2 = m1.Merge(m2);
            merged2.Entires.Keys.ToList().Contains("a").ShouldBeTrue();
            ((GSet<string>)merged2.Entires["a"]).Contains("A2").ShouldBeTrue();
            merged2.Entires.Keys.ToList().Contains("b").ShouldBeTrue();
            ((GSet<string>)merged2.Entires["b"]).Contains("B1").ShouldBeTrue();
            merged2.Entires.Keys.ToList().Contains("c").ShouldBeTrue();
            merged2.Entires.Keys.ToList().Contains("d").ShouldBeTrue();
            var d2 = ((GSet<string>)merged2.Entires["d"]);
            d2.Contains("D1").ShouldBeTrue();
            d2.Contains("D2").ShouldBeTrue();

        }

        [Fact]
        public void ORMap_illustrate_the_danger_of_using_remove_and_put_to_replace_an_entry()
        {
            var m1 = ORMap<IReplicatedData>.Empty.Put(_node1, "a", new GSet<string>().Add("A"))
                .Put(_node1, "b", new GSet<string>().Add("B"));

            var m2 = ORMap<IReplicatedData>.Empty.Put(_node2, "c", new GSet<string>().Add("C"));

            var merged1 = m1.Merge(m2);

            var m3 = merged1.Remove(_node1, "b").Put(_node1, "b", new GSet<string>().Add("B2"));
            // same thing if only put is used
            var merged2 = merged1.Merge(m3);

            var a = ((GSet<string>)merged2.Entires["a"]);
            // note that B is included, because GSet("B") is merged with GSet("B2")
            var b = ((GSet<string>)merged2.Entires["b"]);
            var c = ((GSet<string>)merged2.Entires["c"]);
            a.Contains("A").ShouldBeTrue();
            b.Contains("B").ShouldBeTrue();
            b.Contains("B2").ShouldBeTrue();
            c.Contains("C").ShouldBeTrue();
        }

        [Fact]
        public void ORMap_must_not_allow_put_for_ORSet_elements_type()
        {
            var m = ORMap<IReplicatedData>.Empty.Put(_node1, "a", ORSet<string>.Empty.Add(_node1, "A"));
            Assert.Throws<ArgumentException>(
                () => m.Put(_node1, "a", ORSet<string>.Empty.Add(_node1, "B")));
        }

        [Fact]
        public void ORMap_must_be_able_to_update_entry()
        {
            var m1 = ORMap<IReplicatedData>.Empty.Put(_node1, "a", ORSet<string>.Empty.Add(_node1, "A"))
                .Put(_node1, "b", ORSet<string>.Empty.Add(_node1, "B01").Add(_node1, "B02").Add(_node1, "B03"));
            var m2 = ORMap<IReplicatedData>.Empty.Put(_node2, "c", ORSet<string>.Empty.Add(_node1, "C"));

            var merged1 = m1.Merge(m2);
            var m3 = merged1.Updated(_node1, "b", ORSet<string>.Empty, data => ((ORSet<string>) data).Clear().Add(_node1, "B2"));
            
            var merged2 = merged1.Merge(m3);
            ((ORSet<string>)merged2.Entires["a"]).Contains("A").ShouldBeTrue();
            ((ORSet<string>)merged2.Entires["b"]).Contains("B2").ShouldBeTrue();
            ((ORSet<string>)merged2.Entires["c"]).Contains("C").ShouldBeTrue();

            var m4 = merged1.Updated(_node2, "b", ORSet<string>.Empty, data => ((ORSet<string>)data).Add(_node2, "B3"));
            var merged3 = m3.Merge(m4);
            ((ORSet<string>)merged3.Entires["a"]).Contains("A").ShouldBeTrue();
            ((ORSet<string>)merged3.Entires["b"]).Contains("B2").ShouldBeTrue();
            ((ORSet<string>)merged3.Entires["b"]).Contains("B3").ShouldBeTrue();
            ((ORSet<string>)merged3.Entires["c"]).Contains("C").ShouldBeTrue();
        }

        [Fact]
        public void ORMap_must_be_able_to_update_entry_with_remove_and_put()
        {
            var m1 = ORMap<IReplicatedData>.Empty.Put(_node1, "a", ORSet<string>.Empty.Add(_node1, "A01"))
                .Updated(_node1, "a", ORSet<string>.Empty, data => ((ORSet<string>) data).Add(_node1, "A02"))
                .Updated(_node1, "a", ORSet<string>.Empty, data => ((ORSet<string>) data).Add(_node1, "A03"))
                .Put(_node1, "b", ORSet<string>.Empty.Add(_node1, "B01").Add(_node1, "B02").Add(_node1, "B03"));
            var m2 = ORMap<IReplicatedData>.Empty.Put(_node2, "c", ORSet<string>.Empty.Add(_node1, "C"));

            var merged1 = m1.Merge(m2);

            // note that remove + put work because the new VersionVector version is incremented
            // from a global counter
            var m3 = merged1.Remove(_node1, "b").Put(_node1, "b", ORSet<string>.Empty.Add(_node1, "B2"));


            var merged2 = merged1.Merge(m3);
            ((ORSet<string>)merged2.Entires["a"]).Contains("A01").ShouldBeTrue();
            ((ORSet<string>)merged2.Entires["a"]).Contains("A02").ShouldBeTrue();
            ((ORSet<string>)merged2.Entires["a"]).Contains("A03").ShouldBeTrue();
            ((ORSet<string>)merged2.Entires["b"]).Contains("B2").ShouldBeTrue();
            ((ORSet<string>)merged2.Entires["c"]).Contains("C").ShouldBeTrue();

            var m4 = merged1.Updated(_node2, "b", ORSet<string>.Empty, data => ((ORSet<string>)data).Add(_node2, "B3"));
            var merged3 = m3.Merge(m4);
            ((ORSet<string>)merged3.Entires["a"]).Contains("A01").ShouldBeTrue();
            ((ORSet<string>)merged3.Entires["a"]).Contains("A02").ShouldBeTrue();
            ((ORSet<string>)merged3.Entires["a"]).Contains("A03").ShouldBeTrue();
            ((ORSet<string>)merged3.Entires["b"]).Contains("B2").ShouldBeTrue();
            ((ORSet<string>)merged3.Entires["b"]).Contains("B3").ShouldBeTrue();
            ((ORSet<string>)merged3.Entires["c"]).Contains("C").ShouldBeTrue();
        }

        [Fact]
        public void ORMap_must_be_able_to_update_entry_with_remove_merge_and_put()
        {
            var m1 = ORMap<IReplicatedData>.Empty.Put(_node1, "a", ORSet<string>.Empty.Add(_node1, "A"))
                .Put(_node1, "b", ORSet<string>.Empty.Add(_node1, "B01").Add(_node1, "B02").Add(_node1, "B03"));
            var m2 = ORMap<IReplicatedData>.Empty.Put(_node2, "c", ORSet<string>.Empty.Add(_node1, "C"));

            var merged1 = m1.Merge(m2);

            var m3 = merged1.Remove(_node1, "b");


            var merged2 = merged1.Merge(m3);
            ((ORSet<string>)merged2.Entires["a"]).Contains("A").ShouldBeTrue();
            merged2.Contains("b").ShouldBeFalse();
            ((ORSet<string>)merged2.Entires["c"]).Contains("C").ShouldBeTrue();

            var m4 = merged2.Put(_node1, "b", ORSet<string>.Empty.Add(_node1, "B2"));
            var m5 =
                merged2.Updated(_node2, "c", ORSet<string>.Empty, data => ((ORSet<string>) data).Add(_node2, "C2"))
                    .Put(_node2, "b", ORSet<string>.Empty.Add(_node2, "B3"));

            var merged3 = m5.Merge(m4);
            ((ORSet<string>)merged3.Entires["a"]).Contains("A").ShouldBeTrue();
            ((ORSet<string>)merged3.Entires["b"]).Contains("B2").ShouldBeTrue();
            ((ORSet<string>)merged3.Entires["b"]).Contains("B3").ShouldBeTrue();
            ((ORSet<string>)merged3.Entires["c"]).Contains("C").ShouldBeTrue();
            ((ORSet<string>)merged3.Entires["c"]).Contains("C2").ShouldBeTrue();
        }

    }
}