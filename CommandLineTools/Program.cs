using System;
using DotaApiCore;

namespace CommandLineTools
{
    public class Program
    {
        private const string ApiKeyPath = "../DotaApiCore/Configuration/APIKey.txt";
        private static string _apiKey;

        static void Main(string[] args)
        {
            var authenticator = new WebApiAuthenticator();
            _apiKey = authenticator.GetWebApiKey(ApiKeyPath);
            Console.WriteLine(_apiKey);
            Console.Read();
        }
    }
}