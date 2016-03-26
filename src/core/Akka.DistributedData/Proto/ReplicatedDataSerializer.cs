// -----------------------------------------------------------------------
//  <copyright file="ReplicatedDataSerializer.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Numerics;
using System.Text;
using Akka.Actor;
using Akka.Cluster;
using Akka.Serialization;
using Google.ProtocolBuffers;
using rd = Akka.DistributedData.Messages;

namespace Akka.DistributedData.Proto
{
    public interface IReplicatedDataSerialization
    {}

    public class ReplicatedDataSerializer : SerializerWithStringManifest, ISerializationSupport
    {
        const int BufferSize = 1024 * 4;

        const string DeletedDataManifest = "A";
        const string GSetManifest = "B";
        const string GSetKeyManifest = "b";
        const string ORSetManifest = "C";
        const string ORSetKeyManifest = "c";
        const string FlagManifest = "D";
        const string FlagKeyManifest = "d";
        const string LWWRegisterManifest = "E";
        const string LWWRegisterKeyManifest = "e";
        const string GCounterManifest = "F";
        const string GCounterKeyManifest = "f";
        const string PNCounterManifest = "G";
        const string PNCounterKeyManifest = "g";
        const string ORMapManifest = "H";
        const string ORMapKeyManifest = "h";
        const string LWWMapManifest = "I";
        const string LWWMapKeyManifest = "i";
        const string PNCounterMapManifest = "J";
        const string PNCounterMapKeyManifest = "j";
        const string ORMultiMapManifest = "K";
        const string ORMultiMapKeyManifest = "k";
        const string VersionVectorManifest = "L";

        readonly ExtendedActorSystem _system;

        private string _addressProtocol;

        private Serialization.Serialization _ser;

        public ReplicatedDataSerializer(ExtendedActorSystem system)
            : base(system)
        {
            _system = system;
        }

        public override int Identifier
        {
            get { return 11; }
        }

        public ExtendedActorSystem System
        {
            get { return _system; }
        }

        public Serialization.Serialization Serialization
        {
            get 
            {
                if (_ser == null) _ser = System.Serialization;
                return _ser;
            }
        }

        public string AddressProtocol
        {
            get
            {
                if (_addressProtocol == null) _addressProtocol = System.Provider.DefaultAddress.Protocol;
                return _addressProtocol;
            }
        }

        public override string Manifest(object o)
        {
            if (o is DeletedData) { return DeletedDataManifest; }

            if (o is Flag) { return FlagManifest; }
            if (o is GCounter) { return GCounterManifest; }
            if (o is PNCounter) { return PNCounterManifest; }
            if (o is IGSet) { return GSetManifest; }

            if (o is FlagKey) { return FlagKeyManifest; }
            if (o is GCounterKey) { return GCounterKeyManifest; }
            if (o is PNCounterKey) { return PNCounterKeyManifest; }
            if (o is IGSetKey) { return GSetKeyManifest; }

            throw new ArgumentException("Unsupported object type to be serialized");
        }

        public override object FromBinary(byte[] bytes, string manifest)
        {
            switch(manifest)
            {
                case DeletedDataManifest:
                    return DeletedData.Instance;
                case FlagManifest:
                    return FlagFromBinary(bytes);
                case FlagKeyManifest:
                    return new FlagKey(KeyIdFromBinary(bytes));
                case GCounterManifest:
                    return GCounterFromBinary(bytes);
                case GCounterKeyManifest:
                    return new GCounterKey(KeyIdFromBinary(bytes));
                case PNCounterManifest:
                    return PNCounterFromBinary(bytes);
                case PNCounterKeyManifest:
                    return new PNCounterKey(KeyIdFromBinary(bytes));
                case GSetManifest:
                    return GSetFromBinary(bytes);
                case GSetKeyManifest:
                    return GenericKeyFromBinary(typeof(GSetKey<>), bytes);
                default:
                    throw new ArgumentException(string.Format("Can't serialize manifest {0}", manifest));
            }
        }

        private object GenericKeyFromBinary(Type keyType, byte[] bytes)
        {
            if(!keyType.IsGenericType)
            {
                throw new ArgumentException(string.Format("Expecting a type with a generic parameter but given {0} instead", keyType.Name));
            }
            var genericKey = rd.GenericKey.ParseFrom(bytes);
            var genericTypeName = genericKey.Typehint.ToStringUtf8();
            var genericType = Type.GetType(genericTypeName);
            var t = keyType.MakeGenericType(genericType);
            var constructor = t.GetConstructor(new [] { typeof(string) });
            var id = KeyIdFromBinary(genericKey.Id.ToByteArray());
            return constructor.Invoke(new object[] { id });
        }

        private byte[] GenericKeyToBinary(IKeyWithGenericType key)
        {
            var keyBytes = KeyIdToBinary(key.Id);
            var typeHint = key.Type.AssemblyQualifiedName;
            return rd.GenericKey.CreateBuilder()
                                .SetId(ByteString.CopyFrom(keyBytes))
                                .SetTypehint(ByteString.CopyFromUtf8(typeHint))
                                .Build()
                                .ToByteArray();
        }

        private object GSetFromBinary(byte[] bytes)
        {
            return GSetFromProto(rd.GSet.ParseFrom(bytes));
        }

