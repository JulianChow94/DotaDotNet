using System.Threading.Tasks;
using DotaApiCore.MatchHistory.Models;
using DotaApiCore.Requests;
using Newtonsoft.Json;

namespace DotaApiCore.MatchHistory
{
    public class MatchHistoryService : IMatchHistoryService
    {
        private readonly string _apiKey;

        public MatchHistoryService(string apiKey)
        {
            _apiKey = apiKey;
        }

        public MatchHistoryRequestResult GetMatchHistory(long? accountId = null, 
            int? heroId = null, int? gameMode = null, int? skill = null,
            int? minPlayers = null, long? startingMatchId = null, int? matchesRequested = 100)
        {
            var matchHistoryRequest = new MatchHistoryRequest(_apiKey, accountId, heroId, gameMode, 
                skill, minPlayers, startingMatchId, matchesRequested);

            var responseBody = SendAndValidateRequest(matchHistoryRequest);

            var results = JsonConvert.DeserializeObject<MatchHistoryRequestResult>(responseBody.Result);

            return results;
        }

        private static async Task<string> SendAndValidateRequest(Request matchHistoryRequest)
        {
            var result = matchHistoryRequest.SendRequest();
            result.EnsureSuccessStatusCode();

            var responseBody = await result.Content.ReadAsStringAsync();

            return responseBody;
        }
    }
}
    
