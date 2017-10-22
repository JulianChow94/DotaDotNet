using System.IO;
using System.Reflection;

namespace DotaApiUnitTests.MockData.ItemDetailsService
{
    internal static class ItemDetailsServiceMockData
    {
        private static readonly Assembly assem = typeof(ItemDetailsServiceMockData).Assembly;

        public static readonly string ItemDetails = new StreamReader(assem.GetManifestResourceStream("DotaApiUnitTests.MockData.ItemDetailsService.itemdetails.json")).ReadToEnd();
    }
}
