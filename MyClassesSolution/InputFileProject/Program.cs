using System;
using System.IO;

namespace InputFileProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath= @"C:\Users\Karim\source\repos\TechAcademy_C_Sharp_Projects\MyClassesSolution\InputFileProject\logs\log.txt";

            Console.WriteLine("Input a number.");
            string textInput = Console.ReadLine();
            File.WriteAllText(filePath,textInput);

            string readText= File.ReadAllText(filePath);
            Console.WriteLine("Text from file: "+readText);

            Console.ReadLine();
        }
    }
}
