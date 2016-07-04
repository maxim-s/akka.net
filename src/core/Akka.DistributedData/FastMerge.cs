﻿// -----------------------------------------------------------------------
//  <copyright file="FastMerge.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Lightbend Inc. <http://www.lightbend.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

namespace Akka.DistributedData
{
    /// <summary>
    ///     INTERNAL API
    ///     Optimization for add/remove followed by merge and merge should just fast forward to
    ///     the new instance.
    ///     It's like a cache between calls of the same thread, you can think of it as a thread local.
    ///     The Replicator actor invokes the user's modify function, which returns a new ReplicatedData instance,
    ///     with the ancestor field set(see for example the add method in ORSet). Then(in same thread) the
    ///     Replication calls merge, which makes use of the ancestor field to perform quick merge
    ///     (see for example merge method in ORSet).
    ///     It's not thread safe if the modifying function and merge are called from different threads,
    ///     i.e. if used outside the Replicator infrastructure, but the worst thing that can happen is that
    ///     a full merge is performed instead of the fast forward merge.
    /// </summary>
    public static class FastMerge
    {
        /// <summary>
        ///     INTERNAL API: should be called from "updating" methods
        /// </summary>
        public static IFastMerge AssignAncestor(this IFastMerge fastMerge, IFastMerge newData)
        {
            newData.Ancestor = fastMerge.Ancestor ?? fastMerge;
            fastMerge.Ancestor = null; // only one level, for GC
            return newData;
        }

        /// <summary>
        /// INTERNAL API: should be called from merge
        /// </summary>
        /// <returns></returns>
        public static IFastMerge ClearAncestor(this IFastMerge fastMerge)
        {
            fastMerge.Ancestor = null;
            return fastMerge;
        }

        /// <summary>
        /// INTERNAL API: should be used from merge
        /// </summary>
        public static bool IsAncestorOf(this IFastMerge fastMerge, IFastMerge that)
        {
            return that.Ancestor != null ? that.Ancestor.Equals(fastMerge) : false;
        }
    }

    public interface IFastMerge
    {
        IFastMerge Ancestor { get; set; }
    }

}