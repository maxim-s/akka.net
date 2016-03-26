// -----------------------------------------------------------------------
//  <copyright file="Subscription.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using Akka.Actor;

namespace Akka.DistributedData
{
    internal interface ISubscribe
    {
        IKey Key { get; }
        IActorRef Subscriber { get; }
    }

    public sealed class Subscribe<T> : ISubscribe, IReplicatorMessage where T : IReplicatedData
    {
        readonly Key<T> _key;
        readonly IActorRef _subscriber;

        public Subscribe(Key<T> key, IActorRef subscriber)
        {
            _key = key;
            _subscriber = subscriber;
        }

        public Key<T> Key
        {
            get { return _key; }
        }

        public IActorRef Subscriber
        {
            get { return _subscriber; }
        }

        IKey ISubscribe.Key
        {
            get { return _key; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as Subscribe<T>;
            if (other != null)
            {
                return _key.Equals(other._key) && _subscriber.Equals(other._subscriber);
            }
            return false;
        }
    }

    internal interface IUnsubscribe
    {
        IKey Key { get; }
        IActorRef Subscriber { get; }
    }

    public sealed class Unsubscribe<T> : IUnsubscribe, IReplicatorMessage where T : IReplicatedData
    {
        readonly Key<T> _key;
        readonly IActorRef _subscriber;

        public Unsubscribe(Key<T> key, IActorRef subscriber)
        {
            _key = key;
            _subscriber = subscriber;
        }

        public Key<T> Key
        {
            get { return _key; }
        }

        public IActorRef Subscriber
        {
            get { return _subscriber; }
        }

        IKey IUnsubscribe.Key
        {
            get { return _key; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as Unsubscribe<T>;
            if(other != null)
            {
                return _key.Equals(other._key) && _subscriber.Equals(other._subscriber);
            }
            return false;
        }
    }

    internal interface IChanged
    {
        IKey Key { get; }
        object Data { get; }
    }

    public sealed class Changed<T> : IChanged, IReplicatorMessage where T : IReplicatedData
    {
        readonly T _data;
        readonly Key<T> _key;

        public Changed(Key<T> key, T data)
        {
            _key = key;
            _data = data;
        }

        public Key<T> Key
        {
            get { return _key; }
        }

        public T Data
        {
            get { return _data; }
        }

        IKey IChanged.Key
        {
            get { return _key; }
        }

        object IChanged.Data
        {
            get { return _data; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as Changed<T>;
            if(other != null)
            {
                return _key.Equals(other._key) && _data.Equals(other._data);
            }
            return false;
        }
    }
}
