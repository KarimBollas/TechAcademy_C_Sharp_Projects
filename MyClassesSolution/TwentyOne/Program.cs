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
            int timesShuffled;
            deck = Shuffle(deck: deck, out timesShuffled, times: 3);

            //deck.Cards = new List<Card>();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";
            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            //Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Total Cards: {0} \nTimes Shuffled: {1}",deck.Cards.Count,timesShuffled);
            Console.Read();
        }
        
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times=1)
        {
            timesShuffled = 0;
            for (int i=0; i<times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();
                while (deck.Cards.Count > 0)
                {                    
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;
        }
    }
}
