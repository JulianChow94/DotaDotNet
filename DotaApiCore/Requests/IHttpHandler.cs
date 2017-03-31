using System.Net.Http;
using System.Threading.Tasks;

namespace DotaApiCore.Requests
{
    internal interface IHttpHandler
    {
        HttpResponseMessage Get(string url);
        HttpResponseMessage Post(string url, HttpContent content);
        Task<HttpResponseMessage> GetAsync(string url);
    }
}