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
            int? minPlayers = null, long? startingMatchId = null,
            int? matchesRequested = 100)
        {
            var matchHistoryRequest = new MatchHistoryRequest(_apiKey, accountId, heroId, gameMode,
                skill, minPlayers, startingMatchId, matchesRequested);

            var responseBody = SharedFunctions.SendAndValidateRequest(matchHistoryRequest);

            var results = JsonConvert.DeserializeObject<MatchHistoryRequestResult>(responseBody.Result);

            return results;
        }
    }
}
