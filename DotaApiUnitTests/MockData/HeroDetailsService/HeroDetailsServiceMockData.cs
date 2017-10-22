using System.IO;
using System.Reflection;

namespace DotaApiUnitTests.MockData.HeroDetailsService
{
    internal static class HeroDetailsServiceMockData
    {
        private static readonly Assembly assem = typeof(HeroDetailsServiceMockData).Assembly;

        public static string GenericSuccess = new StreamReader(assem.GetManifestResourceStream("DotaApiUnitTests.MockData.HeroDetailsService.HeroDetailsResponse.json")).ReadToEnd();
    }
}
