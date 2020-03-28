using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace PRlab1
{
	public class SocketManager
	{
		IPEndPoint _ip;
		List<MySocket> _socketCollection;
		IEnumerable<string> _links;
		int _imageStartsAt;

		public SocketManager(IEnumerable<string> links, IPEndPoint ip, int imageStartsAt)
		{
			_ip = ip;
			_socketCollection = new List<MySocket>();
			_links = links;
			_imageStartsAt = imageStartsAt;
			//FillSocketCollection();
		}

		private void FillSocketCollection()
		{
			foreach (var link in _links)
			{
				_socketCollection.Add(new MySocket(link, AddressFamily.InterNetwork,
					SocketType.Stream, ProtocolType.Tcp));
			}
		}

		public string GetSocketId(string link)
		{
			var socket = new MySocket(link, AddressFamily.InterNetwork,
					SocketType.Stream, ProtocolType.Tcp);
			socket.Connect(_ip);


			var splitLink = link.Split("\r\n\r\n");
			var imgSrc = splitLink[0];

			imgSrc = Regex.Replace(imgSrc, @"\t|\n|\r", "");
			var extension = Path.GetExtension(imgSrc);
			if (!Directory.Exists(@"D:\images"))
			{
				var dir = Directory.CreateDirectory(@"D:\images");
			}

			//imgSrc = imgSrc.Trim();
			Console.WriteLine($"IMGSRC {imgSrc}");

			var requestBuilder = new StringBuilder();
			requestBuilder
				.Append($"GET {imgSrc} HTTP/1.1\r\nHost: unite.md\r\n")
				.Append("Accept-Language: en, ru, ro\r\n")
				.Append("Connection: keep-alive\r\n")
				.Append("Accept: text/html\r\n")
				.Append("User-Agent: CSharpTests\r\n\r\n");

			var byteCount = socket.Send(Encoding.UTF8.GetBytes(requestBuilder.ToString()));
			Console.WriteLine($"Byte count {byteCount}");

			var dataInBytes = new byte[socket.ReceiveBufferSize * 4];
			int responseSizeInBytes = socket.Receive(dataInBytes);
			//Console.WriteLine($"Receive Buffer size: {dataInBytes.Length} | Response size in bytes: {responseSizeInBytes}");
			//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
			var resp = string.Empty;
			//byte[] sizeBuf = new byte[4];
			//socket.Receive(sizeBuf, 0, sizeBuf.Length, 0);
			//var size = BitConverter.ToInt32(sizeBuf, 0);
			//byte[] buffer;
			//while(size > 0)
			//{
			//	if(size < socket.ReceiveBufferSize)
			//	{
			//		buffer = new byte[size];
			//	}
			//	else
			//	{
			//		buffer = new byte[socket.ReceiveBufferSize];
			//	}
			//	var rec = socket.Receive(buffer, 0, buffer.Length, 0);
			//	size -= rec;

			//	resp += Encoding.ASCII.GetString(buffer, 0, buffer.Length);
			//}

			//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

			//var respBytes = new List<byte>();

			//while (socket.Receive(dataInBytes) > 0)
			//{
			//	resp += dataInBytes;
			//	respBytes.AddRange(dataInBytes);
			//}

			for (int i = 0; i < responseSizeInBytes; i++)
			{
				resp += $"{Convert.ToChar(dataInBytes[i]).ToString()}";
			}

			var index = resp.IndexOf("\r\n\r\n");
			resp = resp.Trim();
			//var index = FindIndex(respBytes, Encoding.UTF8.GetBytes("\r\n\r\n"));
			//if (index != -1)
			//{

				if (Directory.Exists(@"D:\images"))
				{
					using var outStream = new FileStream(Path.Combine(@"D:\images", $"{Path.GetFileNameWithoutExtension(imgSrc)}{Guid.NewGuid().ToString()}{extension}"), FileMode.Create);
					using var writer = new BinaryWriter(outStream);
					for (int i = index + 4; i < resp.Length; i++)
					{
						writer.Write((byte) resp[i]);
						//writer.Write(respBytes[i]);
					}
				}

			//}
			AddSocket(socket);
			//socket.Close();

			return socket.Id;
		}

		private int FindIndex(List<byte> parentArr, byte[] subArr)
		{
			// iterate backwards, stop if the rest of the array is shorter than needle (i >= needle.Length)
			for (var i = parentArr.Count - 1; i >= subArr.Length - 1; i--)
			{
				var found = true;
				// also iterate backwards through needle, stop if elements do not match (!found)
				for (var j = subArr.Length - 1; j >= 0 && found; j--)
				{
					// compare needle's element with corresponding element of haystack
					found = parentArr[i - (subArr.Length - 1 - j)] == subArr[j];
				}
				if (found)
					// result was found, i is now the index of the last found element, so subtract needle's length - 1
					return i - (subArr.Length - 1);
			}
			// not found, return -1
			return -1;
		}

		public MySocket FindSocket(string id)
		{
			return _socketCollection.FirstOrDefault(s => s.Id == id);
		}

		public void AddSocket(MySocket s)
		{
			_socketCollection.Add(s);
		}

		public void CloseConn(string socketId)
		{
			var socket = FindSocket(socketId);
			socket.Close();
		}
	}
}
