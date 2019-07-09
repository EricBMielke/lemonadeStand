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
            string player1;
            int totalPlayTime;

            player1 = Setup.WelcomePlayer();
            totalPlayTime = Setup.GameplayDuration(totalMoney);
            do
            {
                int temperature = Weather.createTemperature();
                string weatherType = Weather.createWeather();
                int patronNumbers = Day.patronsByDay(weatherType);
                double lemonsNeededInt = UserInterface.LemonsWanted(player1);
                totalMoney = Store.PurchaseLemons(lemonsNeededInt, totalMoney);
                totalLemons = UserInterface.TotalLemons(totalLemons, lemonsNeededInt);
                double cupsNeededInt = UserInterface.CupsWanted(player1);
                totalMoney = Store.PurchaseCups(cupsNeededInt, totalMoney);
                totalCups = UserInterface.TotalCups(totalCups, cupsNeededInt);
                double iceNeededInt = UserInterface.IceWanted(player1);
                totalMoney = Store.PurchaseIce(iceNeededInt, totalMoney);
                totalIce = UserInterface.TotalIce(totalIce, iceNeededInt);
                double sugarNeededInt = UserInterface.SugarWanted(player1);
                totalMoney = Store.PurchaseSugar(sugarNeededInt, totalMoney);
                totalSugar = UserInterface.TotalSugar(totalSugar, sugarNeededInt);
                Inventory.InventoryTotalStatement(totalSugar, totalCups, totalIce, totalLemons);
                Console.WriteLine("Lets build today's recipe: How much sugar per cup would you like?");
                int todaysSugarPerCup = Int32.Parse(Console.ReadLine());
                Console.WriteLine("How much ice per cup would you like?");
                int todaysIcePerCup = Int32.Parse(Console.ReadLine());
                Console.WriteLine("How many lemons per cup would you like?");
                int todaysLemonPerCup = Int32.Parse(Console.ReadLine());
                Console.WriteLine("How much is a price of lemonade? From free to $1");
                double pricePerCup = Double.Parse(Console.ReadLine());
                for (int i = 0; i < patronNumbers; i++)
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
                        if (Ice.CheckEmpty(totalIce, i))
                        {
                            break;
                        }
                        if (Lemon.CheckEmpty(totalLemons, i))
                        {
                            break;
                        }
                        if (Sugar.CheckEmpty(totalSugar, i))
                        {
                            break;
                        }
                        if (Cups.CheckEmpty(totalCups, i))
                        {
                            break;
                        }
                    }
                }
                Day.EndOfDayResults(totalSugar, totalCups, totalIce, totalLemons, totalMoney);
                dayCount++;
            }
            while (dayCount < totalPlayTime);
        }
    }
}
