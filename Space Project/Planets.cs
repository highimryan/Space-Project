using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTrader
{
    public class Planet
    {
        public string name;
        public string description;

        double xPos;
        double yPos;

        decimal tradeRate;

        public List<Items> item;

        public Planet(string name, string description, double xPos, double yPos, List<Items> item, decimal tradeRate = 1.0M)
        {
            this.name = name;
            this.description = description;
            this.xPos = xPos;
            this.yPos = yPos;
            this.tradeRate = tradeRate;
            this.item = item;
        }

        public double DistanceTo(Planet destination)
        {
            var left = Math.Pow(this.xPos - destination.xPos, 2);
            var right = Math.Pow(this.yPos - destination.yPos, 2);

            return Math.Sqrt(left + right);
        }

        public decimal CostOf(Items items) =>
            items.cost * tradeRate;
    }
}
