using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    public class Lemon : Ingredient
    {
        public override bool CheckEmpty(double totalLemonade, int i)
        {
            if (totalLemonade <= 0)
            {
                Console.WriteLine("Sold out for the day after customer number " + (i + 1));
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
