using System;

namespace mathAndComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            
            Console.WriteLine("Person1");
            Console.WriteLine("Hourly Rate?");
            double hourlyRate1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            byte hoursWeek1 = Convert.ToByte(Console.ReadLine());
            
            Console.WriteLine("Person2");
            Console.WriteLine("Hourly Rate?");
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            byte hoursWeek2 = Convert.ToByte(Console.ReadLine());

            double annualSalary= hourlyRate1 * hoursWeek1*52;
            Console.WriteLine("Anual salary Person1: $"+annualSalary);
            annualSalary = hourlyRate2 * hoursWeek2 * 52;
            Console.WriteLine("Anual salary Person2: $" + annualSalary);
            
            bool greaterThan = (hourlyRate1* hoursWeek1*52) > annualSalary;
            Console.WriteLine("Does Person 1 make more money than Person 2?: " + greaterThan);


        }
    }
}
