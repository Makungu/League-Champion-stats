using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace leagueChampionStats.Models
{
    public class champion
    {
        public int id {get; set;}
        public string name {get; set;}
        public string role {get; set;}
        public string type {get; set;}
        public string region {get; set;}
    }
}

