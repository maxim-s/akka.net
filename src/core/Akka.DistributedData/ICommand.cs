// -----------------------------------------------------------------------
//  <copyright file="ICommand.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

namespace Akka.DistributedData
{
    internal interface ICommand<T> where T : IReplicatedData
    {
        IKey<T> Key { get; }
    }
}
