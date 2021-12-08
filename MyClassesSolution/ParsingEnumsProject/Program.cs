using System;

namespace ParsingEnumsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Prompt to user to enter a day of week
            Console.WriteLine("Enter the current day of week: ");
            

            try
            {
                //Parse user input into day (enum DaysOfWeek)
                DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), Console.ReadLine().ToUpper());
                Console.WriteLine("Thank you :)");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week. \n{0}", ex.Message);                    
            }
            Console.ReadLine();
        }
    }
}
