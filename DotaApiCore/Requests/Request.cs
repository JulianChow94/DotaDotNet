using System.Net.Http;
using DotaApiCore.MatchHistory.Models;

namespace DotaApiCore.Requests
{
    public abstract class Request
    {
        public string ApiKey { get; set; }

        public abstract HttpResponseMessage SendRequest();

        protected abstract string InitializeUrl(UrlConfiguration urlConfig);
    }
}
