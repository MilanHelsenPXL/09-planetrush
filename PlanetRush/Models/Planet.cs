using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetRush.Models
{
    internal class Planet
    {
        //Maak de volgende publieke properties: Radius, Seed, Name, TonsOfRawAetherium, TonsOfTrilliumAlloys,
        //NeedsTerraforming, NeedsGenestealing, NeedsNuking, NumberOfLightYearsToReach.
        public int Radius { get; set; }
        public int Seed { get; set; }
        public string Name { get; set; }
        public int TonsOfRawAetherium { get; set; }
        public int TonsOfTrilliumAlloys { get; set; }
        public bool NeedsTerraforming { get; set; }
        public bool NeedsGenestealing { get; set; }
        public bool NeedsNuking { get; set; }
        public int NumberOfLightYearsToReach { get; set; }
    }
}
