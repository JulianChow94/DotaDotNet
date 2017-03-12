using System;
using System.Collections.Generic;
using System.Text;

namespace DotaApiCore
{
    /*
     * Big wrapper object used to bridge the C# API and whatever is importing this library.
     * Instantiated with an API key.
     */
    class DotaAPIRequest
    {
        private readonly string _apiKey;

        //TODO: custom exceptions?
        public DotaAPIRequest(string APIKey = null)
        {
            if (APIKey == null)
                throw new Exception();
            else
               _apiKey = APIKey;
        }
    }
}
