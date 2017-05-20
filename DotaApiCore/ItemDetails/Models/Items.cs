using Newtonsoft.Json;

namespace DotaApiCore.ItemDetails.Models
{
    public class Items
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("secret_shop")]
        public int FromSecretShop { get; set; }

        [JsonProperty("side_shop")]
        public int FromSideShop { get; set; }

        [JsonProperty("recipe")]
        public int IsRecipe { get; set; }

        [JsonProperty("localized_name")]
        public string LocalizedName { get; set; }
    }
}
