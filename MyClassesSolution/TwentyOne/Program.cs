using System;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Card cardOne = new Card();
                        
            Deck deck = new Deck();
            //deck = Shuffle(deck);
            //deck = Shuffle(deck, 3);

            deck.Shuffle(3);

            //deck.Cards = new List<Card>();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";
            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            
            Console.Read();
        }
        
        
    }
}
