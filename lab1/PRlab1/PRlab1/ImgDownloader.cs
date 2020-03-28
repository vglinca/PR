using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Linq;

namespace PRlab1
{
	public class ImgDownloader
	{
		SemaphoreSlim _getImgLinkSem;
		SemaphoreSlim _allow4Sem;
		SemaphoreSlim _getSocketSem;
		SemaphoreSlim _closeConnSem;
		IPHostEntry _ipAddress;
		IPEndPoint _ip;
		Queue<string> _linksQueue;
		SocketManager _socketManager;
		int _port;
		int _imageStartsAt;
		string _url;

		public ImgDownloader(IEnumerable<string> links, string url, int port, int imageStartIndex)
		{
			_getImgLinkSem = new SemaphoreSlim(1, 1);
			_getSocketSem = new SemaphoreSlim(1, 1);
			_closeConnSem = new SemaphoreSlim(1, 1);
			_allow4Sem = new SemaphoreSlim(4, 4);
			_port = port;
			_url = url;
			_ipAddress = Dns.GetHostEntry(_url);
			_ip = new IPEndPoint(_ipAddress.AddressList[0], _port);
			_imageStartsAt = imageStartIndex;

			_linksQueue = new Queue<string>();
			
			foreach (var link in links)
			{
				_linksQueue.Enqueue($"{link}\r\n\r\n{Guid.NewGuid().ToString()}");
			}

			_socketManager = new SocketManager(_linksQueue, _ip, _imageStartsAt);
		}

		private void Execute()
		{
			_allow4Sem.Wait();
			while(_linksQueue.Count > 0)
			{
				Console.WriteLine($"\tThread: {Thread.CurrentThread.Name}");
				_getImgLinkSem.Wait();
				var link = _linksQueue.Dequeue();
				_getImgLinkSem.Release();
				DownloadOneImage(link);
			}
			_allow4Sem.Release();
		}

		private void DownloadOneImage(string link)
		{
			_getSocketSem.Wait();
			var socketId = _socketManager.GetSocketId(link);
			var socket = _socketManager.FindSocket(socketId);
			_getSocketSem.Release();

			_closeConnSem.Wait();
			_socketManager.CloseConn(socketId);
			_closeConnSem.Release();
		}

		public void DownloadImages()
		{
			var th1 = new Thread(Execute);
			var th2 = new Thread(Execute);
			var th3 = new Thread(Execute);
			var th4 = new Thread(Execute);
			var th5 = new Thread(Execute);
			var th6 = new Thread(Execute);

			th1.Name = "A";
			th2.Name = "B";
			th3.Name = "C";
			th4.Name = "D";
			th5.Name = "E";
			th6.Name = "F";

			th1.Start();
			th2.Start();
			th3.Start();
			th4.Start();
			th5.Start();
			th6.Start();
		}
	}
}
