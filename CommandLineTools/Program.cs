using System;
using DotaApiCore;
using System.IO;
using DotaApiCore.UserMatchHistory;

namespace CommandLineTools
{
    /*
     * Test program for DotaAPICore
     */
    public class Program
    {
        private const string ApiKeyPath = "./Configuration/APIKey.txt";
        private static readonly string ApiKey = File.ReadAllText(ApiKeyPath);

        static void Main(string[] args)
        {
            Console.WriteLine("API Key: " + ApiKey);

            var matchHistoryService = new UserMatchHistoryService(ApiKey);
            var latestMatchHistory = matchHistoryService.GetLatestMatchDetailsForUser(accountId: 32588391);

            Console.WriteLine(latestMatchHistory.Result);

            //Pause the output so it doesnt quit right away
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            return;
        }
    }
}