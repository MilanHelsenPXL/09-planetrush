using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetRush.Models
{
    internal class Spacecraft
    {
        public string Name { get; set; }
        public int FuelCapacity { get; set; }
        public int CargoCapacity { get; set; }
        public int EngineEfficiency { get; set; }
        public bool HasWarpDriveCharge { get; set; }
        //Voorzie een private veld _currentFuel en een property CurrentFuel
        //waarbij de setter de waarde beperkt tot FuelCapacity via Math.Min(value, FuelCapacity).
        private int _currentFuel;

        public int CurrentFuel
        {
            get { return _currentFuel; }
            set
            {
                _currentFuel = Math.Min(value, FuelCapacity);
            }
        }
    }
}
