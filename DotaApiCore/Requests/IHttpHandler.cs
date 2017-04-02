using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DotaApiCore.Requests
{
    public interface IHttpHandler
    {
        string SendRequest(string url);
    }
}