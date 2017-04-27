using System.Reflection;
using System.IO;

namespace DotaApiUnitTests.MockData
{
    internal static class MatchDetailsServiceMockData
    {
        public static string Success1 = "{\"result\":{}}";
        public static string Success2 = "{\"result\":{}}";
        public static string Failure1 = "{\"result\":{}}";
        public static string Failure2 = "{\"result\":{}}";

        private static Assembly assem = typeof(TestMatchDetailsService).GetTypeInfo().Assembly;
        private static string[] temp = assem.GetManifestResourceNames();
        private static Stream resource = assem.GetManifestResourceStream(temp[0]);
        private static StreamReader reader = new StreamReader(resource);
        public static string Test1 = reader.ReadToEnd();
    }
}
