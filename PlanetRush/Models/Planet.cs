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
        private void ConfigureCorrectOption()
        {
            Random rng = new Random();
            int randomCorrect = rng.Next(3);
            if (randomCorrect == 0)
            {
                NeedsTerraforming = true;
            }
            else if (randomCorrect == 1)
            {
                NeedsGenestealing = true;
            }
            else if (randomCorrect == 2)
            {
                NeedsNuking = true;
            }
        }
        private string GeneratePlanetCode(int galaxyCode)
        {
            string galaxyConversion;
            string quadrant;
            Random rnd = new Random();
            int planetNumber;

            if (galaxyCode == 1)
            {
                galaxyConversion = "M31";
            }
            else if (galaxyCode == 2)
            {
                galaxyConversion = "M33";
            }
            else
            {
                galaxyConversion = "MW";
            }
            char first = (char)rnd.Next('A', 'Z' + 1);
            char second = (char)rnd.Next('A', 'Z' + 1);
            quadrant = first.ToString() + second.ToString();
            planetNumber = rnd.Next(1000, 10000);
            return string.Concat(galaxyConversion + "-" + quadrant + "-" + planetNumber);
        }
    }
}
