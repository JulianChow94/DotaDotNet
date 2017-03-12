using Newtonsoft.Json;
using System;

namespace DotaApiCore.UserMatchHistory.Models
{
    public class Matches
    {
        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        [JsonProperty("match_seq_num")]
        public long MatchSequenceNumber { get; set; }

        // Unix timestamp
        [JsonProperty("start_time")]
        private int _startTime { get; set; }

        public DateTime StartTime
        {
            get { return UnixTimeStampToDateTime(_startTime); }
        }

        [JsonProperty("lobby_type")]
        public int LobbyType { get; set; }

        [JsonProperty("radiant_team_id")]
        public int RadiantTeamId { get; set; }

        [JsonProperty("dire_team_id")]
        public int DireTeamId { get; set; }

        [JsonProperty("players")]
        public Player[] Players { get; set; }

        private DateTime UnixTimeStampToDateTime(int epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch);
        }
    }
}
