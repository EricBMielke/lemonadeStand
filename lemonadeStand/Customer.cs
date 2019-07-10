using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Customer
    {
        public static int chancePurchaseByPrice(double pricePerCup)
        {
            if (.75 < pricePerCup && pricePerCup <= 1)
            {
                Random rnd = new Random();
                int chanceDueToPrice = rnd.Next(35, 55);
                return chanceDueToPrice;
            }
            else if (.5 <= pricePerCup && pricePerCup <= .75)
            {
                Random rnd = new Random();
                int chanceDueToPrice = rnd.Next(40, 60);
                return chanceDueToPrice;
            }
            else if (.25 <= pricePerCup && pricePerCup < .50)
            {
                Random rnd = new Random();
                int chanceDueToPrice = rnd.Next(45, 65);
                return chanceDueToPrice;
            }
            else
            {
                Random rnd = new Random();
                int chanceDueToPrice = rnd.Next(50, 70);
                return chanceDueToPrice;
            }
        }
        public static int chancePurchaseByTemperature(double temperature)
        {
            if (85 < temperature && temperature <= 100)
            {
                Random rnd = new Random();
                int chanceDueToTemp = rnd.Next(50, 80);
                return chanceDueToTemp;
            }
            else if (65 <= temperature && temperature <= 85)
            {
                Random rnd = new Random();
                int chanceDueToTemp = rnd.Next(35, 65);
                return chanceDueToTemp;
            }
            else
            {
                Random rnd = new Random();
                int chanceDueToTemp = rnd.Next(25, 55);
                return chanceDueToTemp;
            }
        }
        public static bool lemonadePurchase (int chanceDueToTemp, int ChanceDueToPrice)
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
