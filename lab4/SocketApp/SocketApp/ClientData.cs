using ServerData;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
	class ClientData
	{
		public Socket ClientSocket { get; }
		public Thread ClientThread { get; }
		public string Id { get; set; }

		public ClientData()
		{
			Id = Guid.NewGuid().ToString();
			ClientThread = new Thread(Server.DataIn);
			ClientThread.Start(ClientSocket);
			SendRegistrationPacket();
		}

		public ClientData(Socket clientSocket)
		{
			ClientSocket = clientSocket;
			Id = Guid.NewGuid().ToString();
			ClientThread = new Thread(Server.DataIn);
			ClientThread.Start(ClientSocket);
			SendRegistrationPacket();
		}

		public void SendRegistrationPacket()
		{
			Packet p = new Packet(PacketType.Registration, "server");
			p._data.Add(Id);
			ClientSocket.Send(p.ToBytes());
		}
	}
}
