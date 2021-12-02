using System;
using System.Collections.Generic;

namespace StringsIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //init whole numbers list
            List<int> numberList = new List<int>
            {
                4,
                9,
                25,
                49,
                81
            };

            //display list
            foreach (int number in numberList)
            {
                Console.WriteLine(number);
            }

            //exceptions handling
            try
            {
                //ask user for a number 
                Console.WriteLine("Type divisor: ");
                //convert user input string to integers
                int divisor = Convert.ToInt32(Console.ReadLine());
                // go through the list
                foreach (int number in numberList)
                {   
                    //display division 
                    Console.WriteLine((number/divisor));
                }
            }
            //format exception (no integer input )
            catch (FormatException ex)
            {
                Console.WriteLine("Error: only whole numbers are allowed. \n"+ex.Message);
            }
            // exception divide by zero 
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: only whole numbers are allowed. Zero is not a whole number. \n" + ex.Message);
            }
            // finally instruction to continue with the execution of the program in case of a exception
            finally
            {
                Console.Read();
            }


        }
    }
}
