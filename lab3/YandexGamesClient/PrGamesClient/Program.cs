using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OkHttpClient;

// ReSharper disable All

namespace PrGamesClient
{
	class Program
	{
		static async Task Main(string[] args)
		{
			var services = new ServiceCollection();

			Console.WriteLine("Enter login: ");
			var login = Console.ReadLine().ToString();

			Console.WriteLine("Enter password: ");
			var password = Console.ReadLine().ToString();
			
			ConfigureServices(services);
			var serviceProvider = services.BuildServiceProvider();
			
			try
			{
				await serviceProvider.GetService<IHttpClientService>().RunAsync(login, password);
			} catch (Exception e)
			{
				Console.WriteLine(e.Message);
				// var logger = serviceProvider.GetService<ILogger<Program>>();
				// logger.LogError(e, "An exception happened while running the integration service.");
			}
			
			Console.ReadKey();
		}

		private static void ConfigureServices(IServiceCollection serviceCollection)
		{
			serviceCollection.AddScoped<IHttpClientService, OkHttpClient.OkHttpClient>();
		}
	}
}
