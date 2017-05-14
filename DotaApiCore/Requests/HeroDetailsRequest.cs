using System.Net.Http;

namespace DotaApiCore.Requests
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
