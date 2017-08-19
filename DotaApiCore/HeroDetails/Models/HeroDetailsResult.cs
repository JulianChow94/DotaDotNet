using System.Collections.Generic;
using Newtonsoft.Json;

namespace DotaApiCore.HeroDetails.Models
{
    public class HeroDetailsResult
    {
        [JsonProperty("heroes")]
        public List<Hero> Heroes { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("count")]
        public int TotalHeroes { get; set; }
    }
}
