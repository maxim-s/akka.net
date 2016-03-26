// -----------------------------------------------------------------------
//  <copyright file="DeletedData.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------
namespace Akka.DistributedData
{
    public class DeletedData : AbstractReplicatedData<DeletedData>
    {
        static readonly DeletedData _instance = new DeletedData();

        private DeletedData()
        { }

        public static DeletedData Instance
        {
            get { return _instance; }
        }

        public override DeletedData Merge(DeletedData other)
        {
            return this;
        }

        public override bool Equals(object obj)
        {
            return obj is DeletedData;
        }
    }
}
