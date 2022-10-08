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

		public override Task<Reply> Register(
			Request request, ServerCallContext context) {
			return Task.FromResult(Reg(request));
		}
		
		public Reply Reg(Request request) {
            if (process.Frozen) return new Reply { Ok = false };
			doHandleRegister(request);
			return new Reply { Ok = true };
		}

		public void doHandleRegister(Request request) {
            lock (this) {
                clientMap.Add(request.RegisterRequest.Nick, request.RegisterRequest.Url);
            }
            Console.WriteLine($"Registered client {request.RegisterRequest.Nick} with URL {request.RegisterRequest.Url}");
        }

		public override Task<Reply> SendMessage(
			Request request, ServerCallContext context) {

			return Task.FromResult(HandleMsg(request));
		}

		public Reply HandleMsg(Request request) {
			if (process.Frozen) return new Reply { Ok = false };
			doHandleMsg(request);
			return new Reply { Ok = true }; 
		}

		public void doHandleMsg(Request request) {
            clientFrontend.BroadcastMsg(request.SendMessageRequest.Msg, clientMap, request.SendMessageRequest.From);
            Console.WriteLine($"Received Message: {request.SendMessageRequest.Msg}");
        }

	}

	public class ServerMessageInterceptor : Interceptor {

		public Program process;

		public ServerMessageInterceptor(Program _process) {
			process = _process;
		}

        public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(
			TRequest request,
			ServerCallContext context,
			UnaryServerMethod<TRequest, TResponse> continuation)
		{
            try {
                if (process.Frozen) {
                    process.queue.Enqueue((Request)(object)(request));
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
        public Queue<Request> queue { get; set; } = new Queue<Request>();

		public void handleQueuedRequest(ServerService service, Request request) {

			if (request.Id == 1) {
                service.doHandleRegister(request);
            }
			else if (request.Id == 2) {
                service.doHandleMsg(request);
            }
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

