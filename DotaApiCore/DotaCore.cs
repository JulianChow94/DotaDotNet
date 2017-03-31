using System;
using DotaApiCore.MatchHistory;
using DotaApiCore.MatchHistory.Models;
using DotaApiCore.Requests;
using DotaApiCore.SharedLib.ServiceContainer;
using Microsoft.Extensions.DependencyInjection;

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

            _provider = ServiceContainers.Services.BuildServiceProvider();
        }

        public MatchHistoryResult GetMatchHistory(long? accountId = null, int? heroId = null, int? gameMode = null,
            int? skill = null, int? minPlayers = null, 
            long?  startingMatchId = null, int? matchesRequested = 100)
        {
            var service = _provider.GetService<MatchHistoryService>();
            var matchHistory = service.GetMatchHistory(accountId: 32588391, matchesRequested: 1);

            return matchHistory.Result;
        }
    }
}
