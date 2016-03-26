// -----------------------------------------------------------------------
//  <copyright file="ReplicaCount.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

namespace Akka.DistributedData
{
    public class GetReplicaCount
    {
        static readonly GetReplicaCount _instance = new GetReplicaCount();

        static GetReplicaCount Instance
        {
            get { return _instance; }
        }
    }

    public class ReplicaCount
    {
        readonly int _n;

        public ReplicaCount(int n)
        {
            _n = n;
        }

        public int N
        {
            get { return _n; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as ReplicaCount;
            if(other != null)
            {
                return _n == other._n;
            }
            return false;
        }
    }
}
