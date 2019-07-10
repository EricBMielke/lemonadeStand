using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Game
    {
        public void RunGame()
        {
            double totalLemons = 0;
            double totalCups = 0;
            double totalSugar = 0;
            double totalIce = 0;
            double totalMoney = 20;
            int dayCount = 0;
            string player1 = Setup.WelcomePlayer();
            int totalPlayTime = Setup.GameplayDuration(totalMoney);
            int temperatureTomorrow = 0;
            do
            {
                int temperature = Weather.CreateTemperature(dayCount, temperatureTomorrow);
                temperatureTomorrow = Weather.CreateForecast();
                string weatherType = Weather.CreateWeather();
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
                int todaysSugarPerCup = Recipe.RecipeRequestSugar();
                int todaysIcePerCup = Recipe.RecipeRequestIce();
                int todaysLemonPerCup = Recipe.RecipeRequestLemons();
                double pricePerCup = Recipe.RecipeRequestPrice();
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
                        Ice iceCheck = new Ice();
                        if (iceCheck.CheckEmpty(totalIce, i))
                        {
                            break;
                        }
                        Lemon lemonCheck = new Lemon();
                        if (lemonCheck.CheckEmpty(totalLemons, i))
                        {
                            break;
                        }
                        Sugar sugarCheck = new Sugar();
                        if (sugarCheck.CheckEmpty(totalSugar, i))
                        {
                            break;
                        }
                        if (Cups.CheckEmpty(totalCups, i))
                        {
                            break;
                        }
                    }
                }
                totalLemons = Day.EndOfDayLemonSpoil(totalLemons);
                totalIce = Day.EndOfDayIceMelt(totalIce);
                Day.EndOfDayResults(totalSugar, totalCups, totalIce, totalLemons, totalMoney);
                Day.EndOfDayNetStanding(totalMoney);
                dayCount++;
            }
            while (dayCount < totalPlayTime);
            Day.EndOfPlayNetStanding(totalMoney);
        }
    }
}
