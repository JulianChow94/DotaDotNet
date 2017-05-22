using System.IO;
using System.Reflection;

namespace DotaApiUnitTests.MockData.ItemDetailsService
{
    internal static class ItemDetailsServiceMockData
    {
        private static Assembly assem = typeof(TestItemDetailsService).GetTypeInfo().Assembly;

        public static string ItemDetails = new StreamReader(assem.GetManifestResourceStream("DotaApiUnitTests.MockData.ItemDetailsService.itemdetails.json")).ReadToEnd();
    }
}
