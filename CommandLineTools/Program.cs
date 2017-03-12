using System;
using DotaApiCore;
using DotaApiCore.MatchHistory;
using System.IO;

namespace CommandLineTools
{
    /*
     * Test program for DotaAPICore
     */
    public class Program
    {
        private const string ApiKeyPath = "./Configuration/APIKey.txt";
        private static string _apiKey = File.ReadAllText(ApiKeyPath);

        static void Main(string[] args)
        {
            Console.WriteLine("API Key: " + _apiKey);

            var matchHistoryService = new MatchHistoryService(_apiKey);
            var latestMatchHistory = matchHistoryService.GetLatestMatchDetailsForUser(accountId: 76561197992854119);

            Console.WriteLine(latestMatchHistory.Result);

            //Pause the output so it doesnt quit right away
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            return;
        }
    }
}