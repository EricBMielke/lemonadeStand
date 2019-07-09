using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Store
    {

        public static double PurchaseLemons(double lemonsNeededInt, double totalMoney)
        {
            double currentMoney = totalMoney - (lemonsNeededInt * .05);
            Console.WriteLine("At $.05 per lemon, you bought " + lemonsNeededInt + ". Your running total is $" + currentMoney + ".");
            return currentMoney;
        }
        public static double PurchaseCups(double cupsNeededInt, double totalMoney)
        {
            double currentMoney = totalMoney - (cupsNeededInt * .05);
            Console.WriteLine("At $.04 per cup, you bought " + cupsNeededInt + ". Your running total is $" + currentMoney + ".");
            return currentMoney;
        }
        public static double PurchaseIce(double iceNeededInt, double totalMoney)
        {
            double currentMoney = totalMoney - (iceNeededInt * .05);
            Console.WriteLine("At $.04 per piece of ice, you bought " + iceNeededInt + ". Your running total is $" + currentMoney + ".");
            return currentMoney;
        }
        public static double PurchaseSugar(double sugarNeededInt, double totalMoney)
        {
            double currentMoney = totalMoney - (sugarNeededInt * .05);
            Console.WriteLine("At $.04 per gram of sugar, you bought " + sugarNeededInt + ". Your running total is $" + currentMoney + ".");
            return currentMoney;
        }
    }
}
