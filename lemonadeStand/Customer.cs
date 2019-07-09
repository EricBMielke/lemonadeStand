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
                int chanceDueToPrice = rnd.Next(0, 25);
                return chanceDueToPrice;
            }
            else if (.5 <= pricePerCup && pricePerCup <= .75)
            {
                Random rnd = new Random();
                int chanceDueToPrice = rnd.Next(25, 50);
                return chanceDueToPrice;
            }
            else if (.25 <= pricePerCup && pricePerCup < .50)
            {
                Random rnd = new Random();
                int chanceDueToPrice = rnd.Next(50, 75);
                return chanceDueToPrice;
            }
            else
            {
                Random rnd = new Random();
                int chanceDueToPrice = rnd.Next(60, 90);
                return chanceDueToPrice;
            }
        }
        public static int chancePurchaseByTemperature(double temperature)
        {
            if (85 < temperature && temperature <= 100)
            {
                Random rnd = new Random();
                int chanceDueToTemp = rnd.Next(70, 95);
                return chanceDueToTemp;
            }
            else if (65 <= temperature && temperature <= 85)
            {
                Random rnd = new Random();
                int chanceDueToTemp = rnd.Next(30, 70);
                return chanceDueToTemp;
            }
            else
            {
                Random rnd = new Random();
                int chanceDueToTemp = rnd.Next(20, 50);
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
