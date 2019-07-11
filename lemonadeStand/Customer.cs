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

            if (.75 < pricePerCup && pricePerCup <= 1)
            {
                int chanceDueToPrice = rng.Next(25, 55);
                return chanceDueToPrice;
            }
            else if (.5 <= pricePerCup && pricePerCup <= .75)
            {
                int chanceDueToPrice = rng.Next(30, 60);
                return chanceDueToPrice;
            }
            else if (.25 <= pricePerCup && pricePerCup < .50)
            {
                int chanceDueToPrice = rng.Next(35, 65);
                return chanceDueToPrice;
            }
            else
            {
                int chanceDueToPrice = rng.Next(40, 70);
                return chanceDueToPrice;
            }
        }
        public int ChancePurchaseByTemperature(double temperature)
        {
            if (85 < temperature && temperature <= 100)
            {
                int chanceDueToTemp = 5;
                return chanceDueToTemp;
            }
            else if (65 <= temperature && temperature <= 85)
            {
                int chanceDueToTemp = 4;
                return chanceDueToTemp;
            }
            else
            {
                int chanceDueToTemp = 3;
                return chanceDueToTemp;
            }
        }
        public bool LemonadePurchase (int chanceDueToTemp, int ChanceDueToPrice)
        {
            if ((chanceDueToTemp * ChanceDueToPrice) > 200)
            {
                return true;
            }
            else
                return false;
        }
    }
}
