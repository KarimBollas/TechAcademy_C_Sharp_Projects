using System;

namespace booleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(true && true && true || false);
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);

            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //Console.WriteLine(true != false);
            //Console.WriteLine(true != true);
            //Console.WriteLine(false != false);

            //Console.WriteLine(false ^ false);
            //Console.WriteLine(true ^ true);
            //Console.WriteLine(false ^ true);
            //Console.WriteLine(true ^ false);

            // ask for age and read it as a byte 
            Console.WriteLine("What is your age?");            
            byte age = Convert.ToByte(Console.ReadLine());
            //  ask if DUI and read it as a bool 
            Console.WriteLine("Have you ever had a DUI? (type \"true\" or \"false\" )");
            bool hadDUI = Convert.ToBoolean(Console.ReadLine());
            // ask for number of tickets and read it as a byte
            Console.WriteLine("How many speeding tickets do you have?");
            byte numTickets = Convert.ToByte(Console.ReadLine());
            //quilifies if has 15 or more years ald AND no has DUI AND has 3 or less tickets 
            bool qualified = (age >= 15 && !hadDUI && numTickets <= 3);
            Console.WriteLine("Qualified?: "+qualified);
            
            Console.ReadLine();

        }
    }
}
