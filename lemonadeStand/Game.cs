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
                int temperature = Weather.createTemperature();
                Console.WriteLine("Alright, " + player1 + ". How many lemons would you like to buy?");
                double lemonsNeededInt = Int32.Parse(Console.ReadLine());
                totalMoney = Store.PurchaseLemons(lemonsNeededInt, totalMoney);
                totalLemons = totalLemons + lemonsNeededInt;
                Console.WriteLine("Your total number of lemons are " + totalLemons);
                Console.WriteLine("How many cups would you like to buy? Price is $.04 per piece.");
                double cupsNeededInt = Int32.Parse(Console.ReadLine());
                totalMoney = Store.PurchaseCups(cupsNeededInt, totalMoney);
                totalCups = (cupsNeededInt + totalCups);
                Console.WriteLine("Your total number of cups are " + totalCups);
                Console.WriteLine("How much ice would you like to buy? Price is $.04 per piece.");
                double iceNeededInt = Int32.Parse(Console.ReadLine());
                totalMoney = Store.PurchaseIce(iceNeededInt, totalMoney);
                totalIce = (iceNeededInt + totalIce);
                Console.WriteLine("Your total ice is " + totalIce);
                Console.WriteLine("How much sugar would you like to buy? Price is $.04 per piece.");
                double sugarNeededInt = Int32.Parse(Console.ReadLine());
                totalMoney = Store.PurchaseSugar(sugarNeededInt, totalMoney);
                totalSugar = totalSugar + sugarNeededInt;
                Console.WriteLine("Your total sugar is " + totalSugar);
                Inventory.InventoryTotalStatement(totalSugar, totalCups, totalIce, totalLemons);
                Console.WriteLine("Lets build today's recipe: How much sugar per cup would you like?");
                int todaysSugarPerCup = Int32.Parse(Console.ReadLine());
                Console.WriteLine("How much ice per cup would you like?");
                int todaysIcePerCup = Int32.Parse(Console.ReadLine());
                Console.WriteLine("How many lemons per cup would you like?");
                int todaysLemonPerCup = Int32.Parse(Console.ReadLine());
                Console.WriteLine("How much is a price of lemonade? From free to $1");
                double pricePerCup = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < 100; i++)
                {
                int chanceDueToPrice = Customer.chancePurchaseByPrice(pricePerCup);
                int chanceDueToTemp = Customer.chancePurchaseByTemperature(temperature);
                if (Customer.lemonadePurchase(chanceDueToPrice, chanceDueToTemp))
                    {
                        totalMoney = totalMoney + pricePerCup;
                        totalIce = totalIce-todaysIcePerCup;
                        totalSugar = totalSugar - todaysSugarPerCup;
                        totalLemons = totalSugar - todaysLemonPerCup;
                        totalCups = totalCups - 1;
                        if (totalCups == 0 || totalSugar == 0 || totalIce == 0 || totalLemons == 0)
                        {
                            Console.WriteLine("Sold out for the day");
                            break;
                        }
                        Console.ReadLine();
                    }
                }

                dayCount++;
            }
            while (dayCount < totalPlayTime);
        }
    }
}
