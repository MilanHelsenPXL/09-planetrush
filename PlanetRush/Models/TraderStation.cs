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

            }
}
