using System;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Karim";
            game = game + player;
            game = game - player;
            //game.Players = new List<string> { "Mayra", "David", "Engels" };
            //game.ListPlayers();
            //game.Play();

            Deck deck = new Deck();            
            deck.Shuffle(3);


            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);

            Console.ReadLine();
        }
        
        
    }
}
