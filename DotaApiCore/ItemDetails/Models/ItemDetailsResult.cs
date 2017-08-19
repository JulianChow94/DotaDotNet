using System.Collections.Generic;
using Newtonsoft.Json;

namespace DotaApiCore.ItemDetails.Models
{
    public class ItemDetailsResult
    {
        [JsonProperty("items")]
        public List<Items> Items { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }
}
