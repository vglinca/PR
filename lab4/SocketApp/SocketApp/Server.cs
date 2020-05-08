using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using ServerData;
using System.Net;

namespace Server
{
	class Server
	{
		static Socket listenerSocket;
		static List<ClientData> _clients;
		static void Main(string[] args)
		{
			Console.WriteLine($"Starting server on {Packet.GetIpAddress()}");

			listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			_clients = new List<ClientData>();

			var ipEndpoint = new IPEndPoint(IPAddress.Parse(Packet.GetIpAddress()), 4242);
			listenerSocket.Bind(ipEndpoint);

			Thread listenThread = new Thread(ListenThread);
			listenThread.Start();
		}
		//listener - listens for client trying to connect

		static void ListenThread()
		{
			while(true)
			{
				listenerSocket.Listen(0);
				_clients.Add(new ClientData(listenerSocket.Accept()));
			}
		}

		//clientdata data thread which receaves data from client
		public static void DataIn(object cSocket)
		{
			Socket clientSocket = cSocket as Socket;

			byte[] buffer;
			int readBytes;

			try
			{
				while(true)
				{
					buffer = new byte[clientSocket.SendBufferSize];
					readBytes = clientSocket.Receive(buffer);

					if(readBytes > 0)
					{
						ManageData(new Packet(buffer));
					}
				}
			}
			catch(SocketException e)
			{
				Console.WriteLine($"A client has disconnected.");
			}
		}

		public static void ManageData(Packet p)
		{
			switch (p._packetType)
			{
				case PacketType.Registration:
					break;
				case PacketType.Chat:
					foreach ( ClientData c in _clients)
					{
						c.ClientSocket.Send(p.ToBytes());
					}
					break;
				default:
					break;
			}
		}
	}
}
