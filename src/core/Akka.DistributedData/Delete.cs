// -----------------------------------------------------------------------
//  <copyright file="Delete.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System;

namespace Akka.DistributedData
{
    internal interface IDelete
    {
        IKey Key { get; }
        IWriteConsistency Consistency { get; }
    }

    public class Delete<T> : IDelete, ICommand<T> where T : IReplicatedData
    {
        readonly IWriteConsistency _consistency;
        readonly Key<T> _key;

        public Delete(Key<T> key, IWriteConsistency consistency)
        {
            _key = key;
            _consistency = consistency;
        }

        public Key<T> Key
        {
            get { return _key; }
        }

        IKey<T> ICommand<T>.Key
        {
            get { return _key; }
        }

        public IWriteConsistency Consistency
        {
            get { return _consistency; }
        }

        IKey IDelete.Key
        {
            get { return _key; }
        }
    }

    public interface IDeleteResponse<T> where T : IReplicatedData
    {
        Key<T> Key { get; }
    }

    public class DeleteSuccess<T> : IDeleteResponse<T> where T : IReplicatedData
    {
        readonly Key<T> _key;

        public DeleteSuccess(Key<T> key)
        {
            _key = key;
        }

        public Key<T> Key
        {
            get { return _key; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as DeleteSuccess<T>;
            if(other != null)
            {
                return _key.Equals(other._key);
            }
            return false;
        }
    }

    public class ReplicationDeletedFailure<T> : IDeleteResponse<T> where T : IReplicatedData
    {
        readonly Key<T> _key;

        public ReplicationDeletedFailure(Key<T> key)
        {
            _key = key;
        }

        public Key<T> Key
        {
            get { return _key; }
        }
    }

    public class DataDeleted<T> : Exception, IDeleteResponse<T> where T : IReplicatedData
    {
        readonly Key<T> _key;

        public DataDeleted(Key<T> key)
        {
            _key = key;
        }

        public Key<T> Key
        {
            get { return _key; }
        }

        public override string ToString()
        {
 	        return string.Format("DataDeleted {0}", _key.Id);
        }

        public override bool Equals(object obj)
        {
            var other = obj as DataDeleted<T>;
            if(other != null)
            {
                return _key.Equals(other._key);
            }
            return false;
        }
    }
}
