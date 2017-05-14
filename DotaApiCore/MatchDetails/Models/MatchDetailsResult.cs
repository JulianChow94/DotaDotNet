using DotaApiCore.SharedLib;
using Newtonsoft.Json;
using System;

namespace DotaApiCore.MatchDetails.Models
{
    public class MatchDetailsResult
    {
        [JsonProperty("players")]
        public Player[] Players { get; set; }

        [JsonProperty("radiant_win")]
        public bool RadiantWin { get; set; }

        [JsonProperty("duration")] //This and pre_game_duration in seconds
        public int MatchDuration { get; set; }

        [JsonProperty("pre_game_duration")]
        public int PreGameDuration { get; set; }

        [JsonProperty("start_time")] //UNIX timestamp
        private int _startTime { get; set; } //Anything else related to time in seconds

        public DateTime StartTime
        {
            get { return SharedFunctions.UnixTimeStampToDateTime(_startTime); }
        }

        [JsonProperty("match_id")]
        public long Matches { get; set; }

        [JsonProperty("match_seq_num")]
        public long MatchSequenceNumber { get; set; }

        [JsonProperty("tower_status_radiant")]
        public System.UInt16 TowerStatusRadiant { get; set; }

        [JsonProperty("tower_status_dire")]
        public System.UInt16 TowerStatusDire { get; set; }

        [JsonProperty("barracks_status_radiant")]
        public byte BarracksStatusRadiant { get; set; }

        [JsonProperty("barracks_status_dire")]
        public byte BarracksStatusDire { get; set; }

        [JsonProperty("cluster")]
        public int ReplayCluster { get; set; }

        [JsonProperty("first_blood_time")]
        public int FirstBloodTime { get; set; }

        [JsonProperty("lobby_type")]
        public int LobbyType { get; set; }

        [JsonProperty("human_players")]
        public int HumanPlayers { get; set; }

        [JsonProperty("leagueid")]
        public int LeagueID { get; set; }

        [JsonProperty("positive_votes")]
        public int PositiveVotes { get; set; }

        [JsonProperty("negative_votes")]
        public int NegativeVotes { get; set; }

        [JsonProperty("game_mode")]
        public int GameMode { get; set; }

        [JsonProperty("flags")]
        public int Flags { get; set; }

        [JsonProperty("engine")]
        public int Engine { get; set; }

        [JsonProperty("radiant_score")]
        public int RadiantScore { get; set; }

        [JsonProperty("dire_score")]
        public int DireScore { get; set; }

        [JsonProperty("error")]
        public string ErrorMessage { get; set; }
    }
}
