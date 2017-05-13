using Newtonsoft.Json;

namespace DotaApiCore.HeroDetails.Models
{
    public class HeroDetailsResult
    {
        [JsonProperty("heroes")]
        public Hero[] Heroes { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("count")]
        public int TotalHeroes { get; set; }
    }
}
