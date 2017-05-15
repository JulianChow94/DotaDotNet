using Newtonsoft.Json;

namespace DotaApiCore.ItemDetails.Models
{
    public class Items
    {
        [JsonProperty("id")]
        public int ItemId { get; set; }

        [JsonProperty("name")]
        public string ItemName { get; set; }

        [JsonProperty("cost")]
        public int ItemCost { get; set; }

        [JsonProperty("secret_shop")]
        public int ItemFromSecretShop { get; set; }

        [JsonProperty("side_shop")]
        public int ItemFromSideShop { get; set; }

        [JsonProperty("recipe")]
        public int ItemIsRecipe { get; set; }

        [JsonProperty("localized_name")]
        public string ItemLocalizedName { get; set; }
    }
}
