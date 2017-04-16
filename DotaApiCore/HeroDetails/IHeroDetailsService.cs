using DotaApiCore.HeroDetails.Models;

namespace DotaApiCore.HeroDetails
{
    internal interface IHeroDetailsService
    {
        HeroDetailsRequestResult GetHeroDetails(string language = "en");
    }
}
