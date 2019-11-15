// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: chat.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CryptChatProtos.Responses.Chat {

  /// <summary>Holder for reflection information generated from chat.proto</summary>
  public static partial class ChatReflection {

    #region Descriptor
    /// <summary>File descriptor for chat.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChatReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpjaGF0LnByb3RvEh5jcnlwdGNoYXRwcm90b3MucmVzcG9uc2VzLmNoYXQi",
            "QAoNUXVldWVSZXNwb25zZRIPCgdkZWxldGVkGAEgAygJEg4KBmVkaXRlZBgC",
            "IAMoCRIOCgZyZXN5bmMYAyADKAkiPwoMQ2hhdFJlc3BvbnNlEgsKA19pZBgB",
            "IAEoCRIPCgdtZW1iZXJzGAIgAygJEhEKCW1zZ19jb3VudBgDIAEoBSJPChBD",
            "aGF0TGlzdFJlc3BvbnNlEjsKBWNoYXRzGAEgAygLMiwuY3J5cHRjaGF0cHJv",
            "dG9zLnJlc3BvbnNlcy5jaGF0LkNoYXRSZXNwb25zZUIhqgIeQ3J5cHRDaGF0",
            "UHJvdG9zLlJlc3BvbnNlcy5DaGF0YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CryptChatProtos.Responses.Chat.QueueResponse), global::CryptChatProtos.Responses.Chat.QueueResponse.Parser, new[]{ "Deleted", "Edited", "Resync" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CryptChatProtos.Responses.Chat.ChatResponse), global::CryptChatProtos.Responses.Chat.ChatResponse.Parser, new[]{ "Id", "Members", "MsgCount" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CryptChatProtos.Responses.Chat.ChatListResponse), global::CryptChatProtos.Responses.Chat.ChatListResponse.Parser, new[]{ "Chats" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class QueueResponse : pb::IMessage<QueueResponse> {
    private static readonly pb::MessageParser<QueueResponse> _parser = new pb::MessageParser<QueueResponse>(() => new QueueResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QueueResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CryptChatProtos.Responses.Chat.ChatReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueueResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueueResponse(QueueResponse other) : this() {
      deleted_ = other.deleted_.Clone();
      edited_ = other.edited_.Clone();
      resync_ = other.resync_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueueResponse Clone() {
      return new QueueResponse(this);
    }

    /// <summary>Field number for the "deleted" field.</summary>
    public const int DeletedFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_deleted_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> deleted_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Deleted {
      get { return deleted_; }
    }

    /// <summary>Field number for the "edited" field.</summary>
    public const int EditedFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_edited_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> edited_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Edited {
      get { return edited_; }
    }

    /// <summary>Field number for the "resync" field.</summary>
    public const int ResyncFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_resync_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> resync_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Resync {
      get { return resync_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QueueResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QueueResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!deleted_.Equals(other.deleted_)) return false;
      if(!edited_.Equals(other.edited_)) return false;
      if(!resync_.Equals(other.resync_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= deleted_.GetHashCode();
      hash ^= edited_.GetHashCode();
      hash ^= resync_.GetHashCode();
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
      deleted_.WriteTo(output, _repeated_deleted_codec);
      edited_.WriteTo(output, _repeated_edited_codec);
      resync_.WriteTo(output, _repeated_resync_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += deleted_.CalculateSize(_repeated_deleted_codec);
      size += edited_.CalculateSize(_repeated_edited_codec);
      size += resync_.CalculateSize(_repeated_resync_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QueueResponse other) {
      if (other == null) {
        return;
      }
      deleted_.Add(other.deleted_);
      edited_.Add(other.edited_);
      resync_.Add(other.resync_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            deleted_.AddEntriesFrom(input, _repeated_deleted_codec);
            break;
          }
          case 18: {
            edited_.AddEntriesFrom(input, _repeated_edited_codec);
            break;
          }
          case 26: {
            resync_.AddEntriesFrom(input, _repeated_resync_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ChatResponse : pb::IMessage<ChatResponse> {
    private static readonly pb::MessageParser<ChatResponse> _parser = new pb::MessageParser<ChatResponse>(() => new ChatResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChatResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CryptChatProtos.Responses.Chat.ChatReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatResponse(ChatResponse other) : this() {
      Id_ = other.Id_;
      members_ = other.members_.Clone();
      msgCount_ = other.msgCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatResponse Clone() {
      return new ChatResponse(this);
    }

    /// <summary>Field number for the "_id" field.</summary>
    public const int IdFieldNumber = 1;
    private string Id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return Id_; }
      set {
        Id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "members" field.</summary>
    public const int MembersFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_members_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> members_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Members {
      get { return members_; }
    }

    /// <summary>Field number for the "msg_count" field.</summary>
    public const int MsgCountFieldNumber = 3;
    private int msgCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MsgCount {
      get { return msgCount_; }
      set {
        msgCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChatResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChatResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if(!members_.Equals(other.members_)) return false;
      if (MsgCount != other.MsgCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      hash ^= members_.GetHashCode();
      if (MsgCount != 0) hash ^= MsgCount.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      members_.WriteTo(output, _repeated_members_codec);
      if (MsgCount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(MsgCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      size += members_.CalculateSize(_repeated_members_codec);
      if (MsgCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MsgCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChatResponse other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      members_.Add(other.members_);
      if (other.MsgCount != 0) {
        MsgCount = other.MsgCount;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            members_.AddEntriesFrom(input, _repeated_members_codec);
            break;
          }
          case 24: {
            MsgCount = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ChatListResponse : pb::IMessage<ChatListResponse> {
    private static readonly pb::MessageParser<ChatListResponse> _parser = new pb::MessageParser<ChatListResponse>(() => new ChatListResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChatListResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CryptChatProtos.Responses.Chat.ChatReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatListResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatListResponse(ChatListResponse other) : this() {
      chats_ = other.chats_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatListResponse Clone() {
      return new ChatListResponse(this);
    }

    /// <summary>Field number for the "chats" field.</summary>
    public const int ChatsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::CryptChatProtos.Responses.Chat.ChatResponse> _repeated_chats_codec
        = pb::FieldCodec.ForMessage(10, global::CryptChatProtos.Responses.Chat.ChatResponse.Parser);
    private readonly pbc::RepeatedField<global::CryptChatProtos.Responses.Chat.ChatResponse> chats_ = new pbc::RepeatedField<global::CryptChatProtos.Responses.Chat.ChatResponse>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::CryptChatProtos.Responses.Chat.ChatResponse> Chats {
      get { return chats_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChatListResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChatListResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!chats_.Equals(other.chats_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= chats_.GetHashCode();
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
      chats_.WriteTo(output, _repeated_chats_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += chats_.CalculateSize(_repeated_chats_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChatListResponse other) {
      if (other == null) {
        return;
      }
      chats_.Add(other.chats_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            chats_.AddEntriesFrom(input, _repeated_chats_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code