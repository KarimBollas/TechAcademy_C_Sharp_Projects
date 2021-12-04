using System;
using System.Collections.Generic;


namespace CallingMethods
{
    public class MyMath
    {
        public static int returnFactorial(int n) //Method receive an integer returns its factorial
        {            
            for (int i=n; i>=2; i--)
            {
                n = n*(i - 1);    
            }
            return n;
        }
        public static bool answerIsPrime(int n) //Method receive an integer returns a boolean
        {
            bool isPrime = true;         // consider n as a prime until find a divisor                  
            int factor = 2;             // factor as a divisor starts at 2
            do
            {
                if ((n % factor) == 0)    //factor divides n, if true NOT prime
                {
                    isPrime = false;
                }
                factor++;
            } while (factor <= Math.Sqrt(n) && !isPrime);  // calculate up to square root of n
            if (isPrime)    //if isPrime print it
            {
                Console.WriteLine(n);
            }         
            return isPrime;
        }
        public static bool answerIsLeap (int year) //Method receive an integer returns a boolean
        {
            bool isLeap = false;
            if (year%4==0)
            {
                isLeap = true;
                if (year%100==0)            //if a year es divided by 100, so it must by divided by 400, instead it is not Leap
                {
                    if (year%400!=0)
                    {
                        isLeap = false;
                    }                    
                }
            }
            return isLeap;
        }

        public static int supplementaryAngle(int n) //Method receive an integer returns integer suplementary angle in sexagesimal degrees 
        {
            return (180-n);
        }

        public static int complementaryAngle(int n) //Method receive an integer returns suplementary angle in sexagesimal degrees
        {
            return (90 - n);
        }

    }
}
