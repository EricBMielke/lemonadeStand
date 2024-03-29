﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    public class Day
    {
        public int patronsByDay (string weatherType)
        {
            if(weatherType == "sunny")
            {
                Random rnd = new Random();
                int customerNumbers = rnd.Next(150, 200);
                Console.WriteLine(customerNumbers + " customers are supposed to come today because the weather is " + weatherType);
                return customerNumbers;
            }
            else if(weatherType == "cloudy")
            {
                Random rnd = new Random();
                int customerNumbers = rnd.Next(50, 100);
                Console.WriteLine(customerNumbers + " customers are supposed to come today because the weather is " + weatherType);
                return customerNumbers;
            }
            else if (weatherType == "hazy")
            {
                Random rnd = new Random();
                int customerNumbers = rnd.Next(100, 150);
                Console.WriteLine(customerNumbers + " customers are supposed to come today because the weather is " + weatherType);
                return customerNumbers;
            }
            else
            {
                Random rnd = new Random();
                int customerNumbers = rnd.Next(0, 100);
                Console.WriteLine(customerNumbers + " customers are supposed to come today because the weather is " + weatherType);
                return customerNumbers;
            }
        }
        public void EndOfDayResults(double totalSugar, double totalCups, double totalIce, double totalLemons, double totalMoney)
        {
            Console.WriteLine("Inventory totals:");
            Console.WriteLine("Sugar:" + totalSugar);
            Console.WriteLine("Cups:" + totalCups);
            Console.WriteLine("Ice:" + totalIce);
            Console.WriteLine("Lemons:" + totalLemons);
            Console.WriteLine("Total Money :$" + totalMoney.ToString("0.00"));
        }

        public double LiquidationSummation(double totalSugar, double totalCups, double totalLemons, double totalMoney)
        {
            totalMoney = totalSugar * .02 + totalMoney;
            totalMoney = totalLemons * .02 + totalMoney;
            totalMoney = totalCups * .02 + totalMoney;
            Console.WriteLine("Total Liquidation Value :$" + totalMoney.ToString("0.00"));
            return totalMoney;
        }
        public double EndOfDayNetStanding(double totalMoney)
        {
            if(totalMoney > 20)
            {
                Console.WriteLine("You've made an overall profit of $" + (totalMoney - 20).ToString("0.00") + ".");
            }
            else if(totalMoney == 20)
            {
                Console.WriteLine("Overall, you are even.");
            }
            else
            {
                Console.WriteLine("You've lost $" + (20 - totalMoney).ToString("0.00") + " total.");
            }
            return totalMoney;
        }
        public bool BankruptcyCheck(double totalMoney)
        {
            if (totalMoney <= 0)
            {
                Console.WriteLine("Bankruptcy is no joke. Your game is officially over. Hit enter to continue");
                Console.ReadLine();
                Environment.Exit(0);
                return true;
            }
            else
            {
                return false;
            }
        }
        public double EndOfDayIceMelt (double totalIce)
        {
            Console.WriteLine("Your ice has melted.");
            totalIce = 0;
            return totalIce;

        }
        public int StateDay(int dayCount)
        {
            Console.WriteLine("It is the end of day " + (dayCount + 1));
            return dayCount;

        }
        public double EndOfDayLemonSpoil (double totalLemons)
        {
            Random rnd = new Random();
            int lemonSpoil = rnd.Next(0, 100);
            if (0 < lemonSpoil && lemonSpoil < 10)
            {
                totalLemons = totalLemons / 2;
                Console.WriteLine("Some of your lemons spoiled. You now have " + totalLemons);
            }
            return totalLemons;
        }
        public double EndOfPlayNetStanding(double totalMoney)
        {
            if (totalMoney > 20)
            {
                Console.WriteLine("Amazing work. You've made an overall profit of $" + (totalMoney - 20).ToString("0.00") + ".");
            }
            else if (totalMoney == 20)
            {
                Console.WriteLine("Not too shabby. Overall, you were even.");
            }
            else
            {
                Console.WriteLine("Room for improvement. You've lost $" + (20 - totalMoney).ToString("0.00") + " total.");
            }
            return totalMoney;
        }
    }
}
