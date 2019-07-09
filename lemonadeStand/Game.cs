using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Game
    {
        public double dayCount;
        public string totalPlayTime;
        public void RunGame()
        {
            double totalLemons = 0;
            double totalCups = 0;
            double totalSugar = 0;
            double totalIce = 0;
            double totalMoney = 20;
            int dayCount = 0;
            Console.WriteLine("Welcome to Lemonade Stand! What is your name?");
            string player1 = Console.ReadLine();
            Console.WriteLine("Let's begin " + player1 + "!");
            Console.WriteLine("You are in charge of ordering lemons, ice, sugar and cups for your lemonade stand. You will create the recipe and sell it to the masses. Your currently have $" + totalMoney + " to build your empire");
            Console.WriteLine("For how long would you like to play the game? Your options are 7, 14, or 21 days.");
            int totalPlayTime = Int32.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Alright, " + player1 + ". How many lemons would you like to buy?");
                double lemonsNeededInt = Int32.Parse(Console.ReadLine());
                totalMoney = Inventory.PurchaseLemons(lemonsNeededInt, totalMoney);
                totalLemons = totalLemons + lemonsNeededInt;
                Console.WriteLine("Your total number of lemons are " + totalLemons);
                Console.WriteLine("How many cups would you like to buy? Price is $.04 per piece.");
                double cupsNeededInt = Int32.Parse(Console.ReadLine());
                totalMoney = Inventory.PurchaseCups(cupsNeededInt, totalMoney);
                totalCups = (cupsNeededInt + totalCups);
                Console.WriteLine("Your total number of cups are " + totalCups);
                Console.WriteLine("How much ice would you like to buy? Price is $.04 per piece.");
                double iceNeededInt = Int32.Parse(Console.ReadLine());
                totalMoney = Inventory.PurchaseIce(iceNeededInt, totalMoney);
                totalIce = (iceNeededInt + totalCups);
                Console.WriteLine("Your total ice is " + totalIce);
                Console.WriteLine("How much sugar would you like to buy? Price is $.04 per piece.");
                double sugarNeededInt = Int32.Parse(Console.ReadLine());
                totalMoney = Inventory.PurchaseSugar(sugarNeededInt, totalMoney);
                totalSugar = totalSugar + sugarNeededInt;
                Console.WriteLine("Your total sugar is " + totalSugar);
                Inventory.InventoryTotalStatement(totalSugar, totalCups, totalIce, totalLemons);
                Console.ReadLine();
                dayCount++;
            }
            while (dayCount < totalPlayTime);
        }
    }
}
