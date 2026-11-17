using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetRush.Models
{
    internal class Planet
    {
        public int Radius { get; set; }
        public int Seed { get; set; }
        public string Name { get; set; }
        public int TonsOfRawAetherium { get; set; }
        public int TonsOfTrilliumAlloys { get; set; }
        public bool NeedsTerraforming { get; set; }
        public bool NeedsGenestealing { get; set; }
        public bool NeedsNuking { get; set; }
        public int NumberOfLightYearsToReach { get; set; }

        public int ResourceDensity
        {
            get { return (TonsOfRawAetherium + TonsOfTrilliumAlloys) / 10; }
        }
        //Implementeer een parameterloze constructor die de constructor met galaxyCode = 0 aanroept. (zie PLANET-04)
        public Planet() : this(0)
        {
            
        }
    }
}
