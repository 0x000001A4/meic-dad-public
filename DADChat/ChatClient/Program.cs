using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Grpc.Core;
using static ChatClient.ServerBroadcastService;

namespace ChatClient {

	public class ServerBroadcastService : ChatServerBroadcastService.ChatServerBroadcastServiceBase {

		public Form1 guiWindow;
		public delegate void DelAddMsg(string s);
		public delegate void DelConnect(bool x);
		
		public ServerBroadcastService(Form1 _guiWindow) {
			guiWindow = _guiWindow;
		}

		public override Task<ChatServerBroadcastMessageReply> PostMessage(
			ChatServerBroadcastMessageRequest request, ServerCallContext context) {

			return Task.FromResult(HandlePostMsg(request.Msg));
		}

		public ChatServerBroadcastMessageReply HandlePostMsg(string msg) {
			guiWindow.BeginInvoke(new DelAddMsg(guiWindow.AddMsgToChat), new object[] {msg});
			return new ChatServerBroadcastMessageReply { Ok = true };
		}
	}


	class Program {
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		/// 
		static void Main(string[] args) {
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			int clientPort = int.Parse(args[0]);
			Form1 guiWindow = new Form1(clientPort);
            Server server;
            server = new Server {
                Services = { ChatServerBroadcastService.BindService(new ServerBroadcastService(guiWindow)) },
                Ports = { new ServerPort("localhost", clientPort, ServerCredentials.Insecure) }
            };
            server.Start();

            Task thread = Task.Factory.StartNew(() =>
            {
				Application.Run(guiWindow);
            });

			while (!guiWindow.IsHandleCreated);
			guiWindow.BeginInvoke(new DelAddMsg(guiWindow.AddConnectMsg), 
								  new object[] { $"ChatClient server listening on Port: {clientPort.ToString()}" });
            thread.Wait();
            server.ShutdownAsync().Wait();
		}
	}
}
