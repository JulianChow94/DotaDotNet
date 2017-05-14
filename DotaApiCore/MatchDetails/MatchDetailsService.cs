using DotaApiCore.MatchDetails.Models;
using DotaApiCore.Requests;
using Newtonsoft.Json;

namespace DotaApiCore.MatchDetails
{
    internal class MatchDetailsService : IMatchDetailsService
    {
        private readonly string _apiKey;
        private readonly IHttpHandler _handler;

        public MatchDetailsService(IHttpHandler handler, string apiKey)
        {
            _apiKey = apiKey;
            _handler = handler;
        }

        public MatchDetailsRequestResult GetMatchDetails(long? matchId = null)
        {
            var request = new MatchDetailsRequest(_apiKey, matchId);
            var response = _handler.SendRequest(request.MatchDetailsURL);

            return JsonConvert.DeserializeObject<MatchDetailsRequestResult>(response);
        }
    }
}
