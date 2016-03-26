// -----------------------------------------------------------------------
//  <copyright file="Internal.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System.Collections.Immutable;
using System.Linq;
using Akka.IO;

namespace Akka.DistributedData.Internal
{
    internal class GossipTick
    {
        static readonly GossipTick _instance = new GossipTick();

        private GossipTick()
        { }

        internal static GossipTick Instance
        {
            get { return _instance; }
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is GossipTick;
        }
    }

    internal class RemovedNodePruningTick
    {
        static readonly RemovedNodePruningTick _instance = new RemovedNodePruningTick();

        private RemovedNodePruningTick()
        { }

        internal static RemovedNodePruningTick Instance
        {
            get { return _instance; }
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is RemovedNodePruningTick;
        }
    }

    internal class ClockTick
    {
        static readonly ClockTick _instance = new ClockTick();

        private ClockTick()
        { }

        internal static ClockTick Instance
        {
            get { return _instance; }
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is ClockTick;
        }
    }

    internal class Write : IReplicatorMessage
    {
        readonly DataEnvelope _envelope;
        readonly string _key;

        public Write(string key, DataEnvelope envelope)
        {
            _key = key;
            _envelope = envelope;
        }

        public string Key
        {
            get { return _key; }
        }

        public DataEnvelope Envelope
        {
            get { return _envelope; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as Write;
            if(other != null)
            {
                return _key.Equals(other._key) && _envelope.Equals(other._envelope);
            }
            return false;
        }
    }

    internal class WriteAck : IReplicatorMessage
    {
        static readonly WriteAck _instance = new WriteAck();

        private WriteAck()
        { }

        public static WriteAck Instance
        {
            get { return _instance; }
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is WriteAck;
        }
    }

    internal class Read : IReplicatorMessage
    {
        readonly string _key;

        public Read(string key)
        {
            _key = key;
        }

        public string Key
        {
            get { return _key; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as Read;
            if(other == null)
            {
                return false;
            }
            return other.Key == Key;
        }
    }

    internal class ReadResult : IReplicatorMessage
    {
        readonly DataEnvelope _envelope;

        public ReadResult(DataEnvelope envelope)
        {
            _envelope = envelope;
        }

        public DataEnvelope Envelope
        {
            get { return _envelope; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as ReadResult;
            if(other == null)
            {
                return false;
            }
            bool envelopesEqual = false;
            if (_envelope == null && other._envelope == null) { envelopesEqual = true; }
            else if (_envelope != null) { envelopesEqual = _envelope.Equals(other._envelope); }
            return envelopesEqual;
        }
    }

    internal class ReadRepair
    {
        readonly DataEnvelope _envelope;
        readonly string _key;

        public ReadRepair(string key, DataEnvelope envelope)
        {
            _key = key;
            _envelope = envelope;
        }

        public string Key
        {
            get { return _key; }
        }

        public DataEnvelope Envelope
        {
            get { return _envelope; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as ReadRepair;
            if(other == null)
            {
                return false;
            }
            return other.Key == Key && other.Envelope == Envelope;
        }
    }

    internal class ReadRepairAck
    {
        static readonly ReadRepairAck _instance = new ReadRepairAck();

        private ReadRepairAck()
        { }

        public static ReadRepairAck Instance
        {
            get { return _instance; }
        }

        public override bool Equals(object obj)
        {
            return obj is ReadRepairAck;
        }
    }

    internal sealed class Status : IReplicatorMessage
    {
        readonly int _chunk;
        readonly IImmutableDictionary<string, ByteString> _digests;
        readonly int _totChunks;

        public Status(IImmutableDictionary<string, ByteString> digests, int chunk, int totChunks)
        {
            _digests = digests;
            _chunk = chunk;
            _totChunks = totChunks;
        }

        public IImmutableDictionary<string, ByteString> Digests
        {
            get { return _digests; }
        }

        public int Chunk
        {
            get { return _chunk; }
        }

        public int TotChunks
        {
            get { return _totChunks; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as Status;
            if(other == null)
            {
                return false;
            }
            var digestsEqual = Digests.Count.Equals(other.Digests.Count) && Digests.Except(other.Digests).Any();
            return digestsEqual && other.Chunk.Equals(Chunk) && other.TotChunks.Equals(TotChunks);
        }
    }

    internal sealed class Gossip : IReplicatorMessage
    {
        readonly bool _sendBack;
        readonly IImmutableDictionary<string, DataEnvelope> _updatedData;

        public Gossip(IImmutableDictionary<string, DataEnvelope> updatedData, bool sendBack)
        {
            _updatedData = updatedData;
            _sendBack = sendBack;
        }

        public IImmutableDictionary<string, DataEnvelope> UpdatedData
        {
            get { return _updatedData; }
        }

        public bool SendBack
        {
            get { return _sendBack; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as Gossip;
            if(other == null)
            {
                return false;
            }
            return other.SendBack.Equals(SendBack) && other.UpdatedData.Count.Equals(UpdatedData.Count) && !other.UpdatedData.Except(UpdatedData).Any();
        }
    }
}
