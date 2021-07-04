// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: player.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tech.Takenoko.Grpcspring.Proto {

  /// <summary>Holder for reflection information generated from player.proto</summary>
  public static partial class PlayerReflection {

    #region Descriptor
    /// <summary>File descriptor for player.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxwbGF5ZXIucHJvdG8SHnRlY2gudGFrZW5va28uZ3JwY3NwcmluZy5wcm90",
            "bxoMY29tbW9uLnByb3RvIswBCgtNb3ZlUmVxdWVzdBIMCgR1dWlkGAEgASgJ",
            "EjoKCHBvc2l0aW9uGAIgASgLMigudGVjaC50YWtlbm9rby5ncnBjc3ByaW5n",
            "LnByb3RvLlZlY3RvcjNfEjoKCHJvdGF0aW9uGAMgASgLMigudGVjaC50YWtl",
            "bm9rby5ncnBjc3ByaW5nLnByb3RvLlZlY3RvcjNfEjcKBnN0YXR1cxgEIAEo",
            "CzInLnRlY2gudGFrZW5va28uZ3JwY3NwcmluZy5wcm90by5TdGF0dXNfIgsK",
            "CU1vdmVSZXBseSIeCg5DaGFuZ2VkUmVxdWVzdBIMCgR1dWlkGAEgASgJIs0B",
            "CgxDaGFuZ2VkUmVwbHkSDAoEdXVpZBgBIAEoCRI6Cghwb3NpdGlvbhgCIAEo",
            "CzIoLnRlY2gudGFrZW5va28uZ3JwY3NwcmluZy5wcm90by5WZWN0b3IzXxI6",
            "Cghyb3RhdGlvbhgDIAEoCzIoLnRlY2gudGFrZW5va28uZ3JwY3NwcmluZy5w",
            "cm90by5WZWN0b3IzXxI3CgZzdGF0dXMYBCABKAsyJy50ZWNoLnRha2Vub2tv",
            "LmdycGNzcHJpbmcucHJvdG8uU3RhdHVzXzLTAQoGUGxheWVyEl4KBE1vdmUS",
            "Ky50ZWNoLnRha2Vub2tvLmdycGNzcHJpbmcucHJvdG8uTW92ZVJlcXVlc3Qa",
            "KS50ZWNoLnRha2Vub2tvLmdycGNzcHJpbmcucHJvdG8uTW92ZVJlcGx5EmkK",
            "B0NoYW5nZWQSLi50ZWNoLnRha2Vub2tvLmdycGNzcHJpbmcucHJvdG8uQ2hh",
            "bmdlZFJlcXVlc3QaLC50ZWNoLnRha2Vub2tvLmdycGNzcHJpbmcucHJvdG8u",
            "Q2hhbmdlZFJlcGx5MAFCIAoedGVjaC50YWtlbm9rby5ncnBjc3ByaW5nLnBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tech.Takenoko.Grpcspring.Proto.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tech.Takenoko.Grpcspring.Proto.MoveRequest), global::Tech.Takenoko.Grpcspring.Proto.MoveRequest.Parser, new[]{ "Uuid", "Position", "Rotation", "Status" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tech.Takenoko.Grpcspring.Proto.MoveReply), global::Tech.Takenoko.Grpcspring.Proto.MoveReply.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tech.Takenoko.Grpcspring.Proto.ChangedRequest), global::Tech.Takenoko.Grpcspring.Proto.ChangedRequest.Parser, new[]{ "Uuid" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tech.Takenoko.Grpcspring.Proto.ChangedReply), global::Tech.Takenoko.Grpcspring.Proto.ChangedReply.Parser, new[]{ "Uuid", "Position", "Rotation", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MoveRequest : pb::IMessage<MoveRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MoveRequest> _parser = new pb::MessageParser<MoveRequest>(() => new MoveRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MoveRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tech.Takenoko.Grpcspring.Proto.PlayerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MoveRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MoveRequest(MoveRequest other) : this() {
      uuid_ = other.uuid_;
      position_ = other.position_ != null ? other.position_.Clone() : null;
      rotation_ = other.rotation_ != null ? other.rotation_.Clone() : null;
      status_ = other.status_ != null ? other.status_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MoveRequest Clone() {
      return new MoveRequest(this);
    }

    /// <summary>Field number for the "uuid" field.</summary>
    public const int UuidFieldNumber = 1;
    private string uuid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uuid {
      get { return uuid_; }
      set {
        uuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 2;
    private global::Tech.Takenoko.Grpcspring.Proto.Vector3_ position_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tech.Takenoko.Grpcspring.Proto.Vector3_ Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    /// <summary>Field number for the "rotation" field.</summary>
    public const int RotationFieldNumber = 3;
    private global::Tech.Takenoko.Grpcspring.Proto.Vector3_ rotation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tech.Takenoko.Grpcspring.Proto.Vector3_ Rotation {
      get { return rotation_; }
      set {
        rotation_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Tech.Takenoko.Grpcspring.Proto.Status_ status_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tech.Takenoko.Grpcspring.Proto.Status_ Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MoveRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MoveRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uuid != other.Uuid) return false;
      if (!object.Equals(Position, other.Position)) return false;
      if (!object.Equals(Rotation, other.Rotation)) return false;
      if (!object.Equals(Status, other.Status)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uuid.Length != 0) hash ^= Uuid.GetHashCode();
      if (position_ != null) hash ^= Position.GetHashCode();
      if (rotation_ != null) hash ^= Rotation.GetHashCode();
      if (status_ != null) hash ^= Status.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Uuid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uuid);
      }
      if (position_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Position);
      }
      if (rotation_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Rotation);
      }
      if (status_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Uuid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uuid);
      }
      if (position_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Position);
      }
      if (rotation_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Rotation);
      }
      if (status_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uuid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uuid);
      }
      if (position_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
      }
      if (rotation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rotation);
      }
      if (status_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MoveRequest other) {
      if (other == null) {
        return;
      }
      if (other.Uuid.Length != 0) {
        Uuid = other.Uuid;
      }
      if (other.position_ != null) {
        if (position_ == null) {
          Position = new global::Tech.Takenoko.Grpcspring.Proto.Vector3_();
        }
        Position.MergeFrom(other.Position);
      }
      if (other.rotation_ != null) {
        if (rotation_ == null) {
          Rotation = new global::Tech.Takenoko.Grpcspring.Proto.Vector3_();
        }
        Rotation.MergeFrom(other.Rotation);
      }
      if (other.status_ != null) {
        if (status_ == null) {
          Status = new global::Tech.Takenoko.Grpcspring.Proto.Status_();
        }
        Status.MergeFrom(other.Status);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Uuid = input.ReadString();
            break;
          }
          case 18: {
            if (position_ == null) {
              Position = new global::Tech.Takenoko.Grpcspring.Proto.Vector3_();
            }
            input.ReadMessage(Position);
            break;
          }
          case 26: {
            if (rotation_ == null) {
              Rotation = new global::Tech.Takenoko.Grpcspring.Proto.Vector3_();
            }
            input.ReadMessage(Rotation);
            break;
          }
          case 34: {
            if (status_ == null) {
              Status = new global::Tech.Takenoko.Grpcspring.Proto.Status_();
            }
            input.ReadMessage(Status);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Uuid = input.ReadString();
            break;
          }
          case 18: {
            if (position_ == null) {
              Position = new global::Tech.Takenoko.Grpcspring.Proto.Vector3_();
            }
            input.ReadMessage(Position);
            break;
          }
          case 26: {
            if (rotation_ == null) {
              Rotation = new global::Tech.Takenoko.Grpcspring.Proto.Vector3_();
            }
            input.ReadMessage(Rotation);
            break;
          }
          case 34: {
            if (status_ == null) {
              Status = new global::Tech.Takenoko.Grpcspring.Proto.Status_();
            }
            input.ReadMessage(Status);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class MoveReply : pb::IMessage<MoveReply>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MoveReply> _parser = new pb::MessageParser<MoveReply>(() => new MoveReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MoveReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tech.Takenoko.Grpcspring.Proto.PlayerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MoveReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MoveReply(MoveReply other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MoveReply Clone() {
      return new MoveReply(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MoveReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MoveReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MoveReply other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

  }

  public sealed partial class ChangedRequest : pb::IMessage<ChangedRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChangedRequest> _parser = new pb::MessageParser<ChangedRequest>(() => new ChangedRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChangedRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tech.Takenoko.Grpcspring.Proto.PlayerReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangedRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangedRequest(ChangedRequest other) : this() {
      uuid_ = other.uuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangedRequest Clone() {
      return new ChangedRequest(this);
    }

    /// <summary>Field number for the "uuid" field.</summary>
    public const int UuidFieldNumber = 1;
    private string uuid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uuid {
      get { return uuid_; }
      set {
        uuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChangedRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChangedRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uuid != other.Uuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uuid.Length != 0) hash ^= Uuid.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Uuid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uuid);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Uuid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uuid);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uuid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChangedRequest other) {
      if (other == null) {
        return;
      }
      if (other.Uuid.Length != 0) {
        Uuid = other.Uuid;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Uuid = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Uuid = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ChangedReply : pb::IMessage<ChangedReply>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChangedReply> _parser = new pb::MessageParser<ChangedReply>(() => new ChangedReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChangedReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tech.Takenoko.Grpcspring.Proto.PlayerReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangedReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangedReply(ChangedReply other) : this() {
      uuid_ = other.uuid_;
      position_ = other.position_ != null ? other.position_.Clone() : null;
      rotation_ = other.rotation_ != null ? other.rotation_.Clone() : null;
      status_ = other.status_ != null ? other.status_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangedReply Clone() {
      return new ChangedReply(this);
    }

    /// <summary>Field number for the "uuid" field.</summary>
    public const int UuidFieldNumber = 1;
    private string uuid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uuid {
      get { return uuid_; }
      set {
        uuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 2;
    private global::Tech.Takenoko.Grpcspring.Proto.Vector3_ position_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tech.Takenoko.Grpcspring.Proto.Vector3_ Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    /// <summary>Field number for the "rotation" field.</summary>
    public const int RotationFieldNumber = 3;
    private global::Tech.Takenoko.Grpcspring.Proto.Vector3_ rotation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tech.Takenoko.Grpcspring.Proto.Vector3_ Rotation {
      get { return rotation_; }
      set {
        rotation_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Tech.Takenoko.Grpcspring.Proto.Status_ status_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tech.Takenoko.Grpcspring.Proto.Status_ Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChangedReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChangedReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uuid != other.Uuid) return false;
      if (!object.Equals(Position, other.Position)) return false;
      if (!object.Equals(Rotation, other.Rotation)) return false;
      if (!object.Equals(Status, other.Status)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uuid.Length != 0) hash ^= Uuid.GetHashCode();
      if (position_ != null) hash ^= Position.GetHashCode();
      if (rotation_ != null) hash ^= Rotation.GetHashCode();
      if (status_ != null) hash ^= Status.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Uuid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uuid);
      }
      if (position_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Position);
      }
      if (rotation_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Rotation);
      }
      if (status_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Uuid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uuid);
      }
      if (position_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Position);
      }
      if (rotation_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Rotation);
      }
      if (status_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uuid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uuid);
      }
      if (position_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
      }
      if (rotation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rotation);
      }
      if (status_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChangedReply other) {
      if (other == null) {
        return;
      }
      if (other.Uuid.Length != 0) {
        Uuid = other.Uuid;
      }
      if (other.position_ != null) {
        if (position_ == null) {
          Position = new global::Tech.Takenoko.Grpcspring.Proto.Vector3_();
        }
        Position.MergeFrom(other.Position);
      }
      if (other.rotation_ != null) {
        if (rotation_ == null) {
          Rotation = new global::Tech.Takenoko.Grpcspring.Proto.Vector3_();
        }
        Rotation.MergeFrom(other.Rotation);
      }
      if (other.status_ != null) {
        if (status_ == null) {
          Status = new global::Tech.Takenoko.Grpcspring.Proto.Status_();
        }
        Status.MergeFrom(other.Status);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Uuid = input.ReadString();
            break;
          }
          case 18: {
            if (position_ == null) {
              Position = new global::Tech.Takenoko.Grpcspring.Proto.Vector3_();
            }
            input.ReadMessage(Position);
            break;
          }
          case 26: {
            if (rotation_ == null) {
              Rotation = new global::Tech.Takenoko.Grpcspring.Proto.Vector3_();
            }
            input.ReadMessage(Rotation);
            break;
          }
          case 34: {
            if (status_ == null) {
              Status = new global::Tech.Takenoko.Grpcspring.Proto.Status_();
            }
            input.ReadMessage(Status);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Uuid = input.ReadString();
            break;
          }
          case 18: {
            if (position_ == null) {
              Position = new global::Tech.Takenoko.Grpcspring.Proto.Vector3_();
            }
            input.ReadMessage(Position);
            break;
          }
          case 26: {
            if (rotation_ == null) {
              Rotation = new global::Tech.Takenoko.Grpcspring.Proto.Vector3_();
            }
            input.ReadMessage(Rotation);
            break;
          }
          case 34: {
            if (status_ == null) {
              Status = new global::Tech.Takenoko.Grpcspring.Proto.Status_();
            }
            input.ReadMessage(Status);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
