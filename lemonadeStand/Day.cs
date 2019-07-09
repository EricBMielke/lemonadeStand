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
            if(weatherType == "Sunny")
            {
                Random rnd = new Random();
                int customerNumbers = rnd.Next(150, 200);
                return customerNumbers;
            }
            else if(weatherType == "Cloudy")
            {
                Random rnd = new Random();
                int customerNumbers = rnd.Next(50, 100);
                return customerNumbers;
            }
            else if (weatherType == "Hazy")
            {
                Random rnd = new Random();
                int customerNumbers = rnd.Next(100, 150);
                return customerNumbers;
            }
            else
            {
                Random rnd = new Random();
                int customerNumbers = rnd.Next(0, 100);
                return customerNumbers;
            }
        }
    }
}
