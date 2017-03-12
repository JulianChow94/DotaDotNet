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

            //var result = client.GetAsync("https://api.steampowered.com/IDOTA2Match_570/GetMatchHistory/V001/?key=E42BD4E39D900957FE9BDC8706798DA3&account_id=76561197992854119&matches_requested=1").Result;

            var result = client.GetAsync(url).Result;

            result.EnsureSuccessStatusCode();

            string responseBody = await result.Content.ReadAsStringAsync();

            return responseBody;
        }

    }
}
    