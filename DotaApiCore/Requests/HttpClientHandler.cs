using System.Net.Http;
using System.Threading.Tasks;

namespace DotaApiCore.Requests
{
    internal class HttpClientHandler : IHttpHandler
    {
        private readonly HttpClient _client = new HttpClient();

        public string SendRequest(string url)
        {
            var result = Get(url);
            result.EnsureSuccessStatusCode();

            var responseBody = ReadResponse(result).Result;

            return responseBody;
        }

        private HttpResponseMessage Get(string url)
        {
            var result = _client.GetAsync(url).Result;
            return result;
        }

        private static async Task<string> ReadResponse(HttpResponseMessage response)
        {
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
}
