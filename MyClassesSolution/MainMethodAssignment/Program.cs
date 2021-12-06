using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // instantiate the class Operations.
            Operations operations = new Operations();
            //call the one method, passing in an integer and display the result to the screen.
            Console.WriteLine("500 KB equals to: "+operations.ConvertFromKBTob(500)+" bits");

            // instantiate the class Operations
            Operations operations2 = new Operations();
            //call the second  method, passing in a decimal and display the result to the screen.
            Console.WriteLine("500 KB equals to: " + operations2.ConvertFromKBTob(500m) + " bits");

            // instantiate the class Operations
            Operations operations3 = new Operations();
            //call the third  method, passing in a string and display the result to the screen.
            Console.WriteLine("500 KB equals to: " + operations3.ConvertFromKBTob("500") + " bits");

            Console.ReadLine();
        }
    }
}
