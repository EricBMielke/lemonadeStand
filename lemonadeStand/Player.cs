using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Player
    {
        public string WelcomePlayer()
        {
            string player1;
            do
            {
                Console.WriteLine("Welcome to Lemonade Stand! What is your name?");
                player1 = Console.ReadLine();
            }
            while (player1 == "");
            Console.WriteLine("Let's begin " + player1 + "!");
            return player1;
        }
    }
}
