using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace PRlab1
{
	class Program
	{
		const int port = 80;
		static IPHostEntry ipAddress;
		static readonly string url = "unite.md";
		static IEnumerable<string> imageLinks;
		static void Main(string[] args)
		{

			var downloader = new ContentDownloader(url, port);

			var response = downloader.DownloadSiteContent();

			//var host = Dns.GetHostAddresses(url);

			ipAddress = Dns.GetHostEntry(url);

			imageLinks = GetAllImagesRefs(response);

			int imageStartIndex = ImageConentStartsAt(imageLinks.FirstOrDefault());
			
			var imageDownloader = new ImgDownloader(imageLinks, url, port, imageStartIndex);
			imageDownloader.DownloadImages();
		}

		private static int ImageConentStartsAt(string link)
		{
			var ip = new IPEndPoint(ipAddress.AddressList[0], port);
			using var socket = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			socket.Connect(ip);
			string resp = string.Empty;

			var requestBuilder = new StringBuilder();
			requestBuilder
				.Append($"GET {link} HTTP/1.1\r\nHost: unite.md\r\n")
				.Append("Accept-Language: en, ru, ro\r\n")
				.Append("Connection: keep-alive\r\n")
				.Append("Accept: text/html\r\n")
				.Append("User-Agent: CSharpTests\r\n\r\n");

			var GetReq = $"GET {link} HTTP/1.1\r\nHost: {url}\r\nConnection: " +
						$"keep-alive\r\nAccept: text/html\r\nUser-Agent: CSharpTests\r\n\r\n";
			socket.Send(Encoding.UTF8.GetBytes(requestBuilder.ToString()));
			var bytesStored = new byte[socket.ReceiveBufferSize];
			int responseSizeInBytes = socket.Receive(bytesStored);
			for (int i = 0; i < responseSizeInBytes; i++)
			{
				resp += $"{Convert.ToChar(bytesStored[i]).ToString()}";
			}

			var index = resp.IndexOf("\r\n\r\n");
			return index + 4;
		}


		static IEnumerable<string> GetAllImagesRefs(string src)
		{
			var imgs = new List<string>();
			var regex = new Regex("<img.*?src=\"(.*?)\"[^>]+>", 
				RegexOptions.Compiled | RegexOptions.IgnoreCase);
			var matchCollection = regex.Matches(src);
			
			var tmp = new StringBuilder();
			var urls = new StringBuilder();

			foreach (Match match in matchCollection)
			{
				tmp.Append($"{match.Value}\n");
				//Console.WriteLine(match.Value);
			}
			urls.Append(GetImageUrl(tmp.ToString(), "src"))
				.Append(GetImageUrl(tmp.ToString(), "lazy"))
				.Append(GetImageUrl(tmp.ToString(), "narrow"));

			regex = new Regex("/.*", RegexOptions.Compiled | RegexOptions.IgnoreCase);
			matchCollection = regex.Matches(urls.ToString());

			foreach (Match m in matchCollection)
			{
				Console.WriteLine($"{m.Value}\n");
				Console.WriteLine("=======================================================");
				imgs.Add($"{m.Value}\n");
			}

			return imgs;
		}

		static string GetImageUrl(string src, string reference)
		{
			var res = new StringBuilder();
			var regex = new Regex(reference + "=\"/.*(png|gif|jpg)", 
				RegexOptions.Compiled | RegexOptions.IgnoreCase);

			var matchCollection = regex.Matches(src);
			foreach (Match match in matchCollection)
			{
				res.Append($"{match.Value}\n");
				//Console.WriteLine(match.Value);
			}
			return res.ToString();
		}
	}
}
