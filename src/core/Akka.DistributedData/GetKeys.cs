﻿// -----------------------------------------------------------------------
//  <copyright file="Replicator.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Lightbend Inc. <http://www.lightbend.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System.Collections.Immutable;

namespace Akka.DistributedData
{
    public class GetKeyIds
    {
        static readonly GetKeyIds _instance = new GetKeyIds();

        private GetKeyIds()
        { }

        public static GetKeyIds Instance
        {
            get { return _instance; }
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is GetKeyIds;
        }
    }

    public sealed class GetKeysIdsResult
    {
        private readonly IImmutableSet<string> _keys;

        internal GetKeysIdsResult(IImmutableSet<string> keys)
        {
            _keys = keys;
        }

        public IImmutableSet<string> Keys
        {
            get { return _keys; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as GetKeysIdsResult;
            if(other != null)
            {
                return _keys.SetEquals(other._keys);
            }
            return false;
        }
    }
}
