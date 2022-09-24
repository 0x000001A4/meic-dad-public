// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/DADChatServices - Copy.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ChatServer {

  /// <summary>Holder for reflection information generated from protos/DADChatServices - Copy.proto</summary>
  public static partial class DADChatServicesCopyReflection {

    #region Descriptor
    /// <summary>File descriptor for protos/DADChatServices - Copy.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DADChatServicesCopyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNwcm90b3MvREFEQ2hhdFNlcnZpY2VzIC0gQ29weS5wcm90byI2ChlDaGF0",
            "Q2xpZW50UmVnaXN0ZXJSZXF1ZXN0EgwKBG5pY2sYASABKAkSCwoDdXJsGAIg",
            "ASgJIiUKF0NoYXRDbGllbnRSZWdpc3RlclJlcGx5EgoKAm9rGAEgASgIIisK",
            "HENoYXRDbGllbnRTZW5kTWVzc2FnZVJlcXVlc3QSCwoDbXNnGAEgASgJIigK",
            "GkNoYXRDbGllbnRTZW5kTWVzc2FnZVJlcGx5EgoKAm9rGAEgASgIMqABChFD",
            "aGF0U2VydmVyU2VydmljZRJACghSZWdpc3RlchIaLkNoYXRDbGllbnRSZWdp",
            "c3RlclJlcXVlc3QaGC5DaGF0Q2xpZW50UmVnaXN0ZXJSZXBseRJJCgtTZW5k",
            "TWVzc2FnZRIdLkNoYXRDbGllbnRTZW5kTWVzc2FnZVJlcXVlc3QaGy5DaGF0",
            "Q2xpZW50U2VuZE1lc3NhZ2VSZXBseUINqgIKQ2hhdFNlcnZlcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ChatServer.ChatClientRegisterRequest), global::ChatServer.ChatClientRegisterRequest.Parser, new[]{ "Nick", "Url" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ChatServer.ChatClientRegisterReply), global::ChatServer.ChatClientRegisterReply.Parser, new[]{ "Ok" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ChatServer.ChatClientSendMessageRequest), global::ChatServer.ChatClientSendMessageRequest.Parser, new[]{ "Msg" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ChatServer.ChatClientSendMessageReply), global::ChatServer.ChatClientSendMessageReply.Parser, new[]{ "Ok" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChatClientRegisterRequest : pb::IMessage<ChatClientRegisterRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChatClientRegisterRequest> _parser = new pb::MessageParser<ChatClientRegisterRequest>(() => new ChatClientRegisterRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChatClientRegisterRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ChatServer.DADChatServicesCopyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatClientRegisterRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatClientRegisterRequest(ChatClientRegisterRequest other) : this() {
      nick_ = other.nick_;
      url_ = other.url_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatClientRegisterRequest Clone() {
      return new ChatClientRegisterRequest(this);
    }

    /// <summary>Field number for the "nick" field.</summary>
    public const int NickFieldNumber = 1;
    private string nick_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Nick {
      get { return nick_; }
      set {
        nick_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "url" field.</summary>
    public const int UrlFieldNumber = 2;
    private string url_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Url {
      get { return url_; }
      set {
        url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChatClientRegisterRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChatClientRegisterRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Nick != other.Nick) return false;
      if (Url != other.Url) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Nick.Length != 0) hash ^= Nick.GetHashCode();
      if (Url.Length != 0) hash ^= Url.GetHashCode();
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
      if (Nick.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Nick);
      }
      if (Url.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Url);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Nick.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Nick);
      }
      if (Url.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Url);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Nick.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nick);
      }
      if (Url.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChatClientRegisterRequest other) {
      if (other == null) {
        return;
      }
      if (other.Nick.Length != 0) {
        Nick = other.Nick;
      }
      if (other.Url.Length != 0) {
        Url = other.Url;
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
            Nick = input.ReadString();
            break;
          }
          case 18: {
            Url = input.ReadString();
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
            Nick = input.ReadString();
            break;
          }
          case 18: {
            Url = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ChatClientRegisterReply : pb::IMessage<ChatClientRegisterReply>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChatClientRegisterReply> _parser = new pb::MessageParser<ChatClientRegisterReply>(() => new ChatClientRegisterReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChatClientRegisterReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ChatServer.DADChatServicesCopyReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatClientRegisterReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatClientRegisterReply(ChatClientRegisterReply other) : this() {
      ok_ = other.ok_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatClientRegisterReply Clone() {
      return new ChatClientRegisterReply(this);
    }

    /// <summary>Field number for the "ok" field.</summary>
    public const int OkFieldNumber = 1;
    private bool ok_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Ok {
      get { return ok_; }
      set {
        ok_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChatClientRegisterReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChatClientRegisterReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ok != other.Ok) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ok != false) hash ^= Ok.GetHashCode();
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
      if (Ok != false) {
        output.WriteRawTag(8);
        output.WriteBool(Ok);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Ok != false) {
        output.WriteRawTag(8);
        output.WriteBool(Ok);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Ok != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChatClientRegisterReply other) {
      if (other == null) {
        return;
      }
      if (other.Ok != false) {
        Ok = other.Ok;
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
          case 8: {
            Ok = input.ReadBool();
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
          case 8: {
            Ok = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ChatClientSendMessageRequest : pb::IMessage<ChatClientSendMessageRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChatClientSendMessageRequest> _parser = new pb::MessageParser<ChatClientSendMessageRequest>(() => new ChatClientSendMessageRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChatClientSendMessageRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ChatServer.DADChatServicesCopyReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatClientSendMessageRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatClientSendMessageRequest(ChatClientSendMessageRequest other) : this() {
      msg_ = other.msg_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatClientSendMessageRequest Clone() {
      return new ChatClientSendMessageRequest(this);
    }

    /// <summary>Field number for the "msg" field.</summary>
    public const int MsgFieldNumber = 1;
    private string msg_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Msg {
      get { return msg_; }
      set {
        msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChatClientSendMessageRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChatClientSendMessageRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Msg != other.Msg) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Msg.Length != 0) hash ^= Msg.GetHashCode();
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
      if (Msg.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Msg);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Msg.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Msg);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Msg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChatClientSendMessageRequest other) {
      if (other == null) {
        return;
      }
      if (other.Msg.Length != 0) {
        Msg = other.Msg;
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
            Msg = input.ReadString();
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
            Msg = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ChatClientSendMessageReply : pb::IMessage<ChatClientSendMessageReply>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChatClientSendMessageReply> _parser = new pb::MessageParser<ChatClientSendMessageReply>(() => new ChatClientSendMessageReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChatClientSendMessageReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ChatServer.DADChatServicesCopyReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatClientSendMessageReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatClientSendMessageReply(ChatClientSendMessageReply other) : this() {
      ok_ = other.ok_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatClientSendMessageReply Clone() {
      return new ChatClientSendMessageReply(this);
    }

    /// <summary>Field number for the "ok" field.</summary>
    public const int OkFieldNumber = 1;
    private bool ok_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Ok {
      get { return ok_; }
      set {
        ok_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChatClientSendMessageReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChatClientSendMessageReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ok != other.Ok) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ok != false) hash ^= Ok.GetHashCode();
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
      if (Ok != false) {
        output.WriteRawTag(8);
        output.WriteBool(Ok);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Ok != false) {
        output.WriteRawTag(8);
        output.WriteBool(Ok);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Ok != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChatClientSendMessageReply other) {
      if (other == null) {
        return;
      }
      if (other.Ok != false) {
        Ok = other.Ok;
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
          case 8: {
            Ok = input.ReadBool();
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
          case 8: {
            Ok = input.ReadBool();
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
