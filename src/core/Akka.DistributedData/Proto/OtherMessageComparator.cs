// -----------------------------------------------------------------------
//  <copyright file="OtherMessageComparator.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using dm = Akka.DistributedData.Messages;

namespace Akka.DistributedData.Proto
{
    public class OtherMessageComparator : IComparer<dm.OtherMessage>
    {
        public int Compare(dm.OtherMessage x, dm.OtherMessage y)
        {
            var abytestring = x.EnclosedMessage;
            var bbytestring = y.EnclosedMessage;
            var asize = abytestring.Length;
            var bsize = bbytestring.Length;
            if(asize == bsize)
            {
                var aEnum = abytestring.GetEnumerator();
                var bEnum = bbytestring.GetEnumerator();
                while(true)
                {
                    if(aEnum.MoveNext() && bEnum.MoveNext())
                    {
                        if(aEnum.Current < bEnum.Current)
                        {
                            return -1;
                        }
                        if(aEnum.Current > bEnum.Current)
                        {
                            return 1;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            if(asize < bsize)
            {
                return -1;
            }
            return 1;
        }
    }
}
