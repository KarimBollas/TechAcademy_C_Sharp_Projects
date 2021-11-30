using System;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=256;
            int num2 = 9;
            float res;
            res = num1 + num2;
            Console.WriteLine(num1.ToString() + " + " + num2.ToString() + " = " + res.ToString());
            res = num1 - num2;
            Console.WriteLine(num1.ToString() + " - " + num2.ToString() + " = " + res.ToString());
            res = num1 * num2;
            Console.WriteLine(num1.ToString() + " x " + num2.ToString() + " = " + res.ToString());
            res = (float)num1 / (float)num2;
            Console.WriteLine(num1.ToString() + " / " + num2.ToString() + " = " + res.ToString());
            Console.WriteLine("My first number: " + num1);
            
            int total = 5 + 10;
            int otherTotal = 12 + 12;
            int combined = total + otherTotal;
            Console.WriteLine("Five plus Ten = " + total.ToString());
            Console.WriteLine(combined);

            int difference = 10 - 5;
            Console.WriteLine("Ten minus Five = " + difference.ToString());
         
            int product = 10 * 5;
            Console.WriteLine(product);

            double quotient = 100.0 / 17.0;
            Console.WriteLine(quotient);
            
            int remainder = 10 % 3;
            Console.WriteLine(remainder);

            bool trueOrFalse = 12 > 5;
            Console.WriteLine(trueOrFalse.ToString());

            int currentTemperature = 70;
            int roomTemperature = 70;
            bool isWarm = currentTemperature >= roomTemperature;
            Console.WriteLine(isWarm);



            Console.ReadLine();
        }
    }
}
