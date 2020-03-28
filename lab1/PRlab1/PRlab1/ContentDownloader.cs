using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace PRlab1
{
	public class ContentDownloader
	{
		IPHostEntry _ipAddress;
		IPEndPoint _ip;
		int _port;
		string _url;

		public ContentDownloader(string url, int port)
		{
			_port = port;
			_url = url;
			_ipAddress = Dns.GetHostEntry(_url);
			_ip = new IPEndPoint(_ipAddress.AddressList[0], _port);
		}

		public string DownloadSiteContent()
		{
			using var socket = new Socket(_ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			socket.Connect(_ip);

			string GET = $"GET / HTTP/1.1\r\nHost: {_url}\r\nAccept-Language: en, ru, ro\r\nConnection: keep-alive\r\nAccept: " +
				$"text/html\r\nUser-Agent: CSharpTests\r\n\r\n";

			socket.Send(Encoding.UTF8.GetBytes(GET));
			Console.WriteLine("Request sent.");

			string response = string.Empty;

			var bytesStored = new byte[1024];
			//int responseSizeInBytes = socket.Receive(bytesStored);
			while (socket.Receive(bytesStored) > 0)
			{
				response += Encoding.UTF8.GetString(bytesStored);
			}
			//for (int i = 0; i < responseSizeInBytes; i++)
			//{
			//	response += Convert.ToChar(bytesStored[i]).ToString();
			//}
			socket.Close();
			return response;
		}
	}
}
