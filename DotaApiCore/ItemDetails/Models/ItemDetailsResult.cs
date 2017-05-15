using Newtonsoft.Json;

namespace DotaApiCore.ItemDetails.Models
{
    public class ItemDetailsResult
    {
        [JsonProperty("items")]
        public Items[] Items { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }
}
