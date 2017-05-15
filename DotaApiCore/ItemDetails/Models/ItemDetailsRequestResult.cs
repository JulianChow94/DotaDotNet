using Newtonsoft.Json;

namespace DotaApiCore.ItemDetails.Models
{
    public class ItemDetailsRequestResult
    {
        [JsonProperty("result")]
        public ItemDetailsResult Result;
    }
}
