// -----------------------------------------------------------------------
//  <copyright file="VersionVectorSpec.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Lightbend Inc. <http://www.lightbend.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using Akka.Actor;
using Akka.Cluster;
using Akka.TestKit;

using Xunit;

namespace Akka.DistributedData.Tests
{
    public class VersionVectorSpec
    {
        private readonly UniqueAddress _node1 = new UniqueAddress(new Address("akka.tcp", "Sys", "localhost", 2551), 1);

        private readonly UniqueAddress _node2 = new UniqueAddress(new Address("akka.tcp", "Sys", "localhost", 2552), 2);

        private readonly UniqueAddress _node3 = new UniqueAddress(new Address("akka.tcp", "Sys", "localhost", 2553), 3);

        private readonly UniqueAddress _node4 = new UniqueAddress(new Address("akka.tcp", "Sys", "localhost", 2554), 4);

        [Fact]
        public void VersionVector_must_have_zero_versions_when_created()
        {
            var versionVector = VersionVector.Create();
            versionVector.Size.ShouldBe(0);
        }

        [Fact]
        public void VersionVector_must_increment_correctly()
        {
            var vv1 = VersionVector.Create();
            var vv2 = vv1.Add(_node1);
            vv2.VersionAt(_node1).ShouldBeGreaterThan(vv1.VersionAt(_node1));
            var vv3 = vv2.Add(_node1);
            vv3.VersionAt(_node1).ShouldBeGreaterThan(vv2.VersionAt(_node1));

            var vv4 = vv3.Add(_node2);
            vv4.VersionAt(_node1).ShouldBe(vv3.VersionAt(_node1));
            vv4.VersionAt(_node2).ShouldBeGreaterThan(vv3.VersionAt(_node2));
        }

        [Fact]
        public void VersionVector_must_not_happen_before_itself()
        {
            var versionVector1 = VersionVector.Create();
            var versionVector2 = VersionVector.Create();
            versionVector1.IsConcurent(versionVector2).ShouldBeFalse();
        }

        [Fact]
        public void VersionVector_must_pass_misc_comparison_test_1()
        {
            var vv1_1 = VersionVector.Create();
            var vv2_1 = vv1_1.Add(_node1);
            var vv3_1 = vv2_1.Add(_node2);
            var vv4_1 = vv3_1.Add(_node1);
            var vv1_2 = VersionVector.Create();
            var vv2_2 = vv1_2.Add(_node1);
            var vv3_2 = vv2_2.Add(_node2);
            var vv4_2 = vv3_2.Add(_node1);
            vv4_1.IsConcurent(vv4_2).ShouldBeFalse();
        }
        [Fact]
        public void VersionVector_must_pass_misc_comparison_test_2()
        {
            var vv1_1 = VersionVector.Create();
            var vv2_1 = vv1_1.Add(_node1);
            var vv3_1 = vv2_1.Add(_node2);
            var vv4_1 = vv3_1.Add(_node1);

            var vv1_2 = VersionVector.Create();
            var vv2_2 = vv1_2.Add(_node1);
            var vv3_2 = vv2_2.Add(_node2);
            var vv4_2 = vv3_2.Add(_node1);
            var vv5_2 = vv4_2.Add(_node3);
            vv4_1.IsBefore(vv5_2).ShouldBeTrue();
        }

        [Fact]
        public void VersionVector_must_pass_misc_comparison_test_3()
        {
            var vv1_1 = VersionVector.Create();
            var vv2_1 = vv1_1.Add(_node1);

            var vv1_2 = VersionVector.Create();
            var vv2_2 = vv1_2.Add(_node2);
            vv2_1.IsConcurent(vv2_2).ShouldBeTrue();
        }

        [Fact]
        public void VersionVector_must_pass_misc_comparison_test_4()
        {
            var vv1_3 = VersionVector.Create();
            var vv2_3 = vv1_3.Add(_node1);
            var vv3_3 = vv2_3.Add(_node2);
            var vv4_3 = vv3_3.Add(_node1);

            var vv1_4 = VersionVector.Create();
            var vv2_4 = vv1_4.Add(_node1);
            var vv3_4 = vv2_4.Add(_node1);
            var vv4_4 = vv3_4.Add(_node3);
            vv4_3.IsConcurent(vv4_4).ShouldBeTrue();
        }

