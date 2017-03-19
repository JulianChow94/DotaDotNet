using Newtonsoft.Json;

namespace DotaApiCore.MatchHistory.Models
{
    public class UrlConfiguration
    {
        [JsonProperty("DotaApiBaseUrl")]
        public string BaseUrl { get; set; }

        public string GetMatchHistoryExtension { get; set; }
    }
}
