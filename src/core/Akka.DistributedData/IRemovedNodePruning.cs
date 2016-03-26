// -----------------------------------------------------------------------
//  <copyright file="IRemovedNodePruning.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using Akka.Cluster;

namespace Akka.DistributedData
{
    public interface IRemovedNodePruning<T> : IReplicatedData<T> where T : IReplicatedData
    {
        bool NeedPruningFrom(UniqueAddress removedNode);

        T Prune(UniqueAddress removedNode, UniqueAddress collapseInto);

        T PruningCleanup(UniqueAddress removedNode);
    }

    public interface IRemovedNodePruning : IRemovedNodePruning<IReplicatedData>
    {}
}
