using System.Net.Http;
using DotaApiCore.Requests;

namespace DotaApiCore.HeroDetails.Models
{
    internal class HeroDetailsRequest : Request
    {
        private string HeroDetailsBaseUrl { get; }

        public string Language { get; set; }

        public string RequestUrl { get; set; }

        public HeroDetailsRequest(string apiKey, string language = null)
        {
            ApiKey = apiKey;
            Language = language;
            HeroDetailsBaseUrl = SharedLib.Strings.DotaResourcesBaseUrl +
                                 SharedLib.Strings.GetHeroesExtension + string.Format("?key={0}", ApiKey);

            RequestUrl = BuildUrlParameters(HeroDetailsBaseUrl);
        }

        public override HttpResponseMessage SendRequest()
        {
            var client = new HttpClient();
            var result = client.GetAsync(RequestUrl).Result;

            return result;
        }

        private string BuildUrlParameters(string requestUrl)
        {
            if (!string.IsNullOrEmpty(Language))
            {
                requestUrl = requestUrl + string.Format("&language={0}", Language);
            }

            return requestUrl;
        }
    }
}
