using DotaApiCore.MatchDetails.Models;

namespace DotaApiCore.MatchDetails
{
    internal interface IMatchDetailsService
    {
        MatchDetailsRequestResult GetMatchDetails(long? matchId = null);
    }
}