        private object GSetFromProto(rd.GSet gSet)
        {
            var typeIdentifier = gSet.TypeDescriptor;
            var elements = ImmutableHashSet.CreateRange(gSet.IntElementsList.Cast<object>());
            if (typeIdentifier == 0) { return GSet.Create(ImmutableHashSet.CreateRange(gSet.IntElementsList)); }
            if (typeIdentifier == 1) { return GSet.Create(ImmutableHashSet.CreateRange(gSet.LongElementsList)); }
            if (typeIdentifier == 2) { return GSet.Create(ImmutableHashSet.CreateRange(gSet.StringElementsList)); }
            if (typeIdentifier == 3)
            {
                var type = gSet.OtherElementsList[0].GetType();
                var set = typeof(ImmutableHashSet<>).MakeGenericType(type);
                var c = set.GetMethod("MakeRange", global::System.Reflection.BindingFlags.Static);
                var res = c.Invoke(null, new []{ (object)gSet.OtherElementsList });
                var constructor = typeof(GSet).GetMethod("Create");
                return constructor.Invoke(null, new []{ res });
            }
            return new GSet<object>();
        }

        private rd.GSet GSetToProto(IGSet gset)
        {
            var b = rd.GSet.CreateBuilder();
            var t = gset.GetType().GenericTypeArguments[0];
            if(t == typeof(string))
            {
                b.SetTypeDescriptor(2);
                foreach (var s in gset.Elements) { b.AddStringElements((string)s); }
            }
            else if(t == typeof(int))
            {
                b.SetTypeDescriptor(0);
                foreach (var i in gset.Elements) { b.AddIntElements((int)i); }
            }
            else if(t == typeof(long))
            {
                b.SetTypeDescriptor(1);
                foreach (var l in gset.Elements) { b.AddLongElements((long)l); }
            }
            else
            {
                b.SetTypeDescriptor(3);
                foreach (var o in gset.Elements.Select(x => this.OtherMessageToProto(x)).OrderBy(x => x, new OtherMessageComparator())) { b.AddOtherElements(o); }
            }
            return b.Build();
        }

        private PNCounter PNCounterFromBinary(byte[] bytes)
        {
            return PNCounterFromProto(rd.PNCounter.ParseFrom(bytes));
        }

        private PNCounter PNCounterFromProto(rd.PNCounter pNCounter)
        {
            return new PNCounter(GCounterFromProto(pNCounter.Increments), GCounterFromProto(pNCounter.Decrements));
        }

        private rd.PNCounter PNCounterToProto(PNCounter pncounter)
        {
            return rd.PNCounter.CreateBuilder()
                               .SetIncrements(GCounterToProto(pncounter.Increments))
                               .SetDecrements(GCounterToProto(pncounter.Decrements))
                               .Build();
        }

        public override byte[] ToBinary(object obj)
        {
            if (obj is Flag) { return FlagToProto((Flag)obj).ToByteArray(); }
            if (obj is GCounter) { return GCounterToProto((GCounter)obj).ToByteArray(); }
            if (obj is PNCounter) { return PNCounterToProto((PNCounter)obj).ToByteArray(); }
            if (obj is IGSet) { return GSetToProto((IGSet)obj).ToByteArray(); }
            if (obj is DeletedData) { return rd.Empty.DefaultInstance.ToByteArray(); }
            if (obj is IKeyWithGenericType) { return GenericKeyToBinary((IKeyWithGenericType)obj); }
            if (obj is IKey) { return KeyIdToBinary(((IKey)obj).Id); }
            throw new ArgumentException(string.Format("Can't serialize object of type {0}", obj.GetType().Name));
        }

        private Flag FlagFromBinary(byte[] bytes)
        {
            return FlagFromProto(rd.Flag.ParseFrom(bytes));
        }

        private Flag FlagFromProto(rd.Flag flag)
        {
            return new Flag(flag.Enabled);
        }

        private rd.Flag FlagToProto(Flag flag)
        {
            return rd.Flag.CreateBuilder().SetEnabled(flag.Enabled).Build();
        }

        private GCounter GCounterFromBinary(byte[] bytes)
        {
            return GCounterFromProto(rd.GCounter.ParseFrom(bytes));
        }

        private GCounter GCounterFromProto(rd.GCounter gcounter)
        {
            var entries = gcounter.EntriesList.Select(x => new KeyValuePair<UniqueAddress, BigInteger>(this.UniqueAddressFromProto(x.Node), new BigInteger(x.Value.ToByteArray()))).ToImmutableDictionary();
            return new GCounter(entries);
        }

        private rd.GCounter GCounterToProto(GCounter gcounter)
        {
            var b = rd.GCounter.CreateBuilder();
            foreach(var kvp in gcounter.State.OrderBy(x => x.Key))
            {
                b.AddEntries(rd.GCounter.Types.Entry.CreateBuilder()
                                                    .SetNode(this.UniqueAddressToProto(kvp.Key))
                                                    .SetValue(ByteString.CopyFrom(kvp.Value.ToByteArray())));
            }
            return b.Build();
        }

        private byte[] KeyIdToBinary(string id)
        {
            return Encoding.UTF8.GetBytes(id);
        }

        private string KeyIdFromBinary(byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
