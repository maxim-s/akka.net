#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Akka.DistributedData.Messages {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ReplicatedDataMessages {
      #region Extension registration

      public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }

      #endregion

      #region Static variables

      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_GSet__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.GSet, global::Akka.DistributedData.Messages.GSet.Builder> internal__static_Akka_DistributedData_Messages_GSet__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_ORSet__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.ORSet, global::Akka.DistributedData.Messages.ORSet.Builder> internal__static_Akka_DistributedData_Messages_ORSet__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_Flag__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Flag, global::Akka.DistributedData.Messages.Flag.Builder> internal__static_Akka_DistributedData_Messages_Flag__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_LWWRegister__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.LWWRegister, global::Akka.DistributedData.Messages.LWWRegister.Builder> internal__static_Akka_DistributedData_Messages_LWWRegister__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_GCounter__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.GCounter, global::Akka.DistributedData.Messages.GCounter.Builder> internal__static_Akka_DistributedData_Messages_GCounter__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_GCounter_Entry__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.GCounter.Types.Entry, global::Akka.DistributedData.Messages.GCounter.Types.Entry.Builder> internal__static_Akka_DistributedData_Messages_GCounter_Entry__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_PNCounter__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.PNCounter, global::Akka.DistributedData.Messages.PNCounter.Builder> internal__static_Akka_DistributedData_Messages_PNCounter__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_VersionVector__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.VersionVector, global::Akka.DistributedData.Messages.VersionVector.Builder> internal__static_Akka_DistributedData_Messages_VersionVector__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_VersionVector_Entry__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.VersionVector.Types.Entry, global::Akka.DistributedData.Messages.VersionVector.Types.Entry.Builder> internal__static_Akka_DistributedData_Messages_VersionVector_Entry__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_ORMap__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.ORMap, global::Akka.DistributedData.Messages.ORMap.Builder> internal__static_Akka_DistributedData_Messages_ORMap__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_ORMap_Entry__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.ORMap.Types.Entry, global::Akka.DistributedData.Messages.ORMap.Types.Entry.Builder> internal__static_Akka_DistributedData_Messages_ORMap_Entry__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_LWWMap__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.LWWMap, global::Akka.DistributedData.Messages.LWWMap.Builder> internal__static_Akka_DistributedData_Messages_LWWMap__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_LWWMap_Entry__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.LWWMap.Types.Entry, global::Akka.DistributedData.Messages.LWWMap.Types.Entry.Builder> internal__static_Akka_DistributedData_Messages_LWWMap_Entry__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_PNCounterMap__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.PNCounterMap, global::Akka.DistributedData.Messages.PNCounterMap.Builder> internal__static_Akka_DistributedData_Messages_PNCounterMap__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_PNCounterMap_Entry__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry, global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry.Builder> internal__static_Akka_DistributedData_Messages_PNCounterMap_Entry__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_ORMultiMap__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.ORMultiMap, global::Akka.DistributedData.Messages.ORMultiMap.Builder> internal__static_Akka_DistributedData_Messages_ORMultiMap__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_ORMultiMap_Entry__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry, global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry.Builder> internal__static_Akka_DistributedData_Messages_ORMultiMap_Entry__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_Akka_DistributedData_Messages_GenericKey__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.GenericKey, global::Akka.DistributedData.Messages.GenericKey.Builder> internal__static_Akka_DistributedData_Messages_GenericKey__FieldAccessorTable;

      #endregion

      #region Descriptor

      public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }

      private static pbd::FileDescriptor descriptor;

      static ReplicatedDataMessages() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "ChxSZXBsaWNhdGVkRGF0YU1lc3NhZ2VzLnByb3RvEh1Ba2thLkRpc3RyaWJ1" + 
          "dGVkRGF0YS5NZXNzYWdlcxoYUmVwbGljYXRvck1lc3NhZ2VzLnByb3RvIq0B" + 
          "CgRHU2V0EhYKDnR5cGVEZXNjcmlwdG9yGAEgAigFEhYKDnN0cmluZ0VsZW1l" + 
          "bnRzGAIgAygJEhcKC2ludEVsZW1lbnRzGAMgAygRQgIQARIYCgxsb25nRWxl" + 
          "bWVudHMYBCADKBJCAhABEkIKDW90aGVyRWxlbWVudHMYBSADKAsyKy5Ba2th" + 
          "LkRpc3RyaWJ1dGVkRGF0YS5NZXNzYWdlcy5PdGhlck1lc3NhZ2UikQIKBU9S" + 
          "U2V0Ej0KB3Z2ZWN0b3IYASACKAsyLC5Ba2thLkRpc3RyaWJ1dGVkRGF0YS5N" + 
          "ZXNzYWdlcy5WZXJzaW9uVmVjdG9yEjoKBGRvdHMYAiADKAsyLC5Ba2thLkRp" + 
          "c3RyaWJ1dGVkRGF0YS5NZXNzYWdlcy5WZXJzaW9uVmVjdG9yEhYKDnN0cmlu" + 
          "Z0VsZW1lbnRzGAMgAygJEhcKC2ludEVsZW1lbnRzGAQgAygRQgIQARIYCgxs" + 
          "b25nRWxlbWVudHMYBSADKBJCAhABEkIKDW90aGVyRWxlbWVudHMYBiADKAsy" + 
          "Ky5Ba2thLkRpc3RyaWJ1dGVkRGF0YS5NZXNzYWdlcy5PdGhlck1lc3NhZ2Ui" + 
          "FwoERmxhZxIPCgdlbmFibGVkGAEgAigIIpgBCgtMV1dSZWdpc3RlchIRCgl0" + 
          "aW1lc3RhbXAYASACKBISOgoEbm9kZRgCIAIoCzIsLkFra2EuRGlzdHJpYnV0" + 
          "ZWREYXRhLk1lc3NhZ2VzLlVuaXF1ZUFkZHJlc3MSOgoFc3RhdGUYAyACKAsy" + 
          "Ky5Ba2thLkRpc3RyaWJ1dGVkRGF0YS5NZXNzYWdlcy5PdGhlck1lc3NhZ2Ui" + 
          "ngEKCEdDb3VudGVyEj4KB2VudHJpZXMYASADKAsyLS5Ba2thLkRpc3RyaWJ1" + 
          "dGVkRGF0YS5NZXNzYWdlcy5HQ291bnRlci5FbnRyeRpSCgVFbnRyeRI6CgRu" + 
          "b2RlGAEgAigLMiwuQWtrYS5EaXN0cmlidXRlZERhdGEuTWVzc2FnZXMuVW5p" + 
          "cXVlQWRkcmVzcxINCgV2YWx1ZRgCIAIoDCKFAQoJUE5Db3VudGVyEjsKCmlu" + 
          "Y3JlbWVudHMYASACKAsyJy5Ba2thLkRpc3RyaWJ1dGVkRGF0YS5NZXNzYWdl" + 
          "cy5HQ291bnRlchI7CgpkZWNyZW1lbnRzGAIgAigLMicuQWtrYS5EaXN0cmli" + 
          "dXRlZERhdGEuTWVzc2FnZXMuR0NvdW50ZXIiqgEKDVZlcnNpb25WZWN0b3IS" + 
          "QwoHZW50cmllcxgBIAMoCzIyLkFra2EuRGlzdHJpYnV0ZWREYXRhLk1lc3Nh" + 
          "Z2VzLlZlcnNpb25WZWN0b3IuRW50cnkaVAoFRW50cnkSOgoEbm9kZRgBIAIo" + 
          "CzIsLkFra2EuRGlzdHJpYnV0ZWREYXRhLk1lc3NhZ2VzLlVuaXF1ZUFkZHJl" + 
          "c3MSDwoHdmVyc2lvbhgCIAIoAyLKAQoFT1JNYXASMgoEa2V5cxgBIAIoCzIk" + 
          "LkFra2EuRGlzdHJpYnV0ZWREYXRhLk1lc3NhZ2VzLk9SU2V0EjsKB2VudHJp" + 
          "ZXMYAiADKAsyKi5Ba2thLkRpc3RyaWJ1dGVkRGF0YS5NZXNzYWdlcy5PUk1h" + 
          "cC5FbnRyeRpQCgVFbnRyeRILCgNrZXkYASACKAkSOgoFdmFsdWUYAiACKAsy" + 
          "Ky5Ba2thLkRpc3RyaWJ1dGVkRGF0YS5NZXNzYWdlcy5PdGhlck1lc3NhZ2Ui" + 
          "ywEKBkxXV01hcBIyCgRrZXlzGAEgAigLMiQuQWtrYS5EaXN0cmlidXRlZERh" + 
          "dGEuTWVzc2FnZXMuT1JTZXQSPAoHZW50cmllcxgCIAMoCzIrLkFra2EuRGlz" + 
          "dHJpYnV0ZWREYXRhLk1lc3NhZ2VzLkxXV01hcC5FbnRyeRpPCgVFbnRyeRIL" + 
          "CgNrZXkYASACKAkSOQoFdmFsdWUYAiACKAsyKi5Ba2thLkRpc3RyaWJ1dGVk" + 
          "RGF0YS5NZXNzYWdlcy5MV1dSZWdpc3RlciLVAQoMUE5Db3VudGVyTWFwEjIK" + 
          "BGtleXMYASACKAsyJC5Ba2thLkRpc3RyaWJ1dGVkRGF0YS5NZXNzYWdlcy5P" + 
          "UlNldBJCCgdlbnRyaWVzGAIgAygLMjEuQWtrYS5EaXN0cmlidXRlZERhdGEu" + 
          "TWVzc2FnZXMuUE5Db3VudGVyTWFwLkVudHJ5Gk0KBUVudHJ5EgsKA2tleRgB" + 
          "IAIoCRI3CgV2YWx1ZRgCIAIoCzIoLkFra2EuRGlzdHJpYnV0ZWREYXRhLk1l" + 
          "c3NhZ2VzLlBOQ291bnRlciLNAQoKT1JNdWx0aU1hcBIyCgRrZXlzGAEgAigL" + 
          "MiQuQWtrYS5EaXN0cmlidXRlZERhdGEuTWVzc2FnZXMuT1JTZXQSQAoHZW50" + 
          "cmllcxgCIAMoCzIvLkFra2EuRGlzdHJpYnV0ZWREYXRhLk1lc3NhZ2VzLk9S" + 
          "TXVsdGlNYXAuRW50cnkaSQoFRW50cnkSCwoDa2V5GAEgAigJEjMKBXZhbHVl" + 
          "GAIgAigLMiQuQWtrYS5EaXN0cmlidXRlZERhdGEuTWVzc2FnZXMuT1JTZXQi" + 
          "KgoKR2VuZXJpY0tleRIKCgJpZBgBIAIoDBIQCgh0eXBlaGludBgCIAIoDEIj" + 
          "Ch9ha2thLmNsdXN0ZXIuZGRhdGEucHJvdG9idWYubXNnSAE=");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_Akka_DistributedData_Messages_GSet__Descriptor = Descriptor.MessageTypes[0];
        internal__static_Akka_DistributedData_Messages_GSet__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.GSet, global::Akka.DistributedData.Messages.GSet.Builder>(internal__static_Akka_DistributedData_Messages_GSet__Descriptor,
                new string[] { "TypeDescriptor", "StringElements", "IntElements", "LongElements", "OtherElements", });
        internal__static_Akka_DistributedData_Messages_ORSet__Descriptor = Descriptor.MessageTypes[1];
        internal__static_Akka_DistributedData_Messages_ORSet__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.ORSet, global::Akka.DistributedData.Messages.ORSet.Builder>(internal__static_Akka_DistributedData_Messages_ORSet__Descriptor,
                new string[] { "Vvector", "Dots", "StringElements", "IntElements", "LongElements", "OtherElements", });
        internal__static_Akka_DistributedData_Messages_Flag__Descriptor = Descriptor.MessageTypes[2];
        internal__static_Akka_DistributedData_Messages_Flag__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.Flag, global::Akka.DistributedData.Messages.Flag.Builder>(internal__static_Akka_DistributedData_Messages_Flag__Descriptor,
                new string[] { "Enabled", });
        internal__static_Akka_DistributedData_Messages_LWWRegister__Descriptor = Descriptor.MessageTypes[3];
        internal__static_Akka_DistributedData_Messages_LWWRegister__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.LWWRegister, global::Akka.DistributedData.Messages.LWWRegister.Builder>(internal__static_Akka_DistributedData_Messages_LWWRegister__Descriptor,
                new string[] { "Timestamp", "Node", "State", });
        internal__static_Akka_DistributedData_Messages_GCounter__Descriptor = Descriptor.MessageTypes[4];
        internal__static_Akka_DistributedData_Messages_GCounter__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.GCounter, global::Akka.DistributedData.Messages.GCounter.Builder>(internal__static_Akka_DistributedData_Messages_GCounter__Descriptor,
                new string[] { "Entries", });
        internal__static_Akka_DistributedData_Messages_GCounter_Entry__Descriptor = internal__static_Akka_DistributedData_Messages_GCounter__Descriptor.NestedTypes[0];
        internal__static_Akka_DistributedData_Messages_GCounter_Entry__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.GCounter.Types.Entry, global::Akka.DistributedData.Messages.GCounter.Types.Entry.Builder>(internal__static_Akka_DistributedData_Messages_GCounter_Entry__Descriptor,
                new string[] { "Node", "Value", });
        internal__static_Akka_DistributedData_Messages_PNCounter__Descriptor = Descriptor.MessageTypes[5];
        internal__static_Akka_DistributedData_Messages_PNCounter__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.PNCounter, global::Akka.DistributedData.Messages.PNCounter.Builder>(internal__static_Akka_DistributedData_Messages_PNCounter__Descriptor,
                new string[] { "Increments", "Decrements", });
        internal__static_Akka_DistributedData_Messages_VersionVector__Descriptor = Descriptor.MessageTypes[6];
        internal__static_Akka_DistributedData_Messages_VersionVector__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.VersionVector, global::Akka.DistributedData.Messages.VersionVector.Builder>(internal__static_Akka_DistributedData_Messages_VersionVector__Descriptor,
                new string[] { "Entries", });
        internal__static_Akka_DistributedData_Messages_VersionVector_Entry__Descriptor = internal__static_Akka_DistributedData_Messages_VersionVector__Descriptor.NestedTypes[0];
        internal__static_Akka_DistributedData_Messages_VersionVector_Entry__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.VersionVector.Types.Entry, global::Akka.DistributedData.Messages.VersionVector.Types.Entry.Builder>(internal__static_Akka_DistributedData_Messages_VersionVector_Entry__Descriptor,
                new string[] { "Node", "Version", });
        internal__static_Akka_DistributedData_Messages_ORMap__Descriptor = Descriptor.MessageTypes[7];
        internal__static_Akka_DistributedData_Messages_ORMap__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.ORMap, global::Akka.DistributedData.Messages.ORMap.Builder>(internal__static_Akka_DistributedData_Messages_ORMap__Descriptor,
                new string[] { "Keys", "Entries", });
        internal__static_Akka_DistributedData_Messages_ORMap_Entry__Descriptor = internal__static_Akka_DistributedData_Messages_ORMap__Descriptor.NestedTypes[0];
        internal__static_Akka_DistributedData_Messages_ORMap_Entry__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.ORMap.Types.Entry, global::Akka.DistributedData.Messages.ORMap.Types.Entry.Builder>(internal__static_Akka_DistributedData_Messages_ORMap_Entry__Descriptor,
                new string[] { "Key", "Value", });
        internal__static_Akka_DistributedData_Messages_LWWMap__Descriptor = Descriptor.MessageTypes[8];
        internal__static_Akka_DistributedData_Messages_LWWMap__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.LWWMap, global::Akka.DistributedData.Messages.LWWMap.Builder>(internal__static_Akka_DistributedData_Messages_LWWMap__Descriptor,
                new string[] { "Keys", "Entries", });
        internal__static_Akka_DistributedData_Messages_LWWMap_Entry__Descriptor = internal__static_Akka_DistributedData_Messages_LWWMap__Descriptor.NestedTypes[0];
        internal__static_Akka_DistributedData_Messages_LWWMap_Entry__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.LWWMap.Types.Entry, global::Akka.DistributedData.Messages.LWWMap.Types.Entry.Builder>(internal__static_Akka_DistributedData_Messages_LWWMap_Entry__Descriptor,
                new string[] { "Key", "Value", });
        internal__static_Akka_DistributedData_Messages_PNCounterMap__Descriptor = Descriptor.MessageTypes[9];
        internal__static_Akka_DistributedData_Messages_PNCounterMap__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.PNCounterMap, global::Akka.DistributedData.Messages.PNCounterMap.Builder>(internal__static_Akka_DistributedData_Messages_PNCounterMap__Descriptor,
                new string[] { "Keys", "Entries", });
        internal__static_Akka_DistributedData_Messages_PNCounterMap_Entry__Descriptor = internal__static_Akka_DistributedData_Messages_PNCounterMap__Descriptor.NestedTypes[0];
        internal__static_Akka_DistributedData_Messages_PNCounterMap_Entry__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry, global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry.Builder>(internal__static_Akka_DistributedData_Messages_PNCounterMap_Entry__Descriptor,
                new string[] { "Key", "Value", });
        internal__static_Akka_DistributedData_Messages_ORMultiMap__Descriptor = Descriptor.MessageTypes[10];
        internal__static_Akka_DistributedData_Messages_ORMultiMap__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.ORMultiMap, global::Akka.DistributedData.Messages.ORMultiMap.Builder>(internal__static_Akka_DistributedData_Messages_ORMultiMap__Descriptor,
                new string[] { "Keys", "Entries", });
        internal__static_Akka_DistributedData_Messages_ORMultiMap_Entry__Descriptor = internal__static_Akka_DistributedData_Messages_ORMultiMap__Descriptor.NestedTypes[0];
        internal__static_Akka_DistributedData_Messages_ORMultiMap_Entry__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry, global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry.Builder>(internal__static_Akka_DistributedData_Messages_ORMultiMap_Entry__Descriptor,
                new string[] { "Key", "Value", });
        internal__static_Akka_DistributedData_Messages_GenericKey__Descriptor = Descriptor.MessageTypes[11];
        internal__static_Akka_DistributedData_Messages_GenericKey__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Akka.DistributedData.Messages.GenericKey, global::Akka.DistributedData.Messages.GenericKey.Builder>(internal__static_Akka_DistributedData_Messages_GenericKey__Descriptor,
                new string[] { "Id", "Typehint", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::Akka.DistributedData.Messages.ReplicatorMessages.Descriptor, 
          }, assigner);
    }

      #endregion
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GSet : pb::GeneratedMessage<GSet, GSet.Builder> {
      public const int TypeDescriptorFieldNumber = 1;

      public const int StringElementsFieldNumber = 2;

      public const int IntElementsFieldNumber = 3;

      public const int LongElementsFieldNumber = 4;

      public const int OtherElementsFieldNumber = 5;
      private static readonly GSet defaultInstance = new GSet().MakeReadOnly();
      private static readonly string[] _gSetFieldNames = new string[] { "intElements", "longElements", "otherElements", "stringElements", "typeDescriptor" };
      private static readonly uint[] _gSetFieldTags = new uint[] { 26, 34, 42, 18, 8 };
      private bool hasTypeDescriptor;
      private pbc::PopsicleList<int> intElements_ = new pbc::PopsicleList<int>();
      private int intElementsMemoizedSerializedSize;
      private pbc::PopsicleList<long> longElements_ = new pbc::PopsicleList<long>();
      private int longElementsMemoizedSerializedSize;

      private int memoizedSerializedSize = -1;
      private pbc::PopsicleList<global::Akka.DistributedData.Messages.OtherMessage> otherElements_ = new pbc::PopsicleList<global::Akka.DistributedData.Messages.OtherMessage>();
      private pbc::PopsicleList<string> stringElements_ = new pbc::PopsicleList<string>();
      private int typeDescriptor_;

      static GSet() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
    }

      private GSet() { }

      public static GSet DefaultInstance {
      get { return defaultInstance; }
    }

      public override GSet DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override GSet ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_GSet__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<GSet, GSet.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_GSet__FieldAccessorTable; }
    }

      public bool HasTypeDescriptor {
      get { return hasTypeDescriptor; }
    }

      public int TypeDescriptor {
      get { return typeDescriptor_; }
    }

      public scg::IList<string> StringElementsList {
      get { return pbc::Lists.AsReadOnly(stringElements_); }
    }

      public int StringElementsCount {
      get { return stringElements_.Count; }
    }

      public scg::IList<int> IntElementsList {
      get { return pbc::Lists.AsReadOnly(intElements_); }
    }

      public int IntElementsCount {
      get { return intElements_.Count; }
    }

      public scg::IList<long> LongElementsList {
      get { return pbc::Lists.AsReadOnly(longElements_); }
    }

      public int LongElementsCount {
      get { return longElements_.Count; }
    }

      public scg::IList<global::Akka.DistributedData.Messages.OtherMessage> OtherElementsList {
      get { return otherElements_; }
    }

      public int OtherElementsCount {
      get { return otherElements_.Count; }
    }

      public override bool IsInitialized {
      get {
        if (!hasTypeDescriptor) return false;
        foreach (global::Akka.DistributedData.Messages.OtherMessage element in OtherElementsList) {
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
        if (hasTypeDescriptor) {
          size += pb::CodedOutputStream.ComputeInt32Size(1, TypeDescriptor);
        }
        {
          int dataSize = 0;
          foreach (string element in StringElementsList) {
            dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(element);
          }
          size += dataSize;
          size += 1 * stringElements_.Count;
        }
        {
          int dataSize = 0;
          foreach (int element in IntElementsList) {
            dataSize += pb::CodedOutputStream.ComputeSInt32SizeNoTag(element);
          }
          size += dataSize;
          if (intElements_.Count != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32SizeNoTag(dataSize);
          }
          intElementsMemoizedSerializedSize = dataSize;
        }
        {
          int dataSize = 0;
          foreach (long element in LongElementsList) {
            dataSize += pb::CodedOutputStream.ComputeSInt64SizeNoTag(element);
          }
          size += dataSize;
          if (longElements_.Count != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32SizeNoTag(dataSize);
          }
          longElementsMemoizedSerializedSize = dataSize;
        }
        foreach (global::Akka.DistributedData.Messages.OtherMessage element in OtherElementsList) {
          size += pb::CodedOutputStream.ComputeMessageSize(5, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public string GetStringElements(int index) {
      return stringElements_[index];
    }

      public int GetIntElements(int index) {
      return intElements_[index];
    }

      public long GetLongElements(int index) {
      return longElements_[index];
    }

      public global::Akka.DistributedData.Messages.OtherMessage GetOtherElements(int index) {
      return otherElements_[index];
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _gSetFieldNames;
      if (hasTypeDescriptor) {
        output.WriteInt32(1, field_names[4], TypeDescriptor);
      }
      if (stringElements_.Count > 0) {
        output.WriteStringArray(2, field_names[3], stringElements_);
      }
      if (intElements_.Count > 0) {
        output.WritePackedSInt32Array(3, field_names[0], intElementsMemoizedSerializedSize, intElements_);
      }
      if (longElements_.Count > 0) {
        output.WritePackedSInt64Array(4, field_names[1], longElementsMemoizedSerializedSize, longElements_);
      }
      if (otherElements_.Count > 0) {
        output.WriteMessageArray(5, field_names[2], otherElements_);
      }
      UnknownFields.WriteTo(output);
    }

      public static GSet ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static GSet ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static GSet ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static GSet ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static GSet ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static GSet ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static GSet ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static GSet ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static GSet ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static GSet ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private GSet MakeReadOnly() {
      stringElements_.MakeReadOnly();
      intElements_.MakeReadOnly();
      longElements_.MakeReadOnly();
      otherElements_.MakeReadOnly();
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(GSet prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<GSet, Builder> {
        private GSet result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(GSet cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override GSet MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.GSet.Descriptor; }
      }

        public override GSet DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.GSet.DefaultInstance; }
      }


        public bool HasTypeDescriptor {
        get { return result.hasTypeDescriptor; }
      }

        public int TypeDescriptor {
        get { return result.TypeDescriptor; }
        set { SetTypeDescriptor(value); }
      }

        public pbc::IPopsicleList<string> StringElementsList {
        get { return PrepareBuilder().stringElements_; }
      }

        public int StringElementsCount {
        get { return result.StringElementsCount; }
      }

        public pbc::IPopsicleList<int> IntElementsList {
        get { return PrepareBuilder().intElements_; }
      }

        public int IntElementsCount {
        get { return result.IntElementsCount; }
      }

        public pbc::IPopsicleList<long> LongElementsList {
        get { return PrepareBuilder().longElements_; }
      }

        public int LongElementsCount {
        get { return result.LongElementsCount; }
      }

        public pbc::IPopsicleList<global::Akka.DistributedData.Messages.OtherMessage> OtherElementsList {
        get { return PrepareBuilder().otherElements_; }
      }

        public int OtherElementsCount {
        get { return result.OtherElementsCount; }
      }

        private GSet PrepareBuilder() {
        if (resultIsReadOnly) {
          GSet original = result;
          result = new GSet();
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

        public override GSet BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is GSet) {
          return MergeFrom((GSet) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(GSet other) {
        if (other == global::Akka.DistributedData.Messages.GSet.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasTypeDescriptor) {
          TypeDescriptor = other.TypeDescriptor;
        }
        if (other.stringElements_.Count != 0) {
          result.stringElements_.Add(other.stringElements_);
        }
        if (other.intElements_.Count != 0) {
          result.intElements_.Add(other.intElements_);
        }
        if (other.longElements_.Count != 0) {
          result.longElements_.Add(other.longElements_);
        }
        if (other.otherElements_.Count != 0) {
          result.otherElements_.Add(other.otherElements_);
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
            int field_ordinal = global::System.Array.BinarySearch(_gSetFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _gSetFieldTags[field_ordinal];
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
              result.hasTypeDescriptor = input.ReadInt32(ref result.typeDescriptor_);
              break;
            }
            case 18: {
              input.ReadStringArray(tag, field_name, result.stringElements_);
              break;
            }
            case 26:
            case 24: {
              input.ReadSInt32Array(tag, field_name, result.intElements_);
              break;
            }
            case 34:
            case 32: {
              input.ReadSInt64Array(tag, field_name, result.longElements_);
              break;
            }
            case 42: {
              input.ReadMessageArray(tag, field_name, result.otherElements_, global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance, extensionRegistry);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetTypeDescriptor(int value) {
        PrepareBuilder();
        result.hasTypeDescriptor = true;
        result.typeDescriptor_ = value;
        return this;
      }

        public Builder ClearTypeDescriptor() {
        PrepareBuilder();
        result.hasTypeDescriptor = false;
        result.typeDescriptor_ = 0;
        return this;
      }

        public string GetStringElements(int index) {
        return result.GetStringElements(index);
      }

        public Builder SetStringElements(int index, string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.stringElements_[index] = value;
        return this;
      }

        public Builder AddStringElements(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.stringElements_.Add(value);
        return this;
      }

        public Builder AddRangeStringElements(scg::IEnumerable<string> values) {
        PrepareBuilder();
        result.stringElements_.Add(values);
        return this;
      }

        public Builder ClearStringElements() {
        PrepareBuilder();
        result.stringElements_.Clear();
        return this;
      }

        public int GetIntElements(int index) {
        return result.GetIntElements(index);
      }

        public Builder SetIntElements(int index, int value) {
        PrepareBuilder();
        result.intElements_[index] = value;
        return this;
      }

        public Builder AddIntElements(int value) {
        PrepareBuilder();
        result.intElements_.Add(value);
        return this;
      }

        public Builder AddRangeIntElements(scg::IEnumerable<int> values) {
        PrepareBuilder();
        result.intElements_.Add(values);
        return this;
      }

        public Builder ClearIntElements() {
        PrepareBuilder();
        result.intElements_.Clear();
        return this;
      }

        public long GetLongElements(int index) {
        return result.GetLongElements(index);
      }

        public Builder SetLongElements(int index, long value) {
        PrepareBuilder();
        result.longElements_[index] = value;
        return this;
      }

        public Builder AddLongElements(long value) {
        PrepareBuilder();
        result.longElements_.Add(value);
        return this;
      }

        public Builder AddRangeLongElements(scg::IEnumerable<long> values) {
        PrepareBuilder();
        result.longElements_.Add(values);
        return this;
      }

        public Builder ClearLongElements() {
        PrepareBuilder();
        result.longElements_.Clear();
        return this;
      }

        public global::Akka.DistributedData.Messages.OtherMessage GetOtherElements(int index) {
        return result.GetOtherElements(index);
      }

        public Builder SetOtherElements(int index, global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.otherElements_[index] = value;
        return this;
      }

        public Builder SetOtherElements(int index, global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.otherElements_[index] = builderForValue.Build();
        return this;
      }

        public Builder AddOtherElements(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.otherElements_.Add(value);
        return this;
      }

        public Builder AddOtherElements(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.otherElements_.Add(builderForValue.Build());
        return this;
      }

        public Builder AddRangeOtherElements(scg::IEnumerable<global::Akka.DistributedData.Messages.OtherMessage> values) {
        PrepareBuilder();
        result.otherElements_.Add(values);
        return this;
      }

        public Builder ClearOtherElements() {
        PrepareBuilder();
        result.otherElements_.Clear();
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ORSet : pb::GeneratedMessage<ORSet, ORSet.Builder> {
      public const int VvectorFieldNumber = 1;

      public const int DotsFieldNumber = 2;

      public const int StringElementsFieldNumber = 3;

      public const int IntElementsFieldNumber = 4;

      public const int LongElementsFieldNumber = 5;

      public const int OtherElementsFieldNumber = 6;
      private static readonly ORSet defaultInstance = new ORSet().MakeReadOnly();
      private static readonly string[] _oRSetFieldNames = new string[] { "dots", "intElements", "longElements", "otherElements", "stringElements", "vvector" };
      private static readonly uint[] _oRSetFieldTags = new uint[] { 18, 34, 42, 50, 26, 10 };
      private pbc::PopsicleList<global::Akka.DistributedData.Messages.VersionVector> dots_ = new pbc::PopsicleList<global::Akka.DistributedData.Messages.VersionVector>();
      private bool hasVvector;
      private pbc::PopsicleList<int> intElements_ = new pbc::PopsicleList<int>();
      private int intElementsMemoizedSerializedSize;
      private pbc::PopsicleList<long> longElements_ = new pbc::PopsicleList<long>();
      private int longElementsMemoizedSerializedSize;

      private int memoizedSerializedSize = -1;
      private pbc::PopsicleList<global::Akka.DistributedData.Messages.OtherMessage> otherElements_ = new pbc::PopsicleList<global::Akka.DistributedData.Messages.OtherMessage>();
      private pbc::PopsicleList<string> stringElements_ = new pbc::PopsicleList<string>();
      private global::Akka.DistributedData.Messages.VersionVector vvector_;

      static ORSet() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
    }

      private ORSet() { }

      public static ORSet DefaultInstance {
      get { return defaultInstance; }
    }

      public override ORSet DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override ORSet ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_ORSet__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<ORSet, ORSet.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_ORSet__FieldAccessorTable; }
    }

      public bool HasVvector {
      get { return hasVvector; }
    }

      public global::Akka.DistributedData.Messages.VersionVector Vvector {
      get { return vvector_ ?? global::Akka.DistributedData.Messages.VersionVector.DefaultInstance; }
    }

      public scg::IList<global::Akka.DistributedData.Messages.VersionVector> DotsList {
      get { return dots_; }
    }

      public int DotsCount {
      get { return dots_.Count; }
    }

      public scg::IList<string> StringElementsList {
      get { return pbc::Lists.AsReadOnly(stringElements_); }
    }

      public int StringElementsCount {
      get { return stringElements_.Count; }
    }

      public scg::IList<int> IntElementsList {
      get { return pbc::Lists.AsReadOnly(intElements_); }
    }

      public int IntElementsCount {
      get { return intElements_.Count; }
    }

      public scg::IList<long> LongElementsList {
      get { return pbc::Lists.AsReadOnly(longElements_); }
    }

      public int LongElementsCount {
      get { return longElements_.Count; }
    }

      public scg::IList<global::Akka.DistributedData.Messages.OtherMessage> OtherElementsList {
      get { return otherElements_; }
    }

      public int OtherElementsCount {
      get { return otherElements_.Count; }
    }

      public override bool IsInitialized {
      get {
        if (!hasVvector) return false;
        if (!Vvector.IsInitialized) return false;
        foreach (global::Akka.DistributedData.Messages.VersionVector element in DotsList) {
          if (!element.IsInitialized) return false;
        }
        foreach (global::Akka.DistributedData.Messages.OtherMessage element in OtherElementsList) {
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
        if (hasVvector) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Vvector);
        }
        foreach (global::Akka.DistributedData.Messages.VersionVector element in DotsList) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, element);
        }
        {
          int dataSize = 0;
          foreach (string element in StringElementsList) {
            dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(element);
          }
          size += dataSize;
          size += 1 * stringElements_.Count;
        }
        {
          int dataSize = 0;
          foreach (int element in IntElementsList) {
            dataSize += pb::CodedOutputStream.ComputeSInt32SizeNoTag(element);
          }
          size += dataSize;
          if (intElements_.Count != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32SizeNoTag(dataSize);
          }
          intElementsMemoizedSerializedSize = dataSize;
        }
        {
          int dataSize = 0;
          foreach (long element in LongElementsList) {
            dataSize += pb::CodedOutputStream.ComputeSInt64SizeNoTag(element);
          }
          size += dataSize;
          if (longElements_.Count != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32SizeNoTag(dataSize);
          }
          longElementsMemoizedSerializedSize = dataSize;
        }
        foreach (global::Akka.DistributedData.Messages.OtherMessage element in OtherElementsList) {
          size += pb::CodedOutputStream.ComputeMessageSize(6, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public global::Akka.DistributedData.Messages.VersionVector GetDots(int index) {
      return dots_[index];
    }

      public string GetStringElements(int index) {
      return stringElements_[index];
    }

      public int GetIntElements(int index) {
      return intElements_[index];
    }

      public long GetLongElements(int index) {
      return longElements_[index];
    }

      public global::Akka.DistributedData.Messages.OtherMessage GetOtherElements(int index) {
      return otherElements_[index];
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _oRSetFieldNames;
      if (hasVvector) {
        output.WriteMessage(1, field_names[5], Vvector);
      }
      if (dots_.Count > 0) {
        output.WriteMessageArray(2, field_names[0], dots_);
      }
      if (stringElements_.Count > 0) {
        output.WriteStringArray(3, field_names[4], stringElements_);
      }
      if (intElements_.Count > 0) {
        output.WritePackedSInt32Array(4, field_names[1], intElementsMemoizedSerializedSize, intElements_);
      }
      if (longElements_.Count > 0) {
        output.WritePackedSInt64Array(5, field_names[2], longElementsMemoizedSerializedSize, longElements_);
      }
      if (otherElements_.Count > 0) {
        output.WriteMessageArray(6, field_names[3], otherElements_);
      }
      UnknownFields.WriteTo(output);
    }

      public static ORSet ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static ORSet ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static ORSet ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static ORSet ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static ORSet ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static ORSet ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static ORSet ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static ORSet ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static ORSet ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static ORSet ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private ORSet MakeReadOnly() {
      dots_.MakeReadOnly();
      stringElements_.MakeReadOnly();
      intElements_.MakeReadOnly();
      longElements_.MakeReadOnly();
      otherElements_.MakeReadOnly();
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(ORSet prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<ORSet, Builder> {
        private ORSet result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(ORSet cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override ORSet MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.ORSet.Descriptor; }
      }

        public override ORSet DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.ORSet.DefaultInstance; }
      }


        public bool HasVvector {
       get { return result.hasVvector; }
      }

        public global::Akka.DistributedData.Messages.VersionVector Vvector {
        get { return result.Vvector; }
        set { SetVvector(value); }
      }

        public pbc::IPopsicleList<global::Akka.DistributedData.Messages.VersionVector> DotsList {
        get { return PrepareBuilder().dots_; }
      }

        public int DotsCount {
        get { return result.DotsCount; }
      }

        public pbc::IPopsicleList<string> StringElementsList {
        get { return PrepareBuilder().stringElements_; }
      }

        public int StringElementsCount {
        get { return result.StringElementsCount; }
      }

        public pbc::IPopsicleList<int> IntElementsList {
        get { return PrepareBuilder().intElements_; }
      }

        public int IntElementsCount {
        get { return result.IntElementsCount; }
      }

        public pbc::IPopsicleList<long> LongElementsList {
        get { return PrepareBuilder().longElements_; }
      }

        public int LongElementsCount {
        get { return result.LongElementsCount; }
      }

        public pbc::IPopsicleList<global::Akka.DistributedData.Messages.OtherMessage> OtherElementsList {
        get { return PrepareBuilder().otherElements_; }
      }

        public int OtherElementsCount {
        get { return result.OtherElementsCount; }
      }

        private ORSet PrepareBuilder() {
        if (resultIsReadOnly) {
          ORSet original = result;
          result = new ORSet();
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

        public override ORSet BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is ORSet) {
          return MergeFrom((ORSet) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(ORSet other) {
        if (other == global::Akka.DistributedData.Messages.ORSet.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasVvector) {
          MergeVvector(other.Vvector);
        }
        if (other.dots_.Count != 0) {
          result.dots_.Add(other.dots_);
        }
        if (other.stringElements_.Count != 0) {
          result.stringElements_.Add(other.stringElements_);
        }
        if (other.intElements_.Count != 0) {
          result.intElements_.Add(other.intElements_);
        }
        if (other.longElements_.Count != 0) {
          result.longElements_.Add(other.longElements_);
        }
        if (other.otherElements_.Count != 0) {
          result.otherElements_.Add(other.otherElements_);
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
            int field_ordinal = global::System.Array.BinarySearch(_oRSetFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _oRSetFieldTags[field_ordinal];
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
              global::Akka.DistributedData.Messages.VersionVector.Builder subBuilder = global::Akka.DistributedData.Messages.VersionVector.CreateBuilder();
              if (result.hasVvector) {
                subBuilder.MergeFrom(Vvector);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Vvector = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              input.ReadMessageArray(tag, field_name, result.dots_, global::Akka.DistributedData.Messages.VersionVector.DefaultInstance, extensionRegistry);
              break;
            }
            case 26: {
              input.ReadStringArray(tag, field_name, result.stringElements_);
              break;
            }
            case 34:
            case 32: {
              input.ReadSInt32Array(tag, field_name, result.intElements_);
              break;
            }
            case 42:
            case 40: {
              input.ReadSInt64Array(tag, field_name, result.longElements_);
              break;
            }
            case 50: {
              input.ReadMessageArray(tag, field_name, result.otherElements_, global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance, extensionRegistry);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetVvector(global::Akka.DistributedData.Messages.VersionVector value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasVvector = true;
        result.vvector_ = value;
        return this;
      }

        public Builder SetVvector(global::Akka.DistributedData.Messages.VersionVector.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasVvector = true;
        result.vvector_ = builderForValue.Build();
        return this;
      }

        public Builder MergeVvector(global::Akka.DistributedData.Messages.VersionVector value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasVvector &&
            result.vvector_ != global::Akka.DistributedData.Messages.VersionVector.DefaultInstance) {
            result.vvector_ = global::Akka.DistributedData.Messages.VersionVector.CreateBuilder(result.vvector_).MergeFrom(value).BuildPartial();
        } else {
          result.vvector_ = value;
        }
        result.hasVvector = true;
        return this;
      }

        public Builder ClearVvector() {
        PrepareBuilder();
        result.hasVvector = false;
        result.vvector_ = null;
        return this;
      }

        public global::Akka.DistributedData.Messages.VersionVector GetDots(int index) {
        return result.GetDots(index);
      }

        public Builder SetDots(int index, global::Akka.DistributedData.Messages.VersionVector value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.dots_[index] = value;
        return this;
      }

        public Builder SetDots(int index, global::Akka.DistributedData.Messages.VersionVector.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.dots_[index] = builderForValue.Build();
        return this;
      }

        public Builder AddDots(global::Akka.DistributedData.Messages.VersionVector value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.dots_.Add(value);
        return this;
      }

        public Builder AddDots(global::Akka.DistributedData.Messages.VersionVector.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.dots_.Add(builderForValue.Build());
        return this;
      }

        public Builder AddRangeDots(scg::IEnumerable<global::Akka.DistributedData.Messages.VersionVector> values) {
        PrepareBuilder();
        result.dots_.Add(values);
        return this;
      }

        public Builder ClearDots() {
        PrepareBuilder();
        result.dots_.Clear();
        return this;
      }

        public string GetStringElements(int index) {
        return result.GetStringElements(index);
      }

        public Builder SetStringElements(int index, string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.stringElements_[index] = value;
        return this;
      }

        public Builder AddStringElements(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.stringElements_.Add(value);
        return this;
      }

        public Builder AddRangeStringElements(scg::IEnumerable<string> values) {
        PrepareBuilder();
        result.stringElements_.Add(values);
        return this;
      }

        public Builder ClearStringElements() {
        PrepareBuilder();
        result.stringElements_.Clear();
        return this;
      }

        public int GetIntElements(int index) {
        return result.GetIntElements(index);
      }

        public Builder SetIntElements(int index, int value) {
        PrepareBuilder();
        result.intElements_[index] = value;
        return this;
      }

        public Builder AddIntElements(int value) {
        PrepareBuilder();
        result.intElements_.Add(value);
        return this;
      }

        public Builder AddRangeIntElements(scg::IEnumerable<int> values) {
        PrepareBuilder();
        result.intElements_.Add(values);
        return this;
      }

        public Builder ClearIntElements() {
        PrepareBuilder();
        result.intElements_.Clear();
        return this;
      }

        public long GetLongElements(int index) {
        return result.GetLongElements(index);
      }

        public Builder SetLongElements(int index, long value) {
        PrepareBuilder();
        result.longElements_[index] = value;
        return this;
      }

        public Builder AddLongElements(long value) {
        PrepareBuilder();
        result.longElements_.Add(value);
        return this;
      }

        public Builder AddRangeLongElements(scg::IEnumerable<long> values) {
        PrepareBuilder();
        result.longElements_.Add(values);
        return this;
      }

        public Builder ClearLongElements() {
        PrepareBuilder();
        result.longElements_.Clear();
        return this;
      }

        public global::Akka.DistributedData.Messages.OtherMessage GetOtherElements(int index) {
        return result.GetOtherElements(index);
      }

        public Builder SetOtherElements(int index, global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.otherElements_[index] = value;
        return this;
      }

        public Builder SetOtherElements(int index, global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.otherElements_[index] = builderForValue.Build();
        return this;
      }

        public Builder AddOtherElements(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.otherElements_.Add(value);
        return this;
      }

        public Builder AddOtherElements(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.otherElements_.Add(builderForValue.Build());
        return this;
      }

        public Builder AddRangeOtherElements(scg::IEnumerable<global::Akka.DistributedData.Messages.OtherMessage> values) {
        PrepareBuilder();
        result.otherElements_.Add(values);
        return this;
      }

        public Builder ClearOtherElements() {
        PrepareBuilder();
        result.otherElements_.Clear();
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Flag : pb::GeneratedMessage<Flag, Flag.Builder> {
      public const int EnabledFieldNumber = 1;
      private static readonly Flag defaultInstance = new Flag().MakeReadOnly();
      private static readonly string[] _flagFieldNames = new string[] { "enabled" };
      private static readonly uint[] _flagFieldTags = new uint[] { 8 };
      private bool enabled_;
      private bool hasEnabled;

      private int memoizedSerializedSize = -1;

      static Flag() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
    }

      private Flag() { }

      public static Flag DefaultInstance {
      get { return defaultInstance; }
    }

      public override Flag DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override Flag ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_Flag__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<Flag, Flag.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_Flag__FieldAccessorTable; }
    }

      public bool HasEnabled {
      get { return hasEnabled; }
    }

      public bool Enabled {
      get { return enabled_; }
    }

      public override bool IsInitialized {
      get {
        if (!hasEnabled) return false;
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasEnabled) {
          size += pb::CodedOutputStream.ComputeBoolSize(1, Enabled);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _flagFieldNames;
      if (hasEnabled) {
        output.WriteBool(1, field_names[0], Enabled);
      }
      UnknownFields.WriteTo(output);
    }

      public static Flag ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Flag ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Flag ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static Flag ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static Flag ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Flag ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static Flag ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static Flag ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static Flag ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static Flag ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private Flag MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(Flag prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<Flag, Builder> {
        private Flag result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(Flag cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override Flag MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.Flag.Descriptor; }
      }

        public override Flag DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.Flag.DefaultInstance; }
      }


        public bool HasEnabled {
        get { return result.hasEnabled; }
      }

        public bool Enabled {
        get { return result.Enabled; }
        set { SetEnabled(value); }
      }

        private Flag PrepareBuilder() {
        if (resultIsReadOnly) {
          Flag original = result;
          result = new Flag();
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

        public override Flag BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is Flag) {
          return MergeFrom((Flag) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(Flag other) {
        if (other == global::Akka.DistributedData.Messages.Flag.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasEnabled) {
          Enabled = other.Enabled;
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
            int field_ordinal = global::System.Array.BinarySearch(_flagFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _flagFieldTags[field_ordinal];
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
              result.hasEnabled = input.ReadBool(ref result.enabled_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetEnabled(bool value) {
        PrepareBuilder();
        result.hasEnabled = true;
        result.enabled_ = value;
        return this;
      }

        public Builder ClearEnabled() {
        PrepareBuilder();
        result.hasEnabled = false;
        result.enabled_ = false;
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class LWWRegister : pb::GeneratedMessage<LWWRegister, LWWRegister.Builder> {
      public const int TimestampFieldNumber = 1;

      public const int NodeFieldNumber = 2;

      public const int StateFieldNumber = 3;
      private static readonly LWWRegister defaultInstance = new LWWRegister().MakeReadOnly();
      private static readonly string[] _lWWRegisterFieldNames = new string[] { "node", "state", "timestamp" };
      private static readonly uint[] _lWWRegisterFieldTags = new uint[] { 18, 26, 8 };
      private bool hasNode;
      private bool hasState;
      private bool hasTimestamp;

      private int memoizedSerializedSize = -1;
      private global::Akka.DistributedData.Messages.UniqueAddress node_;
      private global::Akka.DistributedData.Messages.OtherMessage state_;
      private long timestamp_;

      static LWWRegister() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
    }

      private LWWRegister() { }

      public static LWWRegister DefaultInstance {
      get { return defaultInstance; }
    }

      public override LWWRegister DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override LWWRegister ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_LWWRegister__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<LWWRegister, LWWRegister.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_LWWRegister__FieldAccessorTable; }
    }

      public bool HasTimestamp {
      get { return hasTimestamp; }
    }

      public long Timestamp {
      get { return timestamp_; }
    }

      public bool HasNode {
      get { return hasNode; }
    }

      public global::Akka.DistributedData.Messages.UniqueAddress Node {
      get { return node_ ?? global::Akka.DistributedData.Messages.UniqueAddress.DefaultInstance; }
    }

      public bool HasState {
      get { return hasState; }
    }

      public global::Akka.DistributedData.Messages.OtherMessage State {
      get { return state_ ?? global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance; }
    }

      public override bool IsInitialized {
      get {
        if (!hasTimestamp) return false;
        if (!hasNode) return false;
        if (!hasState) return false;
        if (!Node.IsInitialized) return false;
        if (!State.IsInitialized) return false;
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasTimestamp) {
          size += pb::CodedOutputStream.ComputeSInt64Size(1, Timestamp);
        }
        if (hasNode) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, Node);
        }
        if (hasState) {
          size += pb::CodedOutputStream.ComputeMessageSize(3, State);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _lWWRegisterFieldNames;
      if (hasTimestamp) {
        output.WriteSInt64(1, field_names[2], Timestamp);
      }
      if (hasNode) {
        output.WriteMessage(2, field_names[0], Node);
      }
      if (hasState) {
        output.WriteMessage(3, field_names[1], State);
      }
      UnknownFields.WriteTo(output);
    }

      public static LWWRegister ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static LWWRegister ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static LWWRegister ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static LWWRegister ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static LWWRegister ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static LWWRegister ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static LWWRegister ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static LWWRegister ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static LWWRegister ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static LWWRegister ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private LWWRegister MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(LWWRegister prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<LWWRegister, Builder> {
        private LWWRegister result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(LWWRegister cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override LWWRegister MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.LWWRegister.Descriptor; }
      }

        public override LWWRegister DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.LWWRegister.DefaultInstance; }
      }


        public bool HasTimestamp {
        get { return result.hasTimestamp; }
      }

        public long Timestamp {
        get { return result.Timestamp; }
        set { SetTimestamp(value); }
      }

        public bool HasNode {
       get { return result.hasNode; }
      }

        public global::Akka.DistributedData.Messages.UniqueAddress Node {
        get { return result.Node; }
        set { SetNode(value); }
      }

        public bool HasState {
       get { return result.hasState; }
      }

        public global::Akka.DistributedData.Messages.OtherMessage State {
        get { return result.State; }
        set { SetState(value); }
      }

        private LWWRegister PrepareBuilder() {
        if (resultIsReadOnly) {
          LWWRegister original = result;
          result = new LWWRegister();
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

        public override LWWRegister BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is LWWRegister) {
          return MergeFrom((LWWRegister) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(LWWRegister other) {
        if (other == global::Akka.DistributedData.Messages.LWWRegister.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasTimestamp) {
          Timestamp = other.Timestamp;
        }
        if (other.HasNode) {
          MergeNode(other.Node);
        }
        if (other.HasState) {
          MergeState(other.State);
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
            int field_ordinal = global::System.Array.BinarySearch(_lWWRegisterFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _lWWRegisterFieldTags[field_ordinal];
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
              result.hasTimestamp = input.ReadSInt64(ref result.timestamp_);
              break;
            }
            case 18: {
              global::Akka.DistributedData.Messages.UniqueAddress.Builder subBuilder = global::Akka.DistributedData.Messages.UniqueAddress.CreateBuilder();
              if (result.hasNode) {
                subBuilder.MergeFrom(Node);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Node = subBuilder.BuildPartial();
              break;
            }
            case 26: {
              global::Akka.DistributedData.Messages.OtherMessage.Builder subBuilder = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder();
              if (result.hasState) {
                subBuilder.MergeFrom(State);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              State = subBuilder.BuildPartial();
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetTimestamp(long value) {
        PrepareBuilder();
        result.hasTimestamp = true;
        result.timestamp_ = value;
        return this;
      }

        public Builder ClearTimestamp() {
        PrepareBuilder();
        result.hasTimestamp = false;
        result.timestamp_ = 0;
        return this;
      }

        public Builder SetNode(global::Akka.DistributedData.Messages.UniqueAddress value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasNode = true;
        result.node_ = value;
        return this;
      }

        public Builder SetNode(global::Akka.DistributedData.Messages.UniqueAddress.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasNode = true;
        result.node_ = builderForValue.Build();
        return this;
      }

        public Builder MergeNode(global::Akka.DistributedData.Messages.UniqueAddress value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasNode &&
            result.node_ != global::Akka.DistributedData.Messages.UniqueAddress.DefaultInstance) {
            result.node_ = global::Akka.DistributedData.Messages.UniqueAddress.CreateBuilder(result.node_).MergeFrom(value).BuildPartial();
        } else {
          result.node_ = value;
        }
        result.hasNode = true;
        return this;
      }

        public Builder ClearNode() {
        PrepareBuilder();
        result.hasNode = false;
        result.node_ = null;
        return this;
      }

        public Builder SetState(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasState = true;
        result.state_ = value;
        return this;
      }

        public Builder SetState(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasState = true;
        result.state_ = builderForValue.Build();
        return this;
      }

        public Builder MergeState(global::Akka.DistributedData.Messages.OtherMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasState &&
            result.state_ != global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance) {
            result.state_ = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder(result.state_).MergeFrom(value).BuildPartial();
        } else {
          result.state_ = value;
        }
        result.hasState = true;
        return this;
      }

        public Builder ClearState() {
        PrepareBuilder();
        result.hasState = false;
        result.state_ = null;
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GCounter : pb::GeneratedMessage<GCounter, GCounter.Builder> {
      public const int EntriesFieldNumber = 1;
      private static readonly GCounter defaultInstance = new GCounter().MakeReadOnly();
      private static readonly string[] _gCounterFieldNames = new string[] { "entries" };
      private static readonly uint[] _gCounterFieldTags = new uint[] { 10 };
      private pbc::PopsicleList<global::Akka.DistributedData.Messages.GCounter.Types.Entry> entries_ = new pbc::PopsicleList<global::Akka.DistributedData.Messages.GCounter.Types.Entry>();

      private int memoizedSerializedSize = -1;

      static GCounter() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
    }

      private GCounter() { }

      public static GCounter DefaultInstance {
      get { return defaultInstance; }
    }

      public override GCounter DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override GCounter ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_GCounter__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<GCounter, GCounter.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_GCounter__FieldAccessorTable; }
    }

      public scg::IList<global::Akka.DistributedData.Messages.GCounter.Types.Entry> EntriesList {
      get { return entries_; }
    }

      public int EntriesCount {
      get { return entries_.Count; }
    }

      public override bool IsInitialized {
      get {
        foreach (global::Akka.DistributedData.Messages.GCounter.Types.Entry element in EntriesList) {
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
        foreach (global::Akka.DistributedData.Messages.GCounter.Types.Entry element in EntriesList) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public global::Akka.DistributedData.Messages.GCounter.Types.Entry GetEntries(int index) {
      return entries_[index];
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _gCounterFieldNames;
      if (entries_.Count > 0) {
        output.WriteMessageArray(1, field_names[0], entries_);
      }
      UnknownFields.WriteTo(output);
    }

      public static GCounter ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static GCounter ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static GCounter ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static GCounter ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static GCounter ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static GCounter ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static GCounter ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static GCounter ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static GCounter ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static GCounter ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private GCounter MakeReadOnly() {
      entries_.MakeReadOnly();
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(GCounter prototype) {
      return new Builder(prototype);
    }

      #region Nested types

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class Entry : pb::GeneratedMessage<Entry, Entry.Builder> {
          public const int NodeFieldNumber = 1;

          public const int ValueFieldNumber = 2;
          private static readonly Entry defaultInstance = new Entry().MakeReadOnly();
          private static readonly string[] _entryFieldNames = new string[] { "node", "value" };
          private static readonly uint[] _entryFieldTags = new uint[] { 10, 18 };
          private bool hasNode;
          private bool hasValue;

          private int memoizedSerializedSize = -1;
          private global::Akka.DistributedData.Messages.UniqueAddress node_;
          private pb::ByteString value_ = pb::ByteString.Empty;

          static Entry() {
          object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
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
          get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_GCounter_Entry__Descriptor; }
        }

          protected override pb::FieldAccess.FieldAccessorTable<Entry, Entry.Builder> InternalFieldAccessors {
          get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_GCounter_Entry__FieldAccessorTable; }
        }

          public bool HasNode {
          get { return hasNode; }
        }

          public global::Akka.DistributedData.Messages.UniqueAddress Node {
          get { return node_ ?? global::Akka.DistributedData.Messages.UniqueAddress.DefaultInstance; }
        }

          public bool HasValue {
          get { return hasValue; }
        }

          public pb::ByteString Value {
          get { return value_; }
        }

          public override bool IsInitialized {
          get {
            if (!hasNode) return false;
            if (!hasValue) return false;
            if (!Node.IsInitialized) return false;
            return true;
          }
        }

          public override int SerializedSize {
          get {
            int size = memoizedSerializedSize;
            if (size != -1) return size;
            
            size = 0;
            if (hasNode) {
              size += pb::CodedOutputStream.ComputeMessageSize(1, Node);
            }
            if (hasValue) {
              size += pb::CodedOutputStream.ComputeBytesSize(2, Value);
            }
            size += UnknownFields.SerializedSize;
            memoizedSerializedSize = size;
            return size;
          }
        }

          public override void WriteTo(pb::ICodedOutputStream output) {
          int size = SerializedSize;
          string[] field_names = _entryFieldNames;
          if (hasNode) {
            output.WriteMessage(1, field_names[0], Node);
          }
          if (hasValue) {
            output.WriteBytes(2, field_names[1], Value);
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
            get { return global::Akka.DistributedData.Messages.GCounter.Types.Entry.Descriptor; }
          }

            public override Entry DefaultInstanceForType {
            get { return global::Akka.DistributedData.Messages.GCounter.Types.Entry.DefaultInstance; }
          }


            public bool HasNode {
           get { return result.hasNode; }
          }

            public global::Akka.DistributedData.Messages.UniqueAddress Node {
            get { return result.Node; }
            set { SetNode(value); }
          }

            public bool HasValue {
            get { return result.hasValue; }
          }

            public pb::ByteString Value {
            get { return result.Value; }
            set { SetValue(value); }
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
            if (other == global::Akka.DistributedData.Messages.GCounter.Types.Entry.DefaultInstance) return this;
            PrepareBuilder();
            if (other.HasNode) {
              MergeNode(other.Node);
            }
            if (other.HasValue) {
              Value = other.Value;
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
                  global::Akka.DistributedData.Messages.UniqueAddress.Builder subBuilder = global::Akka.DistributedData.Messages.UniqueAddress.CreateBuilder();
                  if (result.hasNode) {
                    subBuilder.MergeFrom(Node);
                  }
                  input.ReadMessage(subBuilder, extensionRegistry);
                  Node = subBuilder.BuildPartial();
                  break;
                }
                case 18: {
                  result.hasValue = input.ReadBytes(ref result.value_);
                  break;
                }
              }
            }
            
            if (unknownFields != null) {
              this.UnknownFields = unknownFields.Build();
            }
            return this;
          }

            public Builder SetNode(global::Akka.DistributedData.Messages.UniqueAddress value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.hasNode = true;
            result.node_ = value;
            return this;
          }

            public Builder SetNode(global::Akka.DistributedData.Messages.UniqueAddress.Builder builderForValue) {
            pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
            PrepareBuilder();
            result.hasNode = true;
            result.node_ = builderForValue.Build();
            return this;
          }

            public Builder MergeNode(global::Akka.DistributedData.Messages.UniqueAddress value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            if (result.hasNode &&
                result.node_ != global::Akka.DistributedData.Messages.UniqueAddress.DefaultInstance) {
                result.node_ = global::Akka.DistributedData.Messages.UniqueAddress.CreateBuilder(result.node_).MergeFrom(value).BuildPartial();
            } else {
              result.node_ = value;
            }
            result.hasNode = true;
            return this;
          }

            public Builder ClearNode() {
            PrepareBuilder();
            result.hasNode = false;
            result.node_ = null;
            return this;
          }

            public Builder SetValue(pb::ByteString value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.hasValue = true;
            result.value_ = value;
            return this;
          }

            public Builder ClearValue() {
            PrepareBuilder();
            result.hasValue = false;
            result.value_ = pb::ByteString.Empty;
            return this;
          }
        }
      }
    }

      #endregion

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<GCounter, Builder> {
        private GCounter result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(GCounter cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override GCounter MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.GCounter.Descriptor; }
      }

        public override GCounter DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.GCounter.DefaultInstance; }
      }


        public pbc::IPopsicleList<global::Akka.DistributedData.Messages.GCounter.Types.Entry> EntriesList {
        get { return PrepareBuilder().entries_; }
      }

        public int EntriesCount {
        get { return result.EntriesCount; }
      }

        private GCounter PrepareBuilder() {
        if (resultIsReadOnly) {
          GCounter original = result;
          result = new GCounter();
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

        public override GCounter BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is GCounter) {
          return MergeFrom((GCounter) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(GCounter other) {
        if (other == global::Akka.DistributedData.Messages.GCounter.DefaultInstance) return this;
        PrepareBuilder();
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
            int field_ordinal = global::System.Array.BinarySearch(_gCounterFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _gCounterFieldTags[field_ordinal];
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
              input.ReadMessageArray(tag, field_name, result.entries_, global::Akka.DistributedData.Messages.GCounter.Types.Entry.DefaultInstance, extensionRegistry);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public global::Akka.DistributedData.Messages.GCounter.Types.Entry GetEntries(int index) {
        return result.GetEntries(index);
      }

        public Builder SetEntries(int index, global::Akka.DistributedData.Messages.GCounter.Types.Entry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.entries_[index] = value;
        return this;
      }

        public Builder SetEntries(int index, global::Akka.DistributedData.Messages.GCounter.Types.Entry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.entries_[index] = builderForValue.Build();
        return this;
      }

        public Builder AddEntries(global::Akka.DistributedData.Messages.GCounter.Types.Entry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.entries_.Add(value);
        return this;
      }

        public Builder AddEntries(global::Akka.DistributedData.Messages.GCounter.Types.Entry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.entries_.Add(builderForValue.Build());
        return this;
      }

        public Builder AddRangeEntries(scg::IEnumerable<global::Akka.DistributedData.Messages.GCounter.Types.Entry> values) {
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
  public sealed partial class PNCounter : pb::GeneratedMessage<PNCounter, PNCounter.Builder> {
      public const int IncrementsFieldNumber = 1;

      public const int DecrementsFieldNumber = 2;
      private static readonly PNCounter defaultInstance = new PNCounter().MakeReadOnly();
      private static readonly string[] _pNCounterFieldNames = new string[] { "decrements", "increments" };
      private static readonly uint[] _pNCounterFieldTags = new uint[] { 18, 10 };
      private global::Akka.DistributedData.Messages.GCounter decrements_;
      private bool hasDecrements;
      private bool hasIncrements;
      private global::Akka.DistributedData.Messages.GCounter increments_;

      private int memoizedSerializedSize = -1;

      static PNCounter() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
    }

      private PNCounter() { }

      public static PNCounter DefaultInstance {
      get { return defaultInstance; }
    }

      public override PNCounter DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override PNCounter ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_PNCounter__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<PNCounter, PNCounter.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_PNCounter__FieldAccessorTable; }
    }

      public bool HasIncrements {
      get { return hasIncrements; }
    }

      public global::Akka.DistributedData.Messages.GCounter Increments {
      get { return increments_ ?? global::Akka.DistributedData.Messages.GCounter.DefaultInstance; }
    }

      public bool HasDecrements {
      get { return hasDecrements; }
    }

      public global::Akka.DistributedData.Messages.GCounter Decrements {
      get { return decrements_ ?? global::Akka.DistributedData.Messages.GCounter.DefaultInstance; }
    }

      public override bool IsInitialized {
      get {
        if (!hasIncrements) return false;
        if (!hasDecrements) return false;
        if (!Increments.IsInitialized) return false;
        if (!Decrements.IsInitialized) return false;
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasIncrements) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Increments);
        }
        if (hasDecrements) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, Decrements);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _pNCounterFieldNames;
      if (hasIncrements) {
        output.WriteMessage(1, field_names[1], Increments);
      }
      if (hasDecrements) {
        output.WriteMessage(2, field_names[0], Decrements);
      }
      UnknownFields.WriteTo(output);
    }

      public static PNCounter ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static PNCounter ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static PNCounter ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static PNCounter ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static PNCounter ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static PNCounter ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static PNCounter ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static PNCounter ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static PNCounter ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static PNCounter ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private PNCounter MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(PNCounter prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<PNCounter, Builder> {
        private PNCounter result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(PNCounter cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override PNCounter MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.PNCounter.Descriptor; }
      }

        public override PNCounter DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.PNCounter.DefaultInstance; }
      }


        public bool HasIncrements {
       get { return result.hasIncrements; }
      }

        public global::Akka.DistributedData.Messages.GCounter Increments {
        get { return result.Increments; }
        set { SetIncrements(value); }
      }

        public bool HasDecrements {
       get { return result.hasDecrements; }
      }

        public global::Akka.DistributedData.Messages.GCounter Decrements {
        get { return result.Decrements; }
        set { SetDecrements(value); }
      }

        private PNCounter PrepareBuilder() {
        if (resultIsReadOnly) {
          PNCounter original = result;
          result = new PNCounter();
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

        public override PNCounter BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is PNCounter) {
          return MergeFrom((PNCounter) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(PNCounter other) {
        if (other == global::Akka.DistributedData.Messages.PNCounter.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasIncrements) {
          MergeIncrements(other.Increments);
        }
        if (other.HasDecrements) {
          MergeDecrements(other.Decrements);
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
            int field_ordinal = global::System.Array.BinarySearch(_pNCounterFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _pNCounterFieldTags[field_ordinal];
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
              global::Akka.DistributedData.Messages.GCounter.Builder subBuilder = global::Akka.DistributedData.Messages.GCounter.CreateBuilder();
              if (result.hasIncrements) {
                subBuilder.MergeFrom(Increments);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Increments = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              global::Akka.DistributedData.Messages.GCounter.Builder subBuilder = global::Akka.DistributedData.Messages.GCounter.CreateBuilder();
              if (result.hasDecrements) {
                subBuilder.MergeFrom(Decrements);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Decrements = subBuilder.BuildPartial();
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetIncrements(global::Akka.DistributedData.Messages.GCounter value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasIncrements = true;
        result.increments_ = value;
        return this;
      }

        public Builder SetIncrements(global::Akka.DistributedData.Messages.GCounter.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasIncrements = true;
        result.increments_ = builderForValue.Build();
        return this;
      }

        public Builder MergeIncrements(global::Akka.DistributedData.Messages.GCounter value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasIncrements &&
            result.increments_ != global::Akka.DistributedData.Messages.GCounter.DefaultInstance) {
            result.increments_ = global::Akka.DistributedData.Messages.GCounter.CreateBuilder(result.increments_).MergeFrom(value).BuildPartial();
        } else {
          result.increments_ = value;
        }
        result.hasIncrements = true;
        return this;
      }

        public Builder ClearIncrements() {
        PrepareBuilder();
        result.hasIncrements = false;
        result.increments_ = null;
        return this;
      }

        public Builder SetDecrements(global::Akka.DistributedData.Messages.GCounter value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasDecrements = true;
        result.decrements_ = value;
        return this;
      }

        public Builder SetDecrements(global::Akka.DistributedData.Messages.GCounter.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasDecrements = true;
        result.decrements_ = builderForValue.Build();
        return this;
      }

        public Builder MergeDecrements(global::Akka.DistributedData.Messages.GCounter value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasDecrements &&
            result.decrements_ != global::Akka.DistributedData.Messages.GCounter.DefaultInstance) {
            result.decrements_ = global::Akka.DistributedData.Messages.GCounter.CreateBuilder(result.decrements_).MergeFrom(value).BuildPartial();
        } else {
          result.decrements_ = value;
        }
        result.hasDecrements = true;
        return this;
      }

        public Builder ClearDecrements() {
        PrepareBuilder();
        result.hasDecrements = false;
        result.decrements_ = null;
        return this;
      }
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class VersionVector : pb::GeneratedMessage<VersionVector, VersionVector.Builder> {
      public const int EntriesFieldNumber = 1;
      private static readonly VersionVector defaultInstance = new VersionVector().MakeReadOnly();
      private static readonly string[] _versionVectorFieldNames = new string[] { "entries" };
      private static readonly uint[] _versionVectorFieldTags = new uint[] { 10 };
      private pbc::PopsicleList<global::Akka.DistributedData.Messages.VersionVector.Types.Entry> entries_ = new pbc::PopsicleList<global::Akka.DistributedData.Messages.VersionVector.Types.Entry>();

      private int memoizedSerializedSize = -1;

      static VersionVector() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
    }

      private VersionVector() { }

      public static VersionVector DefaultInstance {
      get { return defaultInstance; }
    }

      public override VersionVector DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override VersionVector ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_VersionVector__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<VersionVector, VersionVector.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_VersionVector__FieldAccessorTable; }
    }

      public scg::IList<global::Akka.DistributedData.Messages.VersionVector.Types.Entry> EntriesList {
      get { return entries_; }
    }

      public int EntriesCount {
      get { return entries_.Count; }
    }

      public override bool IsInitialized {
      get {
        foreach (global::Akka.DistributedData.Messages.VersionVector.Types.Entry element in EntriesList) {
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
        foreach (global::Akka.DistributedData.Messages.VersionVector.Types.Entry element in EntriesList) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public global::Akka.DistributedData.Messages.VersionVector.Types.Entry GetEntries(int index) {
      return entries_[index];
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _versionVectorFieldNames;
      if (entries_.Count > 0) {
        output.WriteMessageArray(1, field_names[0], entries_);
      }
      UnknownFields.WriteTo(output);
    }

      public static VersionVector ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static VersionVector ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static VersionVector ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static VersionVector ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static VersionVector ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static VersionVector ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static VersionVector ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static VersionVector ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static VersionVector ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static VersionVector ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private VersionVector MakeReadOnly() {
      entries_.MakeReadOnly();
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(VersionVector prototype) {
      return new Builder(prototype);
    }

      #region Nested types

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class Entry : pb::GeneratedMessage<Entry, Entry.Builder> {
          public const int NodeFieldNumber = 1;

          public const int VersionFieldNumber = 2;
          private static readonly Entry defaultInstance = new Entry().MakeReadOnly();
          private static readonly string[] _entryFieldNames = new string[] { "node", "version" };
          private static readonly uint[] _entryFieldTags = new uint[] { 10, 16 };
          private bool hasNode;
          private bool hasVersion;

          private int memoizedSerializedSize = -1;
          private global::Akka.DistributedData.Messages.UniqueAddress node_;
          private long version_;

          static Entry() {
          object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
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
          get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_VersionVector_Entry__Descriptor; }
        }

          protected override pb::FieldAccess.FieldAccessorTable<Entry, Entry.Builder> InternalFieldAccessors {
          get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_VersionVector_Entry__FieldAccessorTable; }
        }

          public bool HasNode {
          get { return hasNode; }
        }

          public global::Akka.DistributedData.Messages.UniqueAddress Node {
          get { return node_ ?? global::Akka.DistributedData.Messages.UniqueAddress.DefaultInstance; }
        }

          public bool HasVersion {
          get { return hasVersion; }
        }

          public long Version {
          get { return version_; }
        }

          public override bool IsInitialized {
          get {
            if (!hasNode) return false;
            if (!hasVersion) return false;
            if (!Node.IsInitialized) return false;
            return true;
          }
        }

          public override int SerializedSize {
          get {
            int size = memoizedSerializedSize;
            if (size != -1) return size;
            
            size = 0;
            if (hasNode) {
              size += pb::CodedOutputStream.ComputeMessageSize(1, Node);
            }
            if (hasVersion) {
              size += pb::CodedOutputStream.ComputeInt64Size(2, Version);
            }
            size += UnknownFields.SerializedSize;
            memoizedSerializedSize = size;
            return size;
          }
        }

          public override void WriteTo(pb::ICodedOutputStream output) {
          int size = SerializedSize;
          string[] field_names = _entryFieldNames;
          if (hasNode) {
            output.WriteMessage(1, field_names[0], Node);
          }
          if (hasVersion) {
            output.WriteInt64(2, field_names[1], Version);
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
            get { return global::Akka.DistributedData.Messages.VersionVector.Types.Entry.Descriptor; }
          }

            public override Entry DefaultInstanceForType {
            get { return global::Akka.DistributedData.Messages.VersionVector.Types.Entry.DefaultInstance; }
          }


            public bool HasNode {
           get { return result.hasNode; }
          }

            public global::Akka.DistributedData.Messages.UniqueAddress Node {
            get { return result.Node; }
            set { SetNode(value); }
          }

            public bool HasVersion {
            get { return result.hasVersion; }
          }

            public long Version {
            get { return result.Version; }
            set { SetVersion(value); }
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
            if (other == global::Akka.DistributedData.Messages.VersionVector.Types.Entry.DefaultInstance) return this;
            PrepareBuilder();
            if (other.HasNode) {
              MergeNode(other.Node);
            }
            if (other.HasVersion) {
              Version = other.Version;
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
                  global::Akka.DistributedData.Messages.UniqueAddress.Builder subBuilder = global::Akka.DistributedData.Messages.UniqueAddress.CreateBuilder();
                  if (result.hasNode) {
                    subBuilder.MergeFrom(Node);
                  }
                  input.ReadMessage(subBuilder, extensionRegistry);
                  Node = subBuilder.BuildPartial();
                  break;
                }
                case 16: {
                  result.hasVersion = input.ReadInt64(ref result.version_);
                  break;
                }
              }
            }
            
            if (unknownFields != null) {
              this.UnknownFields = unknownFields.Build();
            }
            return this;
          }

            public Builder SetNode(global::Akka.DistributedData.Messages.UniqueAddress value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.hasNode = true;
            result.node_ = value;
            return this;
          }

            public Builder SetNode(global::Akka.DistributedData.Messages.UniqueAddress.Builder builderForValue) {
            pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
            PrepareBuilder();
            result.hasNode = true;
            result.node_ = builderForValue.Build();
            return this;
          }

            public Builder MergeNode(global::Akka.DistributedData.Messages.UniqueAddress value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            if (result.hasNode &&
                result.node_ != global::Akka.DistributedData.Messages.UniqueAddress.DefaultInstance) {
                result.node_ = global::Akka.DistributedData.Messages.UniqueAddress.CreateBuilder(result.node_).MergeFrom(value).BuildPartial();
            } else {
              result.node_ = value;
            }
            result.hasNode = true;
            return this;
          }

            public Builder ClearNode() {
            PrepareBuilder();
            result.hasNode = false;
            result.node_ = null;
            return this;
          }

            public Builder SetVersion(long value) {
            PrepareBuilder();
            result.hasVersion = true;
            result.version_ = value;
            return this;
          }

            public Builder ClearVersion() {
            PrepareBuilder();
            result.hasVersion = false;
            result.version_ = 0L;
            return this;
          }
        }
      }
    }

      #endregion

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<VersionVector, Builder> {
        private VersionVector result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(VersionVector cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override VersionVector MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.VersionVector.Descriptor; }
      }

        public override VersionVector DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.VersionVector.DefaultInstance; }
      }


        public pbc::IPopsicleList<global::Akka.DistributedData.Messages.VersionVector.Types.Entry> EntriesList {
        get { return PrepareBuilder().entries_; }
      }

        public int EntriesCount {
        get { return result.EntriesCount; }
      }

        private VersionVector PrepareBuilder() {
        if (resultIsReadOnly) {
          VersionVector original = result;
          result = new VersionVector();
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

        public override VersionVector BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is VersionVector) {
          return MergeFrom((VersionVector) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(VersionVector other) {
        if (other == global::Akka.DistributedData.Messages.VersionVector.DefaultInstance) return this;
        PrepareBuilder();
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
            int field_ordinal = global::System.Array.BinarySearch(_versionVectorFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _versionVectorFieldTags[field_ordinal];
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
              input.ReadMessageArray(tag, field_name, result.entries_, global::Akka.DistributedData.Messages.VersionVector.Types.Entry.DefaultInstance, extensionRegistry);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public global::Akka.DistributedData.Messages.VersionVector.Types.Entry GetEntries(int index) {
        return result.GetEntries(index);
      }

        public Builder SetEntries(int index, global::Akka.DistributedData.Messages.VersionVector.Types.Entry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.entries_[index] = value;
        return this;
      }

        public Builder SetEntries(int index, global::Akka.DistributedData.Messages.VersionVector.Types.Entry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.entries_[index] = builderForValue.Build();
        return this;
      }

        public Builder AddEntries(global::Akka.DistributedData.Messages.VersionVector.Types.Entry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.entries_.Add(value);
        return this;
      }

        public Builder AddEntries(global::Akka.DistributedData.Messages.VersionVector.Types.Entry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.entries_.Add(builderForValue.Build());
        return this;
      }

        public Builder AddRangeEntries(scg::IEnumerable<global::Akka.DistributedData.Messages.VersionVector.Types.Entry> values) {
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
  public sealed partial class ORMap : pb::GeneratedMessage<ORMap, ORMap.Builder> {
      public const int KeysFieldNumber = 1;

      public const int EntriesFieldNumber = 2;
      private static readonly ORMap defaultInstance = new ORMap().MakeReadOnly();
      private static readonly string[] _oRMapFieldNames = new string[] { "entries", "keys" };
      private static readonly uint[] _oRMapFieldTags = new uint[] { 18, 10 };
      private pbc::PopsicleList<global::Akka.DistributedData.Messages.ORMap.Types.Entry> entries_ = new pbc::PopsicleList<global::Akka.DistributedData.Messages.ORMap.Types.Entry>();
      private bool hasKeys;
      private global::Akka.DistributedData.Messages.ORSet keys_;

      private int memoizedSerializedSize = -1;

      static ORMap() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
    }

      private ORMap() { }

      public static ORMap DefaultInstance {
      get { return defaultInstance; }
    }

      public override ORMap DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override ORMap ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_ORMap__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<ORMap, ORMap.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_ORMap__FieldAccessorTable; }
    }

      public bool HasKeys {
      get { return hasKeys; }
    }

      public global::Akka.DistributedData.Messages.ORSet Keys {
      get { return keys_ ?? global::Akka.DistributedData.Messages.ORSet.DefaultInstance; }
    }

      public scg::IList<global::Akka.DistributedData.Messages.ORMap.Types.Entry> EntriesList {
      get { return entries_; }
    }

      public int EntriesCount {
      get { return entries_.Count; }
    }

      public override bool IsInitialized {
      get {
        if (!hasKeys) return false;
        if (!Keys.IsInitialized) return false;
        foreach (global::Akka.DistributedData.Messages.ORMap.Types.Entry element in EntriesList) {
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
        if (hasKeys) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Keys);
        }
        foreach (global::Akka.DistributedData.Messages.ORMap.Types.Entry element in EntriesList) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public global::Akka.DistributedData.Messages.ORMap.Types.Entry GetEntries(int index) {
      return entries_[index];
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _oRMapFieldNames;
      if (hasKeys) {
        output.WriteMessage(1, field_names[1], Keys);
      }
      if (entries_.Count > 0) {
        output.WriteMessageArray(2, field_names[0], entries_);
      }
      UnknownFields.WriteTo(output);
    }

      public static ORMap ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static ORMap ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static ORMap ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static ORMap ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static ORMap ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static ORMap ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static ORMap ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static ORMap ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static ORMap ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static ORMap ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private ORMap MakeReadOnly() {
      entries_.MakeReadOnly();
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(ORMap prototype) {
      return new Builder(prototype);
    }

      #region Nested types

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class Entry : pb::GeneratedMessage<Entry, Entry.Builder> {
          public const int KeyFieldNumber = 1;

          public const int ValueFieldNumber = 2;
          private static readonly Entry defaultInstance = new Entry().MakeReadOnly();
          private static readonly string[] _entryFieldNames = new string[] { "key", "value" };
          private static readonly uint[] _entryFieldTags = new uint[] { 10, 18 };
          private bool hasKey;
          private bool hasValue;
          private string key_ = "";

          private int memoizedSerializedSize = -1;
          private global::Akka.DistributedData.Messages.OtherMessage value_;

          static Entry() {
          object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
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
          get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_ORMap_Entry__Descriptor; }
        }

          protected override pb::FieldAccess.FieldAccessorTable<Entry, Entry.Builder> InternalFieldAccessors {
          get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_ORMap_Entry__FieldAccessorTable; }
        }

          public bool HasKey {
          get { return hasKey; }
        }

          public string Key {
          get { return key_; }
        }

          public bool HasValue {
          get { return hasValue; }
        }

          public global::Akka.DistributedData.Messages.OtherMessage Value {
          get { return value_ ?? global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance; }
        }

          public override bool IsInitialized {
          get {
            if (!hasKey) return false;
            if (!hasValue) return false;
            if (!Value.IsInitialized) return false;
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
            if (hasValue) {
              size += pb::CodedOutputStream.ComputeMessageSize(2, Value);
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
            output.WriteString(1, field_names[0], Key);
          }
          if (hasValue) {
            output.WriteMessage(2, field_names[1], Value);
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
            get { return global::Akka.DistributedData.Messages.ORMap.Types.Entry.Descriptor; }
          }

            public override Entry DefaultInstanceForType {
            get { return global::Akka.DistributedData.Messages.ORMap.Types.Entry.DefaultInstance; }
          }


            public bool HasKey {
            get { return result.hasKey; }
          }

            public string Key {
            get { return result.Key; }
            set { SetKey(value); }
          }

            public bool HasValue {
           get { return result.hasValue; }
          }

            public global::Akka.DistributedData.Messages.OtherMessage Value {
            get { return result.Value; }
            set { SetValue(value); }
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
            if (other == global::Akka.DistributedData.Messages.ORMap.Types.Entry.DefaultInstance) return this;
            PrepareBuilder();
            if (other.HasKey) {
              Key = other.Key;
            }
            if (other.HasValue) {
              MergeValue(other.Value);
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
                  global::Akka.DistributedData.Messages.OtherMessage.Builder subBuilder = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder();
                  if (result.hasValue) {
                    subBuilder.MergeFrom(Value);
                  }
                  input.ReadMessage(subBuilder, extensionRegistry);
                  Value = subBuilder.BuildPartial();
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

            public Builder SetValue(global::Akka.DistributedData.Messages.OtherMessage value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.hasValue = true;
            result.value_ = value;
            return this;
          }

            public Builder SetValue(global::Akka.DistributedData.Messages.OtherMessage.Builder builderForValue) {
            pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
            PrepareBuilder();
            result.hasValue = true;
            result.value_ = builderForValue.Build();
            return this;
          }

            public Builder MergeValue(global::Akka.DistributedData.Messages.OtherMessage value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            if (result.hasValue &&
                result.value_ != global::Akka.DistributedData.Messages.OtherMessage.DefaultInstance) {
                result.value_ = global::Akka.DistributedData.Messages.OtherMessage.CreateBuilder(result.value_).MergeFrom(value).BuildPartial();
            } else {
              result.value_ = value;
            }
            result.hasValue = true;
            return this;
          }

            public Builder ClearValue() {
            PrepareBuilder();
            result.hasValue = false;
            result.value_ = null;
            return this;
          }
        }
      }
    }

      #endregion

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<ORMap, Builder> {
        private ORMap result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(ORMap cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override ORMap MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.ORMap.Descriptor; }
      }

        public override ORMap DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.ORMap.DefaultInstance; }
      }


        public bool HasKeys {
       get { return result.hasKeys; }
      }

        public global::Akka.DistributedData.Messages.ORSet Keys {
        get { return result.Keys; }
        set { SetKeys(value); }
      }

        public pbc::IPopsicleList<global::Akka.DistributedData.Messages.ORMap.Types.Entry> EntriesList {
        get { return PrepareBuilder().entries_; }
      }

        public int EntriesCount {
        get { return result.EntriesCount; }
      }

        private ORMap PrepareBuilder() {
        if (resultIsReadOnly) {
          ORMap original = result;
          result = new ORMap();
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

        public override ORMap BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is ORMap) {
          return MergeFrom((ORMap) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(ORMap other) {
        if (other == global::Akka.DistributedData.Messages.ORMap.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasKeys) {
          MergeKeys(other.Keys);
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
            int field_ordinal = global::System.Array.BinarySearch(_oRMapFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _oRMapFieldTags[field_ordinal];
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
              global::Akka.DistributedData.Messages.ORSet.Builder subBuilder = global::Akka.DistributedData.Messages.ORSet.CreateBuilder();
              if (result.hasKeys) {
                subBuilder.MergeFrom(Keys);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Keys = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              input.ReadMessageArray(tag, field_name, result.entries_, global::Akka.DistributedData.Messages.ORMap.Types.Entry.DefaultInstance, extensionRegistry);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetKeys(global::Akka.DistributedData.Messages.ORSet value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasKeys = true;
        result.keys_ = value;
        return this;
      }

        public Builder SetKeys(global::Akka.DistributedData.Messages.ORSet.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasKeys = true;
        result.keys_ = builderForValue.Build();
        return this;
      }

        public Builder MergeKeys(global::Akka.DistributedData.Messages.ORSet value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasKeys &&
            result.keys_ != global::Akka.DistributedData.Messages.ORSet.DefaultInstance) {
            result.keys_ = global::Akka.DistributedData.Messages.ORSet.CreateBuilder(result.keys_).MergeFrom(value).BuildPartial();
        } else {
          result.keys_ = value;
        }
        result.hasKeys = true;
        return this;
      }

        public Builder ClearKeys() {
        PrepareBuilder();
        result.hasKeys = false;
        result.keys_ = null;
        return this;
      }

        public global::Akka.DistributedData.Messages.ORMap.Types.Entry GetEntries(int index) {
        return result.GetEntries(index);
      }

        public Builder SetEntries(int index, global::Akka.DistributedData.Messages.ORMap.Types.Entry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.entries_[index] = value;
        return this;
      }

        public Builder SetEntries(int index, global::Akka.DistributedData.Messages.ORMap.Types.Entry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.entries_[index] = builderForValue.Build();
        return this;
      }

        public Builder AddEntries(global::Akka.DistributedData.Messages.ORMap.Types.Entry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.entries_.Add(value);
        return this;
      }

        public Builder AddEntries(global::Akka.DistributedData.Messages.ORMap.Types.Entry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.entries_.Add(builderForValue.Build());
        return this;
      }

        public Builder AddRangeEntries(scg::IEnumerable<global::Akka.DistributedData.Messages.ORMap.Types.Entry> values) {
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
  public sealed partial class LWWMap : pb::GeneratedMessage<LWWMap, LWWMap.Builder> {
      public const int KeysFieldNumber = 1;

      public const int EntriesFieldNumber = 2;
      private static readonly LWWMap defaultInstance = new LWWMap().MakeReadOnly();
      private static readonly string[] _lWWMapFieldNames = new string[] { "entries", "keys" };
      private static readonly uint[] _lWWMapFieldTags = new uint[] { 18, 10 };
      private pbc::PopsicleList<global::Akka.DistributedData.Messages.LWWMap.Types.Entry> entries_ = new pbc::PopsicleList<global::Akka.DistributedData.Messages.LWWMap.Types.Entry>();
      private bool hasKeys;
      private global::Akka.DistributedData.Messages.ORSet keys_;

      private int memoizedSerializedSize = -1;

      static LWWMap() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
    }

      private LWWMap() { }

      public static LWWMap DefaultInstance {
      get { return defaultInstance; }
    }

      public override LWWMap DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override LWWMap ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_LWWMap__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<LWWMap, LWWMap.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_LWWMap__FieldAccessorTable; }
    }

      public bool HasKeys {
      get { return hasKeys; }
    }

      public global::Akka.DistributedData.Messages.ORSet Keys {
      get { return keys_ ?? global::Akka.DistributedData.Messages.ORSet.DefaultInstance; }
    }

      public scg::IList<global::Akka.DistributedData.Messages.LWWMap.Types.Entry> EntriesList {
      get { return entries_; }
    }

      public int EntriesCount {
      get { return entries_.Count; }
    }

      public override bool IsInitialized {
      get {
        if (!hasKeys) return false;
        if (!Keys.IsInitialized) return false;
        foreach (global::Akka.DistributedData.Messages.LWWMap.Types.Entry element in EntriesList) {
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
        if (hasKeys) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Keys);
        }
        foreach (global::Akka.DistributedData.Messages.LWWMap.Types.Entry element in EntriesList) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public global::Akka.DistributedData.Messages.LWWMap.Types.Entry GetEntries(int index) {
      return entries_[index];
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _lWWMapFieldNames;
      if (hasKeys) {
        output.WriteMessage(1, field_names[1], Keys);
      }
      if (entries_.Count > 0) {
        output.WriteMessageArray(2, field_names[0], entries_);
      }
      UnknownFields.WriteTo(output);
    }

      public static LWWMap ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static LWWMap ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static LWWMap ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static LWWMap ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static LWWMap ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static LWWMap ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static LWWMap ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static LWWMap ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static LWWMap ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static LWWMap ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private LWWMap MakeReadOnly() {
      entries_.MakeReadOnly();
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(LWWMap prototype) {
      return new Builder(prototype);
    }

      #region Nested types

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class Entry : pb::GeneratedMessage<Entry, Entry.Builder> {
          public const int KeyFieldNumber = 1;

          public const int ValueFieldNumber = 2;
          private static readonly Entry defaultInstance = new Entry().MakeReadOnly();
          private static readonly string[] _entryFieldNames = new string[] { "key", "value" };
          private static readonly uint[] _entryFieldTags = new uint[] { 10, 18 };
          private bool hasKey;
          private bool hasValue;
          private string key_ = "";

          private int memoizedSerializedSize = -1;
          private global::Akka.DistributedData.Messages.LWWRegister value_;

          static Entry() {
          object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
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
          get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_LWWMap_Entry__Descriptor; }
        }

          protected override pb::FieldAccess.FieldAccessorTable<Entry, Entry.Builder> InternalFieldAccessors {
          get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_LWWMap_Entry__FieldAccessorTable; }
        }

          public bool HasKey {
          get { return hasKey; }
        }

          public string Key {
          get { return key_; }
        }

          public bool HasValue {
          get { return hasValue; }
        }

          public global::Akka.DistributedData.Messages.LWWRegister Value {
          get { return value_ ?? global::Akka.DistributedData.Messages.LWWRegister.DefaultInstance; }
        }

          public override bool IsInitialized {
          get {
            if (!hasKey) return false;
            if (!hasValue) return false;
            if (!Value.IsInitialized) return false;
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
            if (hasValue) {
              size += pb::CodedOutputStream.ComputeMessageSize(2, Value);
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
            output.WriteString(1, field_names[0], Key);
          }
          if (hasValue) {
            output.WriteMessage(2, field_names[1], Value);
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
            get { return global::Akka.DistributedData.Messages.LWWMap.Types.Entry.Descriptor; }
          }

            public override Entry DefaultInstanceForType {
            get { return global::Akka.DistributedData.Messages.LWWMap.Types.Entry.DefaultInstance; }
          }


            public bool HasKey {
            get { return result.hasKey; }
          }

            public string Key {
            get { return result.Key; }
            set { SetKey(value); }
          }

            public bool HasValue {
           get { return result.hasValue; }
          }

            public global::Akka.DistributedData.Messages.LWWRegister Value {
            get { return result.Value; }
            set { SetValue(value); }
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
            if (other == global::Akka.DistributedData.Messages.LWWMap.Types.Entry.DefaultInstance) return this;
            PrepareBuilder();
            if (other.HasKey) {
              Key = other.Key;
            }
            if (other.HasValue) {
              MergeValue(other.Value);
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
                  global::Akka.DistributedData.Messages.LWWRegister.Builder subBuilder = global::Akka.DistributedData.Messages.LWWRegister.CreateBuilder();
                  if (result.hasValue) {
                    subBuilder.MergeFrom(Value);
                  }
                  input.ReadMessage(subBuilder, extensionRegistry);
                  Value = subBuilder.BuildPartial();
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

            public Builder SetValue(global::Akka.DistributedData.Messages.LWWRegister value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.hasValue = true;
            result.value_ = value;
            return this;
          }

            public Builder SetValue(global::Akka.DistributedData.Messages.LWWRegister.Builder builderForValue) {
            pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
            PrepareBuilder();
            result.hasValue = true;
            result.value_ = builderForValue.Build();
            return this;
          }

            public Builder MergeValue(global::Akka.DistributedData.Messages.LWWRegister value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            if (result.hasValue &&
                result.value_ != global::Akka.DistributedData.Messages.LWWRegister.DefaultInstance) {
                result.value_ = global::Akka.DistributedData.Messages.LWWRegister.CreateBuilder(result.value_).MergeFrom(value).BuildPartial();
            } else {
              result.value_ = value;
            }
            result.hasValue = true;
            return this;
          }

            public Builder ClearValue() {
            PrepareBuilder();
            result.hasValue = false;
            result.value_ = null;
            return this;
          }
        }
      }
    }

      #endregion

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<LWWMap, Builder> {
        private LWWMap result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(LWWMap cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override LWWMap MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.LWWMap.Descriptor; }
      }

        public override LWWMap DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.LWWMap.DefaultInstance; }
      }


        public bool HasKeys {
       get { return result.hasKeys; }
      }

        public global::Akka.DistributedData.Messages.ORSet Keys {
        get { return result.Keys; }
        set { SetKeys(value); }
      }

        public pbc::IPopsicleList<global::Akka.DistributedData.Messages.LWWMap.Types.Entry> EntriesList {
        get { return PrepareBuilder().entries_; }
      }

        public int EntriesCount {
        get { return result.EntriesCount; }
      }

        private LWWMap PrepareBuilder() {
        if (resultIsReadOnly) {
          LWWMap original = result;
          result = new LWWMap();
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

        public override LWWMap BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is LWWMap) {
          return MergeFrom((LWWMap) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(LWWMap other) {
        if (other == global::Akka.DistributedData.Messages.LWWMap.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasKeys) {
          MergeKeys(other.Keys);
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
            int field_ordinal = global::System.Array.BinarySearch(_lWWMapFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _lWWMapFieldTags[field_ordinal];
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
              global::Akka.DistributedData.Messages.ORSet.Builder subBuilder = global::Akka.DistributedData.Messages.ORSet.CreateBuilder();
              if (result.hasKeys) {
                subBuilder.MergeFrom(Keys);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Keys = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              input.ReadMessageArray(tag, field_name, result.entries_, global::Akka.DistributedData.Messages.LWWMap.Types.Entry.DefaultInstance, extensionRegistry);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetKeys(global::Akka.DistributedData.Messages.ORSet value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasKeys = true;
        result.keys_ = value;
        return this;
      }

        public Builder SetKeys(global::Akka.DistributedData.Messages.ORSet.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasKeys = true;
        result.keys_ = builderForValue.Build();
        return this;
      }

        public Builder MergeKeys(global::Akka.DistributedData.Messages.ORSet value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasKeys &&
            result.keys_ != global::Akka.DistributedData.Messages.ORSet.DefaultInstance) {
            result.keys_ = global::Akka.DistributedData.Messages.ORSet.CreateBuilder(result.keys_).MergeFrom(value).BuildPartial();
        } else {
          result.keys_ = value;
        }
        result.hasKeys = true;
        return this;
      }

        public Builder ClearKeys() {
        PrepareBuilder();
        result.hasKeys = false;
        result.keys_ = null;
        return this;
      }

        public global::Akka.DistributedData.Messages.LWWMap.Types.Entry GetEntries(int index) {
        return result.GetEntries(index);
      }

        public Builder SetEntries(int index, global::Akka.DistributedData.Messages.LWWMap.Types.Entry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.entries_[index] = value;
        return this;
      }

        public Builder SetEntries(int index, global::Akka.DistributedData.Messages.LWWMap.Types.Entry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.entries_[index] = builderForValue.Build();
        return this;
      }

        public Builder AddEntries(global::Akka.DistributedData.Messages.LWWMap.Types.Entry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.entries_.Add(value);
        return this;
      }

        public Builder AddEntries(global::Akka.DistributedData.Messages.LWWMap.Types.Entry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.entries_.Add(builderForValue.Build());
        return this;
      }

        public Builder AddRangeEntries(scg::IEnumerable<global::Akka.DistributedData.Messages.LWWMap.Types.Entry> values) {
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
  public sealed partial class PNCounterMap : pb::GeneratedMessage<PNCounterMap, PNCounterMap.Builder> {
      public const int KeysFieldNumber = 1;

      public const int EntriesFieldNumber = 2;
      private static readonly PNCounterMap defaultInstance = new PNCounterMap().MakeReadOnly();
      private static readonly string[] _pNCounterMapFieldNames = new string[] { "entries", "keys" };
      private static readonly uint[] _pNCounterMapFieldTags = new uint[] { 18, 10 };
      private pbc::PopsicleList<global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry> entries_ = new pbc::PopsicleList<global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry>();
      private bool hasKeys;
      private global::Akka.DistributedData.Messages.ORSet keys_;

      private int memoizedSerializedSize = -1;

      static PNCounterMap() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
    }

      private PNCounterMap() { }

      public static PNCounterMap DefaultInstance {
      get { return defaultInstance; }
    }

      public override PNCounterMap DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override PNCounterMap ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_PNCounterMap__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<PNCounterMap, PNCounterMap.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_PNCounterMap__FieldAccessorTable; }
    }

      public bool HasKeys {
      get { return hasKeys; }
    }

      public global::Akka.DistributedData.Messages.ORSet Keys {
      get { return keys_ ?? global::Akka.DistributedData.Messages.ORSet.DefaultInstance; }
    }

      public scg::IList<global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry> EntriesList {
      get { return entries_; }
    }

      public int EntriesCount {
      get { return entries_.Count; }
    }

      public override bool IsInitialized {
      get {
        if (!hasKeys) return false;
        if (!Keys.IsInitialized) return false;
        foreach (global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry element in EntriesList) {
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
        if (hasKeys) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Keys);
        }
        foreach (global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry element in EntriesList) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry GetEntries(int index) {
      return entries_[index];
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _pNCounterMapFieldNames;
      if (hasKeys) {
        output.WriteMessage(1, field_names[1], Keys);
      }
      if (entries_.Count > 0) {
        output.WriteMessageArray(2, field_names[0], entries_);
      }
      UnknownFields.WriteTo(output);
    }

      public static PNCounterMap ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static PNCounterMap ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static PNCounterMap ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static PNCounterMap ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static PNCounterMap ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static PNCounterMap ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static PNCounterMap ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static PNCounterMap ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static PNCounterMap ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static PNCounterMap ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private PNCounterMap MakeReadOnly() {
      entries_.MakeReadOnly();
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(PNCounterMap prototype) {
      return new Builder(prototype);
    }

      #region Nested types

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class Entry : pb::GeneratedMessage<Entry, Entry.Builder> {
          public const int KeyFieldNumber = 1;

          public const int ValueFieldNumber = 2;
          private static readonly Entry defaultInstance = new Entry().MakeReadOnly();
          private static readonly string[] _entryFieldNames = new string[] { "key", "value" };
          private static readonly uint[] _entryFieldTags = new uint[] { 10, 18 };
          private bool hasKey;
          private bool hasValue;
          private string key_ = "";

          private int memoizedSerializedSize = -1;
          private global::Akka.DistributedData.Messages.PNCounter value_;

          static Entry() {
          object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
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
          get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_PNCounterMap_Entry__Descriptor; }
        }

          protected override pb::FieldAccess.FieldAccessorTable<Entry, Entry.Builder> InternalFieldAccessors {
          get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_PNCounterMap_Entry__FieldAccessorTable; }
        }

          public bool HasKey {
          get { return hasKey; }
        }

          public string Key {
          get { return key_; }
        }

          public bool HasValue {
          get { return hasValue; }
        }

          public global::Akka.DistributedData.Messages.PNCounter Value {
          get { return value_ ?? global::Akka.DistributedData.Messages.PNCounter.DefaultInstance; }
        }

          public override bool IsInitialized {
          get {
            if (!hasKey) return false;
            if (!hasValue) return false;
            if (!Value.IsInitialized) return false;
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
            if (hasValue) {
              size += pb::CodedOutputStream.ComputeMessageSize(2, Value);
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
            output.WriteString(1, field_names[0], Key);
          }
          if (hasValue) {
            output.WriteMessage(2, field_names[1], Value);
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
            get { return global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry.Descriptor; }
          }

            public override Entry DefaultInstanceForType {
            get { return global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry.DefaultInstance; }
          }


            public bool HasKey {
            get { return result.hasKey; }
          }

            public string Key {
            get { return result.Key; }
            set { SetKey(value); }
          }

            public bool HasValue {
           get { return result.hasValue; }
          }

            public global::Akka.DistributedData.Messages.PNCounter Value {
            get { return result.Value; }
            set { SetValue(value); }
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
            if (other == global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry.DefaultInstance) return this;
            PrepareBuilder();
            if (other.HasKey) {
              Key = other.Key;
            }
            if (other.HasValue) {
              MergeValue(other.Value);
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
                  global::Akka.DistributedData.Messages.PNCounter.Builder subBuilder = global::Akka.DistributedData.Messages.PNCounter.CreateBuilder();
                  if (result.hasValue) {
                    subBuilder.MergeFrom(Value);
                  }
                  input.ReadMessage(subBuilder, extensionRegistry);
                  Value = subBuilder.BuildPartial();
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

            public Builder SetValue(global::Akka.DistributedData.Messages.PNCounter value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.hasValue = true;
            result.value_ = value;
            return this;
          }

            public Builder SetValue(global::Akka.DistributedData.Messages.PNCounter.Builder builderForValue) {
            pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
            PrepareBuilder();
            result.hasValue = true;
            result.value_ = builderForValue.Build();
            return this;
          }

            public Builder MergeValue(global::Akka.DistributedData.Messages.PNCounter value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            if (result.hasValue &&
                result.value_ != global::Akka.DistributedData.Messages.PNCounter.DefaultInstance) {
                result.value_ = global::Akka.DistributedData.Messages.PNCounter.CreateBuilder(result.value_).MergeFrom(value).BuildPartial();
            } else {
              result.value_ = value;
            }
            result.hasValue = true;
            return this;
          }

            public Builder ClearValue() {
            PrepareBuilder();
            result.hasValue = false;
            result.value_ = null;
            return this;
          }
        }
      }
    }

      #endregion

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<PNCounterMap, Builder> {
        private PNCounterMap result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(PNCounterMap cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override PNCounterMap MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.PNCounterMap.Descriptor; }
      }

        public override PNCounterMap DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.PNCounterMap.DefaultInstance; }
      }


        public bool HasKeys {
       get { return result.hasKeys; }
      }

        public global::Akka.DistributedData.Messages.ORSet Keys {
        get { return result.Keys; }
        set { SetKeys(value); }
      }

        public pbc::IPopsicleList<global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry> EntriesList {
        get { return PrepareBuilder().entries_; }
      }

        public int EntriesCount {
        get { return result.EntriesCount; }
      }

        private PNCounterMap PrepareBuilder() {
        if (resultIsReadOnly) {
          PNCounterMap original = result;
          result = new PNCounterMap();
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

        public override PNCounterMap BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is PNCounterMap) {
          return MergeFrom((PNCounterMap) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(PNCounterMap other) {
        if (other == global::Akka.DistributedData.Messages.PNCounterMap.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasKeys) {
          MergeKeys(other.Keys);
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
            int field_ordinal = global::System.Array.BinarySearch(_pNCounterMapFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _pNCounterMapFieldTags[field_ordinal];
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
              global::Akka.DistributedData.Messages.ORSet.Builder subBuilder = global::Akka.DistributedData.Messages.ORSet.CreateBuilder();
              if (result.hasKeys) {
                subBuilder.MergeFrom(Keys);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Keys = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              input.ReadMessageArray(tag, field_name, result.entries_, global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry.DefaultInstance, extensionRegistry);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetKeys(global::Akka.DistributedData.Messages.ORSet value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasKeys = true;
        result.keys_ = value;
        return this;
      }

        public Builder SetKeys(global::Akka.DistributedData.Messages.ORSet.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasKeys = true;
        result.keys_ = builderForValue.Build();
        return this;
      }

        public Builder MergeKeys(global::Akka.DistributedData.Messages.ORSet value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasKeys &&
            result.keys_ != global::Akka.DistributedData.Messages.ORSet.DefaultInstance) {
            result.keys_ = global::Akka.DistributedData.Messages.ORSet.CreateBuilder(result.keys_).MergeFrom(value).BuildPartial();
        } else {
          result.keys_ = value;
        }
        result.hasKeys = true;
        return this;
      }

        public Builder ClearKeys() {
        PrepareBuilder();
        result.hasKeys = false;
        result.keys_ = null;
        return this;
      }

        public global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry GetEntries(int index) {
        return result.GetEntries(index);
      }

        public Builder SetEntries(int index, global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.entries_[index] = value;
        return this;
      }

        public Builder SetEntries(int index, global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.entries_[index] = builderForValue.Build();
        return this;
      }

        public Builder AddEntries(global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.entries_.Add(value);
        return this;
      }

        public Builder AddEntries(global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.entries_.Add(builderForValue.Build());
        return this;
      }

        public Builder AddRangeEntries(scg::IEnumerable<global::Akka.DistributedData.Messages.PNCounterMap.Types.Entry> values) {
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
  public sealed partial class ORMultiMap : pb::GeneratedMessage<ORMultiMap, ORMultiMap.Builder> {
      public const int KeysFieldNumber = 1;

      public const int EntriesFieldNumber = 2;
      private static readonly ORMultiMap defaultInstance = new ORMultiMap().MakeReadOnly();
      private static readonly string[] _oRMultiMapFieldNames = new string[] { "entries", "keys" };
      private static readonly uint[] _oRMultiMapFieldTags = new uint[] { 18, 10 };
      private pbc::PopsicleList<global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry> entries_ = new pbc::PopsicleList<global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry>();
      private bool hasKeys;
      private global::Akka.DistributedData.Messages.ORSet keys_;

      private int memoizedSerializedSize = -1;

      static ORMultiMap() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
    }

      private ORMultiMap() { }

      public static ORMultiMap DefaultInstance {
      get { return defaultInstance; }
    }

      public override ORMultiMap DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override ORMultiMap ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_ORMultiMap__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<ORMultiMap, ORMultiMap.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_ORMultiMap__FieldAccessorTable; }
    }

      public bool HasKeys {
      get { return hasKeys; }
    }

      public global::Akka.DistributedData.Messages.ORSet Keys {
      get { return keys_ ?? global::Akka.DistributedData.Messages.ORSet.DefaultInstance; }
    }

      public scg::IList<global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry> EntriesList {
      get { return entries_; }
    }

      public int EntriesCount {
      get { return entries_.Count; }
    }

      public override bool IsInitialized {
      get {
        if (!hasKeys) return false;
        if (!Keys.IsInitialized) return false;
        foreach (global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry element in EntriesList) {
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
        if (hasKeys) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Keys);
        }
        foreach (global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry element in EntriesList) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry GetEntries(int index) {
      return entries_[index];
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _oRMultiMapFieldNames;
      if (hasKeys) {
        output.WriteMessage(1, field_names[1], Keys);
      }
      if (entries_.Count > 0) {
        output.WriteMessageArray(2, field_names[0], entries_);
      }
      UnknownFields.WriteTo(output);
    }

      public static ORMultiMap ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static ORMultiMap ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static ORMultiMap ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static ORMultiMap ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static ORMultiMap ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static ORMultiMap ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static ORMultiMap ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static ORMultiMap ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static ORMultiMap ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static ORMultiMap ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private ORMultiMap MakeReadOnly() {
      entries_.MakeReadOnly();
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(ORMultiMap prototype) {
      return new Builder(prototype);
    }

      #region Nested types

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class Entry : pb::GeneratedMessage<Entry, Entry.Builder> {
          public const int KeyFieldNumber = 1;

          public const int ValueFieldNumber = 2;
          private static readonly Entry defaultInstance = new Entry().MakeReadOnly();
          private static readonly string[] _entryFieldNames = new string[] { "key", "value" };
          private static readonly uint[] _entryFieldTags = new uint[] { 10, 18 };
          private bool hasKey;
          private bool hasValue;
          private string key_ = "";

          private int memoizedSerializedSize = -1;
          private global::Akka.DistributedData.Messages.ORSet value_;

          static Entry() {
          object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
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
          get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_ORMultiMap_Entry__Descriptor; }
        }

          protected override pb::FieldAccess.FieldAccessorTable<Entry, Entry.Builder> InternalFieldAccessors {
          get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_ORMultiMap_Entry__FieldAccessorTable; }
        }

          public bool HasKey {
          get { return hasKey; }
        }

          public string Key {
          get { return key_; }
        }

          public bool HasValue {
          get { return hasValue; }
        }

          public global::Akka.DistributedData.Messages.ORSet Value {
          get { return value_ ?? global::Akka.DistributedData.Messages.ORSet.DefaultInstance; }
        }

          public override bool IsInitialized {
          get {
            if (!hasKey) return false;
            if (!hasValue) return false;
            if (!Value.IsInitialized) return false;
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
            if (hasValue) {
              size += pb::CodedOutputStream.ComputeMessageSize(2, Value);
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
            output.WriteString(1, field_names[0], Key);
          }
          if (hasValue) {
            output.WriteMessage(2, field_names[1], Value);
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
            get { return global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry.Descriptor; }
          }

            public override Entry DefaultInstanceForType {
            get { return global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry.DefaultInstance; }
          }


            public bool HasKey {
            get { return result.hasKey; }
          }

            public string Key {
            get { return result.Key; }
            set { SetKey(value); }
          }

            public bool HasValue {
           get { return result.hasValue; }
          }

            public global::Akka.DistributedData.Messages.ORSet Value {
            get { return result.Value; }
            set { SetValue(value); }
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
            if (other == global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry.DefaultInstance) return this;
            PrepareBuilder();
            if (other.HasKey) {
              Key = other.Key;
            }
            if (other.HasValue) {
              MergeValue(other.Value);
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
                  global::Akka.DistributedData.Messages.ORSet.Builder subBuilder = global::Akka.DistributedData.Messages.ORSet.CreateBuilder();
                  if (result.hasValue) {
                    subBuilder.MergeFrom(Value);
                  }
                  input.ReadMessage(subBuilder, extensionRegistry);
                  Value = subBuilder.BuildPartial();
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

            public Builder SetValue(global::Akka.DistributedData.Messages.ORSet value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.hasValue = true;
            result.value_ = value;
            return this;
          }

            public Builder SetValue(global::Akka.DistributedData.Messages.ORSet.Builder builderForValue) {
            pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
            PrepareBuilder();
            result.hasValue = true;
            result.value_ = builderForValue.Build();
            return this;
          }

            public Builder MergeValue(global::Akka.DistributedData.Messages.ORSet value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            if (result.hasValue &&
                result.value_ != global::Akka.DistributedData.Messages.ORSet.DefaultInstance) {
                result.value_ = global::Akka.DistributedData.Messages.ORSet.CreateBuilder(result.value_).MergeFrom(value).BuildPartial();
            } else {
              result.value_ = value;
            }
            result.hasValue = true;
            return this;
          }

            public Builder ClearValue() {
            PrepareBuilder();
            result.hasValue = false;
            result.value_ = null;
            return this;
          }
        }
      }
    }

      #endregion

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<ORMultiMap, Builder> {
        private ORMultiMap result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(ORMultiMap cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override ORMultiMap MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.ORMultiMap.Descriptor; }
      }

        public override ORMultiMap DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.ORMultiMap.DefaultInstance; }
      }


        public bool HasKeys {
       get { return result.hasKeys; }
      }

        public global::Akka.DistributedData.Messages.ORSet Keys {
        get { return result.Keys; }
        set { SetKeys(value); }
      }

        public pbc::IPopsicleList<global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry> EntriesList {
        get { return PrepareBuilder().entries_; }
      }

        public int EntriesCount {
        get { return result.EntriesCount; }
      }

        private ORMultiMap PrepareBuilder() {
        if (resultIsReadOnly) {
          ORMultiMap original = result;
          result = new ORMultiMap();
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

        public override ORMultiMap BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is ORMultiMap) {
          return MergeFrom((ORMultiMap) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(ORMultiMap other) {
        if (other == global::Akka.DistributedData.Messages.ORMultiMap.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasKeys) {
          MergeKeys(other.Keys);
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
            int field_ordinal = global::System.Array.BinarySearch(_oRMultiMapFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _oRMultiMapFieldTags[field_ordinal];
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
              global::Akka.DistributedData.Messages.ORSet.Builder subBuilder = global::Akka.DistributedData.Messages.ORSet.CreateBuilder();
              if (result.hasKeys) {
                subBuilder.MergeFrom(Keys);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Keys = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              input.ReadMessageArray(tag, field_name, result.entries_, global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry.DefaultInstance, extensionRegistry);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetKeys(global::Akka.DistributedData.Messages.ORSet value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasKeys = true;
        result.keys_ = value;
        return this;
      }

        public Builder SetKeys(global::Akka.DistributedData.Messages.ORSet.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasKeys = true;
        result.keys_ = builderForValue.Build();
        return this;
      }

        public Builder MergeKeys(global::Akka.DistributedData.Messages.ORSet value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasKeys &&
            result.keys_ != global::Akka.DistributedData.Messages.ORSet.DefaultInstance) {
            result.keys_ = global::Akka.DistributedData.Messages.ORSet.CreateBuilder(result.keys_).MergeFrom(value).BuildPartial();
        } else {
          result.keys_ = value;
        }
        result.hasKeys = true;
        return this;
      }

        public Builder ClearKeys() {
        PrepareBuilder();
        result.hasKeys = false;
        result.keys_ = null;
        return this;
      }

        public global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry GetEntries(int index) {
        return result.GetEntries(index);
      }

        public Builder SetEntries(int index, global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.entries_[index] = value;
        return this;
      }

        public Builder SetEntries(int index, global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.entries_[index] = builderForValue.Build();
        return this;
      }

        public Builder AddEntries(global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.entries_.Add(value);
        return this;
      }

        public Builder AddEntries(global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.entries_.Add(builderForValue.Build());
        return this;
      }

        public Builder AddRangeEntries(scg::IEnumerable<global::Akka.DistributedData.Messages.ORMultiMap.Types.Entry> values) {
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
  public sealed partial class GenericKey : pb::GeneratedMessage<GenericKey, GenericKey.Builder> {
      public const int IdFieldNumber = 1;

      public const int TypehintFieldNumber = 2;
      private static readonly GenericKey defaultInstance = new GenericKey().MakeReadOnly();
      private static readonly string[] _genericKeyFieldNames = new string[] { "id", "typehint" };
      private static readonly uint[] _genericKeyFieldTags = new uint[] { 10, 18 };
      private bool hasId;
      private bool hasTypehint;
      private pb::ByteString id_ = pb::ByteString.Empty;

      private int memoizedSerializedSize = -1;
      private pb::ByteString typehint_ = pb::ByteString.Empty;

      static GenericKey() {
      object.ReferenceEquals(global::Akka.DistributedData.Messages.ReplicatedDataMessages.Descriptor, null);
    }

      private GenericKey() { }

      public static GenericKey DefaultInstance {
      get { return defaultInstance; }
    }

      public override GenericKey DefaultInstanceForType {
      get { return DefaultInstance; }
    }

      protected override GenericKey ThisMessage {
      get { return this; }
    }

      public static pbd::MessageDescriptor Descriptor {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_GenericKey__Descriptor; }
    }

      protected override pb::FieldAccess.FieldAccessorTable<GenericKey, GenericKey.Builder> InternalFieldAccessors {
      get { return global::Akka.DistributedData.Messages.ReplicatedDataMessages.internal__static_Akka_DistributedData_Messages_GenericKey__FieldAccessorTable; }
    }

      public bool HasId {
      get { return hasId; }
    }

      public pb::ByteString Id {
      get { return id_; }
    }

      public bool HasTypehint {
      get { return hasTypehint; }
    }

      public pb::ByteString Typehint {
      get { return typehint_; }
    }

      public override bool IsInitialized {
      get {
        if (!hasId) return false;
        if (!hasTypehint) return false;
        return true;
      }
    }

      public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasId) {
          size += pb::CodedOutputStream.ComputeBytesSize(1, Id);
        }
        if (hasTypehint) {
          size += pb::CodedOutputStream.ComputeBytesSize(2, Typehint);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }

      public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _genericKeyFieldNames;
      if (hasId) {
        output.WriteBytes(1, field_names[0], Id);
      }
      if (hasTypehint) {
        output.WriteBytes(2, field_names[1], Typehint);
      }
      UnknownFields.WriteTo(output);
    }

      public static GenericKey ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static GenericKey ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static GenericKey ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }

      public static GenericKey ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }

      public static GenericKey ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static GenericKey ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      public static GenericKey ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

      public static GenericKey ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

      public static GenericKey ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }

      public static GenericKey ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }

      private GenericKey MakeReadOnly() {
      return this;
    }

      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }

      public static Builder CreateBuilder(GenericKey prototype) {
      return new Builder(prototype);
    }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<GenericKey, Builder> {
        private GenericKey result;

        private bool resultIsReadOnly;

        public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }

        internal Builder(GenericKey cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

        protected override Builder ThisBuilder {
        get { return this; }
      }

        public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

        protected override GenericKey MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

        public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Akka.DistributedData.Messages.GenericKey.Descriptor; }
      }

        public override GenericKey DefaultInstanceForType {
        get { return global::Akka.DistributedData.Messages.GenericKey.DefaultInstance; }
      }


        public bool HasId {
        get { return result.hasId; }
      }

        public pb::ByteString Id {
        get { return result.Id; }
        set { SetId(value); }
      }

        public bool HasTypehint {
        get { return result.hasTypehint; }
      }

        public pb::ByteString Typehint {
        get { return result.Typehint; }
        set { SetTypehint(value); }
      }

        private GenericKey PrepareBuilder() {
        if (resultIsReadOnly) {
          GenericKey original = result;
          result = new GenericKey();
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

        public override GenericKey BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

        public override Builder MergeFrom(pb::IMessage other) {
        if (other is GenericKey) {
          return MergeFrom((GenericKey) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

        public override Builder MergeFrom(GenericKey other) {
        if (other == global::Akka.DistributedData.Messages.GenericKey.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasId) {
          Id = other.Id;
        }
        if (other.HasTypehint) {
          Typehint = other.Typehint;
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
            int field_ordinal = global::System.Array.BinarySearch(_genericKeyFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _genericKeyFieldTags[field_ordinal];
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
              result.hasId = input.ReadBytes(ref result.id_);
              break;
            }
            case 18: {
              result.hasTypehint = input.ReadBytes(ref result.typehint_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }

        public Builder SetId(pb::ByteString value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasId = true;
        result.id_ = value;
        return this;
      }

        public Builder ClearId() {
        PrepareBuilder();
        result.hasId = false;
        result.id_ = pb::ByteString.Empty;
        return this;
      }

        public Builder SetTypehint(pb::ByteString value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasTypehint = true;
        result.typehint_ = value;
        return this;
      }

        public Builder ClearTypehint() {
        PrepareBuilder();
        result.hasTypehint = false;
        result.typehint_ = pb::ByteString.Empty;
        return this;
      }
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
