using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DotaApiCore.HeroDetails.Models
{
    public class HeroDetailsRequestResult
    {
        [JsonProperty("result")]
        public HeroDetailsResult Result;
    }
}
