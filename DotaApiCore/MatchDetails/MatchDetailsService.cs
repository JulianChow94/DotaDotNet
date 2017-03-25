using DotaApiCore.MatchDetails.Models;
using DotaApiCore.Requests;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace DotaApiCore.MatchDetails
{
    public class MatchDetailsService : IMatchDetailsService
    {
        //TODO
        public MatchDetailsRequestResult GetMatchDetails(long? matchId = null)
        {
            var request = new MatchDetailsRequest();
            var response = SharedFunctions.SendAndValidateRequest(request);

            return JsonConvert.DeserializeObject<MatchDetailsRequestResult>(response.Result);
        }

    }
}
