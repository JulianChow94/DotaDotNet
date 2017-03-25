using DotaApiCore.MatchDetails;
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

            var testMatchHistoryService = new MatchHistoryService(ApiKey);
            var matchHistory = testMatchHistoryService.GetMatchHistory(accountId: 32588391, matchesRequested: 1);

            Debug.Assert(matchHistory != null);
            Debug.Assert(matchHistory.Result.Matches.Length == 1);

            var testMatchDetailsService = new MatchDetailsService(ApiKey);
            var matchDetails1 = testMatchDetailsService.GetMatchDetails(3053641442); //Recent tournament match
            var matchDetails2 = testMatchDetailsService.GetMatchDetails(501672851); //Old wraith night game

            Debug.Assert(matchDetails1 != null);
            Debug.Assert(matchDetails2 != null);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            return;
        }
    }
}
