using System;

namespace MethodClassSubmission
{
    class Program
    {

        static void Main(string[] args)
        {
            //instantiate  the class MyMath3
            MyMath3 myOPeration = new MyMath3();

            int factorial;

            Console.Write("Factorial of ");
            //calls Factorial Method, returns factorial of second parameter in 'factorial', and print second parameter
            myOPeration.Factorial( factorial: out factorial, number: 5);
            //prints factorial
            Console.Write(" is {0}", factorial);
            Console.ReadLine();
        }
    }
}
