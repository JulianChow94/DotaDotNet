using System.Net.Http;
using System.Threading.Tasks;
using DotaApiCore.UserMatchHistory.Models;
using Newtonsoft.Json;

namespace DotaApiCore.UserMatchHistory
{
    public class UserMatchHistoryService : IUserMatchHistoryService
    {
        private readonly string _apiKey;

        public UserMatchHistoryService(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<UserMatchHistoryRequestResult> GetLatestMatchDetailsForUser(long accountId)
        {
            var url = new RequestBuilder().BuildLatestUserMatchDetailRequest(accountId, _apiKey);
            var client = new HttpClient();

            var result = client.GetAsync(url).Result;

            result.EnsureSuccessStatusCode();

            var responseBody = await result.Content.ReadAsStringAsync();

            var results = JsonConvert.DeserializeObject<UserMatchHistoryRequestResult>(responseBody);

            return results;
        }

    }
}
    
