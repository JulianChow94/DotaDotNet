using System.Threading.Tasks;
using DotaApiCore.UserMatchHistory.Models;

namespace DotaApiCore.UserMatchHistory
{
    public interface IUserMatchHistoryService
    {
        Task<UserMatchHistoryRequestResult> GetLatestMatchDetailsForUser(long accountId);
    }
}
