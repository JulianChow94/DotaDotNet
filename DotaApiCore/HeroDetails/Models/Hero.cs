using Newtonsoft.Json;

namespace DotaApiCore.HeroDetails.Models
{
    public class Hero
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("localized_name")]
        public string LocalizedName { get; set; }
    }
}
