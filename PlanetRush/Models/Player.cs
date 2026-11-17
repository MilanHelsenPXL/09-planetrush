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
        //Voeg een read-only property toe LitersOfFuel die de waarde van Spacecraft.CurrentFuel teruggeeft.
        public int LitersOfFuel
        {
            get
            {
                return Spacecraft.CurrentFuel;
            }
        }
    }
}
