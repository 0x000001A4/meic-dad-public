// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/DADChatServices - Copy.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ChatServer {
  public static partial class ChatServerService
  {
    static readonly string __ServiceName = "ChatServerService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::ChatServer.ChatClientRegisterRequest> __Marshaller_ChatClientRegisterRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ChatServer.ChatClientRegisterRequest.Parser));
    static readonly grpc::Marshaller<global::ChatServer.ChatClientRegisterReply> __Marshaller_ChatClientRegisterReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ChatServer.ChatClientRegisterReply.Parser));
    static readonly grpc::Marshaller<global::ChatServer.ChatClientSendMessageRequest> __Marshaller_ChatClientSendMessageRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ChatServer.ChatClientSendMessageRequest.Parser));
    static readonly grpc::Marshaller<global::ChatServer.ChatClientSendMessageReply> __Marshaller_ChatClientSendMessageReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ChatServer.ChatClientSendMessageReply.Parser));

    static readonly grpc::Method<global::ChatServer.ChatClientRegisterRequest, global::ChatServer.ChatClientRegisterReply> __Method_Register = new grpc::Method<global::ChatServer.ChatClientRegisterRequest, global::ChatServer.ChatClientRegisterReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Register",
        __Marshaller_ChatClientRegisterRequest,
        __Marshaller_ChatClientRegisterReply);

    static readonly grpc::Method<global::ChatServer.ChatClientSendMessageRequest, global::ChatServer.ChatClientSendMessageReply> __Method_SendMessage = new grpc::Method<global::ChatServer.ChatClientSendMessageRequest, global::ChatServer.ChatClientSendMessageReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SendMessage",
        __Marshaller_ChatClientSendMessageRequest,
        __Marshaller_ChatClientSendMessageReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ChatServer.DADChatServicesCopyReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ChatServerService</summary>
    [grpc::BindServiceMethod(typeof(ChatServerService), "BindService")]
    public abstract partial class ChatServerServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::ChatServer.ChatClientRegisterReply> Register(global::ChatServer.ChatClientRegisterRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ChatServer.ChatClientSendMessageReply> SendMessage(global::ChatServer.ChatClientSendMessageRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ChatServerServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Register, serviceImpl.Register)
          .AddMethod(__Method_SendMessage, serviceImpl.SendMessage).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ChatServerServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Register, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ChatServer.ChatClientRegisterRequest, global::ChatServer.ChatClientRegisterReply>(serviceImpl.Register));
      serviceBinder.AddMethod(__Method_SendMessage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ChatServer.ChatClientSendMessageRequest, global::ChatServer.ChatClientSendMessageReply>(serviceImpl.SendMessage));
    }

  }
}
#endregion