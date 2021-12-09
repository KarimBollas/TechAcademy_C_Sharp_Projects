using System;

namespace DateTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dateTime = new DateTime(1987, 2, 9, 18, 10, 5);
            //Console.WriteLine(dateTime.ToString());

            //Print to console current date
            DateTime justNow= DateTime.Now;
            Console.WriteLine(justNow);

            //Asks for a number.
            Console.WriteLine("How many hours do you want to add ?");
            double hours = Convert.ToDouble(Console.ReadLine());

            //Add hours to datatime variable
            
            Console.WriteLine(justNow.AddHours(hours));

            Console.ReadLine();
        }
    }
        
}
