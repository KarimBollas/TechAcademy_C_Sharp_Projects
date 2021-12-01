using System;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = "red";
            bool isMexFlag;
            if (color=="green")
            {
                isMexFlag = true;
            }
            else if (color=="white")
            {
                isMexFlag = true;
            }
            else if (color == "red")
            {
                isMexFlag = true;
            }
            else
            {
                isMexFlag = false;
            }
            if (isMexFlag)
            {
                Console.WriteLine(color + " is a mexican flag color.");
            }
            else
            {
                Console.WriteLine(color + " is NOT a mexican flag color.");
            }

            byte age = 17;
            if (age != 0)
            {
                if (age < 18)
                {
                    Console.WriteLine("You are still to young to vote in Mexico.");                    
                }
                else
                {
                    Console.WriteLine("You are an adult in Mexico.");
                }
                if (age >= 65)
                {
                    Console.WriteLine("You can ask for government help in Mexico.");
                }

                
                int daysMonth = 29;
                string month = (daysMonth == 28 || daysMonth == 29) ? "February": "Not February";
                Console.WriteLine(month);

                int currentTemp = 80;
                int roomTemp = 70;

                if (currentTemp==roomTemp)
                {
                    Console.WriteLine("It is exactly room temperature.");
                }
                else if (currentTemp > roomTemp)
                {
                    Console.WriteLine("It is warmer than room temperature.");
                }
                else if (currentTemp < roomTemp)
                {
                    Console.WriteLine("Room temperature is warmer than current temperature.");
                }
                else
                {
                    Console.WriteLine("It is NOT exactly  room temperature.");
                }

                string comparisonResult = currentTemp == roomTemp ? "It is troom temp." : "It is not room temp.";
                Console.WriteLine(comparisonResult);

                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Hello, "+ name+ ", what is the temperature where you are?");
                currentTemp = Convert.ToInt32(Console.ReadLine());

                if (currentTemp==roomTemp)
                {
                    Console.WriteLine("It is exactly room temperature.");
                }
                else if (currentTemp > roomTemp)
                {
                    Console.WriteLine("It is warmer than room temperature.");
                }
                else if (currentTemp < roomTemp)
                {
                    Console.WriteLine("It is colder than room temperature.");
                }
                else
                {
                    Console.WriteLine("Uhhhhh.... something were wrong!!");
                }

                Console.WriteLine("What is your favorite number?");
                int favNum = Convert.ToInt32(Console.ReadLine());

                string result = favNum == 8 ? "You have an awesome fovorite number." : "You do NOT have an awesome fovorite number.";

                Console.WriteLine(result);
            }

        }
    }
}
