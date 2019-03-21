using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SpaceTrader
{
    public class Player
    {
        public double age = 20;
        public decimal money;

        public Planet planet;
        public Races race;

        public List<Items> inventory = new List<Items>();

        public Player(Planet planet, Races race)
        {
            this.planet = planet;
            this.race = race;
            money = 1000M;
        }

        public void TravelTo(Planet destination, double warpSpeed)
        {
            var distance = planet.DistanceTo(destination);
            var speed = Utilities.WarpSpeedToLightSpeed(warpSpeed);

            age += distance / speed;

            planet = destination;
        }

        public void BuyItem(Items item)
        {
            money -= planet.CostOf(item);
            inventory.Add(item);
        }

        public void SellItem(Items item)
        {
            money += planet.CostOf(item);
            inventory.Remove(item);
        }
    }
}