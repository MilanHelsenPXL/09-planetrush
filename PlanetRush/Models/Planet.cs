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
        public Planet() : this(0)
        {

        }

        public Planet(int galaxyCode)
        {
            Random random = new Random();
            Radius = random.Next(4, 14);
            Seed = random.Next(); // ???????????????
            Name = GeneratePlanetCode(galaxyCode);
            TonsOfRawAetherium = random.Next(10, 111);
            TonsOfTrilliumAlloys = random.Next(-10, 31);
            if (TonsOfTrilliumAlloys < 0)
            {
                TonsOfTrilliumAlloys = 0;
            }

            NumberOfLightYearsToReach = random.Next(5, 21);
            ConfigureCorrectOption();
        }
    }
}
