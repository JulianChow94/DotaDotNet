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
        private string _apiKey;
        private URLBuilder httpRequestHelper;

        //TODO: custom exceptions?
        public DotaAPIRequest(string APIKey = null)
        {
            if (APIKey == null)
                throw new Exception();
            else
               _apiKey = APIKey;

            httpRequestHelper = new URLBuilder();
        }

        /*
         * Uses contents of this object to send an HTTP GET request from the Dota2 API.
         * Returns the JSON result upon a successful request, or an error if it fails.
        */
        //TODO: fill this in
        public string SendGetRequest()
        {
            return null;
        }

    }
}
