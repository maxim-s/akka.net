// -----------------------------------------------------------------------
//  <copyright file="Get.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

namespace Akka.DistributedData
{
    internal interface IGet
    {
        IKey Key { get; }
        IReadConsistency Consistency { get; }
        object Request { get; }
    }

    public sealed class Get<T> : IGet, ICommand<T> where T : IReplicatedData
    {
        readonly IReadConsistency _consistency;
        readonly Key<T> _key;
        readonly object _request;

        public Get(Key<T> key, IReadConsistency consistency, object request = null)
        {
            _key = key;
            _consistency = consistency;
            _request = request;
        }

        IKey<T> ICommand<T>.Key
        {
            get { return _key; }
        }

        public IReadConsistency Consistency
        {
            get { return _consistency; }
        }

        public object Request
        {
            get { return _request; }
        }

        IKey IGet.Key
        {
            get { return _key; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as Get<T>;
            if(other != null)
            {
                var keysEqual = _key.Equals(other._key);
                var consistencyEqual = _consistency.Equals(other._consistency);
                bool requestsEqual = false;
                if (_request == null && other._request == null) { requestsEqual = true; }
                else if (_request != null) { requestsEqual = _request.Equals(other._request); }
                return keysEqual && consistencyEqual && requestsEqual;
            }
            return false;
        }
    }

    internal interface IGetResponse<T> where T : IReplicatedData
    {
        Key<T> Key { get; }
        object Request { get; }
    }

    internal interface IGetSuccess
    {
        object Data { get; }
        IKey Key { get; }
        object Request { get; }
    }

    public sealed class GetSuccess<T> : IGetResponse<T>, IGetSuccess, IReplicatorMessage where T : IReplicatedData
    {
        readonly T _data;
        readonly Key<T> _key;
        readonly object _request;

        public GetSuccess(Key<T> key, object request, T data)
        {
            _key = key;
            _request = request;
            _data = data;
        }

        public T Data
        {
            get { return _data; }
        }

        public Key<T> Key
        {
            get { return _key; }
        }

        public object Request
        {
            get { return _request; }
        }

        object IGetSuccess.Data
        {
            get { return _data; }
        }

        IKey IGetSuccess.Key
        {
            get { return _key; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as GetSuccess<T>;
            if (other != null)
            {
                var keysEqual = _key.Equals(other._key);
                var dataEqual = _data.Equals(other._data);
                bool requestsEqual = false;
                if (_request == null && other._request == null) { requestsEqual = true; }
                else if (_request != null) { requestsEqual = _request.Equals(other._request); }
                return keysEqual && dataEqual && requestsEqual;
            }
            return false;
        }
    }

    internal interface INotFound
    {
        IKey Key { get; }
        object Request { get; }
    }

    public sealed class NotFound<T> : IGetResponse<T>, INotFound, IReplicatorMessage where T : IReplicatedData
    {
        readonly Key<T> _key;
        readonly object _request;

        public NotFound(Key<T> key, object request)
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

        IKey INotFound.Key
        {
            get { return _key; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as NotFound<T>;
            if(other != null)
            {
                bool requestsEqual = false;
                if (_request == null && other._request == null) { requestsEqual = true; }
                else if (_request != null) { requestsEqual = _request.Equals(other._request); }
                return _key.Equals(other._key) && requestsEqual;
            }
            return false;
        }

        public static NotFound<T> Create<T>(Key<T> key, object request) where T : IReplicatedData
        {
            return new NotFound<T>(key, request);
        }
    }

    internal interface IGetFailure
    {
        IKey Key { get; }
        object Request { get; }
    }

    public sealed class GetFailure<T> : IGetResponse<T>, IGetFailure, IReplicatorMessage where T : IReplicatedData
    {
        private readonly Key<T> _key;
        private readonly object _request;

        public GetFailure(Key<T> key, object request)
        {
            _key = key;
            _request = request;
        }

        IKey IGetFailure.Key
        {
            get { return _key; }
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
            var other = obj as GetFailure<T>;
            if (other != null)
            {
                bool requestsEqual = false;
                if (_request == null && other._request == null) { requestsEqual = true; }
                else if (_request != null) { requestsEqual = _request.Equals(other._request); }
                return _key.Equals(other._key) && requestsEqual;
            }
            return false;
        }
    }

}
