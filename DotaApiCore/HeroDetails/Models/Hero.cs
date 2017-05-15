using Newtonsoft.Json;

namespace DotaApiCore.HeroDetails.Models
{
    public class Hero
    {
        [JsonProperty("name")]
        public string HeroName { get; set; }

        [JsonProperty("id")]
        public int HeroId { get; set; }

        [JsonProperty("localized_name")]
        public string HeroLocalizedName { get; set; }
    }
}
