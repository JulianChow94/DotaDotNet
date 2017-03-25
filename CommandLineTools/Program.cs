using DotaApiCore.MatchHistory;
using System;
using System.Diagnostics;
using System.IO;

//Temp test program since there are no unit tests yet
namespace CommandLineTools
{
    public class Program
    {
        private const string ApiKeyPath = "./Configuration/APIKey.txt";
        private static readonly string ApiKey = File.ReadAllText(ApiKeyPath);

        public static void Main(string[] args)
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
