using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Cups
    {
        public bool CheckEmpty(double totalCups, int i)
        {
            if (totalCups <= 0)
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
