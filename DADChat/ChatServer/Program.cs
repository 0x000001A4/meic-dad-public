using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Core.Interceptors;

namespace ChatServer {
	// ChatServerService is the namespace defined in the protobuf
	// ChatServerServiceBase is the generated base implementation of the service
	public class ServerService : ChatServerService.ChatServerServiceBase {

		private Dictionary<string, string> clientMap = new Dictionary<string, string>();
		private ClientFrontend clientFrontend = new ClientFrontend();
		private Program process;

		public ServerService(Program _process) {
			process = _process;
		}

		public override Task<ChatClientRegisterReply> Register(
			ChatClientRegisterRequest request, ServerCallContext context) {
			return Task.FromResult(Reg(request));
		}
		
		public ChatClientRegisterReply Reg(ChatClientRegisterRequest request) {
            if (process.Frozen) return new ChatClientRegisterReply { Ok = true };
			doReg(request);
			return new ChatClientRegisterReply { Ok = true };
		}

		void doReg(ChatClientRegisterRequest request) {
            lock (this) {
                clientMap.Add(request.Nick, request.Url);
            }
            Console.WriteLine($"Registered client {request.Nick} with URL {request.Url}");
        }

		public override Task<ChatClientSendMessageReply> SendMessage(
			ChatClientSendMessageRequest request, ServerCallContext context) {

			return Task.FromResult(HandleMsg(request));
		}

		public ChatClientSendMessageReply HandleMsg(ChatClientSendMessageRequest request) {
			if (process.Frozen) return new ChatClientSendMessageReply { Ok = true };
			doHandleMsg(request);
			return new ChatClientSendMessageReply { Ok = true }; 
		}

		public void doHandleMsg(ChatClientSendMessageRequest request) {
            clientFrontend.BroadcastMsg(request.Msg, clientMap, request.From);
            Console.WriteLine($"Received Message: {request.Msg}");
        }

	}

	public class ServerMessageInterceptor : Interceptor {

		public Program process;
		public int i = 0;

		public ServerMessageInterceptor(Program _process) {
			process = _process;
		}

        public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(
			TRequest request,
			ServerCallContext context,
			UnaryServerMethod<TRequest, TResponse> continuation)
		{
            try {
				i = i + 1;
                if (process.Frozen && i > 0) {
                    process.queue.Enqueue((ChatClientSendMessageRequest)(object)(request));
                }
                return await continuation(request, context);

			} catch (Exception ex) {
				throw ex;
			}
		}
	}

	public class Program {
		const int Port = 8000;
		public bool Frozen { get; set; } = false;
        public Queue<ChatClientSendMessageRequest> queue { get; set; } = new Queue<ChatClientSendMessageRequest>();

		public void handleQueuedRequest(ServerService service, ChatClientSendMessageRequest request) {
			service.doHandleMsg(request);
		}

        static void Main(string[] args) {
			Program process = new Program();

			ServerService _service = new ServerService(process);
            Server server = new Server {
				Services = { ChatServerService.BindService(_service).Intercept(new ServerMessageInterceptor(process)) },
				Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
			};

			Console.WriteLine(process.Frozen);
			server.Start();
			Console.WriteLine("ChatServer server listening on port " + Port);
			Console.WriteLine("Press any key to stop the server...");

			ConsoleKey key;
			while ((key = Console.ReadKey().Key) != ConsoleKey.Escape) {
				if (key == ConsoleKey.F) {
					process.Frozen = !process.Frozen;
                    Console.WriteLine($"Command F: Process is now {(process.Frozen == true ? "frozen" : "active")}");
					while (process.Frozen == false && process.queue.Count != 0 ) {
						process.handleQueuedRequest(_service, process.queue.Dequeue());
					}
				}
			}
			server.ShutdownAsync().Wait();

		}
	}
}

