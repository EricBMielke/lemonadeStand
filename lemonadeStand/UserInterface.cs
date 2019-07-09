using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class UserInterface
    {
        public static double LemonsWanted (string player1)
        {
            Console.WriteLine("Alright, " + player1 + ". How many lemons would you like to buy?");
            double lemonsNeededInt = Int32.Parse(Console.ReadLine());
            return lemonsNeededInt;
        }
        public static double TotalLemons (double totalLemons, double lemonsNeededInt)
        {
            totalLemons = totalLemons + lemonsNeededInt;
            Console.WriteLine("Your total number of lemons are " + totalLemons);
            return totalLemons;
        }
        public static double CupsWanted(string player1)
        {
            Console.WriteLine("Alright, " + player1 + ". How many cups would you like to buy? Price is $.04 per piece.");
            double cupsNeededInt = Int32.Parse(Console.ReadLine());
            return cupsNeededInt;
        }
        public static double TotalCups(double totalCups, double cupsNeededInt)
        {
            totalCups = totalCups + cupsNeededInt;
            Console.WriteLine("Your total number of cups are " + totalCups);
            return totalCups;
        }

        public static double IceWanted(string player1)
        {
            Console.WriteLine("Alright, " + player1 + ". How much ice would you like to buy? Price is $.04 per piece.");
            double iceNeededInt = Int32.Parse(Console.ReadLine());
            return iceNeededInt;
        }
        public static double TotalIce(double totalIce, double iceNeededInt)
        {
            totalIce = totalIce + iceNeededInt;
            Console.WriteLine("Your total number of ice is " + totalIce);
            return totalIce;
        }
        public static double SugarWanted(string player1)
        {
            Console.WriteLine("Alright, " + player1 + ". How much sugar would you like to buy? Price is $.04 per piece.");
            double sugarNeededInt = Int32.Parse(Console.ReadLine());
            return sugarNeededInt;
        }
        public static double TotalSugar(double totalSugar, double sugarNeededInt)
        {
            totalSugar = totalSugar + sugarNeededInt;
            Console.WriteLine("Your total number of ice is " + totalSugar);
            return totalSugar;
        }


    }
}
