namespace DotaApiCore.Authentication
{
    public interface IWebApiAuthenticator
    {
        string GetWebApiKey(string pathToApiKey);
    }
}
