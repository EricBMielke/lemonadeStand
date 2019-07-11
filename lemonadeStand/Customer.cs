using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Customer
    {
        static Random rng;

        static Customer()
        {
            rng = new Random();
        }

        public int ChancePurchaseByPrice(double pricePerCup)
        {
            rng = new Random();

            if (.75 < pricePerCup && pricePerCup <= 1)
            {
                int chanceDueToPrice = rng.Next(35, 55);
                return chanceDueToPrice;
            }
            else if (.5 <= pricePerCup && pricePerCup <= .75)
            {
                int chanceDueToPrice = rng.Next(40, 60);
                return chanceDueToPrice;
            }
            else if (.25 <= pricePerCup && pricePerCup < .50)
            {
                int chanceDueToPrice = rng.Next(45, 65);
                return chanceDueToPrice;
            }
            else
            {
                int chanceDueToPrice = rng.Next(50, 70);
                return chanceDueToPrice;
            }
        }
        public int ChancePurchaseByTemperature(double temperature)
        {
            if (85 < temperature && temperature <= 100)
            {
                int chanceDueToTemp = rng.Next(50, 80);
                return chanceDueToTemp;
            }
            else if (65 <= temperature && temperature <= 85)
            {
                int chanceDueToTemp = rng.Next(35, 65);
                return chanceDueToTemp;
            }
            else
            {
                int chanceDueToTemp = rng.Next(25, 55);
                return chanceDueToTemp;
            }
        }
        public bool LemonadePurchase (int chanceDueToTemp, int ChanceDueToPrice)
        {
            if ((chanceDueToTemp * ChanceDueToPrice) > 2500)
            {
                return true;
            }
            else
                return false;
        }
    }
}
