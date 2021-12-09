using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorProject
{
    public class Animal
    {
        //chain constructors, default legs: 4
        public Animal(string specie) : this (specie, 4)
        {

        }
        //constructor 2 parameters
        public Animal(string specie, int legs)
        {
            Specie = specie;
            Legs = legs;
        }
        //const variable
        public const string Kingdom="Animalia";
        public int Legs { get; set; }
        public string Specie { get; set; }

    }
}
