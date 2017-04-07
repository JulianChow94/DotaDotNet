using System.Runtime.CompilerServices;
using DotaApiCore.MatchDetails.Models;
using DotaApiCore.Requests;
using DotaApiCore.SharedLib;
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
            var response = SharedFunctions.SendAndValidateRequest(request);

            return JsonConvert.DeserializeObject<MatchDetailsRequestResult>(response.Result);
        }

    }
}
