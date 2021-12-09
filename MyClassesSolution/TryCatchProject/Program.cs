using System;

namespace TryCatchProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            
            bool isValidAge = false;
            int age;
            while (!isValidAge)
            {
                Console.WriteLine("How old are you? (years) ");

                try
                {
                    isValidAge = int.TryParse(Console.ReadLine(), out age);
                    if (age==0 && isValidAge)
                    {
                        isValidAge = false;
                        throw new Exception("Really? 0 years old? ");
                        
                    }
                    else if (age < 0 && isValidAge)
                    {
                        isValidAge = false;
                        throw new Exception("Positive age please :| ");
                        
                    }
                    else if (isValidAge)
                    {
                        Console.WriteLine("Your birth year: " + DateTime.Now.AddYears(0 - age).Year);
                        Console.ReadLine();
                    }

                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error, {0}\nType only positive whole numbers.",ex.Message);
                    Console.ReadLine();                    
                }
                
            }


            
            
            
        }
    }
}
