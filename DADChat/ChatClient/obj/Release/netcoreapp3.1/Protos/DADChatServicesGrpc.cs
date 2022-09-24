// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/DADChatServices.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ChatClient {
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

    static readonly grpc::Marshaller<global::ChatClient.ChatClientRegisterRequest> __Marshaller_ChatClientRegisterRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ChatClient.ChatClientRegisterRequest.Parser));
    static readonly grpc::Marshaller<global::ChatClient.ChatClientRegisterReply> __Marshaller_ChatClientRegisterReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ChatClient.ChatClientRegisterReply.Parser));
    static readonly grpc::Marshaller<global::ChatClient.ChatClientSendMessageRequest> __Marshaller_ChatClientSendMessageRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ChatClient.ChatClientSendMessageRequest.Parser));
    static readonly grpc::Marshaller<global::ChatClient.ChatClientSendMessageResponse> __Marshaller_ChatClientSendMessageResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ChatClient.ChatClientSendMessageResponse.Parser));

    static readonly grpc::Method<global::ChatClient.ChatClientRegisterRequest, global::ChatClient.ChatClientRegisterReply> __Method_Register = new grpc::Method<global::ChatClient.ChatClientRegisterRequest, global::ChatClient.ChatClientRegisterReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Register",
        __Marshaller_ChatClientRegisterRequest,
        __Marshaller_ChatClientRegisterReply);

    static readonly grpc::Method<global::ChatClient.ChatClientSendMessageRequest, global::ChatClient.ChatClientSendMessageResponse> __Method_SendMessage = new grpc::Method<global::ChatClient.ChatClientSendMessageRequest, global::ChatClient.ChatClientSendMessageResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SendMessage",
        __Marshaller_ChatClientSendMessageRequest,
        __Marshaller_ChatClientSendMessageResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ChatClient.DADChatServicesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ChatServerService</summary>
    public partial class ChatServerServiceClient : grpc::ClientBase<ChatServerServiceClient>
    {
      /// <summary>Creates a new client for ChatServerService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ChatServerServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ChatServerService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ChatServerServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ChatServerServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ChatServerServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::ChatClient.ChatClientRegisterReply Register(global::ChatClient.ChatClientRegisterRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Register(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ChatClient.ChatClientRegisterReply Register(global::ChatClient.ChatClientRegisterRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Register, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ChatClient.ChatClientRegisterReply> RegisterAsync(global::ChatClient.ChatClientRegisterRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegisterAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ChatClient.ChatClientRegisterReply> RegisterAsync(global::ChatClient.ChatClientRegisterRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Register, null, options, request);
      }
      public virtual global::ChatClient.ChatClientSendMessageResponse SendMessage(global::ChatClient.ChatClientSendMessageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendMessage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ChatClient.ChatClientSendMessageResponse SendMessage(global::ChatClient.ChatClientSendMessageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SendMessage, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ChatClient.ChatClientSendMessageResponse> SendMessageAsync(global::ChatClient.ChatClientSendMessageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendMessageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ChatClient.ChatClientSendMessageResponse> SendMessageAsync(global::ChatClient.ChatClientSendMessageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SendMessage, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ChatServerServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ChatServerServiceClient(configuration);
      }
    }

  }
}
#endregion
