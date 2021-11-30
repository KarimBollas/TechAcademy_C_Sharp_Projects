using System;

namespace matchConsoleAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            double res1 = num1 * 50;
            Console.WriteLine(res1);
            res1 = num1 + 25;
            Console.WriteLine(res1);
            res1 = (double)num1 / 12.5;
            Console.WriteLine(res1);
            bool greaterThan50=num1>50;
            Console.WriteLine(greaterThan50);
            res1 = num1 % 7;
            Console.WriteLine(res1);
        }
    }
}
