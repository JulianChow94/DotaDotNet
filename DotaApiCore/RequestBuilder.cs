using System;
using System.Collections.Generic;
using System.Text;

namespace DotaApiCore
{
    /*
     * FLAGGED FOR DELETION
     */
    public class RequestBuilder
    {
        //TODO: BaseURL(s) in external JSON file for modularity.
        public static string BaseUrl = "https://api.steampowered.com/IDOTA2Match_570/";

        public string BuildLatestUserMatchDetailRequest(long accountId, string apiKey)
        {
            var requestUrl = BaseUrl;
            requestUrl = requestUrl + "GetMatchHistory/V001/" + string.Format("?key={0}", apiKey);

            requestUrl = requestUrl + string.Format("&accountId={0}&matches_requested=1", accountId);

            return requestUrl;
        }
    }
}
