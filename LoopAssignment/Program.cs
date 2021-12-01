using System;

namespace LoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number (from 2 to 2,147,483,647)"); 
            int limit = Convert.ToInt32( Console.ReadLine() ); //read a number form input
            bool isPrime;          //bool to determinate a prime number
            int n=limit;            //limit to calculate prime numbers            
            int factor;             // factor to divide number (n)
            

            if (n>=2 && n<= 2147483647)             // is n in range
            {
                Console.WriteLine("Prime Numbers up to " + limit);
                while (n >= 3)              // 
                {
                    isPrime = true;         // consider n as a prime until find a divisor
                    factor = 2;             // factor as a divisor starts at 2
                    do
                    {                        
                        if ((n % factor)==0)    //factor divides n, if true NOT prime
                        {
                            isPrime = false;
                        }
                        factor++;           
                    } while (factor <= Math.Sqrt(n));  // calculate up to square root of n
                    if (isPrime)    //if isPrime print it
                    {
                        Console.WriteLine(n);
                    }
                    n--;    //next number 
                }
                
                Console.WriteLine("2"); // first prime number

            }
            else
            {
                Console.WriteLine("Not a valid number (from 2 to 2,147,483,647). Program ends");
            }

            
            
        }
    }
}
