using Newtonsoft.Json;

namespace DotaApiCore.MatchHistory.Models
{
    public class MatchHistoryResult
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("statusDetail")]
        public string StatusDetail { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("results_remaining")]
        public int ResultsRemaining { get; set; }

        [JsonProperty("matches")]
        public Matches[] Matches { get; set; }

    }
}
