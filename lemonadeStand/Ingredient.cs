using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    public abstract class Ingredient
    {
        //Principle L of SOLID: There are 3 children functions that live below this parent function...they do the exact same thing as the parent class
        public abstract bool CheckEmpty(double item, int index);
    }
}
