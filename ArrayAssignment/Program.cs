using System;
using System.Collections.Generic;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //init arrays and list anda variables
            int i;  // user input
            string[] top5Billboard = new string[] { "Easy on Me", "Stay", "Industry Baby", "All to Well", "Oh My God" };
            int[] top3Heights = new int[] { 29035, 28250, 28169 };
            List<string> myFavoriteAnimals= new List<string>();
            myFavoriteAnimals.Add("Dog");
            myFavoriteAnimals.Add("Chimp");
            myFavoriteAnimals.Add("Elephant");


            Console.WriteLine("Select one of the Top 5 Billboard songs. [Type 1-5]");
            i = Convert.ToInt32(Console.ReadLine());
            if (i<1 || i > 5) // just five elemnts in array
            {
                Console.WriteLine("Error: Invalid number.");
            }
            else
            {
                Console.WriteLine("Song No."+i+ ": "+top5Billboard[i-1]); //i-1 index starts at 0 
            }


            Console.WriteLine("Do you know the heights of three highest mounts?  [type 1-3]");
            i = Convert.ToInt32(Console.ReadLine()); // just three elemnts in array
            if (i < 1 || i > 3)
            {
                Console.WriteLine("Error: Invalid number.");
            }
            else
            {
                Console.WriteLine(i + ". Height: " + top3Heights[i - 1] + " ft."); //i-1 index starts at 0
            }

            Console.WriteLine("Do you know my tree favorite animals?  [type 1-3]");
            i = Convert.ToInt32(Console.ReadLine());
            if (i < 1 || i > 3) // just three elemnts in array
            {
                Console.WriteLine("Error: Invalid number.");
            }
            else
            {
                Console.WriteLine(i + ". " + myFavoriteAnimals[i - 1]);
            }

        }
    }
}
