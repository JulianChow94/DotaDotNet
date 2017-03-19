using Newtonsoft.Json;

namespace DotaApiCore.MatchHistory.Models
{
    public class Player
    {
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("player_slot")]
        public int PlayerSlot { get; set; }

        [JsonProperty("hero_id")]
        public int HeroId { get; set; }
    }
}
