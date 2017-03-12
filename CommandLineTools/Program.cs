using System;
using DotaApiCore;
using DotaApiCore.MatchHistory;

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

            var matchHistoryService = new MatchHistoryService(_apiKey);

            var latestMatchHistory = matchHistoryService.GetLatestMatchDetailsForUser(accountId: 76561197992854119);

            Console.WriteLine(latestMatchHistory.Result);

            Console.Read();
        }
    }
}