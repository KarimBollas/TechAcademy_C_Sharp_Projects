using System;


namespace PolymorphismProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object of type IQuittable and call the Quit() method on it
            IQuittable quittable = new Employee(100, "Pepe", "Perez"); // quitable as an employee cause polymorphism 
            quittable.Quit(); //calls Quit method

            Console.ReadLine();
        }
    }
}
