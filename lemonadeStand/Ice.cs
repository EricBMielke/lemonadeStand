using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    public class Ice : Ingredient
    {
        public override bool CheckEmpty(double totalIce, int i)
        {
            if (totalIce <= 0)
            {
                Console.WriteLine("Sold out for the day after the " + i + " customer");
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
