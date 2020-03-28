using System.Threading.Tasks;

namespace PrGamesClient
{
	public interface IHttpClientService
	{
		Task RunAsync(string login, string password);
	}
}
