using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Recipe
    {
        public static int RecipeRequestSugar()
        {
            Console.WriteLine("Lets build today's recipe: How much sugar per cup would you like?");
            int todaysSugarPerCup = Int32.Parse(Console.ReadLine());
            return todaysSugarPerCup;
        }
        public static int RecipeRequestIce()
        {
            Console.WriteLine("Lets build today's recipe: How much ice per cup would you like?");
            int todaysIcePerCup = Int32.Parse(Console.ReadLine());
            return todaysIcePerCup;
        }
        public static int RecipeRequestLemons()
        {
            Console.WriteLine("Lets build today's recipe: How many lemons per cup would you like?");
            int todaysLemonPerCup = Int32.Parse(Console.ReadLine());
            return todaysLemonPerCup;
        }
        public static double RecipeRequestPrice()
        {
            Console.WriteLine("How much is a price of lemonade? From $.01 to $1.00");
            double pricePerCup = 0;
            try
            {
                pricePerCup = Double.Parse(Console.ReadLine());
                return pricePerCup;
            }
            catch (Exception)
            {
                Console.WriteLine("You cannot leave the question blank and you must enter a decimal between .01 and 1.00");
                RecipeRequestPrice();
                return pricePerCup;
            }
        }
    }
}
