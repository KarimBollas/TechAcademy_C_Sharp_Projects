using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * string myName = "Karim";
            byte myNumber = 8;
            */
            //This is a simpl
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is " + yourName);
            //Console.Read();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNUmber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNUmber);
            //int total = favNum + 10;
            //Console.WriteLine("Your favorite number is: "+favoriteNUmber);
            //Console.WriteLine("Your favorite number plus 10 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;
            
            double heigthInCentimeters = 171.3021;
            
            float secondsLeft = 2.62f;
            
            short temperatureInMars = -314;
            
            string myName = "Karim";
            
            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);


            Console.WriteLine("years?: "+ currentAge.ToString());
            Console.ReadKey();


        }
    }
}
