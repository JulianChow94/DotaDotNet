using System.Net.Http;
using System.Threading.Tasks;

namespace DotaApiCore.MatchHistory
{
    public class MatchHistoryService : IMatchHistoryService
    {
        private readonly string _apiKey;

        public MatchHistoryService(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<string> GetLatestMatchDetailsForUser(long accountId)
        {
            var url = new RequestBuilder().BuildLatestUserMatchDetailRequest(accountId, _apiKey);
            HttpClient client = new HttpClient();

            var result = client.GetAsync(url).Result;

            result.EnsureSuccessStatusCode();

            string responseBody = await result.Content.ReadAsStringAsync();

            return responseBody;
        }

    }
}
    
