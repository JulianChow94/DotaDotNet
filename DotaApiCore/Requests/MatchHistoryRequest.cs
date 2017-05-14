using System.Diagnostics;
using System.Net.Http;

namespace DotaApiCore.Requests
{
    internal class MatchHistoryRequest : Request
    {
        /*
         * TODO: LeagueID to be implemented as part of the "League sprint"
         * Omitting for now
         * Same situation for Tourney games only filter
         */

        private string MatchHistoryBaseUrl { get; }

        public long? AccountId { get; set; }

        public int? HeroId { get; set; }

        //TODO: Enumerize
        public int? GameMode { get; set; }

        //TODO: Enumerize
        public int? Skill { get; set; }

        public int? MinimumPlayers { get; set; }

        public long? StartAtMatchId { get; set; }

        public int? MatchesRequested { get; set; }

        public string RequestUrl { get; set; }

        public MatchHistoryRequest(string apiKey, long? accountId = null, int? heroId = null, int? gameMode = null, int? skill = null,
            int? minPlayers = null, long? startingMatchId = null, int? matchesRequested = 100)
        {
            ApiKey = apiKey;
            AccountId = accountId;
            HeroId = heroId;
            GameMode = gameMode;
            Skill = skill;
            MinimumPlayers = minPlayers;
            StartAtMatchId = startingMatchId;
            MatchesRequested = matchesRequested;
            MatchHistoryBaseUrl = SharedLib.Strings.DotaMatchBaseUrl +
                SharedLib.Strings.GetMatchHistoryExtension +
                string.Format("?key={0}", ApiKey);

            RequestUrl = BuildUrlParameters(MatchHistoryBaseUrl);
        }

        //TODO: Delete
        public override HttpResponseMessage SendRequest()
        {
            var client = new HttpClient();
            var result = client.GetAsync(RequestUrl).Result;

            return result;
        }

        private string BuildUrlParameters(string requestUrl)
        {
            if (AccountId != null)
            {
                requestUrl = requestUrl + string.Format("&account_Id={0}", AccountId);
            }

            if (HeroId != null)
            {
                requestUrl = requestUrl + string.Format("&hero_id={0}", HeroId);
            }

            if (GameMode != null)
            {
                requestUrl = requestUrl + string.Format("&game_mode={0}", GameMode);
            }

            if (Skill != null)
            {
                requestUrl = requestUrl + string.Format("&skill={0}", Skill);
            }

            if (MinimumPlayers != null)
            {
                requestUrl = requestUrl + string.Format("&min_players={0}", MinimumPlayers);
            }

            if (StartAtMatchId != null)
            {
                requestUrl = requestUrl + string.Format("&start_at_match_id={0}", StartAtMatchId);
            }

            if (MatchesRequested != null)
            {
                requestUrl = requestUrl + string.Format("&matches_requested={0}", MatchesRequested);
            }

            return requestUrl;
        }
    }
}
