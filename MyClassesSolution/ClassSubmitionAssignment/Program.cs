using System;

namespace ClassSubmitionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*-------------2. In the Main() method, instantiate that class.-------------*/
            MyClass myObject = new MyClass(); //instantiate class MyClass.
            double numberBy2;

            /*----3. Have the user enter a number. Call the method on that number. Display the output to the screen. 
             * It should be the entered number, divided by two..------*/
            Console.WriteLine("Type a whole number."); //user enter a number
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write(number + " divided by 2: " );
                myObject.DivideBy2(number);                 //Call DivideBy2 Method
                Console.Write("\n");
                myObject.DivideBy2(out numberBy2, number);  //Call overload DivideBy2 Method, out paramter  numberBy2  
                Console.WriteLine(number + " divided by 2: "+numberBy2); //output numberBy2

                Console.WriteLine(number + " divided by 2: " + Division.DivideBy2(number)); //call Method form static class

            }

            //Exception handler in case user input format Not being a number
            catch (FormatException)
            {
                Console.WriteLine("Error: Only whole numbers allowed. \nProgram ends.");
            }
            //Exception handler in case user input being 0
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: No zero allowed. \nProgram ends.");
            }

            Console.ReadLine();
        }
    }
}
