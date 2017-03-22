using Newtonsoft.Json;

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

        [JsonProperty("start_time")] //Should be UNIX timestamp
        public long StartTime { get; set; } //Anything else related to time in seconds

        [JsonProperty("match_id")]
        public long Matches { get; set; }

        [JsonProperty("match_seq_num")]
        public long MatchSequenceNumber { get; set; }

        [JsonProperty("tower_status_radiant")] //16bit UINT mask
        public System.UInt16 TowerStatusRadiant { get; set; }

        [JsonProperty("tower_status_dire")]
        public System.UInt16 TowerStatusDire { get; set; }

        [JsonProperty("barracks_status_radiant")] //8bit UINT mask
        public byte BarracksStatusRadiant { get; set; }

        [JsonProperty("barracks_status_dire")]
        public byte BarracksStatusDire { get; set; }

        [JsonProperty("cluster")]
        public int ReplayCluster { get; set; }

        [JsonProperty("first_blood_time")]
        public int FirstBloodTime { get; set; }

        /*
         Indicates the type of lobby, such as public, practice, ranked, etc. 
            -1: Invalid
            0: Public matchmaking
            1: Practice
            2: Tournament
            3: Tutorial
            4: Co-op with bots
            5: Team match
            6: Solo queue
            7: Ranked
            8: Solo mid 1 vs. 1
         */
        [JsonProperty("lobby_type")]
        public int LobbyType { get; set; }

        [JsonProperty("human_players")]
        public int HumanPlayers { get; set; }

        [JsonProperty("leagueid")]
        public int LeagueID { get; set; }

        [JsonProperty("postive_votes")]
        public int PositiveVotes { get; set; }

        [JsonProperty("negative_votes")]
        public int NegativeVotes { get; set; }

        /*
            0: Unknown
            1: All pick
            2: Captains mode
            3: Random draft
            4: Single draft
            5: All random
            6: Intro
            7: The Diretide
            8: Reverse captains mode
            9: Greeviling
            10: Tutorial
            11: Mid only
            12: Least played
            13: New player pool
            14: Compendium matchmaking
            15: Custom
            16: Captains draft
            17: Balanced draft
            18: Ability draft
            19: Event
            20: All random death match
            21: 1 vs. 1 solo mid
            22: Ranked all pick
         */
        [JsonProperty("game_mode")]
        public int GameMode { get; set; }

        [JsonProperty("flags")]
        public int Flags { get; set; }

        /*
            0 Source1
            1 Source2
         */
        [JsonProperty("engine")]
        public int Engine { get; set; }

        [JsonProperty("radiant_score")]
        public int RadiantScore { get; set; }

        [JsonProperty("dire_score")]
        public int DireScore { get; set; }
    }
}
