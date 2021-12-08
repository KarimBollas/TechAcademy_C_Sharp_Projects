using System;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME to the Grand Hotel Casino.\nLet's start by telling me your name");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Dou ypu wnat to join a game of 21 rigth now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah"|| answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName,bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
            }
        }
        
        
    }
}
