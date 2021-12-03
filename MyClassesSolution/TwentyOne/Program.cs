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
        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;
        }
    }
}
