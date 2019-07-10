using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    public abstract class Ingredient
    {
        public abstract bool CheckEmpty(double item, int index);
    }
}
