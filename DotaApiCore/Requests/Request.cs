using System.Net.Http;

namespace DotaApiCore.Requests
{
    public abstract class Request
    {
        public string ApiKey { get; set; }

        public abstract HttpResponseMessage SendRequest();
    }
}
