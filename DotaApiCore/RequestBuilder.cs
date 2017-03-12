namespace DotaApiCore
{
    /*
     * Class used to build HTTP requests to the Steam API. Should return whatever the Steam API returns.
     */
    public class RequestBuilder
    {
        //TODO: Move to resx
        public static string BaseUrl = "https://api.steampowered.com/IDOTA2Match_570/";

        public string BuildLatestUserMatchDetailRequest(long accountId, string apiKey)
        {
            var requestUrl = BaseUrl;
            requestUrl = requestUrl + "GetMatchHistory/V001/" + string.Format("?key={0}", apiKey);

            requestUrl = requestUrl + string.Format("&account_Id={0}&matches_requested=1", accountId);

            return requestUrl;
        }
    }
}
