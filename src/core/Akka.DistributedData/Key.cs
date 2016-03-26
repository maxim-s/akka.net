// -----------------------------------------------------------------------
//  <copyright file="Key.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System;

namespace Akka.DistributedData
{
    public interface IKey
    {
        string Id { get; }
    }

    public interface IKey<T> : IKey
    {}

    interface IKeyWithGenericType : IKey
    {
        Type Type { get; }
    }

    public abstract class Key<T> : IKey<T> where T : IReplicatedData
    {
        private readonly string _id;

        public Key(string id)
        {
            _id = id;
        }

        public string Id
        {
            get { return _id; }
        }

        public sealed override bool Equals(object obj)
        {
            var other = obj as Key<T>;
            if(other != null)
            {
                return other.Id == Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }

        public override string ToString()
        {
            return _id;
        }
    }
}
