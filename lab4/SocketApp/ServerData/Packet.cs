using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace ServerData
{
	[Serializable]
	public class Packet
	{

		public List<string> _data;
		public int _packetInt;
		public bool _packetBool;
		public string _senderId;
		public PacketType _packetType;

		public Packet(PacketType type, string senderId)
		{
			_data = new List<string>();
			_senderId = senderId;
			_packetType = type;
		}

		public Packet(byte[] packetBytes)
		{
			var bf = new BinaryFormatter();
			var ms = new MemoryStream(packetBytes);
			Packet p = bf.Deserialize(ms) as Packet;
			ms.Close();
			_data = p._data;
			_packetInt = p._packetInt;
			_packetBool = p._packetBool;
			_senderId = p._senderId;
			_packetType = p._packetType;
		}

		public byte[] ToBytes()
		{
			BinaryFormatter bf = new BinaryFormatter();
			MemoryStream ms = new MemoryStream();

			bf.Serialize(ms, this);
			byte[] bytes = ms.ToArray();
			ms.Close();

			return bytes;
		}

		public static string GetIpAddress()
		{
			IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());
			foreach (IPAddress iP in ips)
			{
				if(iP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
				{
					return iP.ToString();
				}
			}
			//return default ip
			return "127.0.0.1";
		}
	}

	public enum PacketType
	{
		Registration,
		Chat
	}
}
