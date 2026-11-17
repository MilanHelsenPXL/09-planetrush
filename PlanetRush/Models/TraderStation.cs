using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetRush.Models
{
    internal class TraderStation
    {
        private const string TrilliumAlloys = "Trillium Alloys";
        private const string RawAetherium = "Raw Aetherium";
        private string _desiredMetal;

        public string DesiredMetal
        {
            get { return _desiredMetal; }
            set
            {
                if (value.Equals(TrilliumAlloys) || value.Equals(RawAetherium))
                {
                    _desiredMetal = value;
                }
                else
                {
                    _desiredMetal = "NONE";
                }

            }
        }
        public bool HasWarpDriveChargesForSale { get; set; }
        public int FuelForMetalRate { get; set; }
        public Planet Planet { get; set; }
        public TraderStation(Planet planet)
        {
            Planet = planet;
            Random rng = new Random();
            int randomNumber = rng.Next(2);
            if (randomNumber == 0)
            {
                DesiredMetal = TrilliumAlloys;
                FuelForMetalRate = rng.Next(10, 20);
            }
            else if (randomNumber == 1)
            {
                DesiredMetal = RawAetherium;
                FuelForMetalRate = rng.Next(2, 7);
            }

            randomNumber = rng.Next(1, 11);
            if (randomNumber == 10)
            {
                HasWarpDriveChargesForSale = true;
            }

        }

    }
}
