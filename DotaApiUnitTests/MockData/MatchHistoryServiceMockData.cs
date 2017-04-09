using System;
using System.Collections.Generic;
using System.Text;

namespace DotaApiUnitTests.MockData
{
    //TODO: Have mock data stored as JSONs instead of hardcoding them in C# files?
    public static class MatchHistoryServiceMockData
    {
        public static string GenericSuccess =
            "{\r\n  \"result\": {\r\n    \"status\": 1,\r\n    \"num_results\": 1,\r\n    \"total_results\": 500,\r\n    \"results_remaining\": 499,\r\n    \"matches\": [\r\n      {\r\n        \"match_id\": 3088091200,\r\n        \"match_seq_num\": 2696663841,\r\n        \"start_time\": 1490921858,\r\n        \"lobby_type\": 7,\r\n        \"radiant_team_id\": 0,\r\n        \"dire_team_id\": 0,\r\n        \"players\": [\r\n          {\r\n            \"account_id\": 86737652,\r\n            \"player_slot\": 0,\r\n            \"hero_id\": 74\r\n          },\r\n          {\r\n            \"account_id\": 322,\r\n            \"player_slot\": 1,\r\n            \"hero_id\": 73\r\n          },\r\n          {\r\n            \"account_id\": 32588391,\r\n            \"player_slot\": 2,\r\n            \"hero_id\": 86\r\n          },\r\n          {\r\n            \"account_id\": 61305446,\r\n            \"player_slot\": 3,\r\n            \"hero_id\": 83\r\n          },\r\n          {\r\n            \"account_id\": 145390484,\r\n            \"player_slot\": 4,\r\n            \"hero_id\": 14\r\n          },\r\n          {\r\n            \"account_id\": 4294967295,\r\n            \"player_slot\": 128,\r\n            \"hero_id\": 114\r\n          },\r\n          {\r\n            \"account_id\": 4294967295,\r\n            \"player_slot\": 129,\r\n            \"hero_id\": 90\r\n          },\r\n          {\r\n            \"account_id\": 4294967295,\r\n            \"player_slot\": 130,\r\n            \"hero_id\": 67\r\n          },\r\n          {\r\n            \"account_id\": 4294967295,\r\n            \"player_slot\": 131,\r\n            \"hero_id\": 11\r\n          },\r\n          {\r\n            \"account_id\": 93656109,\r\n            \"player_slot\": 132,\r\n            \"hero_id\": 88\r\n          }\r\n        ]\r\n\r\n      }\r\n    ]\r\n\r\n  }\r\n}\r\n";

        public static string NotFound =
            "{\r\n\"result\":{\r\n\"status\":15,\r\n\"statusDetail\":\"Cannot get match history for a user that hasn\'t allowed it\"\r\n}\r\n}\r\n";
    }
}
