using System;
using MyResourcesProject;
using System.Collections.Generic;
using System.Linq;


namespace ParametersProject
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Instantiate an Employee object with type “string” as its generic parameter.*/
            Employee<string> employee = new Employee<string>(100,"Pancho","Villa");

            /*Assign a list of strings as the property value of Things.*/
            employee.things.Add("Thing 1");
            employee.things.Add("Thing 2");
            employee.things.Add("Thing 3");

            /* Instantiate an Employee object with type “int” as its generic parameter. */
            Employee<int> employee1 = new Employee<int>(101,"Pedro","Paramo");
            /* Assign a list of integers as the property value of Things.*/
            employee1.things.Add(91);
            employee1.things.Add(92);
            employee1.things.Add(93);
            employee1.things.Add(94);

            //Create a loop that prints all of the Things to the Console.
            
            Console.WriteLine("Things of: ");
            employee.SayName();

            foreach (string things in employee.things)
            {
                Console.WriteLine(things);
            }

            Console.WriteLine("Things of: ");
            employee1.SayName();

            foreach (int things in employee1.things)
            {
                Console.WriteLine(things.ToString());
            }

            Console.ReadLine();
        }
        
    }
}
