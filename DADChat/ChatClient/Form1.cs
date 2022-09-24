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
using System.Windows.Forms;
using Grpc.Net.Client;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChatClient {
	public partial class Form1 : Form {

		private GrpcChannel channel;
		private ChatServerService.ChatServerServiceClient client;
		private int clientPort;
		private bool listening;
		public bool connectedOnce = false;

		public Form1(int _clientPort) {
			InitializeComponent();
			clientPort = _clientPort;
			listening = true;
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
        }

		public void AddMsgToChat(string msg) { richTextBox2.Text += msg + "\r\n"; }

		public void AddConnectMsg(string msg) { radioButton1.Text = msg; }

		public void ChangeListeningStatus(bool status) { listening = status; }

		public bool isListening() { return listening; }

        private void button1_Click(object sender, EventArgs e) {

			var clientAddress = $"http://localhost:{clientPort}";
			var serverPort = textBox1.Text;
			var serverAddress = $"http://localhost:{serverPort}";

            channel = GrpcChannel.ForAddress(serverAddress);
            client = new ChatServerService.ChatServerServiceClient(channel);
            var reply = client.Register(
						 new ChatClientRegisterRequest { Nick = textBox2.Text, Url = clientAddress }
						 );

			if (reply.Ok) { 
				label3.Text = $"Connected to {serverAddress}";
				connectedOnce = true;
			}
			else { label3.Text = $"Connection to {serverAddress} failed"; }
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void richTextBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e) {
			if (listening) {
				var reply = client.SendMessage(
						new ChatClientSendMessageRequest { Msg = richTextBox1.Text, From = textBox2.Text }
						);

				if (reply.Ok)
					label4.Text = "Message sent.";
				else {
					label4.Text = "Failed to send message.";
				}
			}
			else {
				label4.Text = $"Can't send message: ChatClient server is not listening on Port {clientPort}";
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e) {
			listening = false;
			radioButton1.Text = $"ChatClient server Disconnected from Port: {clientPort.ToString()}";
        }
	}
}
