using Newtonsoft.Json;

namespace DotaApiCore.MatchDetails.Models
{
    public class Abilities
    {
        [JsonProperty("ability")]
        public int Ability { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }
    }
}
