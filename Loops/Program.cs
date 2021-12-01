using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool isGuessed = false;

            //while (!isGuessed)
            //{
            //    Console.WriteLine("Guess a number?");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    switch (number)
            //    {
            //        case 12:
            //            Console.WriteLine("You guessed 12. Congrats.");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You guessed " + number +". Try again.");
            //            break;                    
            //    }
            //}


            do
            {
                Console.WriteLine("Guess a number?");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 12:
                        Console.WriteLine("You guessed 12. Congrats.");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You guessed " + number + ". Try again.");
                        break;
                }
            }
            while (!isGuessed);


            Console.Read();
        }
    }
}
