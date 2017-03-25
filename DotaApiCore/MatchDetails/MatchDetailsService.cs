using DotaApiCore.MatchDetails.Models;
using DotaApiCore.Requests;
using Newtonsoft.Json;

namespace DotaApiCore.MatchDetails
{
    public class MatchDetailsService : IMatchDetailsService
    {
        private readonly string _apiKey;

        public MatchDetailsService(string apiKey)
        {
            _apiKey = apiKey;
        }

        public MatchDetailsRequestResult GetMatchDetails(long? matchId = null)
        {
            var request = new MatchDetailsRequest(_apiKey, matchId);
            var response = SharedFunctions.SendAndValidateRequest(request);

            return JsonConvert.DeserializeObject<MatchDetailsRequestResult>(response.Result);
        }

    }
}
