using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Inventory
    {
        public void InventoryTotalStatement(double totalSugar, double totalCups, double totalIce, double totalLemons)
        {
            Console.WriteLine("Inventory totals:");
            Console.WriteLine("Sugar:" + totalSugar);
            Console.WriteLine("Cups:" + totalCups);
            Console.WriteLine("Ice:" + totalIce);
            Console.WriteLine("Lemons:" + totalLemons);
        }
    }
}
