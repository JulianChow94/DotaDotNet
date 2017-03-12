
namespace DotaApiCore
{
    /*
     * Helper class for DotaAPIRequest objects to construct HTTP GET URLs from the Steam API
     */
    
    //TODO: ensure URLBuilder supports all of these types of requests
    public class URLBuilder
    {
        /*
         * Retrieving match history (25 latest only):
         *      GetMatchHistory/V001/?key=<key>
         * 
         * Retrieving match history in XML:
         *      GetMatchHistory/V001/?format=XML&key=<key>
         * 
         * Retrieve 25 starting from id:
         *      GetMatchHistory/V001/?start_at_match_id=27110133&key=<key>
         * 
         * Other args for GetMatchHistory:     
         *      player_name=<name> # Search matches with a player name, exact match only
         *      hero_id=<id> # Search for matches with a specific hero being played, hero id's are in dota/scripts/npc/npc_heroes.txt in your Dota install directory
         *      skill=<skill>  # 0 for any, 1 for normal, 2 for high, 3 for very high skill
         *      date_min=<date> # date in UTC seconds since Jan 1, 1970 (unix time format)
         *      date_max=<date> # date in UTC seconds since Jan 1, 1970 (unix time format)
         *      account_id=<id> # Steam account id (this is not SteamID, its only the account number portion)
         *      league_id=<id> # matches for a particular league
         *      start_at_match_id=<id> # Start the search at the indicated match id, descending
         *      matches_requested=<n> # Defaults is 25 matches, this can limit to less
         * 
         * Details about a specific match
         *      GetMatchDetails/V001/?match_id=27110133&key=<key>
         * 
         */

        //TODO: BaseURL(s) in external JSON file for modularity.
        private static string baseUrl = "https://api.steampowered.com/IDOTA2Match_570/";

        public string BuildLatestUserMatchDetailRequest(long accountId, string apiKey)
        {
            var requestUrl = baseUrl;
            requestUrl = requestUrl + "GetMatchHistory/V001/" + string.Format("?key={0}", apiKey);

            requestUrl = requestUrl + string.Format("&account_Id={0}&matches_requested=1", accountId);

            return requestUrl;
        }
    }
}
