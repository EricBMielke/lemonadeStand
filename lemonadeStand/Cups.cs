﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Cups
    {
        public static bool CheckEmpty(double totalCups)
        {
            if (totalCups == 0)
            {
                Console.WriteLine("Sold out for the day");
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
