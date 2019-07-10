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
                //Principle S of SOLID is below : All functions handle one singular purpose...specifically, CreateTemperature only worries about creating the current days temperature and returning it to the user
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
                        totalLemons = totalLemons - todaysLemonPerCup;
                        totalCups = totalCups - 1;
                        //Principle O of SOLID is below: The CheckEmpty method lives in the parent class of Ingredients.  The subclasses of Ice, Lemon, Sugar, and Cups are build off this parent class
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
                Day.BankruptcyCheck(totalMoney);
                dayCount++;
            }
            while (dayCount < totalPlayTime);
            Day.EndOfPlayNetStanding(totalMoney);
        }
    }
}
