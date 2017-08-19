using DotaApiCore.HeroDetails;
using DotaApiCore.HeroDetails.Models;
using DotaApiCore.ItemDetails;
using DotaApiCore.ItemDetails.Models;
using DotaApiCore.MatchDetails;
using DotaApiCore.MatchDetails.Models;
using DotaApiCore.MatchHistory;
using DotaApiCore.MatchHistory.Models;
using DotaApiCore.Requests;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using SimpleInjector;

[assembly: InternalsVisibleTo("DotaApiUnitTests")]

namespace DotaApiCore
{
    public class DotaCore
    {
        private readonly string _apiKey;
        private static Container _container;

        public DotaCore(string apiKey)
        {
            _apiKey = apiKey;

            SetUpContainers();
        }

        private void SetUpContainers()
        {
            _container = new Container();
            _container.Register<IHttpHandler, HttpClientHandler>();

            _container.Register<MatchHistoryService>(
                () => new MatchHistoryService(_container.GetInstance<IHttpHandler>(), _apiKey));

            _container.Register<MatchDetailsService>(
                () => new MatchDetailsService(_container.GetInstance<IHttpHandler>(), _apiKey));

            _container.Register<HeroDetailsService>(
                () => new HeroDetailsService(_container.GetInstance<IHttpHandler>(), _apiKey));

            _container.Register<ItemDetailsService>(
                () => new ItemDetailsService(_container.GetInstance<IHttpHandler>(), _apiKey));

            _container.Verify();
        }

        public static MatchHistoryResult GetMatchHistory(long? accountId = null, int? heroId = null, int? gameMode = null,
            int? skill = null, int? minPlayers = null,
            long? startingMatchId = null, int? matchesRequested = 100)
        {
            IMatchHistoryService service = _container.GetService<MatchHistoryService>();
            MatchHistoryRequestResult matchHistory = service.GetMatchHistory(accountId, heroId, gameMode, skill,
                minPlayers, startingMatchId, matchesRequested);

            return matchHistory.Result;
        }

        public static MatchDetailsResult GetMatchDetails(long? matchID = null)
        {
            IMatchDetailsService service = _container.GetService<MatchDetailsService>();
            MatchDetailsRequestResult details = service.GetMatchDetails(matchID);

            return details.Result;
        }

        public static HeroDetailsResult GetAllHeroDetails(string language = "en_us")
        {
            IHeroDetailsService service = _container.GetService<HeroDetailsService>();
            HeroDetailsRequestResult heroDetails = service.GetHeroDetails(language);

            return heroDetails.Result;
        }

        public static ItemDetailsResult GetAllItemDetails (string language = "en_us")
        {
            IItemDetailsService service = _container.GetService<ItemDetailsService>();
            ItemDetailsRequestResult details = service.GetItemDetails(language);
            return details.Result;
        }
    }
}
