using Newtonsoft.Json;

namespace DotaApiCore.MatchHistory.Models
{
    internal class UrlConfiguration
    {
        [JsonProperty("DotaMatchBaseUrl")]
        public string BaseUrl { get; set; }

        public string GetMatchHistoryExtension { get; set; }
    }
}
