using System.Threading.Tasks;

namespace DotaApiCore.MatchHistory
{
    public interface IMatchHistoryService
    {
        Task<string> GetLatestMatchDetailsForUser(long accountId);
    }
}
