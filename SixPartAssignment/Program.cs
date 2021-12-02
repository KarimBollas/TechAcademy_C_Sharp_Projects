using System;
using System.Collections.Generic;

namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Initialize array of animals
            string[] arrayAnimals = new string[]
            {
                "Dog",
                "Duck",
                "Chimp",
                "Bear",
                "Moose",
                "Cat",
                "Lion"
            };

            // Ask for a  input string
            Console.WriteLine("Input a string ");
            string userInput = " "+Console.ReadLine();

            //iterates through array
            for (int i=0; i< arrayAnimals.Length; i++)
            {
                arrayAnimals[i] += userInput; // add user input string
            }

            //print all elements 
            for (int i = 0; i < arrayAnimals.Length; i++) //CONSOLE APP PART THREE ASSIGNMENT 3. comparison that’s used to determine whether to continue iterating the loop is a “<”
            {
                Console.WriteLine( (i+1) + ". " +arrayAnimals[i]); // format n. string userInput
            }

            //CONSOLE APP PART TWO ASSIGNMENT 3 infinite loop
            /*
            for (int i = 0; i < arrayAnimals.Length; i--) // wrong instruction i--
            {
                Console.WriteLine((i + 1) + ". " + arrayAnimals[i]); // format n. string userInput
            }
            */

            //CONSOLE APP PART THREE ASSIGNMENT 3. comparison that’s used to determine whether to continue iterating the loop is a “<=”
            for (int i=1; i <= arrayAnimals.Length; i++ )
            {
                Console.WriteLine(i + ". " + arrayAnimals[i-1]);
            }

            //------------CONSOLE APP PART FOUR ASSIGNMENT-------------------
            List<string> listColors = new List<string>();
            listColors.Add("blue");
            listColors.Add("red");
            listColors.Add("yellow");
            listColors.Add("magenta");
            listColors.Add("pink");
            listColors.Add("purple");
            listColors.Add("green");
            listColors.Add("orange");
            listColors.Add("gray");
            bool isInColor = false;

            // Ask for a  input string
            Console.WriteLine("\n\nType a color");
            string inputColor = Console.ReadLine();

            int j=0; //control index 
            while (j<listColors.Count && !isInColor) 
            {                
                
                if (listColors[j].Equals(inputColor,StringComparison.OrdinalIgnoreCase)) //compare input and eaxh element on the list
                {
                    isInColor = true;  // found on the list
                    Console.WriteLine("Congrats, the index of "+ inputColor + " is "+j+ " (index starts at 0)");
                }
                j++;
            }
            if (!isInColor)
            {
                Console.WriteLine(inputColor+" is not on the list.");
            }

            //------------CONSOLE APP PART FIVE ASSIGNMENT-------------------
            List<string> listNames = new List<string>();
            listNames.Add("Maria");
            listNames.Add("Pedro");
            listNames.Add("Juan");
            listNames.Add("Ernesto");
            listNames.Add("Raul");
            listNames.Add("Ricardo");
            listNames.Add("Manuel");
            listNames.Add("Maria");
            listNames.Add("Ernesto");

            List<int> listIndex = new List<int>();
            j = 0; //control index
            
            //Display list to the user
            Console.WriteLine("\n\nList of names: "); 
            foreach (string name in listNames)
            {
                Console.WriteLine(name);
            }

            //ask user to type a name to search for
            Console.WriteLine("Type a name to search for in the list?");
            string inputName = Console.ReadLine();

            //intearates through list
            foreach (string name in listNames)
            {
                if (name.Equals(inputName, StringComparison.CurrentCultureIgnoreCase)) //compares input and array element
                {
                    listIndex.Add(j);                                   // stores the index found
                    Console.WriteLine(name + " found, index: " + j);    // displays found name and index 
                }
                j++; //incrments index
            }

            if (listIndex.Count==0) // if list of index is empty ?
            {
                Console.WriteLine("Input is not on the list");  // Displays name is not in the list
            }

            //------------CONSOLE APP PART SIX ASSIGNMENT-------------------

            //use listNames and a listNamesBuffer

            List<string> listNamesBuffer = new List<string>();

            // scroll through the entire list
            foreach (string name in listNames)
            {
                Console.WriteLine(name); // prints element
                if (listNamesBuffer.Contains(name)) // if found element in buffer
                {
                    Console.WriteLine("Already exists in the list."); //display found
                }
                else
                {
                    listNamesBuffer.Add(name); // add elemnt to buffer list
                }             
            }
            Console.ReadLine();
        }
    }
}
