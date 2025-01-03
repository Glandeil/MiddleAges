using MiddleAges.Entities;
using System;
using System.Collections.Generic;

namespace MiddleAges.ViewModels
{
    public class CountryInfoViewModel
    {
        public Country Country { get; set; }
        public List<Land> Lands { get; set; }
        public Player Ruler { get; set; }
        public List<Country> OtherCountries { get; set; }
        public List<Player> OtherRulers { get; set; }
        public List<Law> Laws { get; set; }
        public List<Land> LandsToTranfer { get; set; }        
        public List<BorderLand> BorderLands { get; set; }
        public long PeasantsCount { get; set; }
        public long SoldiersCount { get; set; }
        public long LordsCount { get; set; }
        public string DeviceType { get; set; }
    }
}
