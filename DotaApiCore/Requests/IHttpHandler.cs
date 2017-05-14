namespace DotaApiCore.Requests
{
    public interface IHttpHandler
    {
        string SendRequest(string url);
    }
}