using DotaApiCore.MatchDetails.Models;

namespace DotaApiCore.MatchDetails
{
    public interface IMatchDetailsService
    {
        MatchDetailsRequestResult GetMatchDetails(long? matchId = null);
    }
}
