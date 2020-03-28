using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace PRlab1
{
	public class MySocket : Socket, IDisposable
	{
		public string Id { get; private set; }
		public MySocket(string id, AddressFamily addressFamily, SocketType socketType, 
			ProtocolType protocolType) 
			: base(addressFamily, socketType, protocolType)
		{
			Id = id;
		}
	}
}
