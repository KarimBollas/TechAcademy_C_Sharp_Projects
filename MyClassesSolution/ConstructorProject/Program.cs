using System;
using System.Collections.Generic;
using System.Linq;

namespace ConstructorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //var variable as a a List of Animal
            var animals = new List<Animal>();

            //adding animals to list
            animals.Add(new Animal("Cat")); // it uses Chain constructor 
            animals.Add(new Animal("Dog"));
            animals.Add(new Animal("Ostrich",2)); // it uses oroiginal constructor

            //display animals
            foreach (var animal in animals)
            {
                Console.WriteLine("Specie {0}, legs: {1}", animal.Specie, animal.Legs.ToString());
            }


            Console.ReadLine();
        }
    }
}
