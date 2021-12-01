using System;

namespace shippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. \n\rPlease follow the instructions below.\n\n");
            Console.WriteLine("What is the weight of your package? ");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight>50) //if weight greater than 50 send error and program ends.
            {
                Console.WriteLine("Error Message: Package too heavy to be shipped via Package Express. :( \n Have a good day. :) ");
            }
            else // if package not heavy ask for width, height and length
            {
                Console.WriteLine("What is the width of your package? ");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the height of your package? ");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the length of your package? ");
                int length = Convert.ToInt32(Console.ReadLine());

                int size = width + height + length;
                if (size>50) //if size greater than 50 send error and program ends.
                {
                    Console.WriteLine("Error Message: Package too big to be shipped via Package Express. ");
                }
                else //otherwise calculates quote
                {
                    double quote = ((double)width * (double)height * (double)length) * (double)weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                }
            }
            Console.ReadLine();
        }
    }
}
