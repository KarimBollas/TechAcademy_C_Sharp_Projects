using System;
using System.Collections.Generic;
using System.IO;
using Casino;
using System.Linq;

namespace TwentyOne

{
    class Program
    {
        
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel Casino";
            Player newPLayer = new Player("Karim");
            Guid identifier = Guid.NewGuid();

            //string someText = "This is some text.";
            //File.WriteAllText(@"C:\Users\Karim\source\repos\TechAcademy_C_Sharp_Projects\MyClassesSolution\TwentyOne\Logs\log.txt",someText);

            Console.WriteLine("WELCOME to the {0}.\nLet's start by telling me your name",casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;

            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer)
                {
                    Console.WriteLine("Type digits only, no decimals.");
                }
            }

                    
            
            Console.WriteLine("Hello, {0}. Dou ypu wnat to join a game of 21 rigth now?", playerName);
            string answer = Console.ReadLine().ToLower();
            
            if (answer == "yes" || answer == "yeah"|| answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName,bank);
                player.Id = Guid.NewGuid();
                Game game = new TwentyOneGame();
                
                game += player;
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch(FraudException ex)
                    {
                        
                        Console.WriteLine("{0}\nSecurity! Kick this person out.",ex.Message);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error, please contact your System Administratr.\n{0}", ex.Message);
                        Console.ReadLine();
                        return;
                    }

                    
                }
                
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            
            Console.WriteLine("Feel free to look around the casino. By for now.");
            Console.Read();
        }
        
        
    }
}
