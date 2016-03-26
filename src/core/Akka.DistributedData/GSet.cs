// -----------------------------------------------------------------------
//  <copyright file="GSet.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Immutable;
using System.Linq;
using Akka.DistributedData.Proto;

namespace Akka.DistributedData
{
    internal interface IGSet
    {
        IImmutableSet<object> Elements { get; }
    }

    public static class GSet
    {
        public static GSet<T> Create<T>(IImmutableSet<T> elements)
        {
            return new GSet<T>(elements);
        }
    }

    public sealed class GSet<T> : AbstractReplicatedData<GSet<T>>, IReplicatedDataSerialization, IGSet
    {
        readonly IImmutableSet<T> _elements;

        public GSet()
            : this(ImmutableHashSet<T>.Empty)
        { }

        public GSet(IImmutableSet<T> elements)
        {
            _elements = elements;
        }

        public IImmutableSet<T> Elements
        {
            get { return _elements; }
        }

        IImmutableSet<object> IGSet.Elements
        {
            get { return _elements.Cast<object>().ToImmutableHashSet(); }
        }

        public override GSet<T> Merge(GSet<T> other)
        {
            return new GSet<T>(Elements.Union(other.Elements));
        }

        public bool Contains(T element)
        {
            return _elements.Contains(element);
        }

        public bool IsEmpty()
        {
            return _elements.Count == 0;
        }

        public int Count()
        {
            return _elements.Count;
        }

        public GSet<T> Add(T element)
        {
            return new GSet<T>(_elements.Add(element));
        }

        public override bool Equals(object obj)
        {
            var other = obj as GSet<T>;
            if(other != null)
            {
                var elementsEqual = _elements.SetEquals(other._elements);
                return elementsEqual;
            }
            return false;
        }
    }

    internal interface IGSetKey
    {}

    public sealed class GSetKey<T> : Key<GSet<T>>, IKeyWithGenericType, IGSetKey, IReplicatedDataSerialization
    {
        readonly Type _type;

        public GSetKey(string id)
            : base(id)
        {
            _type = typeof(T);
        }

        public Type Type
        {
            get { return _type; }
        }
    }
}
