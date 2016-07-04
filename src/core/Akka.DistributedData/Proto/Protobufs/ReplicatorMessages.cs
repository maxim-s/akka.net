// -----------------------------------------------------------------------
//  <copyright file="ReplicatorMessages.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Akka.DistributedData.Messages {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ReplicatorMessages {
      #region Extension registration

      public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }

      #endregion

      #region Static variables

      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_Get__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Get, global::Akka.DistributedData.Messages.Get.Builder> internal__static_Akka_DistributedData_Messages_Get__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_GetSuccess__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.GetSuccess, global::Akka.DistributedData.Messages.GetSuccess.Builder> internal__static_Akka_DistributedData_Messages_GetSuccess__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_NotFound__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.NotFound, global::Akka.DistributedData.Messages.NotFound.Builder> internal__static_Akka_DistributedData_Messages_NotFound__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_GetFailure__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.GetFailure, global::Akka.DistributedData.Messages.GetFailure.Builder> internal__static_Akka_DistributedData_Messages_GetFailure__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_Subscribe__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Subscribe, global::Akka.DistributedData.Messages.Subscribe.Builder> internal__static_Akka_DistributedData_Messages_Subscribe__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_Unsubscribe__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Unsubscribe, global::Akka.DistributedData.Messages.Unsubscribe.Builder> internal__static_Akka_DistributedData_Messages_Unsubscribe__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_Changed__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Changed, global::Akka.DistributedData.Messages.Changed.Builder> internal__static_Akka_DistributedData_Messages_Changed__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_Write__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Write, global::Akka.DistributedData.Messages.Write.Builder> internal__static_Akka_DistributedData_Messages_Write__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_Empty__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Empty, global::Akka.DistributedData.Messages.Empty.Builder> internal__static_Akka_DistributedData_Messages_Empty__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_Read__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Read, global::Akka.DistributedData.Messages.Read.Builder> internal__static_Akka_DistributedData_Messages_Read__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_ReadResult__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.ReadResult, global::Akka.DistributedData.Messages.ReadResult.Builder> internal__static_Akka_DistributedData_Messages_ReadResult__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_DataEnvelope__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.DataEnvelope, global::Akka.DistributedData.Messages.DataEnvelope.Builder> internal__static_Akka_DistributedData_Messages_DataEnvelope__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_DataEnvelope_PruningEntry__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry, global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry.Builder> internal__static_Akka_DistributedData_Messages_DataEnvelope_PruningEntry__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_Status__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Status, global::Akka.DistributedData.Messages.Status.Builder> internal__static_Akka_DistributedData_Messages_Status__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_Status_Entry__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Status.Types.Entry, global::Akka.DistributedData.Messages.Status.Types.Entry.Builder> internal__static_Akka_DistributedData_Messages_Status_Entry__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_Gossip__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Gossip, global::Akka.DistributedData.Messages.Gossip.Builder> internal__static_Akka_DistributedData_Messages_Gossip__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_Gossip_Entry__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Gossip.Types.Entry, global::Akka.DistributedData.Messages.Gossip.Types.Entry.Builder> internal__static_Akka_DistributedData_Messages_Gossip_Entry__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_UniqueAddress__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.UniqueAddress, global::Akka.DistributedData.Messages.UniqueAddress.Builder> internal__static_Akka_DistributedData_Messages_UniqueAddress__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_Address__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Address, global::Akka.DistributedData.Messages.Address.Builder> internal__static_Akka_DistributedData_Messages_Address__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_OtherMessage__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.OtherMessage, global::Akka.DistributedData.Messages.OtherMessage.Builder> internal__static_Akka_DistributedData_Messages_OtherMessage__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_StringGSet__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.StringGSet, global::Akka.DistributedData.Messages.StringGSet.Builder> internal__static_Akka_DistributedData_Messages_StringGSet__FieldAccessorTable;

      #endregion

      #region Descriptor

      public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }

      private static pbd::FileDescriptor descriptor;

      static ReplicatorMessages() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "ChhSZXBsaWNhdG9yTWVzc2FnZXMucHJvdG8SHUFra2EuRGlzdHJpYnV0ZWRE" + 
          "YXRhLk1lc3NhZ2VzIqMBCgNHZXQSOAoDa2V5GAEgAigLMisuQWtrYS5EaXN0" + 
          "cmlidXRlZERhdGEuTWVzc2FnZXMuT3RoZXJNZXNzYWdlEhMKC2NvbnNpc3Rl" + 
          "bmN5GAIgAigREg8KB3RpbWVvdXQYAyACKA0SPAoHcmVxdWVzdBgEIAEoCzIr" + 
          "LkFra2EuRGlzdHJpYnV0ZWREYXRhLk1lc3NhZ2VzLk90aGVyTWVzc2FnZSK/" + 
          "AQoKR2V0U3VjY2VzcxI4CgNrZXkYASACKAsyKy5Ba2thLkRpc3RyaWJ1dGVk" + 
          "RGF0YS5NZXNzYWdlcy5PdGhlck1lc3NhZ2USOQoEZGF0YRgCIAIoCzIrLkFr" + 
          "a2EuRGlzdHJpYnV0ZWREYXRhLk1lc3NhZ2VzLk90aGVyTWVzc2FnZRI8Cgdy" + 
          "ZXF1ZXN0GAQgASgLMisuQWtrYS5EaXN0cmlidXRlZERhdGEuTWVzc2FnZXMu" + 
          "T3RoZXJNZXNzYWdlIoIBCghOb3RGb3VuZBI4CgNrZXkYASACKAsyKy5Ba2th" + 
          "LkRpc3RyaWJ1dGVkRGF0YS5NZXNzYWdlcy5PdGhlck1lc3NhZ2USPAoHcmVx" + 
          "dWVzdBgCIAEoCzIrLkFra2EuRGlzdHJpYnV0ZWREYXRhLk1lc3NhZ2VzLk90" + 
          "aGVyTWVzc2FnZSKEAQoKR2V0RmFpbHVyZRI4CgNrZXkYASACKAsyKy5Ba2th" + 
          "LkRpc3RyaWJ1dGVkRGF0YS5NZXNzYWdlcy5PdGhlck1lc3NhZ2USPAoHcmVx" + 
          "dWVzdBgCIAEoCzIrLkFra2EuRGlzdHJpYnV0ZWREYXRhLk1lc3NhZ2VzLk90" + 
          "aGVyTWVzc2FnZSJSCglTdWJzY3JpYmUSOAoDa2V5GAEgAigLMisuQWtrYS5E" + 
          "aXN0cmlidXRlZERhdGEuTWVzc2FnZXMuT3RoZXJNZXNzYWdlEgsKA3JlZhgC" + 
          "IAIoCSJUCgtVbnN1YnNjcmliZRI4CgNrZXkYASACKAsyKy5Ba2thLkRpc3Ry" + 
          "aWJ1dGVkRGF0YS5NZXNzYWdlcy5PdGhlck1lc3NhZ2USCwoDcmVmGAIgAigJ" + 
          "In4KB0NoYW5nZWQSOAoDa2V5GAEgAigLMisuQWtrYS5EaXN0cmlidXRlZERh" + 
          "dGEuTWVzc2FnZXMuT3RoZXJNZXNzYWdlEjkKBGRhdGEYAiACKAsyKy5Ba2th" + 
          "LkRpc3RyaWJ1dGVkRGF0YS5NZXNzYWdlcy5PdGhlck1lc3NhZ2UiUwoFV3Jp" + 
          "dGUSCwoDa2V5GAEgAigJEj0KCGVudmVsb3BlGAIgAigLMisuQWtrYS5EaXN0" + 
          "cmlidXRlZERhdGEuTWVzc2FnZXMuRGF0YUVudmVsb3BlIgcKBUVtcHR5IhMK" + 
          "BFJlYWQSCwoDa2V5GAEgAigJIksKClJlYWRSZXN1bHQSPQoIZW52ZWxvcGUY" + 
          "ASABKAsyKy5Ba2thLkRpc3RyaWJ1dGVkRGF0YS5NZXNzYWdlcy5EYXRhRW52" + 
          "ZWxvcGUi+AIKDERhdGFFbnZlbG9wZRI5CgRkYXRhGAEgAigLMisuQWtrYS5E" + 
          "aXN0cmlidXRlZERhdGEuTWVzc2FnZXMuT3RoZXJNZXNzYWdlEkkKB3BydW5p" + 
          "bmcYAiADKAsyOC5Ba2thLkRpc3RyaWJ1dGVkRGF0YS5NZXNzYWdlcy5EYXRh" + 
          "RW52ZWxvcGUuUHJ1bmluZ0VudHJ5GuEBCgxQcnVuaW5nRW50cnkSRAoOcmVt" + 
          "b3ZlZEFkZHJlc3MYASACKAsyLC5Ba2thLkRpc3RyaWJ1dGVkRGF0YS5NZXNz" + 
          "YWdlcy5VbmlxdWVBZGRyZXNzEkIKDG93bmVyQWRkcmVzcxgCIAIoCzIsLkFr" + 
          "a2EuRGlzdHJpYnV0ZWREYXRhLk1lc3NhZ2VzLlVuaXF1ZUFkZHJlc3MSEQoJ" + 
          "cGVyZm9ybWVkGAMgAigIEjQKBHNlZW4YBCADKAsyJi5Ba2thLkRpc3RyaWJ1" + 
          "dGVkRGF0YS5NZXNzYWdlcy5BZGRyZXNzIo4BCgZTdGF0dXMSDQoFY2h1bmsY" + 
          "ASACKA0SEQoJdG90Q2h1bmtzGAIgAigNEjwKB2VudHJpZXMYAyADKAsyKy5B" + 
          "a2thLkRpc3RyaWJ1dGVkRGF0YS5NZXNzYWdlcy5TdGF0dXMuRW50cnkaJAoF" + 
          "RW50cnkSCwoDa2V5GAEgAigJEg4KBmRpZ2VzdBgCIAIoDCKtAQoGR29zc2lw" + 
          "EhAKCHNlbmRCYWNrGAEgAigIEjwKB2VudHJpZXMYAiADKAsyKy5Ba2thLkRp" + 
          "c3RyaWJ1dGVkRGF0YS5NZXNzYWdlcy5Hb3NzaXAuRW50cnkaUwoFRW50cnkS" + 
          "CwoDa2V5GAEgAigJEj0KCGVudmVsb3BlGAIgAigLMisuQWtrYS5EaXN0cmli" + 
          "dXRlZERhdGEuTWVzc2FnZXMuRGF0YUVudmVsb3BlIlUKDVVuaXF1ZUFkZHJl" + 
          "c3MSNwoHYWRkcmVzcxgBIAIoCzImLkFra2EuRGlzdHJpYnV0ZWREYXRhLk1l" + 
          "c3NhZ2VzLkFkZHJlc3MSCwoDdWlkGAIgAigPIikKB0FkZHJlc3MSEAoIaG9z" + 
          "dG5hbWUYASACKAkSDAoEcG9ydBgCIAIoDSJWCgxPdGhlck1lc3NhZ2USFwoP" + 
          "ZW5jbG9zZWRNZXNzYWdlGAEgAigMEhQKDHNlcmlhbGl6ZXJJZBgCIAIoBRIX" + 
          "Cg9tZXNzYWdlTWFuaWZlc3QYBCABKAwiHgoKU3RyaW5nR1NldBIQCghlbGVt" + 
          "ZW50cxgBIAMoCUIjCh9ha2thLmNsdXN0ZXIuZGRhdGEucHJvdG9idWYubXNn" + 
          "SAE=");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_Akka_DistributedData_Messages_Get__Descriptor = Descriptor.MessageTypes[0];
        internal__static_Akka_DistributedData_Messages_Get__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Get, global::Akka.DistributedData.Messages.Get.Builder>(internal__static_Akka_DistributedData_Messages_Get__Descriptor,
                new string[] { "Key", "Consistency", "Timeout", "Request", });
        internal__static_Akka_DistributedData_Messages_GetSuccess__Descriptor = Descriptor.MessageTypes[1];
        internal__static_Akka_DistributedData_Messages_GetSuccess__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.GetSuccess, global::Akka.DistributedData.Messages.GetSuccess.Builder>(internal__static_Akka_DistributedData_Messages_GetSuccess__Descriptor,
                new string[] { "Key", "Data", "Request", });
        internal__static_Akka_DistributedData_Messages_NotFound__Descriptor = Descriptor.MessageTypes[2];
        internal__static_Akka_DistributedData_Messages_NotFound__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.NotFound, global::Akka.DistributedData.Messages.NotFound.Builder>(internal__static_Akka_DistributedData_Messages_NotFound__Descriptor,
                new string[] { "Key", "Request", });
        internal__static_Akka_DistributedData_Messages_GetFailure__Descriptor = Descriptor.MessageTypes[3];
        internal__static_Akka_DistributedData_Messages_GetFailure__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.GetFailure, global::Akka.DistributedData.Messages.GetFailure.Builder>(internal__static_Akka_DistributedData_Messages_GetFailure__Descriptor,
                new string[] { "Key", "Request", });
        internal__static_Akka_DistributedData_Messages_Subscribe__Descriptor = Descriptor.MessageTypes[4];
        internal__static_Akka_DistributedData_Messages_Subscribe__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Subscribe, global::Akka.DistributedData.Messages.Subscribe.Builder>(internal__static_Akka_DistributedData_Messages_Subscribe__Descriptor,
                new string[] { "Key", "Ref", });
        internal__static_Akka_DistributedData_Messages_Unsubscribe__Descriptor = Descriptor.MessageTypes[5];
        internal__static_Akka_DistributedData_Messages_Unsubscribe__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Unsubscribe, global::Akka.DistributedData.Messages.Unsubscribe.Builder>(internal__static_Akka_DistributedData_Messages_Unsubscribe__Descriptor,
                new string[] { "Key", "Ref", });
        internal__static_Akka_DistributedData_Messages_Changed__Descriptor = Descriptor.MessageTypes[6];
        internal__static_Akka_DistributedData_Messages_Changed__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Changed, global::Akka.DistributedData.Messages.Changed.Builder>(internal__static_Akka_DistributedData_Messages_Changed__Descriptor,
                new string[] { "Key", "Data", });
        internal__static_Akka_DistributedData_Messages_Write__Descriptor = Descriptor.MessageTypes[7];
        internal__static_Akka_DistributedData_Messages_Write__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Write, global::Akka.DistributedData.Messages.Write.Builder>(internal__static_Akka_DistributedData_Messages_Write__Descriptor,
                new string[] { "Key", "Envelope", });
        internal__static_Akka_DistributedData_Messages_Empty__Descriptor = Descriptor.MessageTypes[8];
        internal__static_Akka_DistributedData_Messages_Empty__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Empty, global::Akka.DistributedData.Messages.Empty.Builder>(internal__static_Akka_DistributedData_Messages_Empty__Descriptor,
                new string[] { });
        internal__static_Akka_DistributedData_Messages_Read__Descriptor = Descriptor.MessageTypes[9];
        internal__static_Akka_DistributedData_Messages_Read__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Read, global::Akka.DistributedData.Messages.Read.Builder>(internal__static_Akka_DistributedData_Messages_Read__Descriptor,
                new string[] { "Key", });
        internal__static_Akka_DistributedData_Messages_ReadResult__Descriptor = Descriptor.MessageTypes[10];
        internal__static_Akka_DistributedData_Messages_ReadResult__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.ReadResult, global::Akka.DistributedData.Messages.ReadResult.Builder>(internal__static_Akka_DistributedData_Messages_ReadResult__Descriptor,
                new string[] { "Envelope", });
        internal__static_Akka_DistributedData_Messages_DataEnvelope__Descriptor = Descriptor.MessageTypes[11];
        internal__static_Akka_DistributedData_Messages_DataEnvelope__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.DataEnvelope, global::Akka.DistributedData.Messages.DataEnvelope.Builder>(internal__static_Akka_DistributedData_Messages_DataEnvelope__Descriptor,
                new string[] { "Data", "Pruning", });
        internal__static_Akka_DistributedData_Messages_DataEnvelope_PruningEntry__Descriptor = internal__static_Akka_DistributedData_Messages_DataEnvelope__Descriptor.NestedTypes[0];
        internal__static_Akka_DistributedData_Messages_DataEnvelope_PruningEntry__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry, global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry.Builder>(internal__static_Akka_DistributedData_Messages_DataEnvelope_PruningEntry__Descriptor,
                new string[] { "RemovedAddress", "OwnerAddress", "Performed", "Seen", });
        internal__static_Akka_DistributedData_Messages_Status__Descriptor = Descriptor.MessageTypes[12];
        internal__static_Akka_DistributedData_Messages_Status__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Status, global::Akka.DistributedData.Messages.Status.Builder>(internal__static_Akka_DistributedData_Messages_Status__Descriptor,
                new string[] { "Chunk", "TotChunks", "Entries", });
        internal__static_Akka_DistributedData_Messages_Status_Entry__Descriptor = internal__static_Akka_DistributedData_Messages_Status__Descriptor.NestedTypes[0];
        internal__static_Akka_DistributedData_Messages_Status_Entry__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Status.Types.Entry, global::Akka.DistributedData.Messages.Status.Types.Entry.Builder>(internal__static_Akka_DistributedData_Messages_Status_Entry__Descriptor,
                new string[] { "Key", "Digest", });
        internal__static_Akka_DistributedData_Messages_Gossip__Descriptor = Descriptor.MessageTypes[13];
        internal__static_Akka_DistributedData_Messages_Gossip__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Gossip, global::Akka.DistributedData.Messages.Gossip.Builder>(internal__static_Akka_DistributedData_Messages_Gossip__Descriptor,
                new string[] { "SendBack", "Entries", });
        internal__static_Akka_DistributedData_Messages_Gossip_Entry__Descriptor = internal__static_Akka_DistributedData_Messages_Gossip__Descriptor.NestedTypes[0];
        internal__static_Akka_DistributedData_Messages_Gossip_Entry__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Gossip.Types.Entry, global::Akka.DistributedData.Messages.Gossip.Types.Entry.Builder>(internal__static_Akka_DistributedData_Messages_Gossip_Entry__Descriptor,
                new string[] { "Key", "Envelope", });
        internal__static_Akka_DistributedData_Messages_UniqueAddress__Descriptor = Descriptor.MessageTypes[14];
        internal__static_Akka_DistributedData_Messages_UniqueAddress__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.UniqueAddress, global::Akka.DistributedData.Messages.UniqueAddress.Builder>(internal__static_Akka_DistributedData_Messages_UniqueAddress__Descriptor,
                new string[] { "Address", "Uid", });
        internal__static_Akka_DistributedData_Messages_Address__Descriptor = Descriptor.MessageTypes[15];
        internal__static_Akka_DistributedData_Messages_Address__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Address, global::Akka.DistributedData.Messages.Address.Builder>(internal__static_Akka_DistributedData_Messages_Address__Descriptor,
                new string[] { "Hostname", "Port", });
        internal__static_Akka_DistributedData_Messages_OtherMessage__Descriptor = Descriptor.MessageTypes[16];
        internal__static_Akka_DistributedData_Messages_OtherMessage__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.OtherMessage, global::Akka.DistributedData.Messages.OtherMessage.Builder>(internal__static_Akka_DistributedData_Messages_OtherMessage__Descriptor,
                new string[] { "EnclosedMessage", "SerializerId", "MessageManifest", });
        internal__static_Akka_DistributedData_Messages_StringGSet__Descriptor = Descriptor.MessageTypes[17];
        internal__static_Akka_DistributedData_Messages_StringGSet__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.StringGSet, global::Akka.DistributedData.Messages.StringGSet.Builder>(internal__static_Akka_DistributedData_Messages_StringGSet__Descriptor,
                new string[] { "Elements", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }

      #endregion
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Get : pb::GeneratedMessage<Get, Get.Builder> {
      public const int KeyFieldNumber = 1;

      public const int ConsistencyFieldNumber = 2;

      public const int TimeoutFieldNumber = 3;

      public const int RequestFieldNumber = 4;
      private static readonly Get defaultInstance = new Get().MakeReadOnly();
      private static readonly string[] _getFieldNames = new string[] { "consistency", "key", "request", "timeout" };
      private static readonly uint[] _getFieldTags = new uint[] { 16, 10, 34, 24 };
      private int consistency_;
      private bool hasConsistency;
      private bool hasKey;
      private bool hasRequest;
      private bool hasTimeout;
      private global::Akka.DistributedData.Messages.OtherMessage key_;

      private int memoizedSerializedSize = -1;
      private global::Akka.DistributedData.Messages.OtherMessage request_;
      private uint timeout_;

      static Get() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private Get() { }

      public static Get DefaultInstance {
      get { return defaultInstance; }
    }

      public override Get DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override Get ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Get__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<Get, Get.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Get__FieldAccessorTable; }
    }

      public bool HasKey {
      get { return hasKey; }
    }

      public global::Akka.DistributedData.Messages.OtherMessage Key {
      get { return key_ ?? global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance; }
    }

      public bool HasConsistency {
      get { return hasConsistency; }
    }

      public int Consistency {
      get { return consistency_; }
    }

      public bool HasTimeout {
      get { return hasTimeout; }
    }

      [global::System.CLSCompliant(false)]
    public uint Timeout {
      get { return timeout_; }
    }

      public bool HasRequest {
      get { return hasRequest; }
    }

      public global::Akka.DistributedData.Messages.OtherMessage Request {
      get { return request_ ?? global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance; }
    }

      public override bool IsInitialized {
      get {
        if (!hasKey) return false;
        if (!hasConsistency) return false;
        if (!hasTimeout) return false;
        if (!Key.IsInitialized) return false;
        if (HasRequest) {
          if (!Request.IsInitialized) return false;
        }
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasKey) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Key);
        }
        if (hasConsistency) {
          size += pb::CodedOutputStream.ComputeSInt32Size(2, Consistency);
        }
        if (hasTimeout) {
          size += pb::CodedOutputStream.ComputeUInt32Size(3, Timeout);
        }
        if (hasRequest) {
          size += pb::CodedOutputStream.ComputeMessageSize(4, Request);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _getFieldNames;
      if (hasKey) {
        output.WriteMessage(1, field_names[1], Key);
      }
      if (hasConsistency) {
        output.WriteSInt32(2, field_names[0], Consistency);
      }
      if (hasTimeout) {
        output.WriteUInt32(3, field_names[3], Timeout);
      }
      if (hasRequest) {
        output.WriteMessage(4, field_names[2], Request);
      }
      UnknownFields.WriteTo(output);
    }

      public static Get ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Get ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Get ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Get ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Get ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Get ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static Get ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static Get ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static Get ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Get ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private Get MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(Get prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<Get, Builder> {
        private Get result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(Get cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override Get MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.Get.Descriptor; }
      }

        public override Get DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.Get.DefaultInstance; }
      }


        public bool HasKey {
       get { return result.hasKey; }
      }

        public global::Akka.DistributedData.Messages.OtherMessage Key {
        get { return result.Key; }
        set { SetKey(value); }
      }

        public bool HasConsistency {
        get { return result.hasConsistency; }
      }

        public int Consistency {
        get { return result.Consistency; }
        set { SetConsistency(value); }
      }

        public bool HasTimeout {
        get { return result.hasTimeout; }
      }

        [global::System.CLSCompliant(false)]
      public uint Timeout {
        get { return result.Timeout; }
        set { SetTimeout(value); }
      }

        public bool HasRequest {
       get { return result.hasRequest; }
      }

        public global::Akka.DistributedData.Messages.OtherMessage Request {
        get { return result.Request; }
        set { SetRequest(value); }
      }

        private Get PrepareBuilder() {
        if (resultIsReadOnly) {
          Get original = result;
          result = new Get();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override Get BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is Get) {
          return MergeFrom((Get) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(Get other) {
        if (other == global::Akka.DistributedData.Messages.Get.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasKey) {
          MergeKey(other.Key);
        }
        if (other.HasConsistency) {
          Consistency = other.Consistency;
        }
        if (other.HasTimeout) {
          Timeout = other.Timeout;
        }
        if (other.HasRequest) {
          MergeRequest(other.Request);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_getFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _getFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              global::Akka.DistributedData.Messages.OtherMessage.Builder subBuilder = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder();
              if (result.hasKey) {
                subBuilder.MergeFrom(Key);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Key = subBuilder.BuildPartial();
              break;
            }
            case 16: {
              result.hasConsistency = input.ReadSInt32(ref result.consistency_);
              break;
            }
            case 24: {
              result.hasTimeout = input.ReadUInt32(ref result.timeout_);
              break;
            }
            case 34: {
              global::Akka.DistributedData.Messages.OtherMessage.Builder subBuilder = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder();
              if (result.hasRequest) {
                subBuilder.MergeFrom(Request);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Request = subBuilder.BuildPartial();
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetKey(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasKey = true;
        result.key_ = value;
        return this;
      }

        public Builder SetKey(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasKey = true;
        result.key_ = builderForValue.Build();
        return this;
      }

        public Builder MergeKey(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasKey &&
            result.key_ != global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance) {
            result.key_ = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder(result.key_).MergeFrom(value).BuildPartial();
        } else {
          result.key_ = value;
        }
        result.hasKey = true;
        return this;
      }

        public Builder ClearKey() {
        PrepareBuilder();
        result.hasKey = false;
        result.key_ = null;
        return this;
      }

        public Builder SetConsistency(int value) {
        PrepareBuilder();
        result.hasConsistency = true;
        result.consistency_ = value;
        return this;
      }

        public Builder ClearConsistency() {
        PrepareBuilder();
        result.hasConsistency = false;
        result.consistency_ = 0;
        return this;
      }

        [global::System.CLSCompliant(false)]
      public Builder SetTimeout(uint value) {
        PrepareBuilder();
        result.hasTimeout = true;
        result.timeout_ = value;
        return this;
      }

        public Builder ClearTimeout() {
        PrepareBuilder();
        result.hasTimeout = false;
        result.timeout_ = 0;
        return this;
      }

        public Builder SetRequest(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasRequest = true;
        result.request_ = value;
        return this;
      }

        public Builder SetRequest(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasRequest = true;
        result.request_ = builderForValue.Build();
        return this;
      }

        public Builder MergeRequest(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasRequest &&
            result.request_ != global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance) {
            result.request_ = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder(result.request_).MergeFrom(value).BuildPartial();
        } else {
          result.request_ = value;
        }
        result.hasRequest = true;
        return this;
      }

        public Builder ClearRequest() {
        PrepareBuilder();
        result.hasRequest = false;
        result.request_ = null;
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetSuccess : pb::GeneratedMessage<GetSuccess, GetSuccess.Builder> {
      public const int KeyFieldNumber = 1;

      public const int DataFieldNumber = 2;

      public const int RequestFieldNumber = 4;
      private static readonly GetSuccess defaultInstance = new GetSuccess().MakeReadOnly();
      private static readonly string[] _getSuccessFieldNames = new string[] { "data", "key", "request" };
      private static readonly uint[] _getSuccessFieldTags = new uint[] { 18, 10, 34 };
      private global::Akka.DistributedData.Messages.OtherMessage data_;
      private bool hasData;
      private bool hasKey;
      private bool hasRequest;
      private global::Akka.DistributedData.Messages.OtherMessage key_;

      private int memoizedSerializedSize = -1;
      private global::Akka.DistributedData.Messages.OtherMessage request_;

      static GetSuccess() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private GetSuccess() { }

      public static GetSuccess DefaultInstance {
      get { return defaultInstance; }
    }

      public override GetSuccess DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override GetSuccess ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_GetSuccess__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<GetSuccess, GetSuccess.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_GetSuccess__FieldAccessorTable; }
    }

      public bool HasKey {
      get { return hasKey; }
    }

      public global::Akka.DistributedData.Messages.OtherMessage Key {
      get { return key_ ?? global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance; }
    }

      public bool HasData {
      get { return hasData; }
    }

      public global::Akka.DistributedData.Messages.OtherMessage Data {
      get { return data_ ?? global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance; }
    }

      public bool HasRequest {
      get { return hasRequest; }
    }

      public global::Akka.DistributedData.Messages.OtherMessage Request {
      get { return request_ ?? global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance; }
    }

      public override bool IsInitialized {
      get {
        if (!hasKey) return false;
        if (!hasData) return false;
        if (!Key.IsInitialized) return false;
        if (!Data.IsInitialized) return false;
        if (HasRequest) {
          if (!Request.IsInitialized) return false;
        }
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasKey) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Key);
        }
        if (hasData) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, Data);
        }
        if (hasRequest) {
          size += pb::CodedOutputStream.ComputeMessageSize(4, Request);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _getSuccessFieldNames;
      if (hasKey) {
        output.WriteMessage(1, field_names[1], Key);
      }
      if (hasData) {
        output.WriteMessage(2, field_names[0], Data);
      }
      if (hasRequest) {
        output.WriteMessage(4, field_names[2], Request);
      }
      UnknownFields.WriteTo(output);
    }

      public static GetSuccess ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static GetSuccess ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static GetSuccess ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static GetSuccess ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static GetSuccess ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static GetSuccess ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static GetSuccess ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static GetSuccess ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static GetSuccess ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static GetSuccess ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private GetSuccess MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(GetSuccess prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<GetSuccess, Builder> {
        private GetSuccess result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(GetSuccess cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override GetSuccess MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.GetSuccess.Descriptor; }
      }

        public override GetSuccess DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.GetSuccess.DefaultInstance; }
      }


        public bool HasKey {
       get { return result.hasKey; }
      }

        public global::Akka.DistributedData.Messages.OtherMessage Key {
        get { return result.Key; }
        set { SetKey(value); }
      }

        public bool HasData {
       get { return result.hasData; }
      }

        public global::Akka.DistributedData.Messages.OtherMessage Data {
        get { return result.Data; }
        set { SetData(value); }
      }

        public bool HasRequest {
       get { return result.hasRequest; }
      }

        public global::Akka.DistributedData.Messages.OtherMessage Request {
        get { return result.Request; }
        set { SetRequest(value); }
      }

        private GetSuccess PrepareBuilder() {
        if (resultIsReadOnly) {
          GetSuccess original = result;
          result = new GetSuccess();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override GetSuccess BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is GetSuccess) {
          return MergeFrom((GetSuccess) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(GetSuccess other) {
        if (other == global::Akka.DistributedData.Messages.GetSuccess.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasKey) {
          MergeKey(other.Key);
        }
        if (other.HasData) {
          MergeData(other.Data);
        }
        if (other.HasRequest) {
          MergeRequest(other.Request);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_getSuccessFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _getSuccessFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              global::Akka.DistributedData.Messages.OtherMessage.Builder subBuilder = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder();
              if (result.hasKey) {
                subBuilder.MergeFrom(Key);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Key = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              global::Akka.DistributedData.Messages.OtherMessage.Builder subBuilder = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder();
              if (result.hasData) {
                subBuilder.MergeFrom(Data);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Data = subBuilder.BuildPartial();
              break;
            }
            case 34: {
              global::Akka.DistributedData.Messages.OtherMessage.Builder subBuilder = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder();
              if (result.hasRequest) {
                subBuilder.MergeFrom(Request);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Request = subBuilder.BuildPartial();
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetKey(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasKey = true;
        result.key_ = value;
        return this;
      }

        public Builder SetKey(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasKey = true;
        result.key_ = builderForValue.Build();
        return this;
      }

        public Builder MergeKey(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasKey &&
            result.key_ != global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance) {
            result.key_ = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder(result.key_).MergeFrom(value).BuildPartial();
        } else {
          result.key_ = value;
        }
        result.hasKey = true;
        return this;
      }

        public Builder ClearKey() {
        PrepareBuilder();
        result.hasKey = false;
        result.key_ = null;
        return this;
      }

        public Builder SetData(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasData = true;
        result.data_ = value;
        return this;
      }

        public Builder SetData(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasData = true;
        result.data_ = builderForValue.Build();
        return this;
      }

        public Builder MergeData(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasData &&
            result.data_ != global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance) {
            result.data_ = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder(result.data_).MergeFrom(value).BuildPartial();
        } else {
          result.data_ = value;
        }
        result.hasData = true;
        return this;
      }

        public Builder ClearData() {
        PrepareBuilder();
        result.hasData = false;
        result.data_ = null;
        return this;
      }

        public Builder SetRequest(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasRequest = true;
        result.request_ = value;
        return this;
      }

        public Builder SetRequest(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasRequest = true;
        result.request_ = builderForValue.Build();
        return this;
      }

        public Builder MergeRequest(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasRequest &&
            result.request_ != global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance) {
            result.request_ = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder(result.request_).MergeFrom(value).BuildPartial();
        } else {
          result.request_ = value;
        }
        result.hasRequest = true;
        return this;
      }

        public Builder ClearRequest() {
        PrepareBuilder();
        result.hasRequest = false;
        result.request_ = null;
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class NotFound : pb::GeneratedMessage<NotFound, NotFound.Builder> {
      public const int KeyFieldNumber = 1;

      public const int RequestFieldNumber = 2;
      private static readonly NotFound defaultInstance = new NotFound().MakeReadOnly();
      private static readonly string[] _notFoundFieldNames = new string[] { "key", "request" };
      private static readonly uint[] _notFoundFieldTags = new uint[] { 10, 18 };
      private bool hasKey;
      private bool hasRequest;
      private global::Akka.DistributedData.Messages.OtherMessage key_;

      private int memoizedSerializedSize = -1;
      private global::Akka.DistributedData.Messages.OtherMessage request_;

      static NotFound() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private NotFound() { }

      public static NotFound DefaultInstance {
      get { return defaultInstance; }
    }

      public override NotFound DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override NotFound ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_NotFound__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<NotFound, NotFound.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_NotFound__FieldAccessorTable; }
    }

      public bool HasKey {
      get { return hasKey; }
    }

      public global::Akka.DistributedData.Messages.OtherMessage Key {
      get { return key_ ?? global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance; }
    }

      public bool HasRequest {
      get { return hasRequest; }
    }

      public global::Akka.DistributedData.Messages.OtherMessage Request {
      get { return request_ ?? global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance; }
    }

      public override bool IsInitialized {
      get {
        if (!hasKey) return false;
        if (!Key.IsInitialized) return false;
        if (HasRequest) {
          if (!Request.IsInitialized) return false;
        }
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasKey) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Key);
        }
        if (hasRequest) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, Request);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _notFoundFieldNames;
      if (hasKey) {
        output.WriteMessage(1, field_names[0], Key);
      }
      if (hasRequest) {
        output.WriteMessage(2, field_names[1], Request);
      }
      UnknownFields.WriteTo(output);
    }

      public static NotFound ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static NotFound ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static NotFound ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static NotFound ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static NotFound ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static NotFound ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static NotFound ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static NotFound ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static NotFound ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static NotFound ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private NotFound MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(NotFound prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<NotFound, Builder> {
        private NotFound result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(NotFound cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override NotFound MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.NotFound.Descriptor; }
      }

        public override NotFound DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.NotFound.DefaultInstance; }
      }


        public bool HasKey {
       get { return result.hasKey; }
      }

        public global::Akka.DistributedData.Messages.OtherMessage Key {
        get { return result.Key; }
        set { SetKey(value); }
      }

        public bool HasRequest {
       get { return result.hasRequest; }
      }

        public global::Akka.DistributedData.Messages.OtherMessage Request {
        get { return result.Request; }
        set { SetRequest(value); }
      }

        private NotFound PrepareBuilder() {
        if (resultIsReadOnly) {
          NotFound original = result;
          result = new NotFound();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override NotFound BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is NotFound) {
          return MergeFrom((NotFound) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(NotFound other) {
        if (other == global::Akka.DistributedData.Messages.NotFound.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasKey) {
          MergeKey(other.Key);
        }
        if (other.HasRequest) {
          MergeRequest(other.Request);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_notFoundFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _notFoundFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              global::Akka.DistributedData.Messages.OtherMessage.Builder subBuilder = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder();
              if (result.hasKey) {
                subBuilder.MergeFrom(Key);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Key = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              global::Akka.DistributedData.Messages.OtherMessage.Builder subBuilder = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder();
              if (result.hasRequest) {
                subBuilder.MergeFrom(Request);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Request = subBuilder.BuildPartial();
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetKey(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasKey = true;
        result.key_ = value;
        return this;
      }

        public Builder SetKey(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasKey = true;
        result.key_ = builderForValue.Build();
        return this;
      }

        public Builder MergeKey(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasKey &&
            result.key_ != global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance) {
            result.key_ = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder(result.key_).MergeFrom(value).BuildPartial();
        } else {
          result.key_ = value;
        }
        result.hasKey = true;
        return this;
      }

        public Builder ClearKey() {
        PrepareBuilder();
        result.hasKey = false;
        result.key_ = null;
        return this;
      }

        public Builder SetRequest(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasRequest = true;
        result.request_ = value;
        return this;
      }

        public Builder SetRequest(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasRequest = true;
        result.request_ = builderForValue.Build();
        return this;
      }

        public Builder MergeRequest(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasRequest &&
            result.request_ != global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance) {
            result.request_ = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder(result.request_).MergeFrom(value).BuildPartial();
        } else {
          result.request_ = value;
        }
        result.hasRequest = true;
        return this;
      }

        public Builder ClearRequest() {
        PrepareBuilder();
        result.hasRequest = false;
        result.request_ = null;
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetFailure : pb::GeneratedMessage<GetFailure, GetFailure.Builder> {
      public const int KeyFieldNumber = 1;

      public const int RequestFieldNumber = 2;
      private static readonly GetFailure defaultInstance = new GetFailure().MakeReadOnly();
      private static readonly string[] _getFailureFieldNames = new string[] { "key", "request" };
      private static readonly uint[] _getFailureFieldTags = new uint[] { 10, 18 };
      private bool hasKey;
      private bool hasRequest;
      private global::Akka.DistributedData.Messages.OtherMessage key_;

      private int memoizedSerializedSize = -1;
      private global::Akka.DistributedData.Messages.OtherMessage request_;

      static GetFailure() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private GetFailure() { }

      public static GetFailure DefaultInstance {
      get { return defaultInstance; }
    }

      public override GetFailure DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override GetFailure ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_GetFailure__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<GetFailure, GetFailure.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_GetFailure__FieldAccessorTable; }
    }

      public bool HasKey {
      get { return hasKey; }
    }

      public global::Akka.DistributedData.Messages.OtherMessage Key {
      get { return key_ ?? global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance; }
    }

      public bool HasRequest {
      get { return hasRequest; }
    }

      public global::Akka.DistributedData.Messages.OtherMessage Request {
      get { return request_ ?? global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance; }
    }

      public override bool IsInitialized {
      get {
        if (!hasKey) return false;
        if (!Key.IsInitialized) return false;
        if (HasRequest) {
          if (!Request.IsInitialized) return false;
        }
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasKey) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Key);
        }
        if (hasRequest) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, Request);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _getFailureFieldNames;
      if (hasKey) {
        output.WriteMessage(1, field_names[0], Key);
      }
      if (hasRequest) {
        output.WriteMessage(2, field_names[1], Request);
      }
      UnknownFields.WriteTo(output);
    }

      public static GetFailure ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static GetFailure ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static GetFailure ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static GetFailure ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static GetFailure ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static GetFailure ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static GetFailure ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static GetFailure ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static GetFailure ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static GetFailure ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private GetFailure MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(GetFailure prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<GetFailure, Builder> {
        private GetFailure result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(GetFailure cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override GetFailure MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.GetFailure.Descriptor; }
      }

        public override GetFailure DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.GetFailure.DefaultInstance; }
      }


        public bool HasKey {
       get { return result.hasKey; }
      }

        public global::Akka.DistributedData.Messages.OtherMessage Key {
        get { return result.Key; }
        set { SetKey(value); }
      }

        public bool HasRequest {
       get { return result.hasRequest; }
      }

        public global::Akka.DistributedData.Messages.OtherMessage Request {
        get { return result.Request; }
        set { SetRequest(value); }
      }

        private GetFailure PrepareBuilder() {
        if (resultIsReadOnly) {
          GetFailure original = result;
          result = new GetFailure();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override GetFailure BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is GetFailure) {
          return MergeFrom((GetFailure) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(GetFailure other) {
        if (other == global::Akka.DistributedData.Messages.GetFailure.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasKey) {
          MergeKey(other.Key);
        }
        if (other.HasRequest) {
          MergeRequest(other.Request);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_getFailureFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _getFailureFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              global::Akka.DistributedData.Messages.OtherMessage.Builder subBuilder = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder();
              if (result.hasKey) {
                subBuilder.MergeFrom(Key);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Key = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              global::Akka.DistributedData.Messages.OtherMessage.Builder subBuilder = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder();
              if (result.hasRequest) {
                subBuilder.MergeFrom(Request);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Request = subBuilder.BuildPartial();
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetKey(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasKey = true;
        result.key_ = value;
        return this;
      }

        public Builder SetKey(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasKey = true;
        result.key_ = builderForValue.Build();
        return this;
      }

        public Builder MergeKey(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasKey &&
            result.key_ != global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance) {
            result.key_ = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder(result.key_).MergeFrom(value).BuildPartial();
        } else {
          result.key_ = value;
        }
        result.hasKey = true;
        return this;
      }

        public Builder ClearKey() {
        PrepareBuilder();
        result.hasKey = false;
        result.key_ = null;
        return this;
      }

        public Builder SetRequest(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasRequest = true;
        result.request_ = value;
        return this;
      }

        public Builder SetRequest(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasRequest = true;
        result.request_ = builderForValue.Build();
        return this;
      }

        public Builder MergeRequest(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasRequest &&
            result.request_ != global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance) {
            result.request_ = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder(result.request_).MergeFrom(value).BuildPartial();
        } else {
          result.request_ = value;
        }
        result.hasRequest = true;
        return this;
      }

        public Builder ClearRequest() {
        PrepareBuilder();
        result.hasRequest = false;
        result.request_ = null;
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Subscribe : pb::GeneratedMessage<Subscribe, Subscribe.Builder> {
      public const int KeyFieldNumber = 1;

      public const int RefFieldNumber = 2;
      private static readonly Subscribe defaultInstance = new Subscribe().MakeReadOnly();
      private static readonly string[] _subscribeFieldNames = new string[] { "key", "ref" };
      private static readonly uint[] _subscribeFieldTags = new uint[] { 10, 18 };
      private bool hasKey;
      private bool hasRef;
      private global::Akka.DistributedData.Messages.OtherMessage key_;

      private int memoizedSerializedSize = -1;
      private string ref_ = "";

      static Subscribe() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private Subscribe() { }

      public static Subscribe DefaultInstance {
      get { return defaultInstance; }
    }

      public override Subscribe DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override Subscribe ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Subscribe__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<Subscribe, Subscribe.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Subscribe__FieldAccessorTable; }
    }

      public bool HasKey {
      get { return hasKey; }
    }

      public global::Akka.DistributedData.Messages.OtherMessage Key {
      get { return key_ ?? global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance; }
    }

      public bool HasRef {
      get { return hasRef; }
    }

      public string Ref {
      get { return ref_; }
    }

      public override bool IsInitialized {
      get {
        if (!hasKey) return false;
        if (!hasRef) return false;
        if (!Key.IsInitialized) return false;
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasKey) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Key);
        }
        if (hasRef) {
          size += pb::CodedOutputStream.ComputeStringSize(2, Ref);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _subscribeFieldNames;
      if (hasKey) {
        output.WriteMessage(1, field_names[0], Key);
      }
      if (hasRef) {
        output.WriteString(2, field_names[1], Ref);
      }
      UnknownFields.WriteTo(output);
    }

      public static Subscribe ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Subscribe ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Subscribe ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Subscribe ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Subscribe ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Subscribe ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static Subscribe ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static Subscribe ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static Subscribe ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Subscribe ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private Subscribe MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(Subscribe prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<Subscribe, Builder> {
        private Subscribe result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(Subscribe cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override Subscribe MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.Subscribe.Descriptor; }
      }

        public override Subscribe DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.Subscribe.DefaultInstance; }
      }


        public bool HasKey {
       get { return result.hasKey; }
      }

        public global::Akka.DistributedData.Messages.OtherMessage Key {
        get { return result.Key; }
        set { SetKey(value); }
      }

        public bool HasRef {
        get { return result.hasRef; }
      }

        public string Ref {
        get { return result.Ref; }
        set { SetRef(value); }
      }

        private Subscribe PrepareBuilder() {
        if (resultIsReadOnly) {
          Subscribe original = result;
          result = new Subscribe();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override Subscribe BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is Subscribe) {
          return MergeFrom((Subscribe) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(Subscribe other) {
        if (other == global::Akka.DistributedData.Messages.Subscribe.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasKey) {
          MergeKey(other.Key);
        }
        if (other.HasRef) {
          Ref = other.Ref;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_subscribeFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _subscribeFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              global::Akka.DistributedData.Messages.OtherMessage.Builder subBuilder = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder();
              if (result.hasKey) {
                subBuilder.MergeFrom(Key);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Key = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              result.hasRef = input.ReadString(ref result.ref_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetKey(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasKey = true;
        result.key_ = value;
        return this;
      }

        public Builder SetKey(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasKey = true;
        result.key_ = builderForValue.Build();
        return this;
      }

        public Builder MergeKey(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasKey &&
            result.key_ != global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance) {
            result.key_ = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder(result.key_).MergeFrom(value).BuildPartial();
        } else {
          result.key_ = value;
        }
        result.hasKey = true;
        return this;
      }

        public Builder ClearKey() {
        PrepareBuilder();
        result.hasKey = false;
        result.key_ = null;
        return this;
      }

        public Builder SetRef(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasRef = true;
        result.ref_ = value;
        return this;
      }

        public Builder ClearRef() {
        PrepareBuilder();
        result.hasRef = false;
        result.ref_ = "";
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Unsubscribe : pb::GeneratedMessage<Unsubscribe, Unsubscribe.Builder> {
      public const int KeyFieldNumber = 1;

      public const int RefFieldNumber = 2;
      private static readonly Unsubscribe defaultInstance = new Unsubscribe().MakeReadOnly();
      private static readonly string[] _unsubscribeFieldNames = new string[] { "key", "ref" };
      private static readonly uint[] _unsubscribeFieldTags = new uint[] { 10, 18 };
      private bool hasKey;
      private bool hasRef;
      private global::Akka.DistributedData.Messages.OtherMessage key_;

      private int memoizedSerializedSize = -1;
      private string ref_ = "";

      static Unsubscribe() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private Unsubscribe() { }

      public static Unsubscribe DefaultInstance {
      get { return defaultInstance; }
    }

      public override Unsubscribe DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override Unsubscribe ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Unsubscribe__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<Unsubscribe, Unsubscribe.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Unsubscribe__FieldAccessorTable; }
    }

      public bool HasKey {
      get { return hasKey; }
    }

      public global::Akka.DistributedData.Messages.OtherMessage Key {
      get { return key_ ?? global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance; }
    }

      public bool HasRef {
      get { return hasRef; }
    }

      public string Ref {
      get { return ref_; }
    }

      public override bool IsInitialized {
      get {
        if (!hasKey) return false;
        if (!hasRef) return false;
        if (!Key.IsInitialized) return false;
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasKey) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Key);
        }
        if (hasRef) {
          size += pb::CodedOutputStream.ComputeStringSize(2, Ref);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _unsubscribeFieldNames;
      if (hasKey) {
        output.WriteMessage(1, field_names[0], Key);
      }
      if (hasRef) {
        output.WriteString(2, field_names[1], Ref);
      }
      UnknownFields.WriteTo(output);
    }

      public static Unsubscribe ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Unsubscribe ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Unsubscribe ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Unsubscribe ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Unsubscribe ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Unsubscribe ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static Unsubscribe ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static Unsubscribe ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static Unsubscribe ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Unsubscribe ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private Unsubscribe MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(Unsubscribe prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<Unsubscribe, Builder> {
        private Unsubscribe result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(Unsubscribe cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override Unsubscribe MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.Unsubscribe.Descriptor; }
      }

        public override Unsubscribe DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.Unsubscribe.DefaultInstance; }
      }


        public bool HasKey {
       get { return result.hasKey; }
      }

        public global::Akka.DistributedData.Messages.OtherMessage Key {
        get { return result.Key; }
        set { SetKey(value); }
      }

        public bool HasRef {
        get { return result.hasRef; }
      }

        public string Ref {
        get { return result.Ref; }
        set { SetRef(value); }
      }

        private Unsubscribe PrepareBuilder() {
        if (resultIsReadOnly) {
          Unsubscribe original = result;
          result = new Unsubscribe();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override Unsubscribe BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is Unsubscribe) {
          return MergeFrom((Unsubscribe) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(Unsubscribe other) {
        if (other == global::Akka.DistributedData.Messages.Unsubscribe.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasKey) {
          MergeKey(other.Key);
        }
        if (other.HasRef) {
          Ref = other.Ref;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_unsubscribeFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _unsubscribeFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              global::Akka.DistributedData.Messages.OtherMessage.Builder subBuilder = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder();
              if (result.hasKey) {
                subBuilder.MergeFrom(Key);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Key = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              result.hasRef = input.ReadString(ref result.ref_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetKey(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasKey = true;
        result.key_ = value;
        return this;
      }

        public Builder SetKey(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasKey = true;
        result.key_ = builderForValue.Build();
        return this;
      }

        public Builder MergeKey(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasKey &&
            result.key_ != global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance) {
            result.key_ = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder(result.key_).MergeFrom(value).BuildPartial();
        } else {
          result.key_ = value;
        }
        result.hasKey = true;
        return this;
      }

        public Builder ClearKey() {
        PrepareBuilder();
        result.hasKey = false;
        result.key_ = null;
        return this;
      }

        public Builder SetRef(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasRef = true;
        result.ref_ = value;
        return this;
      }

        public Builder ClearRef() {
        PrepareBuilder();
        result.hasRef = false;
        result.ref_ = "";
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Changed : pb::GeneratedMessage<Changed, Changed.Builder> {
      public const int KeyFieldNumber = 1;

      public const int DataFieldNumber = 2;
      private static readonly Changed defaultInstance = new Changed().MakeReadOnly();
      private static readonly string[] _changedFieldNames = new string[] { "data", "key" };
      private static readonly uint[] _changedFieldTags = new uint[] { 18, 10 };
      private global::Akka.DistributedData.Messages.OtherMessage data_;
      private bool hasData;
      private bool hasKey;
      private global::Akka.DistributedData.Messages.OtherMessage key_;

      private int memoizedSerializedSize = -1;

      static Changed() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private Changed() { }

      public static Changed DefaultInstance {
      get { return defaultInstance; }
    }

      public override Changed DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override Changed ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Changed__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<Changed, Changed.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Changed__FieldAccessorTable; }
    }

      public bool HasKey {
      get { return hasKey; }
    }

      public global::Akka.DistributedData.Messages.OtherMessage Key {
      get { return key_ ?? global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance; }
    }

      public bool HasData {
      get { return hasData; }
    }

      public global::Akka.DistributedData.Messages.OtherMessage Data {
      get { return data_ ?? global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance; }
    }

      public override bool IsInitialized {
      get {
        if (!hasKey) return false;
        if (!hasData) return false;
        if (!Key.IsInitialized) return false;
        if (!Data.IsInitialized) return false;
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasKey) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Key);
        }
        if (hasData) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, Data);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _changedFieldNames;
      if (hasKey) {
        output.WriteMessage(1, field_names[1], Key);
      }
      if (hasData) {
        output.WriteMessage(2, field_names[0], Data);
      }
      UnknownFields.WriteTo(output);
    }

      public static Changed ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Changed ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Changed ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Changed ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Changed ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Changed ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static Changed ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static Changed ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static Changed ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Changed ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private Changed MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(Changed prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<Changed, Builder> {
        private Changed result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(Changed cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override Changed MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.Changed.Descriptor; }
      }

        public override Changed DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.Changed.DefaultInstance; }
      }


        public bool HasKey {
       get { return result.hasKey; }
      }

        public global::Akka.DistributedData.Messages.OtherMessage Key {
        get { return result.Key; }
        set { SetKey(value); }
      }

        public bool HasData {
       get { return result.hasData; }
      }

        public global::Akka.DistributedData.Messages.OtherMessage Data {
        get { return result.Data; }
        set { SetData(value); }
      }

        private Changed PrepareBuilder() {
        if (resultIsReadOnly) {
          Changed original = result;
          result = new Changed();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override Changed BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is Changed) {
          return MergeFrom((Changed) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(Changed other) {
        if (other == global::Akka.DistributedData.Messages.Changed.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasKey) {
          MergeKey(other.Key);
        }
        if (other.HasData) {
          MergeData(other.Data);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_changedFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _changedFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              global::Akka.DistributedData.Messages.OtherMessage.Builder subBuilder = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder();
              if (result.hasKey) {
                subBuilder.MergeFrom(Key);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Key = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              global::Akka.DistributedData.Messages.OtherMessage.Builder subBuilder = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder();
              if (result.hasData) {
                subBuilder.MergeFrom(Data);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Data = subBuilder.BuildPartial();
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetKey(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasKey = true;
        result.key_ = value;
        return this;
      }

        public Builder SetKey(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasKey = true;
        result.key_ = builderForValue.Build();
        return this;
      }

        public Builder MergeKey(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasKey &&
            result.key_ != global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance) {
            result.key_ = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder(result.key_).MergeFrom(value).BuildPartial();
        } else {
          result.key_ = value;
        }
        result.hasKey = true;
        return this;
      }

        public Builder ClearKey() {
        PrepareBuilder();
        result.hasKey = false;
        result.key_ = null;
        return this;
      }

        public Builder SetData(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasData = true;
        result.data_ = value;
        return this;
      }

        public Builder SetData(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasData = true;
        result.data_ = builderForValue.Build();
        return this;
      }

        public Builder MergeData(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasData &&
            result.data_ != global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance) {
            result.data_ = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder(result.data_).MergeFrom(value).BuildPartial();
        } else {
          result.data_ = value;
        }
        result.hasData = true;
        return this;
      }

        public Builder ClearData() {
        PrepareBuilder();
        result.hasData = false;
        result.data_ = null;
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Write : pb::GeneratedMessage<Write, Write.Builder> {
      public const int KeyFieldNumber = 1;

      public const int EnvelopeFieldNumber = 2;
      private static readonly Write defaultInstance = new Write().MakeReadOnly();
      private static readonly string[] _writeFieldNames = new string[] { "envelope", "key" };
      private static readonly uint[] _writeFieldTags = new uint[] { 18, 10 };
      private global::Akka.DistributedData.Messages.DataEnvelope envelope_;
      private bool hasEnvelope;
      private bool hasKey;
      private string key_ = "";

      private int memoizedSerializedSize = -1;

      static Write() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private Write() { }

      public static Write DefaultInstance {
      get { return defaultInstance; }
    }

      public override Write DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override Write ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Write__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<Write, Write.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Write__FieldAccessorTable; }
    }

      public bool HasKey {
      get { return hasKey; }
    }

      public string Key {
      get { return key_; }
    }

      public bool HasEnvelope {
      get { return hasEnvelope; }
    }

      public global::Akka.DistributedData.Messages.DataEnvelope Envelope {
      get { return envelope_ ?? global::Akka.DistributedData.Messages.DataEnvelope.DefaultInstance; }
    }

      public override bool IsInitialized {
      get {
        if (!hasKey) return false;
        if (!hasEnvelope) return false;
        if (!Envelope.IsInitialized) return false;
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasKey) {
          size += pb::CodedOutputStream.ComputeStringSize(1, Key);
        }
        if (hasEnvelope) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, Envelope);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _writeFieldNames;
      if (hasKey) {
        output.WriteString(1, field_names[1], Key);
      }
      if (hasEnvelope) {
        output.WriteMessage(2, field_names[0], Envelope);
      }
      UnknownFields.WriteTo(output);
    }

      public static Write ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Write ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Write ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Write ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Write ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Write ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static Write ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static Write ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static Write ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Write ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private Write MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(Write prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<Write, Builder> {
        private Write result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(Write cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override Write MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.Write.Descriptor; }
      }

        public override Write DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.Write.DefaultInstance; }
      }


        public bool HasKey {
        get { return result.hasKey; }
      }

        public string Key {
        get { return result.Key; }
        set { SetKey(value); }
      }

        public bool HasEnvelope {
       get { return result.hasEnvelope; }
      }

        public global::Akka.DistributedData.Messages.DataEnvelope Envelope {
        get { return result.Envelope; }
        set { SetEnvelope(value); }
      }

        private Write PrepareBuilder() {
        if (resultIsReadOnly) {
          Write original = result;
          result = new Write();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override Write BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is Write) {
          return MergeFrom((Write) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(Write other) {
        if (other == global::Akka.DistributedData.Messages.Write.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasKey) {
          Key = other.Key;
        }
        if (other.HasEnvelope) {
          MergeEnvelope(other.Envelope);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_writeFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _writeFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              result.hasKey = input.ReadString(ref result.key_);
              break;
            }
            case 18: {
              global::Akka.DistributedData.Messages.DataEnvelope.Builder subBuilder = global::Akka.DistributedData.Messages.DataEnvelope.CreateBuilder();
              if (result.hasEnvelope) {
                subBuilder.MergeFrom(Envelope);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Envelope = subBuilder.BuildPartial();
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetKey(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasKey = true;
        result.key_ = value;
        return this;
      }

        public Builder ClearKey() {
        PrepareBuilder();
        result.hasKey = false;
        result.key_ = "";
        return this;
      }

        public Builder SetEnvelope(global::Akka.DistributedData.Messages.DataEnvelope value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasEnvelope = true;
        result.envelope_ = value;
        return this;
      }

        public Builder SetEnvelope(global::Akka.DistributedData.Messages.DataEnvelope.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasEnvelope = true;
        result.envelope_ = builderForValue.Build();
        return this;
      }

        public Builder MergeEnvelope(global::Akka.DistributedData.Messages.DataEnvelope value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasEnvelope &&
            result.envelope_ != global::Akka.DistributedData.Messages.DataEnvelope.DefaultInstance) {
            result.envelope_ = global::Akka.DistributedData.Messages.DataEnvelope.CreateBuilder(result.envelope_).MergeFrom(value).BuildPartial();
        } else {
          result.envelope_ = value;
        }
        result.hasEnvelope = true;
        return this;
      }

        public Builder ClearEnvelope() {
        PrepareBuilder();
        result.hasEnvelope = false;
        result.envelope_ = null;
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Empty : pb::GeneratedMessage<Empty, Empty.Builder> {
      private static readonly Empty defaultInstance = new Empty().MakeReadOnly();
      private static readonly string[] _emptyFieldNames = new string[] {  };
      private static readonly uint[] _emptyFieldTags = new uint[] {  };

      private int memoizedSerializedSize = -1;

      static Empty() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private Empty() { }

      public static Empty DefaultInstance {
      get { return defaultInstance; }
    }

      public override Empty DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override Empty ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Empty__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<Empty, Empty.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Empty__FieldAccessorTable; }
    }

      public override bool IsInitialized {
      get {
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _emptyFieldNames;
      UnknownFields.WriteTo(output);
    }

      public static Empty ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Empty ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Empty ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Empty ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Empty ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Empty ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static Empty ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static Empty ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static Empty ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Empty ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private Empty MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(Empty prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<Empty, Builder> {
        private Empty result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(Empty cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override Empty MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.Empty.Descriptor; }
      }

        public override Empty DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.Empty.DefaultInstance; }
      }

        private Empty PrepareBuilder() {
        if (resultIsReadOnly) {
          Empty original = result;
          result = new Empty();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override Empty BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is Empty) {
          return MergeFrom((Empty) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(Empty other) {
        if (other == global::Akka.DistributedData.Messages.Empty.DefaultInstance) return this;
        PrepareBuilder();
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_emptyFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _emptyFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Read : pb::GeneratedMessage<Read, Read.Builder> {
      public const int KeyFieldNumber = 1;
      private static readonly Read defaultInstance = new Read().MakeReadOnly();
      private static readonly string[] _readFieldNames = new string[] { "key" };
      private static readonly uint[] _readFieldTags = new uint[] { 10 };
      private bool hasKey;
      private string key_ = "";

      private int memoizedSerializedSize = -1;

      static Read() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private Read() { }

      public static Read DefaultInstance {
      get { return defaultInstance; }
    }

      public override Read DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override Read ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Read__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<Read, Read.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Read__FieldAccessorTable; }
    }

      public bool HasKey {
      get { return hasKey; }
    }

      public string Key {
      get { return key_; }
    }

      public override bool IsInitialized {
      get {
        if (!hasKey) return false;
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasKey) {
          size += pb::CodedOutputStream.ComputeStringSize(1, Key);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _readFieldNames;
      if (hasKey) {
        output.WriteString(1, field_names[0], Key);
      }
      UnknownFields.WriteTo(output);
    }

      public static Read ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Read ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Read ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Read ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Read ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Read ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static Read ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static Read ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static Read ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Read ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private Read MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(Read prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<Read, Builder> {
        private Read result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(Read cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override Read MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.Read.Descriptor; }
      }

        public override Read DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.Read.DefaultInstance; }
      }


        public bool HasKey {
        get { return result.hasKey; }
      }

        public string Key {
        get { return result.Key; }
        set { SetKey(value); }
      }

        private Read PrepareBuilder() {
        if (resultIsReadOnly) {
          Read original = result;
          result = new Read();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override Read BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is Read) {
          return MergeFrom((Read) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(Read other) {
        if (other == global::Akka.DistributedData.Messages.Read.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasKey) {
          Key = other.Key;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_readFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _readFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              result.hasKey = input.ReadString(ref result.key_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetKey(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasKey = true;
        result.key_ = value;
        return this;
      }

        public Builder ClearKey() {
        PrepareBuilder();
        result.hasKey = false;
        result.key_ = "";
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ReadResult : pb::GeneratedMessage<ReadResult, ReadResult.Builder> {
      public const int EnvelopeFieldNumber = 1;
      private static readonly ReadResult defaultInstance = new ReadResult().MakeReadOnly();
      private static readonly string[] _readResultFieldNames = new string[] { "envelope" };
      private static readonly uint[] _readResultFieldTags = new uint[] { 10 };
      private global::Akka.DistributedData.Messages.DataEnvelope envelope_;
      private bool hasEnvelope;

      private int memoizedSerializedSize = -1;

      static ReadResult() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private ReadResult() { }

      public static ReadResult DefaultInstance {
      get { return defaultInstance; }
    }

      public override ReadResult DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override ReadResult ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_ReadResult__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<ReadResult, ReadResult.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_ReadResult__FieldAccessorTable; }
    }

      public bool HasEnvelope {
      get { return hasEnvelope; }
    }

      public global::Akka.DistributedData.Messages.DataEnvelope Envelope {
      get { return envelope_ ?? global::Akka.DistributedData.Messages.DataEnvelope.DefaultInstance; }
    }

      public override bool IsInitialized {
      get {
        if (HasEnvelope) {
          if (!Envelope.IsInitialized) return false;
        }
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasEnvelope) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Envelope);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _readResultFieldNames;
      if (hasEnvelope) {
        output.WriteMessage(1, field_names[0], Envelope);
      }
      UnknownFields.WriteTo(output);
    }

      public static ReadResult ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static ReadResult ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static ReadResult ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static ReadResult ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static ReadResult ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static ReadResult ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static ReadResult ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static ReadResult ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static ReadResult ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static ReadResult ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private ReadResult MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(ReadResult prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<ReadResult, Builder> {
        private ReadResult result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(ReadResult cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override ReadResult MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.ReadResult.Descriptor; }
      }

        public override ReadResult DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.ReadResult.DefaultInstance; }
      }


        public bool HasEnvelope {
       get { return result.hasEnvelope; }
      }

        public global::Akka.DistributedData.Messages.DataEnvelope Envelope {
        get { return result.Envelope; }
        set { SetEnvelope(value); }
      }

        private ReadResult PrepareBuilder() {
        if (resultIsReadOnly) {
          ReadResult original = result;
          result = new ReadResult();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override ReadResult BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is ReadResult) {
          return MergeFrom((ReadResult) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(ReadResult other) {
        if (other == global::Akka.DistributedData.Messages.ReadResult.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasEnvelope) {
          MergeEnvelope(other.Envelope);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_readResultFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _readResultFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              global::Akka.DistributedData.Messages.DataEnvelope.Builder subBuilder = global::Akka.DistributedData.Messages.DataEnvelope.CreateBuilder();
              if (result.hasEnvelope) {
                subBuilder.MergeFrom(Envelope);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Envelope = subBuilder.BuildPartial();
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetEnvelope(global::Akka.DistributedData.Messages.DataEnvelope value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasEnvelope = true;
        result.envelope_ = value;
        return this;
      }

        public Builder SetEnvelope(global::Akka.DistributedData.Messages.DataEnvelope.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasEnvelope = true;
        result.envelope_ = builderForValue.Build();
        return this;
      }

        public Builder MergeEnvelope(global::Akka.DistributedData.Messages.DataEnvelope value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasEnvelope &&
            result.envelope_ != global::Akka.DistributedData.Messages.DataEnvelope.DefaultInstance) {
            result.envelope_ = global::Akka.DistributedData.Messages.DataEnvelope.CreateBuilder(result.envelope_).MergeFrom(value).BuildPartial();
        } else {
          result.envelope_ = value;
        }
        result.hasEnvelope = true;
        return this;
      }

        public Builder ClearEnvelope() {
        PrepareBuilder();
        result.hasEnvelope = false;
        result.envelope_ = null;
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class DataEnvelope : pb::GeneratedMessage<DataEnvelope, DataEnvelope.Builder> {
      public const int DataFieldNumber = 1;

      public const int PruningFieldNumber = 2;
      private static readonly DataEnvelope defaultInstance = new DataEnvelope().MakeReadOnly();
      private static readonly string[] _dataEnvelopeFieldNames = new string[] { "data", "pruning" };
      private static readonly uint[] _dataEnvelopeFieldTags = new uint[] { 10, 18 };
      private global::Akka.DistributedData.Messages.OtherMessage data_;
      private bool hasData;

      private int memoizedSerializedSize = -1;
      private pbc::PopsicleList<global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry> pruning_ = new pbc::PopsicleList<global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry>();

      static DataEnvelope() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private DataEnvelope() { }

      public static DataEnvelope DefaultInstance {
      get { return defaultInstance; }
    }

      public override DataEnvelope DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override DataEnvelope ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_DataEnvelope__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<DataEnvelope, DataEnvelope.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_DataEnvelope__FieldAccessorTable; }
    }

      public bool HasData {
      get { return hasData; }
    }

      public global::Akka.DistributedData.Messages.OtherMessage Data {
      get { return data_ ?? global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance; }
    }

      public scg::IList<global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry> PruningList {
      get { return pruning_; }
    }

      public int PruningCount {
      get { return pruning_.Count; }
    }

      public override bool IsInitialized {
      get {
        if (!hasData) return false;
        if (!Data.IsInitialized) return false;
        foreach (global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry element in PruningList) {
          if (!element.IsInitialized) return false;
        }
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasData) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Data);
        }
        foreach (global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry element in PruningList) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry GetPruning(int index) {
      return pruning_[index];
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _dataEnvelopeFieldNames;
      if (hasData) {
        output.WriteMessage(1, field_names[0], Data);
      }
      if (pruning_.Count > 0) {
        output.WriteMessageArray(2, field_names[1], pruning_);
      }
      UnknownFields.WriteTo(output);
    }

      public static DataEnvelope ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static DataEnvelope ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static DataEnvelope ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static DataEnvelope ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static DataEnvelope ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static DataEnvelope ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static DataEnvelope ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static DataEnvelope ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static DataEnvelope ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static DataEnvelope ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private DataEnvelope MakeReadOnly() {
      pruning_.MakeReadOnly();
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(DataEnvelope prototype) {
      return new Builder(prototype);
    }

      #region Nested types

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class PruningEntry : pb::GeneratedMessage<PruningEntry, PruningEntry.Builder> {
          public const int RemovedAddressFieldNumber = 1;

          public const int OwnerAddressFieldNumber = 2;

          public const int PerformedFieldNumber = 3;

          public const int SeenFieldNumber = 4;
          private static readonly PruningEntry defaultInstance = new PruningEntry().MakeReadOnly();
          private static readonly string[] _pruningEntryFieldNames = new string[] { "ownerAddress", "performed", "removedAddress", "seen" };
          private static readonly uint[] _pruningEntryFieldTags = new uint[] { 18, 24, 10, 34 };
          private bool hasOwnerAddress;
          private bool hasPerformed;
          private bool hasRemovedAddress;

          private int memoizedSerializedSize = -1;
          private global::Akka.DistributedData.Messages.UniqueAddress ownerAddress_;
          private bool performed_;
          private global::Akka.DistributedData.Messages.UniqueAddress removedAddress_;
          private pbc::PopsicleList<global::Akka.DistributedData.Messages.Address> seen_ = new pbc::PopsicleList<global::Akka.DistributedData.Messages.Address>();

          static PruningEntry() {
          object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
        }

          private PruningEntry() { }

          public static PruningEntry DefaultInstance {
          get { return defaultInstance; }
        }

          public override PruningEntry DefaultInstanceForType {
          get { return DefaultInstance; }
        }

          protected override PruningEntry ThisMessage {
          get { return this; }
        }

          public static pbd::MessageDescriptor Descriptor {
          get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_DataEnvelope_PruningEntry__Descriptor; }
        }

          protected override pb::FieldAccess.FieldAccessorTable<PruningEntry, PruningEntry.Builder> InternalFieldAccessors {
          get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_DataEnvelope_PruningEntry__FieldAccessorTable; }
        }

          public bool HasRemovedAddress {
          get { return hasRemovedAddress; }
        }

          public global::Akka.DistributedData.Messages.UniqueAddress RemovedAddress {
          get { return removedAddress_ ?? global::Akka.DistributedData.Messages.UniqueAddress.DefaultInstance; }
        }

          public bool HasOwnerAddress {
          get { return hasOwnerAddress; }
        }

          public global::Akka.DistributedData.Messages.UniqueAddress OwnerAddress {
          get { return ownerAddress_ ?? global::Akka.DistributedData.Messages.UniqueAddress.DefaultInstance; }
        }

          public bool HasPerformed {
          get { return hasPerformed; }
        }

          public bool Performed {
          get { return performed_; }
        }

          public scg::IList<global::Akka.DistributedData.Messages.Address> SeenList {
          get { return seen_; }
        }

          public int SeenCount {
          get { return seen_.Count; }
        }

          public override bool IsInitialized {
          get {
            if (!hasRemovedAddress) return false;
            if (!hasOwnerAddress) return false;
            if (!hasPerformed) return false;
            if (!RemovedAddress.IsInitialized) return false;
            if (!OwnerAddress.IsInitialized) return false;
            foreach (global::Akka.DistributedData.Messages.Address element in SeenList) {
              if (!element.IsInitialized) return false;
            }
            return true;
          }
        }

          public override int SerializedSize {
          get {
            int size = memoizedSerializedSize;
            if (size != -1) return size;
            
            size = 0;
            if (hasRemovedAddress) {
              size += pb::CodedOutputStream.ComputeMessageSize(1, RemovedAddress);
            }
            if (hasOwnerAddress) {
              size += pb::CodedOutputStream.ComputeMessageSize(2, OwnerAddress);
            }
            if (hasPerformed) {
              size += pb::CodedOutputStream.ComputeBoolSize(3, Performed);
            }
            foreach (global::Akka.DistributedData.Messages.Address element in SeenList) {
              size += pb::CodedOutputStream.ComputeMessageSize(4, element);
            }
            size += UnknownFields.SerializedSize;
            memoizedSerializedSize = size;
            return size;
          }
        }

          public global::Akka.DistributedData.Messages.Address GetSeen(int index) {
          return seen_[index];
        }

          public override void WriteTo(pb::ICodedOutputStream output) {
          int size = SerializedSize;
          string[] field_names = _pruningEntryFieldNames;
          if (hasRemovedAddress) {
            output.WriteMessage(1, field_names[2], RemovedAddress);
          }
          if (hasOwnerAddress) {
            output.WriteMessage(2, field_names[0], OwnerAddress);
          }
          if (hasPerformed) {
            output.WriteBool(3, field_names[1], Performed);
          }
          if (seen_.Count > 0) {
            output.WriteMessageArray(4, field_names[3], seen_);
          }
          UnknownFields.WriteTo(output);
        }

          public static PruningEntry ParseFrom(pb::ByteString data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }

          public static PruningEntry ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }

          public static PruningEntry ParseFrom(byte[] data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }

          public static PruningEntry ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }

          public static PruningEntry ParseFrom(global::System.IO.Stream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }

          public static PruningEntry ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }

          public static PruningEntry ParseDelimitedFrom(global::System.IO.Stream input) {
          return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

          public static PruningEntry ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

          public static PruningEntry ParseFrom(pb::ICodedInputStream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }

          public static PruningEntry ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }

          private PruningEntry MakeReadOnly() {
          seen_.MakeReadOnly();
          return this;
        }

          public static Builder CreateBuilder() { return new Builder(); }
          public override Builder ToBuilder() { return CreateBuilder(this); }
          public override Builder CreateBuilderForType() { return new Builder(); }

          public static Builder CreateBuilder(PruningEntry prototype) {
          return new Builder(prototype);
        }

          [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed partial class Builder : pb::GeneratedBuilder<PruningEntry, Builder> {
            private PruningEntry result;

            private bool resultIsReadOnly;

            public Builder() {
            result = DefaultInstance;
            resultIsReadOnly = true;
          }

            internal Builder(PruningEntry cloneFrom) {
            result = cloneFrom;
            resultIsReadOnly = true;
          }

            protected override Builder ThisBuilder {
            get { return this; }
          }

            public override bool IsInitialized {
            get { return result.IsInitialized; }
          }

            protected override PruningEntry MessageBeingBuilt {
            get { return PrepareBuilder(); }
          }

            public override pbd::MessageDescriptor DescriptorForType {
            get { return global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry.Descriptor; }
          }

            public override PruningEntry DefaultInstanceForType {
            get { return global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry.DefaultInstance; }
          }


            public bool HasRemovedAddress {
           get { return result.hasRemovedAddress; }
          }

            public global::Akka.DistributedData.Messages.UniqueAddress RemovedAddress {
            get { return result.RemovedAddress; }
            set { SetRemovedAddress(value); }
          }

            public bool HasOwnerAddress {
           get { return result.hasOwnerAddress; }
          }

            public global::Akka.DistributedData.Messages.UniqueAddress OwnerAddress {
            get { return result.OwnerAddress; }
            set { SetOwnerAddress(value); }
          }

            public bool HasPerformed {
            get { return result.hasPerformed; }
          }

            public bool Performed {
            get { return result.Performed; }
            set { SetPerformed(value); }
          }

            public pbc::IPopsicleList<global::Akka.DistributedData.Messages.Address> SeenList {
            get { return PrepareBuilder().seen_; }
          }

            public int SeenCount {
            get { return result.SeenCount; }
          }

            private PruningEntry PrepareBuilder() {
            if (resultIsReadOnly) {
              PruningEntry original = result;
              result = new PruningEntry();
              resultIsReadOnly = false;
              MergeFrom(original);
            }
            return result;
          }

            public override Builder Clear() {
            result = DefaultInstance;
            resultIsReadOnly = true;
            return this;
          }

            public override Builder Clone() {
            if (resultIsReadOnly) {
              return new Builder(result);
            } else {
              return new Builder().MergeFrom(result);
            }
          }

            public override PruningEntry BuildPartial() {
            if (resultIsReadOnly) {
              return result;
            }
            resultIsReadOnly = true;
            return result.MakeReadOnly();
          }

            public override Builder MergeFrom(pb::IMessage other) {
            if (other is PruningEntry) {
              return MergeFrom((PruningEntry) other);
            } else {
              base.MergeFrom(other);
              return this;
            }
          }

            public override Builder MergeFrom(PruningEntry other) {
            if (other == global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry.DefaultInstance) return this;
            PrepareBuilder();
            if (other.HasRemovedAddress) {
              MergeRemovedAddress(other.RemovedAddress);
            }
            if (other.HasOwnerAddress) {
              MergeOwnerAddress(other.OwnerAddress);
            }
            if (other.HasPerformed) {
              Performed = other.Performed;
            }
            if (other.seen_.Count != 0) {
              result.seen_.Add(other.seen_);
            }
            this.MergeUnknownFields(other.UnknownFields);
            return this;
          }

            public override Builder MergeFrom(pb::ICodedInputStream input) {
            return MergeFrom(input, pb::ExtensionRegistry.Empty);
          }

            public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
            PrepareBuilder();
            pb::UnknownFieldSet.Builder unknownFields = null;
            uint tag;
            string field_name;
            while (input.ReadTag(out tag, out field_name)) {
              if(tag == 0 && field_name != null) {
                int field_ordinal = global::System.Array.BinarySearch(_pruningEntryFieldNames, field_name, global::System.StringComparer.Ordinal);
                if(field_ordinal >= 0)
                  tag = _pruningEntryFieldTags[field_ordinal];
                else {
                  if (unknownFields == null) {
                    unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                  }
                  ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                  continue;
                }
              }
              switch (tag) {
                case 0: {
                  throw pb::InvalidProtocolBufferException.InvalidTag();
                }
                default: {
                  if (pb::WireFormat.IsEndGroupTag(tag)) {
                    if (unknownFields != null) {
                      this.UnknownFields = unknownFields.Build();
                    }
                    return this;
                  }
                  if (unknownFields == null) {
                    unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                  }
                  ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                  break;
                }
                case 10: {
                  global::Akka.DistributedData.Messages.UniqueAddress.Builder subBuilder = global::Akka.DistributedData.Messages.UniqueAddress.CreateBuilder();
                  if (result.hasRemovedAddress) {
                    subBuilder.MergeFrom(RemovedAddress);
                  }
                  input.ReadMessage(subBuilder, extensionRegistry);
                  RemovedAddress = subBuilder.BuildPartial();
                  break;
                }
                case 18: {
                  global::Akka.DistributedData.Messages.UniqueAddress.Builder subBuilder = global::Akka.DistributedData.Messages.UniqueAddress.CreateBuilder();
                  if (result.hasOwnerAddress) {
                    subBuilder.MergeFrom(OwnerAddress);
                  }
                  input.ReadMessage(subBuilder, extensionRegistry);
                  OwnerAddress = subBuilder.BuildPartial();
                  break;
                }
                case 24: {
                  result.hasPerformed = input.ReadBool(ref result.performed_);
                  break;
                }
                case 34: {
                  input.ReadMessageArray(tag, field_name, result.seen_, global::Akka.DistributedData.Messages.Address.DefaultInstance, extensionRegistry);
                  break;
                }
              }
            }
            
            if (unknownFields != null) {
              this.UnknownFields = unknownFields.Build();
            }
            return this;
          }

            public Builder SetRemovedAddress(global::Akka.DistributedData.Messages.UniqueAddress value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.hasRemovedAddress = true;
            result.removedAddress_ = value;
            return this;
          }

            public Builder SetRemovedAddress(global::Akka.DistributedData.Messages.UniqueAddress.Builder builderForValue) {
            pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
            PrepareBuilder();
            result.hasRemovedAddress = true;
            result.removedAddress_ = builderForValue.Build();
            return this;
          }

            public Builder MergeRemovedAddress(global::Akka.DistributedData.Messages.UniqueAddress value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            if (result.hasRemovedAddress &&
                result.removedAddress_ != global::Akka.DistributedData.Messages.UniqueAddress.DefaultInstance) {
                result.removedAddress_ = global::Akka.DistributedData.Messages.UniqueAddress.CreateBuilder(result.removedAddress_).MergeFrom(value).BuildPartial();
            } else {
              result.removedAddress_ = value;
            }
            result.hasRemovedAddress = true;
            return this;
          }

            public Builder ClearRemovedAddress() {
            PrepareBuilder();
            result.hasRemovedAddress = false;
            result.removedAddress_ = null;
            return this;
          }

            public Builder SetOwnerAddress(global::Akka.DistributedData.Messages.UniqueAddress value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.hasOwnerAddress = true;
            result.ownerAddress_ = value;
            return this;
          }

            public Builder SetOwnerAddress(global::Akka.DistributedData.Messages.UniqueAddress.Builder builderForValue) {
            pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
            PrepareBuilder();
            result.hasOwnerAddress = true;
            result.ownerAddress_ = builderForValue.Build();
            return this;
          }

            public Builder MergeOwnerAddress(global::Akka.DistributedData.Messages.UniqueAddress value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            if (result.hasOwnerAddress &&
                result.ownerAddress_ != global::Akka.DistributedData.Messages.UniqueAddress.DefaultInstance) {
                result.ownerAddress_ = global::Akka.DistributedData.Messages.UniqueAddress.CreateBuilder(result.ownerAddress_).MergeFrom(value).BuildPartial();
            } else {
              result.ownerAddress_ = value;
            }
            result.hasOwnerAddress = true;
            return this;
          }

            public Builder ClearOwnerAddress() {
            PrepareBuilder();
            result.hasOwnerAddress = false;
            result.ownerAddress_ = null;
            return this;
          }

            public Builder SetPerformed(bool value) {
            PrepareBuilder();
            result.hasPerformed = true;
            result.performed_ = value;
            return this;
          }

            public Builder ClearPerformed() {
            PrepareBuilder();
            result.hasPerformed = false;
            result.performed_ = false;
            return this;
          }

            public global::Akka.DistributedData.Messages.Address GetSeen(int index) {
            return result.GetSeen(index);
          }

            public Builder SetSeen(int index, global::Akka.DistributedData.Messages.Address value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.seen_[index] = value;
            return this;
          }

            public Builder SetSeen(int index, global::Akka.DistributedData.Messages.Address.Builder builderForValue) {
            pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
            PrepareBuilder();
            result.seen_[index] = builderForValue.Build();
            return this;
          }

            public Builder AddSeen(global::Akka.DistributedData.Messages.Address value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.seen_.Add(value);
            return this;
          }

            public Builder AddSeen(global::Akka.DistributedData.Messages.Address.Builder builderForValue) {
            pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
            PrepareBuilder();
            result.seen_.Add(builderForValue.Build());
            return this;
          }

            public Builder AddRangeSeen(scg::IEnumerable<global::Akka.DistributedData.Messages.Address> values) {
            PrepareBuilder();
            result.seen_.Add(values);
            return this;
          }

            public Builder ClearSeen() {
            PrepareBuilder();
            result.seen_.Clear();
            return this;
          }
        }
      }
    }

      #endregion

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<DataEnvelope, Builder> {
        private DataEnvelope result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(DataEnvelope cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override DataEnvelope MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.DataEnvelope.Descriptor; }
      }

        public override DataEnvelope DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.DataEnvelope.DefaultInstance; }
      }


        public bool HasData {
       get { return result.hasData; }
      }

        public global::Akka.DistributedData.Messages.OtherMessage Data {
        get { return result.Data; }
        set { SetData(value); }
      }

        public pbc::IPopsicleList<global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry> PruningList {
        get { return PrepareBuilder().pruning_; }
      }

        public int PruningCount {
        get { return result.PruningCount; }
      }

        private DataEnvelope PrepareBuilder() {
        if (resultIsReadOnly) {
          DataEnvelope original = result;
          result = new DataEnvelope();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override DataEnvelope BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is DataEnvelope) {
          return MergeFrom((DataEnvelope) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(DataEnvelope other) {
        if (other == global::Akka.DistributedData.Messages.DataEnvelope.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasData) {
          MergeData(other.Data);
        }
        if (other.pruning_.Count != 0) {
          result.pruning_.Add(other.pruning_);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_dataEnvelopeFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _dataEnvelopeFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              global::Akka.DistributedData.Messages.OtherMessage.Builder subBuilder = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder();
              if (result.hasData) {
                subBuilder.MergeFrom(Data);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Data = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              input.ReadMessageArray(tag, field_name, result.pruning_, global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry.DefaultInstance, extensionRegistry);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetData(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasData = true;
        result.data_ = value;
        return this;
      }

        public Builder SetData(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasData = true;
        result.data_ = builderForValue.Build();
        return this;
      }

        public Builder MergeData(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasData &&
            result.data_ != global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance) {
            result.data_ = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder(result.data_).MergeFrom(value).BuildPartial();
        } else {
          result.data_ = value;
        }
        result.hasData = true;
        return this;
      }

        public Builder ClearData() {
        PrepareBuilder();
        result.hasData = false;
        result.data_ = null;
        return this;
      }

        public global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry GetPruning(int index) {
        return result.GetPruning(index);
      }

        public Builder SetPruning(int index, global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.pruning_[index] = value;
        return this;
      }

        public Builder SetPruning(int index, global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.pruning_[index] = builderForValue.Build();
        return this;
      }

        public Builder AddPruning(global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.pruning_.Add(value);
        return this;
      }

        public Builder AddPruning(global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.pruning_.Add(builderForValue.Build());
        return this;
      }

        public Builder AddRangePruning(scg::IEnumerable<global::Akka.DistributedData.Messages.DataEnvelope.Types.PruningEntry> values) {
        PrepareBuilder();
        result.pruning_.Add(values);
        return this;
      }

        public Builder ClearPruning() {
        PrepareBuilder();
        result.pruning_.Clear();
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Status : pb::GeneratedMessage<Status, Status.Builder> {
      public const int ChunkFieldNumber = 1;

      public const int TotChunksFieldNumber = 2;

      public const int EntriesFieldNumber = 3;
      private static readonly Status defaultInstance = new Status().MakeReadOnly();
      private static readonly string[] _statusFieldNames = new string[] { "chunk", "entries", "totChunks" };
      private static readonly uint[] _statusFieldTags = new uint[] { 8, 26, 16 };
      private uint chunk_;
      private pbc::PopsicleList<global::Akka.DistributedData.Messages.Status.Types.Entry> entries_ = new pbc::PopsicleList<global::Akka.DistributedData.Messages.Status.Types.Entry>();
      private bool hasChunk;
      private bool hasTotChunks;

      private int memoizedSerializedSize = -1;
      private uint totChunks_;

      static Status() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private Status() { }

      public static Status DefaultInstance {
      get { return defaultInstance; }
    }

      public override Status DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override Status ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Status__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<Status, Status.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Status__FieldAccessorTable; }
    }

      public bool HasChunk {
      get { return hasChunk; }
    }

      [global::System.CLSCompliant(false)]
    public uint Chunk {
      get { return chunk_; }
    }

      public bool HasTotChunks {
      get { return hasTotChunks; }
    }

      [global::System.CLSCompliant(false)]
    public uint TotChunks {
      get { return totChunks_; }
    }

      public scg::IList<global::Akka.DistributedData.Messages.Status.Types.Entry> EntriesList {
      get { return entries_; }
    }

      public int EntriesCount {
      get { return entries_.Count; }
    }

      public override bool IsInitialized {
      get {
        if (!hasChunk) return false;
        if (!hasTotChunks) return false;
        foreach (global::Akka.DistributedData.Messages.Status.Types.Entry element in EntriesList) {
          if (!element.IsInitialized) return false;
        }
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasChunk) {
          size += pb::CodedOutputStream.ComputeUInt32Size(1, Chunk);
        }
        if (hasTotChunks) {
          size += pb::CodedOutputStream.ComputeUInt32Size(2, TotChunks);
        }
        foreach (global::Akka.DistributedData.Messages.Status.Types.Entry element in EntriesList) {
          size += pb::CodedOutputStream.ComputeMessageSize(3, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public global::Akka.DistributedData.Messages.Status.Types.Entry GetEntries(int index) {
      return entries_[index];
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _statusFieldNames;
      if (hasChunk) {
        output.WriteUInt32(1, field_names[0], Chunk);
      }
      if (hasTotChunks) {
        output.WriteUInt32(2, field_names[2], TotChunks);
      }
      if (entries_.Count > 0) {
        output.WriteMessageArray(3, field_names[1], entries_);
      }
      UnknownFields.WriteTo(output);
    }

      public static Status ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Status ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Status ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Status ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Status ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Status ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static Status ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static Status ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static Status ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Status ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private Status MakeReadOnly() {
      entries_.MakeReadOnly();
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(Status prototype) {
      return new Builder(prototype);
    }

      #region Nested types

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class Entry : pb::GeneratedMessage<Entry, Entry.Builder> {
          public const int KeyFieldNumber = 1;

          public const int DigestFieldNumber = 2;
          private static readonly Entry defaultInstance = new Entry().MakeReadOnly();
          private static readonly string[] _entryFieldNames = new string[] { "digest", "key" };
          private static readonly uint[] _entryFieldTags = new uint[] { 18, 10 };
          private pb::ByteString digest_ = pb::ByteString.Empty;
          private bool hasDigest;
          private bool hasKey;
          private string key_ = "";

          private int memoizedSerializedSize = -1;

          static Entry() {
          object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
        }

          private Entry() { }

          public static Entry DefaultInstance {
          get { return defaultInstance; }
        }

          public override Entry DefaultInstanceForType {
          get { return DefaultInstance; }
        }

          protected override Entry ThisMessage {
          get { return this; }
        }

          public static pbd::MessageDescriptor Descriptor {
          get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Status_Entry__Descriptor; }
        }

          protected override pb::FieldAccess.FieldAccessorTable<Entry, Entry.Builder> InternalFieldAccessors {
          get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Status_Entry__FieldAccessorTable; }
        }

          public bool HasKey {
          get { return hasKey; }
        }

          public string Key {
          get { return key_; }
        }

          public bool HasDigest {
          get { return hasDigest; }
        }

          public pb::ByteString Digest {
          get { return digest_; }
        }

          public override bool IsInitialized {
          get {
            if (!hasKey) return false;
            if (!hasDigest) return false;
            return true;
          }
        }

          public override int SerializedSize {
          get {
            int size = memoizedSerializedSize;
            if (size != -1) return size;
            
            size = 0;
            if (hasKey) {
              size += pb::CodedOutputStream.ComputeStringSize(1, Key);
            }
            if (hasDigest) {
              size += pb::CodedOutputStream.ComputeBytesSize(2, Digest);
            }
            size += UnknownFields.SerializedSize;
            memoizedSerializedSize = size;
            return size;
          }
        }

          public override void WriteTo(pb::ICodedOutputStream output) {
          int size = SerializedSize;
          string[] field_names = _entryFieldNames;
          if (hasKey) {
            output.WriteString(1, field_names[1], Key);
          }
          if (hasDigest) {
            output.WriteBytes(2, field_names[0], Digest);
          }
          UnknownFields.WriteTo(output);
        }

          public static Entry ParseFrom(pb::ByteString data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }

          public static Entry ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }

          public static Entry ParseFrom(byte[] data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }

          public static Entry ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }

          public static Entry ParseFrom(global::System.IO.Stream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }

          public static Entry ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }

          public static Entry ParseDelimitedFrom(global::System.IO.Stream input) {
          return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

          public static Entry ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

          public static Entry ParseFrom(pb::ICodedInputStream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }

          public static Entry ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }

          private Entry MakeReadOnly() {
          return this;
        }

          public static Builder CreateBuilder() { return new Builder(); }
          public override Builder ToBuilder() { return CreateBuilder(this); }
          public override Builder CreateBuilderForType() { return new Builder(); }

          public static Builder CreateBuilder(Entry prototype) {
          return new Builder(prototype);
        }

          [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed partial class Builder : pb::GeneratedBuilder<Entry, Builder> {
            private Entry result;

            private bool resultIsReadOnly;

            public Builder() {
            result = DefaultInstance;
            resultIsReadOnly = true;
          }

            internal Builder(Entry cloneFrom) {
            result = cloneFrom;
            resultIsReadOnly = true;
          }

            protected override Builder ThisBuilder {
            get { return this; }
          }

            public override bool IsInitialized {
            get { return result.IsInitialized; }
          }

            protected override Entry MessageBeingBuilt {
            get { return PrepareBuilder(); }
          }

            public override pbd::MessageDescriptor DescriptorForType {
            get { return global::Akka.DistributedData.Messages.Status.Types.Entry.Descriptor; }
          }

            public override Entry DefaultInstanceForType {
            get { return global::Akka.DistributedData.Messages.Status.Types.Entry.DefaultInstance; }
          }


            public bool HasKey {
            get { return result.hasKey; }
          }

            public string Key {
            get { return result.Key; }
            set { SetKey(value); }
          }

            public bool HasDigest {
            get { return result.hasDigest; }
          }

            public pb::ByteString Digest {
            get { return result.Digest; }
            set { SetDigest(value); }
          }

            private Entry PrepareBuilder() {
            if (resultIsReadOnly) {
              Entry original = result;
              result = new Entry();
              resultIsReadOnly = false;
              MergeFrom(original);
            }
            return result;
          }

            public override Builder Clear() {
            result = DefaultInstance;
            resultIsReadOnly = true;
            return this;
          }

            public override Builder Clone() {
            if (resultIsReadOnly) {
              return new Builder(result);
            } else {
              return new Builder().MergeFrom(result);
            }
          }

            public override Entry BuildPartial() {
            if (resultIsReadOnly) {
              return result;
            }
            resultIsReadOnly = true;
            return result.MakeReadOnly();
          }

            public override Builder MergeFrom(pb::IMessage other) {
            if (other is Entry) {
              return MergeFrom((Entry) other);
            } else {
              base.MergeFrom(other);
              return this;
            }
          }

            public override Builder MergeFrom(Entry other) {
            if (other == global::Akka.DistributedData.Messages.Status.Types.Entry.DefaultInstance) return this;
            PrepareBuilder();
            if (other.HasKey) {
              Key = other.Key;
            }
            if (other.HasDigest) {
              Digest = other.Digest;
            }
            this.MergeUnknownFields(other.UnknownFields);
            return this;
          }

            public override Builder MergeFrom(pb::ICodedInputStream input) {
            return MergeFrom(input, pb::ExtensionRegistry.Empty);
          }

            public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
            PrepareBuilder();
            pb::UnknownFieldSet.Builder unknownFields = null;
            uint tag;
            string field_name;
            while (input.ReadTag(out tag, out field_name)) {
              if(tag == 0 && field_name != null) {
                int field_ordinal = global::System.Array.BinarySearch(_entryFieldNames, field_name, global::System.StringComparer.Ordinal);
                if(field_ordinal >= 0)
                  tag = _entryFieldTags[field_ordinal];
                else {
                  if (unknownFields == null) {
                    unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                  }
                  ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                  continue;
                }
              }
              switch (tag) {
                case 0: {
                  throw pb::InvalidProtocolBufferException.InvalidTag();
                }
                default: {
                  if (pb::WireFormat.IsEndGroupTag(tag)) {
                    if (unknownFields != null) {
                      this.UnknownFields = unknownFields.Build();
                    }
                    return this;
                  }
                  if (unknownFields == null) {
                    unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                  }
                  ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                  break;
                }
                case 10: {
                  result.hasKey = input.ReadString(ref result.key_);
                  break;
                }
                case 18: {
                  result.hasDigest = input.ReadBytes(ref result.digest_);
                  break;
                }
              }
            }
            
            if (unknownFields != null) {
              this.UnknownFields = unknownFields.Build();
            }
            return this;
          }

            public Builder SetKey(string value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.hasKey = true;
            result.key_ = value;
            return this;
          }

            public Builder ClearKey() {
            PrepareBuilder();
            result.hasKey = false;
            result.key_ = "";
            return this;
          }

            public Builder SetDigest(pb::ByteString value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.hasDigest = true;
            result.digest_ = value;
            return this;
          }

            public Builder ClearDigest() {
            PrepareBuilder();
            result.hasDigest = false;
            result.digest_ = pb::ByteString.Empty;
            return this;
          }
        }
      }
    }

      #endregion

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<Status, Builder> {
        private Status result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(Status cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override Status MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.Status.Descriptor; }
      }

        public override Status DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.Status.DefaultInstance; }
      }


        public bool HasChunk {
        get { return result.hasChunk; }
      }

        [global::System.CLSCompliant(false)]
      public uint Chunk {
        get { return result.Chunk; }
        set { SetChunk(value); }
      }

        public bool HasTotChunks {
        get { return result.hasTotChunks; }
      }

        [global::System.CLSCompliant(false)]
      public uint TotChunks {
        get { return result.TotChunks; }
        set { SetTotChunks(value); }
      }

        public pbc::IPopsicleList<global::Akka.DistributedData.Messages.Status.Types.Entry> EntriesList {
        get { return PrepareBuilder().entries_; }
      }

        public int EntriesCount {
        get { return result.EntriesCount; }
      }

        private Status PrepareBuilder() {
        if (resultIsReadOnly) {
          Status original = result;
          result = new Status();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override Status BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is Status) {
          return MergeFrom((Status) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(Status other) {
        if (other == global::Akka.DistributedData.Messages.Status.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasChunk) {
          Chunk = other.Chunk;
        }
        if (other.HasTotChunks) {
          TotChunks = other.TotChunks;
        }
        if (other.entries_.Count != 0) {
          result.entries_.Add(other.entries_);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_statusFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _statusFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 8: {
              result.hasChunk = input.ReadUInt32(ref result.chunk_);
              break;
            }
            case 16: {
              result.hasTotChunks = input.ReadUInt32(ref result.totChunks_);
              break;
            }
            case 26: {
              input.ReadMessageArray(tag, field_name, result.entries_, global::Akka.DistributedData.Messages.Status.Types.Entry.DefaultInstance, extensionRegistry);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        [global::System.CLSCompliant(false)]
      public Builder SetChunk(uint value) {
        PrepareBuilder();
        result.hasChunk = true;
        result.chunk_ = value;
        return this;
      }

        public Builder ClearChunk() {
        PrepareBuilder();
        result.hasChunk = false;
        result.chunk_ = 0;
        return this;
      }

        [global::System.CLSCompliant(false)]
      public Builder SetTotChunks(uint value) {
        PrepareBuilder();
        result.hasTotChunks = true;
        result.totChunks_ = value;
        return this;
      }

        public Builder ClearTotChunks() {
        PrepareBuilder();
        result.hasTotChunks = false;
        result.totChunks_ = 0;
        return this;
      }

        public global::Akka.DistributedData.Messages.Status.Types.Entry GetEntries(int index) {
        return result.GetEntries(index);
      }

        public Builder SetEntries(int index, global::Akka.DistributedData.Messages.Status.Types.Entry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.entries_[index] = value;
        return this;
      }

        public Builder SetEntries(int index, global::Akka.DistributedData.Messages.Status.Types.Entry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.entries_[index] = builderForValue.Build();
        return this;
      }

        public Builder AddEntries(global::Akka.DistributedData.Messages.Status.Types.Entry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.entries_.Add(value);
        return this;
      }

        public Builder AddEntries(global::Akka.DistributedData.Messages.Status.Types.Entry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.entries_.Add(builderForValue.Build());
        return this;
      }

        public Builder AddRangeEntries(scg::IEnumerable<global::Akka.DistributedData.Messages.Status.Types.Entry> values) {
        PrepareBuilder();
        result.entries_.Add(values);
        return this;
      }

        public Builder ClearEntries() {
        PrepareBuilder();
        result.entries_.Clear();
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Gossip : pb::GeneratedMessage<Gossip, Gossip.Builder> {
      public const int SendBackFieldNumber = 1;

      public const int EntriesFieldNumber = 2;
      private static readonly Gossip defaultInstance = new Gossip().MakeReadOnly();
      private static readonly string[] _gossipFieldNames = new string[] { "entries", "sendBack" };
      private static readonly uint[] _gossipFieldTags = new uint[] { 18, 8 };
      private pbc::PopsicleList<global::Akka.DistributedData.Messages.Gossip.Types.Entry> entries_ = new pbc::PopsicleList<global::Akka.DistributedData.Messages.Gossip.Types.Entry>();
      private bool hasSendBack;

      private int memoizedSerializedSize = -1;
      private bool sendBack_;

      static Gossip() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private Gossip() { }

      public static Gossip DefaultInstance {
      get { return defaultInstance; }
    }

      public override Gossip DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override Gossip ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Gossip__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<Gossip, Gossip.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Gossip__FieldAccessorTable; }
    }

      public bool HasSendBack {
      get { return hasSendBack; }
    }

      public bool SendBack {
      get { return sendBack_; }
    }

      public scg::IList<global::Akka.DistributedData.Messages.Gossip.Types.Entry> EntriesList {
      get { return entries_; }
    }

      public int EntriesCount {
      get { return entries_.Count; }
    }

      public override bool IsInitialized {
      get {
        if (!hasSendBack) return false;
        foreach (global::Akka.DistributedData.Messages.Gossip.Types.Entry element in EntriesList) {
          if (!element.IsInitialized) return false;
        }
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasSendBack) {
          size += pb::CodedOutputStream.ComputeBoolSize(1, SendBack);
        }
        foreach (global::Akka.DistributedData.Messages.Gossip.Types.Entry element in EntriesList) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public global::Akka.DistributedData.Messages.Gossip.Types.Entry GetEntries(int index) {
      return entries_[index];
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _gossipFieldNames;
      if (hasSendBack) {
        output.WriteBool(1, field_names[1], SendBack);
      }
      if (entries_.Count > 0) {
        output.WriteMessageArray(2, field_names[0], entries_);
      }
      UnknownFields.WriteTo(output);
    }

      public static Gossip ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Gossip ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Gossip ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Gossip ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Gossip ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Gossip ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static Gossip ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static Gossip ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static Gossip ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Gossip ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private Gossip MakeReadOnly() {
      entries_.MakeReadOnly();
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(Gossip prototype) {
      return new Builder(prototype);
    }

      #region Nested types

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class Entry : pb::GeneratedMessage<Entry, Entry.Builder> {
          public const int KeyFieldNumber = 1;

          public const int EnvelopeFieldNumber = 2;
          private static readonly Entry defaultInstance = new Entry().MakeReadOnly();
          private static readonly string[] _entryFieldNames = new string[] { "envelope", "key" };
          private static readonly uint[] _entryFieldTags = new uint[] { 18, 10 };
          private global::Akka.DistributedData.Messages.DataEnvelope envelope_;
          private bool hasEnvelope;
          private bool hasKey;
          private string key_ = "";

          private int memoizedSerializedSize = -1;

          static Entry() {
          object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
        }

          private Entry() { }

          public static Entry DefaultInstance {
          get { return defaultInstance; }
        }

          public override Entry DefaultInstanceForType {
          get { return DefaultInstance; }
        }

          protected override Entry ThisMessage {
          get { return this; }
        }

          public static pbd::MessageDescriptor Descriptor {
          get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Gossip_Entry__Descriptor; }
        }

          protected override pb::FieldAccess.FieldAccessorTable<Entry, Entry.Builder> InternalFieldAccessors {
          get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Gossip_Entry__FieldAccessorTable; }
        }

          public bool HasKey {
          get { return hasKey; }
        }

          public string Key {
          get { return key_; }
        }

          public bool HasEnvelope {
          get { return hasEnvelope; }
        }

          public global::Akka.DistributedData.Messages.DataEnvelope Envelope {
          get { return envelope_ ?? global::Akka.DistributedData.Messages.DataEnvelope.DefaultInstance; }
        }

          public override bool IsInitialized {
          get {
            if (!hasKey) return false;
            if (!hasEnvelope) return false;
            if (!Envelope.IsInitialized) return false;
            return true;
          }
        }

          public override int SerializedSize {
          get {
            int size = memoizedSerializedSize;
            if (size != -1) return size;
            
            size = 0;
            if (hasKey) {
              size += pb::CodedOutputStream.ComputeStringSize(1, Key);
            }
            if (hasEnvelope) {
              size += pb::CodedOutputStream.ComputeMessageSize(2, Envelope);
            }
            size += UnknownFields.SerializedSize;
            memoizedSerializedSize = size;
            return size;
          }
        }

          public override void WriteTo(pb::ICodedOutputStream output) {
          int size = SerializedSize;
          string[] field_names = _entryFieldNames;
          if (hasKey) {
            output.WriteString(1, field_names[1], Key);
          }
          if (hasEnvelope) {
            output.WriteMessage(2, field_names[0], Envelope);
          }
          UnknownFields.WriteTo(output);
        }

          public static Entry ParseFrom(pb::ByteString data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }

          public static Entry ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }

          public static Entry ParseFrom(byte[] data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }

          public static Entry ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }

          public static Entry ParseFrom(global::System.IO.Stream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }

          public static Entry ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }

          public static Entry ParseDelimitedFrom(global::System.IO.Stream input) {
          return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

          public static Entry ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

          public static Entry ParseFrom(pb::ICodedInputStream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }

          public static Entry ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }

          private Entry MakeReadOnly() {
          return this;
        }

          public static Builder CreateBuilder() { return new Builder(); }
          public override Builder ToBuilder() { return CreateBuilder(this); }
          public override Builder CreateBuilderForType() { return new Builder(); }

          public static Builder CreateBuilder(Entry prototype) {
          return new Builder(prototype);
        }

          [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed partial class Builder : pb::GeneratedBuilder<Entry, Builder> {
            private Entry result;

            private bool resultIsReadOnly;

            public Builder() {
            result = DefaultInstance;
            resultIsReadOnly = true;
          }

            internal Builder(Entry cloneFrom) {
            result = cloneFrom;
            resultIsReadOnly = true;
          }

            protected override Builder ThisBuilder {
            get { return this; }
          }

            public override bool IsInitialized {
            get { return result.IsInitialized; }
          }

            protected override Entry MessageBeingBuilt {
            get { return PrepareBuilder(); }
          }

            public override pbd::MessageDescriptor DescriptorForType {
            get { return global::Akka.DistributedData.Messages.Gossip.Types.Entry.Descriptor; }
          }

            public override Entry DefaultInstanceForType {
            get { return global::Akka.DistributedData.Messages.Gossip.Types.Entry.DefaultInstance; }
          }


            public bool HasKey {
            get { return result.hasKey; }
          }

            public string Key {
            get { return result.Key; }
            set { SetKey(value); }
          }

            public bool HasEnvelope {
           get { return result.hasEnvelope; }
          }

            public global::Akka.DistributedData.Messages.DataEnvelope Envelope {
            get { return result.Envelope; }
            set { SetEnvelope(value); }
          }

            private Entry PrepareBuilder() {
            if (resultIsReadOnly) {
              Entry original = result;
              result = new Entry();
              resultIsReadOnly = false;
              MergeFrom(original);
            }
            return result;
          }

            public override Builder Clear() {
            result = DefaultInstance;
            resultIsReadOnly = true;
            return this;
          }

            public override Builder Clone() {
            if (resultIsReadOnly) {
              return new Builder(result);
            } else {
              return new Builder().MergeFrom(result);
            }
          }

            public override Entry BuildPartial() {
            if (resultIsReadOnly) {
              return result;
            }
            resultIsReadOnly = true;
            return result.MakeReadOnly();
          }

            public override Builder MergeFrom(pb::IMessage other) {
            if (other is Entry) {
              return MergeFrom((Entry) other);
            } else {
              base.MergeFrom(other);
              return this;
            }
          }

            public override Builder MergeFrom(Entry other) {
            if (other == global::Akka.DistributedData.Messages.Gossip.Types.Entry.DefaultInstance) return this;
            PrepareBuilder();
            if (other.HasKey) {
              Key = other.Key;
            }
            if (other.HasEnvelope) {
              MergeEnvelope(other.Envelope);
            }
            this.MergeUnknownFields(other.UnknownFields);
            return this;
          }

            public override Builder MergeFrom(pb::ICodedInputStream input) {
            return MergeFrom(input, pb::ExtensionRegistry.Empty);
          }

            public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
            PrepareBuilder();
            pb::UnknownFieldSet.Builder unknownFields = null;
            uint tag;
            string field_name;
            while (input.ReadTag(out tag, out field_name)) {
              if(tag == 0 && field_name != null) {
                int field_ordinal = global::System.Array.BinarySearch(_entryFieldNames, field_name, global::System.StringComparer.Ordinal);
                if(field_ordinal >= 0)
                  tag = _entryFieldTags[field_ordinal];
                else {
                  if (unknownFields == null) {
                    unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                  }
                  ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                  continue;
                }
              }
              switch (tag) {
                case 0: {
                  throw pb::InvalidProtocolBufferException.InvalidTag();
                }
                default: {
                  if (pb::WireFormat.IsEndGroupTag(tag)) {
                    if (unknownFields != null) {
                      this.UnknownFields = unknownFields.Build();
                    }
                    return this;
                  }
                  if (unknownFields == null) {
                    unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                  }
                  ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                  break;
                }
                case 10: {
                  result.hasKey = input.ReadString(ref result.key_);
                  break;
                }
                case 18: {
                  global::Akka.DistributedData.Messages.DataEnvelope.Builder subBuilder = global::Akka.DistributedData.Messages.DataEnvelope.CreateBuilder();
                  if (result.hasEnvelope) {
                    subBuilder.MergeFrom(Envelope);
                  }
                  input.ReadMessage(subBuilder, extensionRegistry);
                  Envelope = subBuilder.BuildPartial();
                  break;
                }
              }
            }
            
            if (unknownFields != null) {
              this.UnknownFields = unknownFields.Build();
            }
            return this;
          }

            public Builder SetKey(string value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.hasKey = true;
            result.key_ = value;
            return this;
          }

            public Builder ClearKey() {
            PrepareBuilder();
            result.hasKey = false;
            result.key_ = "";
            return this;
          }

            public Builder SetEnvelope(global::Akka.DistributedData.Messages.DataEnvelope value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.hasEnvelope = true;
            result.envelope_ = value;
            return this;
          }

            public Builder SetEnvelope(global::Akka.DistributedData.Messages.DataEnvelope.Builder builderForValue) {
            pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
            PrepareBuilder();
            result.hasEnvelope = true;
            result.envelope_ = builderForValue.Build();
            return this;
          }

            public Builder MergeEnvelope(global::Akka.DistributedData.Messages.DataEnvelope value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            if (result.hasEnvelope &&
                result.envelope_ != global::Akka.DistributedData.Messages.DataEnvelope.DefaultInstance) {
                result.envelope_ = global::Akka.DistributedData.Messages.DataEnvelope.CreateBuilder(result.envelope_).MergeFrom(value).BuildPartial();
            } else {
              result.envelope_ = value;
            }
            result.hasEnvelope = true;
            return this;
          }

            public Builder ClearEnvelope() {
            PrepareBuilder();
            result.hasEnvelope = false;
            result.envelope_ = null;
            return this;
          }
        }
      }
    }

      #endregion

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<Gossip, Builder> {
        private Gossip result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(Gossip cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override Gossip MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.Gossip.Descriptor; }
      }

        public override Gossip DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.Gossip.DefaultInstance; }
      }


        public bool HasSendBack {
        get { return result.hasSendBack; }
      }

        public bool SendBack {
        get { return result.SendBack; }
        set { SetSendBack(value); }
      }

        public pbc::IPopsicleList<global::Akka.DistributedData.Messages.Gossip.Types.Entry> EntriesList {
        get { return PrepareBuilder().entries_; }
      }

        public int EntriesCount {
        get { return result.EntriesCount; }
      }

        private Gossip PrepareBuilder() {
        if (resultIsReadOnly) {
          Gossip original = result;
          result = new Gossip();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override Gossip BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is Gossip) {
          return MergeFrom((Gossip) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(Gossip other) {
        if (other == global::Akka.DistributedData.Messages.Gossip.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasSendBack) {
          SendBack = other.SendBack;
        }
        if (other.entries_.Count != 0) {
          result.entries_.Add(other.entries_);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_gossipFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _gossipFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 8: {
              result.hasSendBack = input.ReadBool(ref result.sendBack_);
              break;
            }
            case 18: {
              input.ReadMessageArray(tag, field_name, result.entries_, global::Akka.DistributedData.Messages.Gossip.Types.Entry.DefaultInstance, extensionRegistry);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetSendBack(bool value) {
        PrepareBuilder();
        result.hasSendBack = true;
        result.sendBack_ = value;
        return this;
      }

        public Builder ClearSendBack() {
        PrepareBuilder();
        result.hasSendBack = false;
        result.sendBack_ = false;
        return this;
      }

        public global::Akka.DistributedData.Messages.Gossip.Types.Entry GetEntries(int index) {
        return result.GetEntries(index);
      }

        public Builder SetEntries(int index, global::Akka.DistributedData.Messages.Gossip.Types.Entry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.entries_[index] = value;
        return this;
      }

        public Builder SetEntries(int index, global::Akka.DistributedData.Messages.Gossip.Types.Entry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.entries_[index] = builderForValue.Build();
        return this;
      }

        public Builder AddEntries(global::Akka.DistributedData.Messages.Gossip.Types.Entry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.entries_.Add(value);
        return this;
      }

        public Builder AddEntries(global::Akka.DistributedData.Messages.Gossip.Types.Entry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.entries_.Add(builderForValue.Build());
        return this;
      }

        public Builder AddRangeEntries(scg::IEnumerable<global::Akka.DistributedData.Messages.Gossip.Types.Entry> values) {
        PrepareBuilder();
        result.entries_.Add(values);
        return this;
      }

        public Builder ClearEntries() {
        PrepareBuilder();
        result.entries_.Clear();
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UniqueAddress : pb::GeneratedMessage<UniqueAddress, UniqueAddress.Builder> {
      public const int AddressFieldNumber = 1;

      public const int UidFieldNumber = 2;
      private static readonly UniqueAddress defaultInstance = new UniqueAddress().MakeReadOnly();
      private static readonly string[] _uniqueAddressFieldNames = new string[] { "address", "uid" };
      private static readonly uint[] _uniqueAddressFieldTags = new uint[] { 10, 21 };
      private global::Akka.DistributedData.Messages.Address address_;
      private bool hasAddress;
      private bool hasUid;

      private int memoizedSerializedSize = -1;
      private int uid_;

      static UniqueAddress() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private UniqueAddress() { }

      public static UniqueAddress DefaultInstance {
      get { return defaultInstance; }
    }

      public override UniqueAddress DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override UniqueAddress ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_UniqueAddress__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<UniqueAddress, UniqueAddress.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_UniqueAddress__FieldAccessorTable; }
    }

      public bool HasAddress {
      get { return hasAddress; }
    }

      public global::Akka.DistributedData.Messages.Address Address {
      get { return address_ ?? global::Akka.DistributedData.Messages.Address.DefaultInstance; }
    }

      public bool HasUid {
      get { return hasUid; }
    }

      public int Uid {
      get { return uid_; }
    }

      public override bool IsInitialized {
      get {
        if (!hasAddress) return false;
        if (!hasUid) return false;
        if (!Address.IsInitialized) return false;
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasAddress) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Address);
        }
        if (hasUid) {
          size += pb::CodedOutputStream.ComputeSFixed32Size(2, Uid);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _uniqueAddressFieldNames;
      if (hasAddress) {
        output.WriteMessage(1, field_names[0], Address);
      }
      if (hasUid) {
        output.WriteSFixed32(2, field_names[1], Uid);
      }
      UnknownFields.WriteTo(output);
    }

      public static UniqueAddress ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static UniqueAddress ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static UniqueAddress ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static UniqueAddress ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static UniqueAddress ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static UniqueAddress ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static UniqueAddress ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static UniqueAddress ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static UniqueAddress ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static UniqueAddress ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private UniqueAddress MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(UniqueAddress prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<UniqueAddress, Builder> {
        private UniqueAddress result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(UniqueAddress cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override UniqueAddress MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.UniqueAddress.Descriptor; }
      }

        public override UniqueAddress DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.UniqueAddress.DefaultInstance; }
      }


        public bool HasAddress {
       get { return result.hasAddress; }
      }

        public global::Akka.DistributedData.Messages.Address Address {
        get { return result.Address; }
        set { SetAddress(value); }
      }

        public bool HasUid {
        get { return result.hasUid; }
      }

        public int Uid {
        get { return result.Uid; }
        set { SetUid(value); }
      }

        private UniqueAddress PrepareBuilder() {
        if (resultIsReadOnly) {
          UniqueAddress original = result;
          result = new UniqueAddress();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override UniqueAddress BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is UniqueAddress) {
          return MergeFrom((UniqueAddress) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(UniqueAddress other) {
        if (other == global::Akka.DistributedData.Messages.UniqueAddress.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasAddress) {
          MergeAddress(other.Address);
        }
        if (other.HasUid) {
          Uid = other.Uid;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_uniqueAddressFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _uniqueAddressFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              global::Akka.DistributedData.Messages.Address.Builder subBuilder = global::Akka.DistributedData.Messages.Address.CreateBuilder();
              if (result.hasAddress) {
                subBuilder.MergeFrom(Address);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Address = subBuilder.BuildPartial();
              break;
            }
            case 21: {
              result.hasUid = input.ReadSFixed32(ref result.uid_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetAddress(global::Akka.DistributedData.Messages.Address value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasAddress = true;
        result.address_ = value;
        return this;
      }

        public Builder SetAddress(global::Akka.DistributedData.Messages.Address.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasAddress = true;
        result.address_ = builderForValue.Build();
        return this;
      }

        public Builder MergeAddress(global::Akka.DistributedData.Messages.Address value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasAddress &&
            result.address_ != global::Akka.DistributedData.Messages.Address.DefaultInstance) {
            result.address_ = global::Akka.DistributedData.Messages.Address.CreateBuilder(result.address_).MergeFrom(value).BuildPartial();
        } else {
          result.address_ = value;
        }
        result.hasAddress = true;
        return this;
      }

        public Builder ClearAddress() {
        PrepareBuilder();
        result.hasAddress = false;
        result.address_ = null;
        return this;
      }

        public Builder SetUid(int value) {
        PrepareBuilder();
        result.hasUid = true;
        result.uid_ = value;
        return this;
      }

        public Builder ClearUid() {
        PrepareBuilder();
        result.hasUid = false;
        result.uid_ = 0;
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Address : pb::GeneratedMessage<Address, Address.Builder> {
      public const int HostnameFieldNumber = 1;

      public const int PortFieldNumber = 2;
      private static readonly Address defaultInstance = new Address().MakeReadOnly();
      private static readonly string[] _addressFieldNames = new string[] { "hostname", "port" };
      private static readonly uint[] _addressFieldTags = new uint[] { 10, 16 };
      private bool hasHostname;
      private bool hasPort;
      private string hostname_ = "";

      private int memoizedSerializedSize = -1;
      private uint port_;

      static Address() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private Address() { }

      public static Address DefaultInstance {
      get { return defaultInstance; }
    }

      public override Address DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override Address ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Address__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<Address, Address.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_Address__FieldAccessorTable; }
    }

      public bool HasHostname {
      get { return hasHostname; }
    }

      public string Hostname {
      get { return hostname_; }
    }

      public bool HasPort {
      get { return hasPort; }
    }

      [global::System.CLSCompliant(false)]
    public uint Port {
      get { return port_; }
    }

      public override bool IsInitialized {
      get {
        if (!hasHostname) return false;
        if (!hasPort) return false;
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasHostname) {
          size += pb::CodedOutputStream.ComputeStringSize(1, Hostname);
        }
        if (hasPort) {
          size += pb::CodedOutputStream.ComputeUInt32Size(2, Port);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _addressFieldNames;
      if (hasHostname) {
        output.WriteString(1, field_names[0], Hostname);
      }
      if (hasPort) {
        output.WriteUInt32(2, field_names[1], Port);
      }
      UnknownFields.WriteTo(output);
    }

      public static Address ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Address ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Address ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Address ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Address ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Address ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static Address ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static Address ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static Address ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Address ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private Address MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(Address prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<Address, Builder> {
        private Address result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(Address cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override Address MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.Address.Descriptor; }
      }

        public override Address DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.Address.DefaultInstance; }
      }


        public bool HasHostname {
        get { return result.hasHostname; }
      }

        public string Hostname {
        get { return result.Hostname; }
        set { SetHostname(value); }
      }

        public bool HasPort {
        get { return result.hasPort; }
      }

        [global::System.CLSCompliant(false)]
      public uint Port {
        get { return result.Port; }
        set { SetPort(value); }
      }

        private Address PrepareBuilder() {
        if (resultIsReadOnly) {
          Address original = result;
          result = new Address();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override Address BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is Address) {
          return MergeFrom((Address) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(Address other) {
        if (other == global::Akka.DistributedData.Messages.Address.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasHostname) {
          Hostname = other.Hostname;
        }
        if (other.HasPort) {
          Port = other.Port;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_addressFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _addressFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              result.hasHostname = input.ReadString(ref result.hostname_);
              break;
            }
            case 16: {
              result.hasPort = input.ReadUInt32(ref result.port_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetHostname(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasHostname = true;
        result.hostname_ = value;
        return this;
      }

        public Builder ClearHostname() {
        PrepareBuilder();
        result.hasHostname = false;
        result.hostname_ = "";
        return this;
      }

        [global::System.CLSCompliant(false)]
      public Builder SetPort(uint value) {
        PrepareBuilder();
        result.hasPort = true;
        result.port_ = value;
        return this;
      }

        public Builder ClearPort() {
        PrepareBuilder();
        result.hasPort = false;
        result.port_ = 0;
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class OtherMessage : pb::GeneratedMessage<OtherMessage, OtherMessage.Builder> {
      public const int EnclosedMessageFieldNumber = 1;

      public const int SerializerIdFieldNumber = 2;

      public const int MessageManifestFieldNumber = 4;
      private static readonly OtherMessage defaultInstance = new OtherMessage().MakeReadOnly();
      private static readonly string[] _otherMessageFieldNames = new string[] { "enclosedMessage", "messageManifest", "serializerId" };
      private static readonly uint[] _otherMessageFieldTags = new uint[] { 10, 34, 16 };
      private pb::ByteString enclosedMessage_ = pb::ByteString.Empty;
      private bool hasEnclosedMessage;
      private bool hasMessageManifest;
      private bool hasSerializerId;

      private int memoizedSerializedSize = -1;
      private pb::ByteString messageManifest_ = pb::ByteString.Empty;
      private int serializerId_;

      static OtherMessage() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private OtherMessage() { }

      public static OtherMessage DefaultInstance {
      get { return defaultInstance; }
    }

      public override OtherMessage DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override OtherMessage ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_OtherMessage__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<OtherMessage, OtherMessage.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_OtherMessage__FieldAccessorTable; }
    }

      public bool HasEnclosedMessage {
      get { return hasEnclosedMessage; }
    }

      public pb::ByteString EnclosedMessage {
      get { return enclosedMessage_; }
    }

      public bool HasSerializerId {
      get { return hasSerializerId; }
    }

      public int SerializerId {
      get { return serializerId_; }
    }

      public bool HasMessageManifest {
      get { return hasMessageManifest; }
    }

      public pb::ByteString MessageManifest {
      get { return messageManifest_; }
    }

      public override bool IsInitialized {
      get {
        if (!hasEnclosedMessage) return false;
        if (!hasSerializerId) return false;
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasEnclosedMessage) {
          size += pb::CodedOutputStream.ComputeBytesSize(1, EnclosedMessage);
        }
        if (hasSerializerId) {
          size += pb::CodedOutputStream.ComputeInt32Size(2, SerializerId);
        }
        if (hasMessageManifest) {
          size += pb::CodedOutputStream.ComputeBytesSize(4, MessageManifest);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _otherMessageFieldNames;
      if (hasEnclosedMessage) {
        output.WriteBytes(1, field_names[0], EnclosedMessage);
      }
      if (hasSerializerId) {
        output.WriteInt32(2, field_names[2], SerializerId);
      }
      if (hasMessageManifest) {
        output.WriteBytes(4, field_names[1], MessageManifest);
      }
      UnknownFields.WriteTo(output);
    }

      public static OtherMessage ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static OtherMessage ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static OtherMessage ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static OtherMessage ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static OtherMessage ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static OtherMessage ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static OtherMessage ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static OtherMessage ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static OtherMessage ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static OtherMessage ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private OtherMessage MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(OtherMessage prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<OtherMessage, Builder> {
        private OtherMessage result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(OtherMessage cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override OtherMessage MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.OtherMessage.Descriptor; }
      }

        public override OtherMessage DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance; }
      }


        public bool HasEnclosedMessage {
        get { return result.hasEnclosedMessage; }
      }

        public pb::ByteString EnclosedMessage {
        get { return result.EnclosedMessage; }
        set { SetEnclosedMessage(value); }
      }

        public bool HasSerializerId {
        get { return result.hasSerializerId; }
      }

        public int SerializerId {
        get { return result.SerializerId; }
        set { SetSerializerId(value); }
      }

        public bool HasMessageManifest {
        get { return result.hasMessageManifest; }
      }

        public pb::ByteString MessageManifest {
        get { return result.MessageManifest; }
        set { SetMessageManifest(value); }
      }

        private OtherMessage PrepareBuilder() {
        if (resultIsReadOnly) {
          OtherMessage original = result;
          result = new OtherMessage();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override OtherMessage BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is OtherMessage) {
          return MergeFrom((OtherMessage) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(OtherMessage other) {
        if (other == global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasEnclosedMessage) {
          EnclosedMessage = other.EnclosedMessage;
        }
        if (other.HasSerializerId) {
          SerializerId = other.SerializerId;
        }
        if (other.HasMessageManifest) {
          MessageManifest = other.MessageManifest;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_otherMessageFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _otherMessageFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              result.hasEnclosedMessage = input.ReadBytes(ref result.enclosedMessage_);
              break;
            }
            case 16: {
              result.hasSerializerId = input.ReadInt32(ref result.serializerId_);
              break;
            }
            case 34: {
              result.hasMessageManifest = input.ReadBytes(ref result.messageManifest_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetEnclosedMessage(pb::ByteString value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasEnclosedMessage = true;
        result.enclosedMessage_ = value;
        return this;
      }

        public Builder ClearEnclosedMessage() {
        PrepareBuilder();
        result.hasEnclosedMessage = false;
        result.enclosedMessage_ = pb::ByteString.Empty;
        return this;
      }

        public Builder SetSerializerId(int value) {
        PrepareBuilder();
        result.hasSerializerId = true;
        result.serializerId_ = value;
        return this;
      }

        public Builder ClearSerializerId() {
        PrepareBuilder();
        result.hasSerializerId = false;
        result.serializerId_ = 0;
        return this;
      }

        public Builder SetMessageManifest(pb::ByteString value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasMessageManifest = true;
        result.messageManifest_ = value;
        return this;
      }

        public Builder ClearMessageManifest() {
        PrepareBuilder();
        result.hasMessageManifest = false;
        result.messageManifest_ = pb::ByteString.Empty;
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class StringGSet : pb::GeneratedMessage<StringGSet, StringGSet.Builder> {
      public const int ElementsFieldNumber = 1;
      private static readonly StringGSet defaultInstance = new StringGSet().MakeReadOnly();
      private static readonly string[] _stringGSetFieldNames = new string[] { "elements" };
      private static readonly uint[] _stringGSetFieldTags = new uint[] { 10 };
      private pbc::PopsicleList<string> elements_ = new pbc::PopsicleList<string>();

      private int memoizedSerializedSize = -1;

      static StringGSet() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, null);
    }

      private StringGSet() { }

      public static StringGSet DefaultInstance {
      get { return defaultInstance; }
    }

      public override StringGSet DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override StringGSet ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_StringGSet__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<StringGSet, StringGSet.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatorMessages.internal__static_Akka_DistributedData_Messages_StringGSet__FieldAccessorTable; }
    }

      public scg::IList<string> ElementsList {
      get { return pbc::Lists.AsReadOnly(elements_); }
    }

      public int ElementsCount {
      get { return elements_.Count; }
    }

      public override bool IsInitialized {
      get {
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        {
          int dataSize = 0;
          foreach (string element in ElementsList) {
            dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(element);
          }
          size += dataSize;
          size += 1 * elements_.Count;
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public string GetElements(int index) {
      return elements_[index];
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _stringGSetFieldNames;
      if (elements_.Count > 0) {
        output.WriteStringArray(1, field_names[0], elements_);
      }
      UnknownFields.WriteTo(output);
    }

      public static StringGSet ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static StringGSet ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static StringGSet ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static StringGSet ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static StringGSet ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static StringGSet ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static StringGSet ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static StringGSet ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static StringGSet ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static StringGSet ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private StringGSet MakeReadOnly() {
      elements_.MakeReadOnly();
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(StringGSet prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<StringGSet, Builder> {
        private StringGSet result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(StringGSet cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override StringGSet MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.StringGSet.Descriptor; }
      }

        public override StringGSet DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.StringGSet.DefaultInstance; }
      }


        public pbc::IPopsicleList<string> ElementsList {
        get { return PrepareBuilder().elements_; }
      }

        public int ElementsCount {
        get { return result.ElementsCount; }
      }

        private StringGSet PrepareBuilder() {
        if (resultIsReadOnly) {
          StringGSet original = result;
          result = new StringGSet();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

        public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

        public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

        public override StringGSet BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is StringGSet) {
          return MergeFrom((StringGSet) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(StringGSet other) {
        if (other == global::Akka.DistributedData.Messages.StringGSet.DefaultInstance) return this;
        PrepareBuilder();
        if (other.elements_.Count != 0) {
          result.elements_.Add(other.elements_);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

        public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_stringGSetFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _stringGSetFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              input.ReadStringArray(tag, field_name, result.elements_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public string GetElements(int index) {
        return result.GetElements(index);
      }

        public Builder SetElements(int index, string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.elements_[index] = value;
        return this;
      }

        public Builder AddElements(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.elements_.Add(value);
        return this;
      }

        public Builder AddRangeElements(scg::IEnumerable<string> values) {
        PrepareBuilder();
        result.elements_.Add(values);
        return this;
      }

        public Builder ClearElements() {
        PrepareBuilder();
        result.elements_.Clear();
        return this;
      }
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
