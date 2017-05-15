using DotaApiCore.ItemDetails.Models;
using DotaApiCore.Requests;
using Newtonsoft.Json;

namespace DotaApiCore.ItemDetails
{
    internal class ItemDetailsService : IItemDetailsService
    {
        private readonly string _apikey_;
        private readonly IHttpHandler _httpclient_;

        public ItemDetailsService (IHttpHandler handler, string apikey)
        {
            _apikey_ = apikey;
            _httpclient_ = handler;
        }

        public ItemDetailsRequestResult GetItemDetails (string language = null)
        {
            var request = new ItemDetailsRequest(_apikey_, language);
            var response = _httpclient_.SendRequest(request.ItemDetailsURL);
            return JsonConvert.DeserializeObject<ItemDetailsRequestResult>(response);
        }
    }
}
