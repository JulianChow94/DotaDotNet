using DotaApiCore;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace CommandLineTools
{
    public class Program
    {
        private const string ApiKeyPath = "./Configuration/APIKey.txt";
        private static readonly string ApiKey = File.ReadAllText(ApiKeyPath);

        public static void Main(string[] args)
        {
            var lib = new DotaCore(ApiKey);
            var matchHistory = lib.GetMatchHistory(accountId: 70388657, matchesRequested: 1);

            Debug.Assert(matchHistory != null);
            Debug.Assert(matchHistory.Matches.Length == 1);

            var matchDetails1 = lib.GetMatchDetails(3053641442); // Recent tournament match
            var matchDetails2 = lib.GetMatchDetails(501672851);  // Old wraith night game

            Debug.Assert(matchDetails1 != null);
            Debug.Assert(matchDetails1.RadiantWin == true);
            Debug.Assert(matchDetails2 != null);
            Debug.Assert(matchDetails2.RadiantWin == false);

            var heroDetails = lib.GetAllHeroDetails();
            Debug.Assert(heroDetails.Status == (int)HttpStatusCode.OK);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
