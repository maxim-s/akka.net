// -----------------------------------------------------------------------
//  <copyright file="FlushChanges.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

namespace Akka.DistributedData
{
    public class FlushChanges
    {
        static readonly FlushChanges _instance = new FlushChanges();

        private FlushChanges()
        { }

        public static FlushChanges Instance
        {
            get { return _instance; }
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is FlushChanges;
        }
    }
}