        [Fact]
        public void VersionVector_must_pass_misc_comparison_test_5()
        {
            var vv1_1 = VersionVector.Create();
            var vv2_1 = vv1_1.Add(_node2);
            var vv3_1 = vv2_1.Add(_node2);

            var vv1_2 = VersionVector.Create();
            var vv2_2 = vv1_2.Add(_node1);
            var vv3_2 = vv2_2.Add(_node2);
            var vv4_2 = vv3_2.Add(_node2);
            var vv5_2 = vv4_2.Add(_node3);
            vv3_1.IsBefore(vv5_2).ShouldBeTrue();
            vv5_2.IsAfter(vv3_1).ShouldBeTrue();
        }
        [Fact]
        public void VersionVector_must_pass_misc_comparison_test_6()
        {
            var vv1_1 = VersionVector.Create();
            var vv2_1 = vv1_1.Add(_node1);
            var vv3_1 = vv2_1.Add(_node2);

            var vv1_2 = VersionVector.Create();
            var vv2_2 = vv1_2.Add(_node1);
            var vv3_2 = vv2_2.Add(_node1);

            vv3_1.IsConcurent(vv3_2).ShouldBeTrue();
            vv3_2.IsConcurent(vv3_1).ShouldBeTrue();
        }
        [Fact]
        public void VersionVector_must_pass_misc_comparison_test_7()
        {
            var vv1_1 = VersionVector.Create();
            var vv2_1 = vv1_1.Add(_node1);
            var vv3_1 = vv2_1.Add(_node2);
            var vv4_1 = vv3_1.Add(_node2);
            var vv5_1 = vv4_1.Add(_node3);

            var vv1_2 = VersionVector.Create();
            var vv2_2 = vv1_2.Add(_node2);
            var vv3_2 = vv2_2.Add(_node2);

            vv5_1.IsConcurent(vv3_2).ShouldBeTrue();
            vv3_2.IsConcurent(vv5_1).ShouldBeTrue();
        }
        [Fact]
        public void VersionVector_must_pass_misc_comparison_test_8()
        {
            var vv1_1 = VersionVector.Create();
            var vv2_1 = vv1_1.Add(_node1);
            var vv3_1 = vv2_1.Add(_node3);

            var vv1_2 = vv3_1.Add(_node2);

            var vv4_1 = vv3_1.Add(_node3);

            vv4_1.IsConcurent(vv1_2).ShouldBeTrue();
            vv1_2.IsConcurent(vv4_1).ShouldBeTrue();
        }

        [Fact]
        public void VersionVector_must_correctly_merge_two_version_vectors()
        {
            var vv1_1 = VersionVector.Create();
            var vv2_1 = vv1_1.Add(_node1);
            var vv3_1 = vv2_1.Add(_node2);
            var vv4_1 = vv3_1.Add(_node2);
            var vv5_1 = vv4_1.Add(_node3);

            var vv1_2 = vv4_1;
            var vv2_2 = vv1_2.Add(_node2);
            var vv3_2 = vv2_2.Add(_node2);

            var merged1 = vv3_2.Merge(vv5_1);
            merged1.Size.ShouldBe(3);
            merged1.Contains(_node1).ShouldBeTrue();
            merged1.Contains(_node2).ShouldBeTrue();
            merged1.Contains(_node3).ShouldBeTrue();


            var merged2 = vv5_1.Merge(vv3_2);
            merged2.Size.ShouldBe(3);
            merged2.Contains(_node1).ShouldBeTrue();
            merged2.Contains(_node2).ShouldBeTrue();
            merged2.Contains(_node3).ShouldBeTrue();

            vv3_2.IsBefore(merged1).ShouldBe(true);
            vv5_1.IsBefore(merged1).ShouldBeTrue();

            vv3_2.IsBefore(merged2).ShouldBeTrue();
            vv5_1.IsBefore(merged2).ShouldBeTrue();

            merged1.Equals(merged2).ShouldBeTrue();
            
        }

        [Fact]
        public void VersionVector_must_correctly_merge_two_disjoint_version_vectors()
        {
            var vv1_1 = VersionVector.Create();
            var vv2_1 = vv1_1.Add(_node1);
            var vv3_1 = vv2_1.Add(_node2);
            var vv4_1 = vv3_1.Add(_node2);
            var vv5_1 = vv4_1.Add(_node3);

            var vv1_2 = VersionVector.Create();
            var vv2_2 = vv1_2.Add(_node4);
            var vv3_2 = vv2_2.Add(_node4);

            var merged1 = vv3_2.Merge(vv5_1);
            merged1.Size.ShouldBe(4);
            merged1.Contains(_node1).ShouldBeTrue();
            merged1.Contains(_node2).ShouldBeTrue();
            merged1.Contains(_node3).ShouldBeTrue();
            merged1.Contains(_node4).ShouldBeTrue();


            var merged2 = vv5_1.Merge(vv3_2);
            merged2.Size.ShouldBe(4);
            merged2.Contains(_node1).ShouldBeTrue();
            merged2.Contains(_node2).ShouldBeTrue();
            merged2.Contains(_node3).ShouldBeTrue();
            merged2.Contains(_node4).ShouldBeTrue();

            vv3_2.IsBefore(merged1).ShouldBe(true);
            vv5_1.IsBefore(merged1).ShouldBeTrue();

            vv3_2.IsBefore(merged2).ShouldBeTrue();
            vv5_1.IsBefore(merged2).ShouldBeTrue();

            merged1.Equals(merged2).ShouldBeTrue();
        }

        [Fact]
        public void VersionVector_must_pass_blank_version_vector_incrementing()
        {
            var v1 = VersionVector.Create();
            var v2 = VersionVector.Create();

            var vv1 = v1.Add(_node1);
            var vv2 = v2.Add(_node2);

            vv1.IsAfter(v1).ShouldBeTrue();
            vv2.IsAfter(v2).ShouldBeTrue();

            vv1.IsAfter(v2).ShouldBeTrue();
            vv2.IsAfter(v1).ShouldBeTrue();

            vv2.IsAfter(vv1).ShouldBeFalse();
            vv1.IsAfter(vv2).ShouldBeFalse();


        }

        [Fact]
        public void VersionVector_must_pass_merging_behavior()
        {
            var a = VersionVector.Create();
            var b = VersionVector.Create();

            var a1 = a.Add(_node1);
            var b1 = b.Add(_node2);

            var a2 = a1.Add(_node1);
            var c = a2.Merge(b1);
            var c1 = c.Add(_node3);
            c1.IsAfter(a2).ShouldBeTrue();
            c1.IsAfter(b1).ShouldBeTrue();


        }
    }
}