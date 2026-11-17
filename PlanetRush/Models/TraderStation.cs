using PlanetRush.Sounds;
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
        public void Visit(Player player)
        {
            bool correctInput = false;
            int input;
            string leaveTraderStation = "You leave the safety of the trader station and journey back into the eternal void of deepspace.";
            string traderStationOptions = $" 1. Sell {DesiredMetal} for Fuel ({FuelForMetalRate} per ton of {DesiredMetal})\n" +
                                          " 2. Leave and travel to the next planet\n" +
                                          " 3. Look at your travel logs";
            Console.WriteLine(@$"The alien-looking trader greets you as you enter his home.
The station is crawling with robotic servants.

    'Welcome in the Trader Station of {Planet.Name}.
     I'm looking to buy {DesiredMetal}. Do you have any?
     I can trade you for it, fellow space explorer.'
");
            Console.WriteLine(traderStationOptions);
            correctInput = int.TryParse(Console.ReadLine(), out input);
            do
            {
                if (!correctInput)
                {
                    Console.Write("Choose a valid option instead: ");
                    correctInput = int.TryParse(Console.ReadLine(), out input);
                }
                if (input == 1)
                {
                    SellMetals(player);
                }
                else if (input == 2)
                {
                    Console.WriteLine(leaveTraderStation);
                }
                else
                {
                    correctInput = false;
                }
            } while (!correctInput);
        }
        private void SellMetals(Player player)
        {
            int carriedTons = DesiredMetal == TrilliumAlloys ? player.TonsOfTrilliumAlloys : player.TonsOfRawAetherium;
            Console.WriteLine("How many tons do you sell?");
            Console.WriteLine($"You currently carry {carriedTons} tons.");
            Console.WriteLine($"Your spacecraft has {player.Spacecraft.CurrentFuel}/{player.Spacecraft.FuelCapacity} liters.");
            int chosenAmount;
            while (!int.TryParse(Console.ReadLine(), out chosenAmount) || chosenAmount > carriedTons || chosenAmount < 0)
            {
                SoundBoard.PlayFailSound();
                Console.Write("Chose a valid amount instead: ");
            }
            if (DesiredMetal == TrilliumAlloys)
            {
                player.TonsOfTrilliumAlloys -= chosenAmount;
            }
            else
            {
                player.TonsOfRawAetherium -= chosenAmount;
            }

            player.AddFuel(chosenAmount * FuelForMetalRate);
            SoundBoard.PlayConfirmSound();
            Console.WriteLine($"You sold {chosenAmount} tons of metals and bought {chosenAmount * FuelForMetalRate} liters of fuel");
        }

    }
}
