using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using PrGamesClient;

// ReSharper disable All

namespace OkHttpClient
{
    public class OkHttpClient : IHttpClientService
    {
        private IEnumerable<Cookie> _cookies;
        private readonly string _rootFilePath;
        private readonly string _rootUrl;
        
        public OkHttpClient()
        {
            _rootFilePath = @"D:\Универ\3 курс\семестр 2\PR\httpClientFiles";
            _rootUrl = "https://ok.ru/";
           _cookies = new List<Cookie>();
        }
        
        public async Task RunAsync(string login, string password)
        {
            await LoginAsync(login, password);
            await GetAsync();
            await HeadAsync();
            await OptionsAsync();
        }

        private async Task OptionsAsync()
        {
            var cookieContainer = new CookieContainer();
            cookieContainer.Add( _cookies as CookieCollection);
            using (var httpClientHandler = new HttpClientHandler {CookieContainer = cookieContainer, SslProtocols = SslProtocols.Tls})
            {
                using (var httpClient = new HttpClient(httpClientHandler))
                {
                    httpClient.Timeout = new TimeSpan(0, 0, 60);
                    httpClient.DefaultRequestHeaders.Clear();
            
                    var request = new HttpRequestMessage(HttpMethod.Options, $"{_rootUrl}dk?cmd=MessagesGrowl");
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
                    var response = await httpClient.SendAsync(request);
            
                    response.EnsureSuccessStatusCode();
                    var headersBuilder = new StringBuilder("Allow:\n\n");
                    
                    foreach (var header in response.Content.Headers.Allow)
                    {
                        headersBuilder.AppendLine($"{header}");
                    }
                    var path = Path.Combine(_rootFilePath, "opt.txt");
                    await WriteToFile(path, headersBuilder.ToString());
                }
            }
        }

        private async Task HeadAsync()
        {
            var cookieContainer = new CookieContainer();
            cookieContainer.Add( _cookies as CookieCollection);
            using (var httpClientHandler = new HttpClientHandler {CookieContainer = cookieContainer, SslProtocols = SslProtocols.Tls})
            {
                using (var httpClient = new HttpClient(httpClientHandler))
                {
                    httpClient.Timeout = new TimeSpan(0, 0, 60);
                    httpClient.DefaultRequestHeaders.Clear();

                    var request = new HttpRequestMessage(HttpMethod.Head, $"{_rootUrl}dk?cmd=MessagesGrowl");
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
                    var response = await httpClient.SendAsync(request);

                    response.EnsureSuccessStatusCode();
                    var headersBuilder = new StringBuilder();

                    foreach (var header in response.Headers)
                    {
                        headersBuilder.AppendLine($"{header.Key} : {header.Value.FirstOrDefault()}");
                    }
                    var path = Path.Combine(_rootFilePath, "head.txt");
                    await WriteToFile(path, headersBuilder.ToString());
                }
            }
        }

        private async Task GetAsync()
        {
            var cookieContainer = new CookieContainer();
            cookieContainer.Add( _cookies as CookieCollection);
            using (var httpClientHandler = new HttpClientHandler {CookieContainer = cookieContainer, SslProtocols = SslProtocols.Tls})
            {
                using (var httpClient = new HttpClient(httpClientHandler))
                {
                    httpClient.Timeout = new TimeSpan(0,0, 60);
                    httpClient.DefaultRequestHeaders.Clear();

                    var responseMsg = await httpClient.GetAsync($"{_rootUrl}dk?cmd=MessagesGrowl");
                    responseMsg.EnsureSuccessStatusCode();
                    var resp = string.Empty;
                    Task task = await responseMsg.Content.ReadAsStreamAsync().ContinueWith(async ts =>
                    {
                        using (var reader = new StreamReader(ts.Result))
                        {
                            resp = await reader.ReadToEndAsync();
                        }
                    });

                    var path = Path.Combine(_rootFilePath, "pagehtml.txt");
                    await WriteToFile(path, resp);
                }
            }
        }

        private async Task LoginAsync(string login, string password)
        {
            
            var cookieContainer = new CookieContainer();
            using (var httpClientHandler = new HttpClientHandler {CookieContainer = cookieContainer, SslProtocols = SslProtocols.Tls})
            {
                using(var client = new HttpClient(httpClientHandler))
                {
                    client.Timeout = new TimeSpan(0,0, 60);
                    client.DefaultRequestHeaders.Clear();
                    var credentials = new Dictionary<string, string>
                    {
                        {"st.posted", "set"},
                        {"st.originalaction", $"{_rootUrl}dk?cmd=AnonymLogin&st.cmd=anonymLogin"},
                        {"st.fJS", "on"},
                        {"st.st.screenSize", "1536 x 864"},
                        {"st.st.browserSize", "723"},
                        {"st.st.flashVer", "32.0.0"},
                        {"st.email", login},
                        {"st.password", password},
                        {"st.iscode", "false"}
                    };
                    
                    var content = new FormUrlEncodedContent(credentials);
                
                    var response = await client.PostAsync($"{_rootUrl}https", content);
//Request URL: https://www.worldcubeassociation.org/users/sign_in
//https://www.keft.ru/ajax/keft/login.php
//Request URL: https://rapidapi.com/auth/login
//Request URL: https://rutracker.org/forum/login.php
//Request URL: https://www.ok.ru/https

                    response.EnsureSuccessStatusCode();

                    var resp = string.Empty;
                    Task task = await response.Content.ReadAsStreamAsync().ContinueWith(async ts =>
                    {
                        using (var reader = new StreamReader(ts.Result))
                        {
                            resp = await reader.ReadToEndAsync();
                        }
                    });

                    var uri = new Uri("https://www.ok.ru");
                    _cookies = cookieContainer.GetCookies(uri).Cast<Cookie>();
                    var cookiesAsString = new StringBuilder();
                    foreach (Cookie c in _cookies)
                    {
                        Console.WriteLine($"{c.Name} : {c.Value}");
                        cookiesAsString.AppendLine($"{c.Name} : {c.Value}");
                    }
                    var path = Path.Combine(_rootFilePath, "cookies.txt");
                    await WriteToFile(path, cookiesAsString.ToString());
                }
            }
        }

        private async Task WriteToFile(string filename, string content)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            await File.WriteAllTextAsync(filename, content);
        }
    }
}