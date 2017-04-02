using System.Net.Http;

namespace DotaApiCore.Requests
{
    internal abstract class Request
    {
        public string ApiKey { get; set; }

        public abstract HttpResponseMessage SendRequest();
    }
}
