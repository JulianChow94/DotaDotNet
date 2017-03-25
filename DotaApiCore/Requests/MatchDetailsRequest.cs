using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DotaApiCore.Requests
{
    class MatchDetailsRequest : Request
    {
        private string MatchDetailsURL { get; set; }

        public MatchDetailsRequest(string apiKey, long? matchId = null)
        {
            if (string.IsNullOrEmpty(apiKey) || matchId == null)
            {
                throw new ArgumentException();
            }

            ApiKey = apiKey;
            MatchDetailsURL = SharedLib.Strings.DotaApiBaseUrl +
                SharedLib.Strings.GetMatchDetailsExtension +
                string.Format("?key={0}", ApiKey) +
                string.Format("&match_id={0}", matchId);
        }

        public override HttpResponseMessage SendRequest()
        {
            var client = new HttpClient();
            return client.GetAsync(MatchDetailsURL).Result;
        }
    }
}
