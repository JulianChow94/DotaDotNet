using DotaApiCore.ItemDetails.Models;

namespace DotaApiCore.ItemDetails
{
    internal interface IItemDetailsService
    {
        ItemDetailsRequestResult GetItemDetails(string language);
    }
}
