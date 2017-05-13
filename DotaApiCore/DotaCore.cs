using System;
using System.Runtime.CompilerServices;
using DotaApiCore.HeroDetails;
using DotaApiCore.HeroDetails.Models;
using DotaApiCore.MatchDetails;
using DotaApiCore.MatchDetails.Models;
using DotaApiCore.MatchHistory;
using DotaApiCore.MatchHistory.Models;
using DotaApiCore.Requests;
using DotaApiCore.SharedLib.ServiceContainer;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("DotaApiUnitTests")]

namespace DotaApiCore
{
    public class DotaCore
    {
        private readonly string _apiKey;
        private IServiceProvider _provider;

        public DotaCore(string apiKey)
        {
            _apiKey = apiKey;

            SetUpContainers();
        }

        private void SetUpContainers()
        {
            ServiceContainers.Services.AddTransient<IHttpHandler, HttpClientHandler>();
            ServiceContainers.Services.AddTransient<MatchHistoryService>(
                provider => new MatchHistoryService(provider.GetService<IHttpHandler>(), _apiKey));
            ServiceContainers.Services.AddTransient<MatchDetailsService>(
                provider => new MatchDetailsService(provider.GetService<IHttpHandler>(), _apiKey));
            ServiceContainers.Services.AddTransient<HeroDetailsService>(
                provider => new HeroDetailsService(provider.GetService<IHttpHandler>(), _apiKey));

            _provider = ServiceContainers.Services.BuildServiceProvider();
        }

        public MatchHistoryResult GetMatchHistory(long? accountId = null, int? heroId = null, int? gameMode = null,
            int? skill = null, int? minPlayers = null, 
            long? startingMatchId = null, int? matchesRequested = 100)
        {
            IMatchHistoryService service = _provider.GetService<MatchHistoryService>();
            MatchHistoryRequestResult matchHistory = service.GetMatchHistory(accountId, heroId, gameMode, skill, 
                minPlayers, startingMatchId, matchesRequested);

            return matchHistory.Result;
        }

        public MatchDetailsResult GetMatchDetails(long? matchID = null)
        {
            IMatchDetailsService service = _provider.GetService<MatchDetailsService>();
            MatchDetailsRequestResult details = service.GetMatchDetails(matchID);

            return details.Result;
        }

        public HeroDetailsResult GetAllHeroDetails(string language = null)
        {
            IHeroDetailsService service = _provider.GetService<HeroDetailsService>();
            HeroDetailsRequestResult heroDetails = service.GetHeroDetails(language);

            return heroDetails.Result;
        }
    }
}
