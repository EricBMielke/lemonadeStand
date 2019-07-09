using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Setup
    {
        public static string WelcomePlayer()
        {
            Console.WriteLine("Welcome to Lemonade Stand! What is your name?");
            string player1 = Console.ReadLine();
            Console.WriteLine("Let's begin " + player1 + "!");
            return player1;
        }
        public static int GameplayDuration(double totalMoney)
        {
            Console.WriteLine("You are in charge of ordering lemons, ice, sugar and cups for your lemonade stand. You will create the recipe and sell it to the masses. Your currently have $" + totalMoney + " to build your empire");
            Console.WriteLine("For how long would you like to play the game? Your options are 7 days - 30 days.");
            int totalPlayTime = Int32.Parse(Console.ReadLine());
            return totalPlayTime;
        }
    }
}
