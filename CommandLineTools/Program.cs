using DotaApiCore;
using DotaApiCore.MatchHistory.Models;
using DotaApiCore.MatchDetails.Models;
using DotaApiCore.HeroDetails.Models;
using DotaApiCore.ItemDetails.Models;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace CommandLineTools
{
    //Sample program on how to use DotaApiCore wrapper
    public static class Program
    {
        private const string ApiKeyPath = "./Configuration/APIKey.txt";
        private static readonly string ApiKey = File.ReadAllText(ApiKeyPath);

        public static void Main(string[] args)
        {
            //Create new instance of DotaCore object using API key
            DotaCore lib = new DotaCore(ApiKey);

            //DotaCore.GetMatchHistory fetches match history of a specific accountid
            MatchHistoryResult matchHistory = lib.GetMatchHistory(accountId: 32588391, matchesRequested: 1);
            Debug.Assert(matchHistory != null);
            Debug.Assert(matchHistory.Matches.Count == 1);

            //DotaCore.GetMatchDetails gets detailed information about a specific matchid
            MatchDetailsResult matchDetails1 = lib.GetMatchDetails(3053641442); // Recent tournament match
            MatchDetailsResult matchDetails2 = lib.GetMatchDetails(501672851);  // Old wraith night game
            Debug.Assert(matchDetails1 != null);
            Debug.Assert(matchDetails1.RadiantWin == true);
            Debug.Assert(matchDetails2 != null);
            Debug.Assert(matchDetails2.RadiantWin == false);

            //DotaCore.GetHeroDetails fetches all heroes in the API with hero names localized to en_uk (en_us default)
            HeroDetailsResult heroDetails = lib.GetAllHeroDetails("en_uk");
            Debug.Assert(heroDetails.Status == (int)HttpStatusCode.OK);

            //DotaCore.GetItemDetails fetches all items in the API with item names localized to en_uk (en_us default)
            ItemDetailsResult itemDetails = lib.GetAllItemDetails("en_uk");
            Debug.Assert(itemDetails.Status == (int)HttpStatusCode.OK);

            Console.WriteLine("All POC tests have passed. Press any key to continue");
            Console.ReadKey();
        }
    }
}
