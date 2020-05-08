using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net;
using System.Threading.Tasks;
using System.IO;

// ReSharper disable All

namespace PrGamesClient
{
	class Program
	{
		static async Task Main(string[] args)
		{
			var services = new ServiceCollection();

			var credentials = await File.ReadAllTextAsync(@"D:\Универ\3 курс\семестр 2\PR\httpClientFiles\credentials.txt");
			var splitCredentials = credentials.Split(';');
			
			ConfigureServices(services);
			var serviceProvider = services.BuildServiceProvider();
			
			try
			{
				await serviceProvider.GetService<IHttpClientService>().RunAsync(splitCredentials[0], splitCredentials[1]);
			} catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			
			Console.ReadKey();
		}

		private static void ConfigureServices(IServiceCollection serviceCollection)
		{
			serviceCollection.AddScoped<IHttpClientService, OkHttpClient.OkHttpClient>();
		}
	}
}
