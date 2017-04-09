using System.Net.Http;

namespace DotaApiCore.Requests
{
    internal abstract class Request
    {
        public string ApiKey { get; set; }
        
        //TODO: Delete since IoC made this unecessary. Also remove in all subclasses
        public abstract HttpResponseMessage SendRequest();
    }
}
