using System;

namespace DotaApiCore.Requests
{
    internal class ItemDetailsRequest : Request
    {
        public string ItemDetailsURL { get; set; }

        public string Langauge { get; set; }

        public ItemDetailsRequest(string apikey, string language = null)
        {
            if (string.IsNullOrEmpty(apikey) || language == null)
            {
                throw new ArgumentException();
            }

            ApiKey = apikey;
            Langauge = language;

            ItemDetailsURL = SharedLib.Strings.DotaResourcesBaseUrl +
                SharedLib.Strings.GetItemsExtension +
                string.Format("?key={0}", ApiKey) +
                string.Format("&language={0}", Langauge);
        }
    }
}
