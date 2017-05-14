using System.IO;
using System.Reflection;

namespace DotaApiUnitTests.MockData
{
    internal static class MatchDetailsServiceMockData
    {
        private static Assembly assem = typeof(TestMatchDetailsService).GetTypeInfo().Assembly;

        public static string OldMatch = new StreamReader(assem.GetManifestResourceStream("DotaApiUnitTests.MockData.MatchDetailsService.oldmatch.json")).ReadToEnd();
        public static string NewMatch = new StreamReader(assem.GetManifestResourceStream("DotaApiUnitTests.MockData.MatchDetailsService.newmatch.json")).ReadToEnd();
        public static string FailedMatch = new StreamReader(assem.GetManifestResourceStream("DotaApiUnitTests.MockData.MatchDetailsService.failedmatch.json")).ReadToEnd();
    }
}
