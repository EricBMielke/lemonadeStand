using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Recipe
    {
        public int RecipeRequestSugar()
        {
            int todaysSugarPerCup = 0;
            do
            {
                Console.WriteLine("Lets build today's recipe: How much sugar per cup would you like?");
                try
                {
                    todaysSugarPerCup = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You cannot leave the question blank and you must enter an integer over 0");
                }
            }
            while (todaysSugarPerCup <= 0);
            return todaysSugarPerCup;
        }
        public int RecipeRequestIce()
        {
            int todaysIcePerCup = 0;
            do
            {
                Console.WriteLine("Lets build today's recipe: How much ice per cup would you like?");
                try
                {
                    todaysIcePerCup = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You cannot leave the question blank and you must enter an integer over 0");
                }
            }
            while (todaysIcePerCup <= 0);
            return todaysIcePerCup;
        }
        public int RecipeRequestLemons()
        {
            int todaysLemonPerCup = 0;
            do
            {
                Console.WriteLine("Lets build today's recipe: How many lemons per cup would you like?");
                try
                {
                    todaysLemonPerCup = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You cannot leave the question blank and you must enter an integer over 0");
                }
            }
            while (todaysLemonPerCup <= 0);
            return todaysLemonPerCup;
        }
        public double RecipeRequestPrice()
        {
            double pricePerCup = 0;
            do
            {
                Console.WriteLine("How much is a price of lemonade? From $.01 to $1.00");
                try
                {
                    pricePerCup = Double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You cannot leave the question blank and you must enter a decimal between .01 and 1.00");
                }
            }
            while (pricePerCup <= 0 || pricePerCup > 1);
            return pricePerCup;
        }
    }
}
