using DotaApiCore.UserMatchHistory.Models;
using Newtonsoft.Json;

namespace DotaApiCore.UserMatchHistory.Models
{
    public class UserMatchHistoryRequestResult
    {
        [JsonProperty("result")]
        public UserMatchHistoryResult Result;
    }
}
