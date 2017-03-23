using Newtonsoft.Json;

namespace DotaApiCore.MatchDetails.Models
{
    public class MatchDetailsRequestResult
    {
        [JsonProperty("result")]
        public MatchDetailsResult Result;
    }
}
