using DotaApiCore.HeroDetails.Models;
using DotaApiCore.Requests;
using Newtonsoft.Json;

namespace DotaApiCore.HeroDetails
{
    internal class HeroDetailsService : IHeroDetailsService
    {
        private readonly string _apiKey;
        private readonly IHttpHandler _client;

        public HeroDetailsService(IHttpHandler handler, string apiKey)
        {
            _client = handler;
            _apiKey = apiKey;
        }

        public HeroDetailsRequestResult GetHeroDetails(string language = null)
        {
            var heroDetailsRequest = new HeroDetailsRequest(_apiKey, language);
            var responseBody = _client.SendRequest(heroDetailsRequest.RequestUrl);

            var results = JsonConvert.DeserializeObject<HeroDetailsRequestResult>(responseBody);
            return results;
        }
    }
}
