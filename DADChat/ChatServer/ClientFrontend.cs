using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace ChatServer {

	public class ClientFrontend {

		private GrpcChannel channel;
		private ChatServerBroadcastService.ChatServerBroadcastServiceClient client;

		public ClientFrontend() { 
			AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
		}


		public void BroadcastMsg(string msg, Dictionary<string, string> clientMap, string _from) {
			Console.WriteLine($"Broadcasting message: {msg}");
			foreach (var key in clientMap.Keys)
			{
				var user = clientMap[key];
				Console.WriteLine($"Sending message to {user.ToString()}");
				channel = GrpcChannel.ForAddress(user.ToString());
				client = new ChatServerBroadcastService.ChatServerBroadcastServiceClient(channel);

                _ = client.PostMessage(
					new ChatServerBroadcastMessageRequest { Msg = $"From {_from}: {msg}" }
					);
			}
		}
	}
}
