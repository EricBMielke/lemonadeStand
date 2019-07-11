using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Game
    {
        public async System.Threading.Tasks.Task RunGame()
        {
            //Method variables
            double totalLemons = 0;
            double totalCups = 0;
            double totalSugar = 0;
            double totalIce = 0;
            double totalMoney = 20;
            int dayCount = 0;
            int temperatureTomorrow = 0;

            //Actual method
            Setup game = new Setup();
            Day currentDay = new Day();
            OnlineWeather todaysWeather = new OnlineWeather();
            string player1 = game.WelcomePlayer();
            int totalPlayTime = game.GameplayDuration(totalMoney);
            string cityOfPlayer = game.PlayerLocation();
            double updatedOnlineTemp = await todaysWeather.fetchWeatherOnline(cityOfPlayer);
            do
            {
                //Principle S of SOLID is below : All functions handle one singular purpose...specifically, CreateTemperature only worries about creating the current days temperature and returning it to the user
                WeatherStatus weather = new WeatherStatus();
                Store store = new Store();
                UserInterface userInterface = new UserInterface();
                Inventory inventory = new Inventory();
                Recipe recipe = new Recipe();
                Customer customer = new Customer();
                Ice ice = new Ice();
                Sugar sugar = new Sugar();
                Cups cups = new Cups();
                Lemon lemon = new Lemon();

                int temperature = weather.CreateTemperature(dayCount, temperatureTomorrow, updatedOnlineTemp);
                temperatureTomorrow = weather.CreateForecast();
                string weatherType = weather.CreateWeather();
                int patronNumbers = currentDay.patronsByDay(weatherType);
                double lemonsNeededInt = userInterface.LemonsWanted(player1);
                totalMoney = store.PurchaseLemons(lemonsNeededInt, totalMoney);
                totalLemons = userInterface.TotalLemons(totalLemons, lemonsNeededInt);
                double cupsNeededInt = userInterface.CupsWanted(player1);
                totalMoney = store.PurchaseCups(cupsNeededInt, totalMoney);
                totalCups = userInterface.TotalCups(totalCups, cupsNeededInt);
                double iceNeededInt = userInterface.IceWanted(player1);
                totalMoney = store.PurchaseIce(iceNeededInt, totalMoney);
                totalIce = userInterface.TotalIce(totalIce, iceNeededInt);
                double sugarNeededInt = userInterface.SugarWanted(player1);
                totalMoney = store.PurchaseSugar(sugarNeededInt, totalMoney);
                totalSugar = userInterface.TotalSugar(totalSugar, sugarNeededInt);
                inventory.InventoryTotalStatement(totalSugar, totalCups, totalIce, totalLemons);
                int todaysSugarPerCup = recipe.RecipeRequestSugar();
                int todaysIcePerCup = recipe.RecipeRequestIce();
                int todaysLemonPerCup = recipe.RecipeRequestLemons();
                double pricePerCup = recipe.RecipeRequestPrice();
                for (int i = 0; i < patronNumbers; i++)
                {
                int chanceDueToPrice = customer.ChancePurchaseByPrice(pricePerCup);
                int chanceDueToTemp = customer.ChancePurchaseByTemperature(temperature);
                if (customer.LemonadePurchase(chanceDueToPrice, chanceDueToTemp))
                    {
                        totalMoney = totalMoney + pricePerCup;
                        totalIce = totalIce-todaysIcePerCup;
                        totalSugar = totalSugar - todaysSugarPerCup;
                        totalLemons = totalLemons - todaysLemonPerCup;
                        totalCups = totalCups - 1;
                        //Principle O of SOLID is below: The CheckEmpty method lives in the parent class of Ingredients.  The subclasses of Ice, Lemon, Sugar, and Cups are build off this parent class
                        if (ice.CheckEmpty(totalIce, i))
                        {
                            break;
                        }
                        if (lemon.CheckEmpty(totalLemons, i))
                        {
                            break;
                        }
                        if (sugar.CheckEmpty(totalSugar, i))
                        {
                            break;
                        }
                        if (cups.CheckEmpty(totalCups, i))
                        {
                            break;
                        }
                    }
                }
                totalLemons = currentDay.EndOfDayLemonSpoil(totalLemons);
                totalIce = currentDay.EndOfDayIceMelt(totalIce);
                currentDay.EndOfDayResults(totalSugar, totalCups, totalIce, totalLemons, totalMoney);
                currentDay.EndOfDayNetStanding(totalMoney);
                currentDay.BankruptcyCheck(totalMoney);
                dayCount++;
            }
            while (dayCount < totalPlayTime);
            currentDay.EndOfPlayNetStanding(totalMoney);
        }
    }
}
