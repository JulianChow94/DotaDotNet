using System.IO;

namespace DotaApiCore.Authentication
{
    /*
     * Class used to fetch your authentication key required for the Steam API.
     */
    public class WebApiAuthenticator : IWebApiAuthenticator
    {
        public string GetWebApiKey(string pathToApiKey)
        {
            return File.ReadAllText(pathToApiKey);
        }
    }
}
