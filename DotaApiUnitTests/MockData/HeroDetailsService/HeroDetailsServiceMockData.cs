using System.IO;
using System.Reflection;

namespace DotaApiUnitTests.MockData.HeroDetailsService
{
    internal static class HeroDetailsServiceMockData
    {
        private static readonly Assembly asm = typeof(TestMatchDetailsService).GetTypeInfo().Assembly;

        public static string GenericSuccess =
            new StreamReader(
                asm.GetManifestResourceStream(
                    "DotaApiUnitTests.MockData.HeroDetailsService.HeroDetailsResponse.json")).ReadToEnd();
    }
}
