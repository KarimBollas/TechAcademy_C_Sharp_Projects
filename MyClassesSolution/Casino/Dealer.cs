using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { set; get; }
        public Deck Deck { set; get; }
        public int Balance { set; get; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString()+ "\n");
            Console.WriteLine(card);

            using (StreamWriter file = new StreamWriter(@"C:\Users\Karim\source\repos\TechAcademy_C_Sharp_Projects\MyClassesSolution\TwentyOne\Logs\log.txt",true))
            {
                file.WriteLine(card);
            }



                Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0);
        }
    }
}
