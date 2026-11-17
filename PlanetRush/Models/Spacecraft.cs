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
        private int _currentFuel;

        public int CurrentFuel
        {
            get { return _currentFuel; }
            set
            {
                _currentFuel = Math.Min(value, FuelCapacity);
            }
        }
        public Spacecraft()
        {
            FuelCapacity = 1000;
            CurrentFuel = FuelCapacity;
            CargoCapacity = 1000;
            EngineEfficiency = 10;
            HasWarpDriveCharge = false;
        }
    }
}
