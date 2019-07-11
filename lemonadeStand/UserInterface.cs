using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class UserInterface
    {

        public int LemonsWanted (string player1)
        {
            int lemonsNeededInt;
            Console.WriteLine("Alright, " + player1 + ". How many lemons would you like to buy? Price is $.05 per lemon.");
            try
            {
                lemonsNeededInt = Int32.Parse(Console.ReadLine());
                return lemonsNeededInt;

            }
            catch (Exception)
            {
                Console.WriteLine("You need to enter a valid integer");
                lemonsNeededInt = LemonsWanted(player1);
                return lemonsNeededInt;
            }
        }
        public double TotalLemons (double totalLemons, double lemonsNeededInt)
        {
            totalLemons = totalLemons + lemonsNeededInt;
            Console.WriteLine("Your total number of lemons are " + totalLemons);
            return totalLemons;
        }
        public int CupsWanted(string player1)
        {
            int cupsNeededInt;
            Console.WriteLine("Alright, " + player1 + ". How many cups would you like to buy? Price is $.05 per piece.");
            try
            {
                cupsNeededInt = Int32.Parse(Console.ReadLine());
                return cupsNeededInt;

            }
            catch (Exception)
            {
                Console.WriteLine("You need to enter a valid integer");
                cupsNeededInt = CupsWanted(player1);
                return cupsNeededInt;
            }
        }
        public double TotalCups(double totalCups, double cupsNeededInt)
        {
            totalCups = totalCups + cupsNeededInt;
            Console.WriteLine("Your total number of cups are " + totalCups);
            return totalCups;
        }

        public int IceWanted(string player1)
        {
            int iceNeededInt;
            Console.WriteLine("Alright, " + player1 + ". How much ice would you like to buy? Price is $.05 per piece.");
            try
            {
                iceNeededInt = Int32.Parse(Console.ReadLine());
                return iceNeededInt;

            }
            catch (Exception)
            {
                Console.WriteLine("You need to enter a valid integer");
                iceNeededInt = IceWanted(player1);
                return iceNeededInt;
            }
        }
        public double TotalIce(double totalIce, double iceNeededInt)
        {
            totalIce = totalIce + iceNeededInt;
            Console.WriteLine("Your total number of ice is " + totalIce);
            return totalIce;
        }
        public int SugarWanted(string player1)
        {
            int sugarNeededInt;
            Console.WriteLine("Alright, " + player1 + ". How much sugar would you like to buy? Price is $.05 per piece.");
            try
            {
                sugarNeededInt = Int32.Parse(Console.ReadLine());
                return sugarNeededInt;

            }
            catch (Exception)
            {
                Console.WriteLine("You need to enter a valid integer");
                sugarNeededInt = SugarWanted(player1);
                return sugarNeededInt;
            }
        }
        public double TotalSugar(double totalSugar, double sugarNeededInt)
        {
            totalSugar = totalSugar + sugarNeededInt;
            Console.WriteLine("Your total number of sugar is " + totalSugar);
            return totalSugar;
        }


    }
}
