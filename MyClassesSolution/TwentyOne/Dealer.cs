using System;
using System.Collections.Generic;
using System.Linq;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { set; get; }
        public Deck Deck { set; get; }
        public int Balance { set; get; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0);
        }
    }
}
