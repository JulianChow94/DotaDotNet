using Newtonsoft.Json;

namespace DotaApiCore.MatchHistory.Models
{
    public class MatchHistoryRequestResult
    {
        [JsonProperty("result")]
        public MatchHistoryResult Result;
    }
}
