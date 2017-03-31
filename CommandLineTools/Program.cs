using DotaApiCore.MatchHistory;
using System;
using System.Diagnostics;
using System.IO;
using DotaApiCore;

namespace CommandLineTools
{
    public class Program
    {
        private const string ApiKeyPath = "./Configuration/APIKey.txt";
        private static readonly string ApiKey = File.ReadAllText(ApiKeyPath);

        public static void Main(string[] args)
        {
            Console.WriteLine("API Key: " + ApiKey);

            var lib = new DotaCore(ApiKey);
            var matchHistory = lib.GetMatchHistory();

            Debug.Assert(matchHistory != null);
            Debug.Assert(matchHistory.Matches.Length == 1);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            return;
        }
    }
}
