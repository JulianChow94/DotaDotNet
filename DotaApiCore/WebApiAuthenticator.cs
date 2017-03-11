using System.IO;

namespace DotaApiCore
{
    public class WebApiAuthenticator : IWebApiAuthenticator
    {
        public string GetWebApiKey(string pathToApiKey)
        {
            return File.ReadAllText(pathToApiKey);
        }
    }
}
