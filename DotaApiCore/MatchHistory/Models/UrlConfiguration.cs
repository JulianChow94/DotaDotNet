using Newtonsoft.Json;

namespace DotaApiCore.MatchHistory.Models
{
    internal class UrlConfiguration
    {
        [JsonProperty("DotaApiBaseUrl")]
        public string BaseUrl { get; set; }

        public string GetMatchHistoryExtension { get; set; }
    }
}
