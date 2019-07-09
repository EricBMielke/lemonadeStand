using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Day
    {
        public static int patronsByDay (string weatherType)
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
        public static void EndOfDayResults(double totalSugar, double totalCups, double totalIce, double totalLemons, double totalMoney)
        {
            Console.WriteLine("Inventory totals:");
            Console.WriteLine("Sugar:" + totalSugar);
            Console.WriteLine("Cups:" + totalCups);
            Console.WriteLine("Ice:" + totalIce);
            Console.WriteLine("Lemons:" + totalLemons);
            Console.WriteLine("Total Money :$" + totalMoney);
        }

        public static double EndOfDayNetStanding(double totalMoney)
        {
            if(totalMoney > 20)
            {
                Console.WriteLine("You've made an overall profit of $" + (totalMoney - 20) + ".");
            }
            else if(totalMoney == 20)
            {
                Console.WriteLine("Overall, you are even.");
            }
            else
            {
                Console.WriteLine("You've lost $" + (20 - totalMoney) + " total.");
            }
            return totalMoney;
        }
        public static double EndOfPlayNetStanding(double totalMoney)
        {
            if (totalMoney > 20)
            {
                Console.WriteLine("Amazing work. You've made an overall profit of $" + (totalMoney - 20) + ".");
            }
            else if (totalMoney == 20)
            {
                Console.WriteLine("Not too shabby. Overall, you were even.");
            }
            else
            {
                Console.WriteLine("Room for improvement. You've lost $" + (20 - totalMoney) + " total.");
            }
            return totalMoney;
        }
    }
}
