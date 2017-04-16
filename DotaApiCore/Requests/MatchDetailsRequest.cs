using System;
using System.Diagnostics;
using System.Net.Http;

namespace DotaApiCore.Requests
{
    internal class MatchDetailsRequest : Request
    {
        public string MatchDetailsURL { get; set; }

        public MatchDetailsRequest(string apiKey, long? matchId = null)
        {
            if (string.IsNullOrEmpty(apiKey) || matchId == null)
            {
                throw new ArgumentException();
            }

            ApiKey = apiKey;
            MatchDetailsURL = SharedLib.Strings.DotaMatchBaseUrl +
                SharedLib.Strings.GetMatchDetailsExtension +
                string.Format("?key={0}", ApiKey) +
                string.Format("&match_id={0}", matchId);
        }

        //TODO: Delete
        public override HttpResponseMessage SendRequest()
        {
            Debug.WriteLine(MatchDetailsURL);
            var client = new HttpClient();
            return client.GetAsync(MatchDetailsURL).Result;
        }
    }
}
