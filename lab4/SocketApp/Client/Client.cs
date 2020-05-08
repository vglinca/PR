using System;
using ServerData;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using static System.Console;

namespace Client
{
	class Client
	{
		public static Socket masterSocket;
		public static string name;
		public static string id;
		static void Main(string[] args)
		{
			Write("Enter your name: ");
			name = ReadLine().Trim();
			bool connected = false;

			while (!connected)
			{
				Clear();
				Write($"Enter host ip: ");
				string ip = ReadLine().Trim();

				masterSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				IPEndPoint ipEndpoint = new IPEndPoint(IPAddress.Parse(ip), 4242);

				try
				{
					masterSocket.Connect(ipEndpoint);
					connected = true;
				}
				catch (Exception)
				{
					WriteLine($"Could not connect to host.");
					connected = false;
					Thread.Sleep(2000);
				}
			}

			Thread th = new Thread(DataIn);
			th.Start();

			while (true)
			{
				Console.Write($"::>");
				string input = ReadLine().Trim();

				var packet = new Packet(PacketType.Chat, id);
				packet._data.Add(name);
				packet._data.Add(input);
				masterSocket.Send(packet.ToBytes());
			}
		}

		static void DataIn()
		{
			byte[] buffer;
			int readBytes;

			try
			{
				while (true)
				{
					buffer = new byte[masterSocket.SendBufferSize];
					readBytes = masterSocket.Receive(buffer);
					if (readBytes > 0)
					{
						ManageData(new Packet(buffer));
					}
				}
			}
			catch (SocketException ex)
			{
				WriteLine("Server has disconnected.");
				ReadLine();
				Environment.Exit(0);
			}
		}

		static void ManageData(Packet p)
		{
			switch (p._packetType)
			{
				case PacketType.Registration:
					WriteLine($"Received a packet for registration. Responding...");
					id = p._data[0];
					WriteLine();
					break;
				case PacketType.Chat:
					ConsoleColor c = ForegroundColor;
					ForegroundColor = ConsoleColor.Green;
					WriteLine($"{p._data[0]} : {p._data[1]}");
					ForegroundColor = c;
					break;
				default:
					break;
			}
		}
	}
}
