using System;

namespace StructProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 3.141598m;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
