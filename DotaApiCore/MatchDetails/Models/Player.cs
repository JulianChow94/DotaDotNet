﻿using Newtonsoft.Json;

namespace DotaApiCore.MatchDetails.Models
{
    //The player class in MatchHistory is a subset of of the stuff here
    public class Player : MatchHistory.Models.Player
    {
        //Contains itemid. 0 means no item
        [JsonProperty ("item_0")]
        public int Item0 { get; set; }

        [JsonProperty("item_1")]
        public int Item1 { get; set; }

        [JsonProperty("item_2")]
        public int Item2 { get; set; }

        [JsonProperty("item_3")]
        public int Item3 { get; set; }

        [JsonProperty("item_4")]
        public int Item4 { get; set; }

        [JsonProperty("item_5")]
        public int Item5 { get; set; }

        [JsonProperty("backpack_0")]
        public int Backpack0 { get; set; }

        [JsonProperty("backpack_1")]
        public int Backpack1 { get; set; }

        [JsonProperty("backpack_2")]
        public int Backpack2 { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        /*
            0, NONE: Player finished match with no abandon
            1, DISCONNECTED: Player disconnected from the match without an abandon
            2, DISCONNECTED_TOO_LONG: Player was disconnected from the match for greater than 5 minutes and was assessed with an abandon
            3, ABANDONED: Player disconnected, clicked leave, and abandoned the game
            4, AFK: Player was assessed with an abandon after being idle in the game for too long
            5, NEVER_CONNECTED: Player never connected to the game, but was not given an abandon
            6, NEVER_CONNECTED_TOO_LONG: Player took too long to connect and never connected, but no abandon was given
         */
        [JsonProperty("leaver_status")]
        public int LeaverStatus { get; set; }

        [JsonProperty("last_hits")] //CS LUL
        public int LastHits { get; set; }

        [JsonProperty("denies")]
        public int Denies { get; set; }

        [JsonProperty("gold_per_min")]
        public int GPM { get; set; }

        [JsonProperty("xp_per_min")]
        public int XPM { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        //Newer properties that may not exist in older matchIDs

        [JsonProperty("hero_damage")]
        public int HeroDamage { get; set; }

        [JsonProperty("tower_damage")]
        public int TowerDamage { get; set; }

        [JsonProperty("hero_healing")]
        public int HeroHealing { get; set; }

        [JsonProperty("gold")]
        public int Gold { get; set; }

        [JsonProperty("gold_spent")]
        public int gold_spent { get; set; }

        [JsonProperty("scaled_hero_damage")]
        public int ScaledHeroDamage { get; set; }

        [JsonProperty("scaled_tower_damage")]
        public int ScaledTowerDamage { get; set; }

        [JsonProperty("scaled_hero_healing")]
        public int ScaledHeroHealing { get; set; }

        [JsonProperty("ability_upgrades")]
        public Abilities[] AbilityUpgrades { get; set; }
    }
}