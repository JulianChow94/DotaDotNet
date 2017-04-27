using System.Reflection;
using System.IO;

namespace DotaApiUnitTests.MockData
{
    internal static class MatchDetailsServiceMockData
    {
        private static Assembly assem = typeof(TestMatchDetailsService).GetTypeInfo().Assembly;

        public static string OldMatch = new StreamReader(assem.GetManifestResourceStream("DotaApiUnitTests.MockData.oldmatch.json")).ReadToEnd();
        public static string NewMatch = new StreamReader(assem.GetManifestResourceStream("DotaApiUnitTests.MockData.newmatch.json")).ReadToEnd();
        public static string FailedMatch = new StreamReader(assem.GetManifestResourceStream("DotaApiUnitTests.MockData.failedmatch.json")).ReadToEnd();
    }
}
