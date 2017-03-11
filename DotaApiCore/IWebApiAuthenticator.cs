using System;
using System.Collections.Generic;
using System.Text;

namespace DotaApiCore
{
    public interface IWebApiAuthenticator
    {
        string GetWebApiKey(string pathToApiKey);
    }
}
