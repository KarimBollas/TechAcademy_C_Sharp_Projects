using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The factorial of 5 is: "+ MyMath.returnFactorial(5));
            Console.WriteLine("The suplementary angle of 110⁰: " + MyMath.supplementaryAngle(110));
            Console.WriteLine("The complementary angle of 30⁰: " + MyMath.complementaryAngle(30));
            Console.ReadLine();
        }
    }
}
