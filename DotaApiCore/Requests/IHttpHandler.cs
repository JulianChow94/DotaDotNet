using System.Net.Http;
using System.Threading.Tasks;

namespace DotaApiCore.Requests
{
    internal interface IHttpHandler
    {
        string SendRequest(string url);
    }
}