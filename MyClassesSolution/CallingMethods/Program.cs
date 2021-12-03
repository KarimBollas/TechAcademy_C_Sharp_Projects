using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The factorial of 5 is: "+ MyMath.returnFactorial(5));
            Console.WriteLine("Is 40520 a prime number: " + MyMath.answerIsPrime(40520));
            Console.WriteLine("Is 1996 a leap year?: " + MyMath.answerIsLeap(1996));
            Console.WriteLine("Is 1998 a leap year?: " + MyMath.answerIsLeap(1998));
            Console.WriteLine("Is 1800 a leap year?: " + MyMath.answerIsLeap(1800));
            Console.WriteLine("Is 400 a leap year?: " + MyMath.answerIsLeap(400));
            Console.ReadLine();
        }
    }
}
