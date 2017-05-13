using System.IO;
using System.Reflection;

namespace DotaApiUnitTests.MockData.HeroDetailsService
{
    internal static class HeroDetailsServiceMockData
    {
        private static readonly Assembly Assembly = typeof(TestMatchDetailsService).GetTypeInfo().Assembly;

        public static string GenericSuccess =
            new StreamReader(
                Assembly.GetManifestResourceStream(
                    "DotaApiUnitTests.MockData.HeroDetailsService.HeroDetailsResponse.json")).ReadToEnd();

    }
}
