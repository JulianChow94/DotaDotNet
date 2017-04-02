using DotaApiCore.MatchHistory.Models;

namespace DotaApiCore.MatchHistory
{
    internal interface IMatchHistoryService
    {
        MatchHistoryRequestResult GetMatchHistory(long? accountId = null, int? heroId = null, int? gameMode = null, int? skill = null,
            int? minPlayers = null, long? startingMatchId = null, int? matchesRequested = 100);
    }
}
