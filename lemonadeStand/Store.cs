using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Store
    {

        public double PurchaseLemons(double lemonsNeededInt, double totalMoney)
        {
            double currentMoney = totalMoney - (lemonsNeededInt * .02);
            Console.WriteLine("At $.02 per lemon, you bought " + lemonsNeededInt + ". Your running total is $" + currentMoney.ToString("0.00") + ".");
            return currentMoney;
        }
        public double PurchaseCups(double cupsNeededInt, double totalMoney)
        {
            double currentMoney = totalMoney - (cupsNeededInt * .02);
            Console.WriteLine("At $.02 per cup, you bought " + cupsNeededInt + ". Your running total is $" + currentMoney.ToString("0.00") + ".");
            return currentMoney;
        }
        public double PurchaseIce(double iceNeededInt, double totalMoney)
        {
            double currentMoney = totalMoney - (iceNeededInt * .02);
            Console.WriteLine("At $.02 per piece of ice, you bought " + iceNeededInt + ". Your running total is $" + currentMoney.ToString("0.00") + ".");
            return currentMoney;
        }
        public double PurchaseSugar(double sugarNeededInt, double totalMoney)
        {
            double currentMoney = totalMoney - (sugarNeededInt * .02);
            Console.WriteLine("At $.02 per gram of sugar, you bought " + sugarNeededInt + ". Your running total is $" + currentMoney.ToString("0.00") + ".");
            return currentMoney;
        }
    }
}
