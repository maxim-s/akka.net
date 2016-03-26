// -----------------------------------------------------------------------
//  <copyright file="MultiMapBinding.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;

namespace Akka.DistributedData
{
    public static class MultiMapBinding
    {
        public static void AddBinding<T,U>(this IDictionary<T, ISet<U>> dict, T key, U value)
        {
            if(!dict.ContainsKey(key))
            {
                dict.Add(key, new HashSet<U>());
            }
            dict[key].Add(value);
        }

        public static void RemoveBinding<T,U>(this IDictionary<T, ISet<U>> dict, T key, U value)
        {
            if(dict.ContainsKey(key))
            {
                dict[key].Remove(value);
            }
        }
    }
}
