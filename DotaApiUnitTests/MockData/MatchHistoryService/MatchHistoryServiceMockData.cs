using System.IO;
using System.Reflection;

namespace DotaApiUnitTests.MockData.MatchHistoryService
{
    //TODO: Have mock data stored as JSONs instead of hardcoding them in C# files?
    internal static class MatchHistoryServiceMockData
    {
        private static readonly Assembly Assembly = typeof(TestMatchDetailsService).GetTypeInfo().Assembly;

        public static string GenericSuccess = new StreamReader(Assembly.GetManifestResourceStream("DotaApiUnitTests.MockData.MatchHistoryService.SucessfullMatchHistory.json")).ReadToEnd();
        public static string NotFound = new StreamReader(Assembly.GetManifestResourceStream("DotaApiUnitTests.MockData.MatchHistoryService.FailedMatchHistory.json")).ReadToEnd();
    }
}
