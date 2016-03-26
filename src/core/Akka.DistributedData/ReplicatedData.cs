// -----------------------------------------------------------------------
//  <copyright file="ReplicatedData.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System;

namespace Akka.DistributedData
{
    public interface IReplicatedData
    {
        IReplicatedData Merge(IReplicatedData other);
    }

    public interface IReplicatedData<T> : IReplicatedData where T : IReplicatedData
    {
        T Merge(T other);
    }

    public abstract class AbstractReplicatedData<T> : IReplicatedData<T> where T : IReplicatedData
    {
        public abstract T Merge(T other);

        public IReplicatedData Merge(IReplicatedData other)
        {
            if(other is T)
            {
                return Merge((T)other);
            }
            throw new ArgumentException("Unable to merge different CRDTs");
        }
    }

}
