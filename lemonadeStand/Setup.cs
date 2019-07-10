﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Setup
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
        public int GameplayDuration(double totalMoney)
        {
            int totalPlayTime = 0;
            do
            {
                Console.WriteLine("You are in charge of ordering lemons, ice, sugar and cups for your lemonade stand. You will create the recipe and sell it to the masses. Your currently have $" + totalMoney + " to build your empire");
                Console.WriteLine("For how long would you like to play the game? Your options are 7 days - 30 days.");
                try
                {
                    totalPlayTime = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You cannot leave the question blank and you must enter an integer");
                    GameplayDuration(totalMoney);
                }
            }
            while (totalPlayTime < 7  || totalPlayTime > 30);
            return totalPlayTime;
        }
      
            
    }
}
