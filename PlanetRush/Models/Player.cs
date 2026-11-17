using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetRush.Models
{
    internal class Player
    {
        public int TonsOfTrilliumAlloys { get; set; }
        public int TonsOfRawAetherium { get; set; }
        public Spacecraft Spacecraft { get; set; }
        public int LitersOfFuel
        {
            get
            {
                return Spacecraft.CurrentFuel;
            }
        }

        public Player()
        {
            Spacecraft = new Spacecraft();
        }
        public void AddFuel(int fuel)
        {
            Spacecraft.CurrentFuel += fuel;
        }
        public void TravelLightYears(int lightYears)
        {
            //LitersOfFuel of spacecraft.currentfuel???
            Spacecraft.CurrentFuel -= lightYears * Spacecraft.EngineEfficiency;
        }
    }
}
