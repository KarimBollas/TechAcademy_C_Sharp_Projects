using System;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, power, result;
            string powerString;            
            MathOperations myMathOperation = new MathOperations();
            try
            {
                //Ask for a number, stores in number as integer
                Console.WriteLine("Power of a number \nPlease pick a whole number");
                number=Convert.ToInt32(Console.ReadLine());

                //ask for the power, stores in powerString as string
                Console.WriteLine("Type the power (default 2)");                
                powerString = Console.ReadLine();

                //if user input default ""
                if (powerString=="")
                {
                    //calls method Power, default power option
                    result = myMathOperation.Power(number);
                    //Display result
                    Console.WriteLine(number + " power 2: " + result);
                }
                else // other case
                {
                    //convert user input power to int
                    power = Convert.ToInt32(powerString);
                    if (power >= 0)
                    {
                        //calls method Power
                        result = myMathOperation.Power(number, power);
                        //Display result
                        Console.WriteLine(number + " power " + power + ": " + result);
                    }
                    else //Only positive (and 0) powers 
                    {
                        Console.WriteLine("Sorry, type a positive power. ");
                    }
                }         
            }
            //exception handler in case not type an integer
            catch (FormatException)
            {

                Console.WriteLine("Error: Type an whole number. ");
            }

            Console.ReadLine();
        }
    }
}
