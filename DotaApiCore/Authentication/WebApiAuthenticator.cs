using System.IO;

namespace DotaApiCore.Authentication
{
    public class WebApiAuthenticator : IWebApiAuthenticator
    {
        public string GetWebApiKey(string pathToApiKey)
        {
            return File.ReadAllText(pathToApiKey);
        }
    }
}
