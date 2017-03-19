using System;
using System.Diagnostics;
using System.IO;
using DotaApiCore.MatchHistory;

namespace CommandLineTools
{
    public class Program
    {
        private const string ApiKeyPath = "./Configuration/APIKey.txt";
        private static readonly string ApiKey = File.ReadAllText(ApiKeyPath);

        static void Main(string[] args)
        {
            Console.WriteLine("API Key: " + ApiKey);

            var matchHistoryService = new MatchHistoryService(ApiKey);
            var matchHistory = matchHistoryService.GetMatchHistory(accountId: 32588391, matchesRequested: 1);

            Debug.Assert(matchHistory != null);
            Debug.Assert(matchHistory.Result.Matches.Length == 1);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            return;
        }
    }
}