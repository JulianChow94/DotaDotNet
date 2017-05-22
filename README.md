# DotaDotNet
.NET Core wrapper for Dota 2 Steam Web API

## CommandLineTools
Sample program on how to use the library. Requires an API key from valve at 
https://steamcommunity.com/dev/apikey and placed in CommandLineTools/Configuration/APIKey.txt

## DotaApiCore
The library itself. Currently has 4 public functions that correspond to 4 different API calls.

`GetMatchHistory()` fetches match history of a specific user  
`GetMatchDetails()` fetches detailed information about a specific match  
`GetAllHeroDetails()` fetches information about all heroes currently in the game  
`GetAllItemDetails()` fetches all items currently in the game

## DotaApiCoreUnitTest
Unit testing suite for the library.
