// -----------------------------------------------------------------------
//  <copyright file="Update.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System;

namespace Akka.DistributedData
{
    internal interface IUpdate
    {
        IKey Key { get; }
        IWriteConsistency Consistency { get; }
        object Request { get; }
        Func<IReplicatedData, IReplicatedData> Modify { get; }
    }

    public class Update<T> : IUpdate, ICommand<T> where T : IReplicatedData
    {
        readonly IWriteConsistency _consistency;

        readonly Key<T> _key;
        readonly Func<IReplicatedData, IReplicatedData> _modify;
        readonly object _request;

        public Update(Key<T> key, IWriteConsistency consistency, Func<IReplicatedData,IReplicatedData> modify, object requst = null)
        {
            _key = key;
            _consistency = consistency;
            _modify = modify;
            _request = requst;
        }

        public Update(Key<T> key, T initial, IWriteConsistency consistency, Func<IReplicatedData, IReplicatedData> modify, object request = null)
        {
            _key = key;
            _consistency = consistency;
            _request = request;
            _modify = x => ModifyWithInitial(initial, modify, x);
        }

        IKey<T> ICommand<T>.Key
        {
            get { return _key; }
        }

        public IWriteConsistency Consistency
        {
            get { return _consistency; }
        }

        public object Request
        {
            get { return _request; }
        }

        IKey IUpdate.Key
        {
            get { return _key; }
        }

        public Func<IReplicatedData, IReplicatedData> Modify
        {
            get { return x => _modify(x); }
        }

        private IReplicatedData ModifyWithInitial(T initial, Func<IReplicatedData, IReplicatedData> modifier, IReplicatedData data)
        {
            if(data == null)
            {
                return modifier(initial);
            }
            return modifier(data);
        }
    }

    public interface IUpdateResponse<T> where T : IReplicatedData
    {
        Key<T> Key { get; }
        object Request { get; }
    }

    public sealed class UpdateSuccess<T> : IUpdateResponse<T> where T : IReplicatedData
    {
        readonly Key<T> _key;
        readonly object _request;

        public UpdateSuccess(Key<T> key, object request)
        {
            _key = key;
            _request = request;
        }

        public Key<T> Key
        {
            get { return _key; }
        }

        public object Request
        {
            get { return _request; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as UpdateSuccess<T>;
            if(other != null)
            {
                bool requestsEqual = false;
                if (_request == null && other._request == null) { requestsEqual = true; }
                else if (_request != null) { requestsEqual = _request.Equals(other._request); }
                return Key.Equals(other.Key) && requestsEqual;
            }
            return false;
        }
    }

    public interface IUpdateFailure<T> : IUpdateResponse<T> where T : IReplicatedData
    {}

    public class UpdateTimeout<T> : IUpdateFailure<T> where T : IReplicatedData
    {
        private readonly Key<T> _key;
        private readonly object _request;

        public UpdateTimeout(Key<T> key, object request)
        {
            _key = key;
            _request = request;
        }

        public Key<T> Key
        {
            get { return _key; }
        }

        public object Request
        {
            get { return _request; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as UpdateTimeout<T>;
            if(other != null)
            {
                bool requestEqual = false;
                if (_request == null && other._request == null) requestEqual = true;
                else if(_request != null && _request.Equals(other._request)) requestEqual = true;
                return requestEqual && _key.Equals(other._key);
            }
            return false;
        }
    }

    public class ModifyFailure<T> : IUpdateFailure<T> where T : IReplicatedData
    {
        readonly Exception _cause;
        readonly string _errorMessage;
        readonly Key<T> _key;
        readonly object _request;

        public ModifyFailure(Key<T> key, string errorMessage, Exception cause, object request)
        {
            _key = key;
            _request = request;
            _errorMessage = errorMessage;
            _cause = cause;
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
        }

        public Exception Cause
        {
            get { return _cause; }
        }

        public Key<T> Key
        {
            get { return _key; }
        }

        public object Request
        {
            get { return _request; }
        }

        public override string ToString()
        {
            return string.Format("ModifyFailure {0}: {1}", Key, ErrorMessage);
        }
    }
}
