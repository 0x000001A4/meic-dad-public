using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;

namespace ChatServer {
	// ChatServerService is the namespace defined in the protobuf
	// ChatServerServiceBase is the generated base implementation of the service
	public class ServerService : ChatServerService.ChatServerServiceBase {

		private Dictionary<string, string> clientMap = new Dictionary<string, string>();
		private ClientFrontend clientFrontend = new ClientFrontend();

		public ServerService() {

		}

		public override Task<ChatClientRegisterReply> Register(
			ChatClientRegisterRequest request, ServerCallContext context) {
			return Task.FromResult(Reg(request));
		}
		
		public ChatClientRegisterReply Reg(ChatClientRegisterRequest request) {
			lock (this) {
				clientMap.Add(request.Nick, request.Url);
			}
			Console.WriteLine($"Registered client {request.Nick} with URL {request.Url}");
			return new ChatClientRegisterReply { Ok = true };
		}

		public override Task<ChatClientSendMessageReply> SendMessage(
			ChatClientSendMessageRequest request, ServerCallContext context) {

			return Task.FromResult(HandleMsg(request));
		}

		public ChatClientSendMessageReply HandleMsg(ChatClientSendMessageRequest request) {
			clientFrontend.BroadcastMsg(request.Msg, clientMap, request.From);
			Console.WriteLine($"Received Message: {request.Msg}");
			return new ChatClientSendMessageReply { Ok = true }; 
		}

	}
	class Program {
		const int Port = 8000;
		static void Main(string[] args) {
			Server server = new Server {
				Services = { ChatServerService.BindService(new ServerService()) },
				Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
			};
			server.Start();
			Console.WriteLine("ChatServer server listening on port " + Port);
			Console.WriteLine("Press any key to stop the server...");
			Console.ReadKey();

			server.ShutdownAsync().Wait();

		}
	}
}

