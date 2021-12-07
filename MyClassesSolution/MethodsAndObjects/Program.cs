using System;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            /*----- 4. Inside of the Main method, instantiate and initialize an Employee object 
             * with a first name of “Sample” and a last name of “Student”.---------*/

            Employee employee = new Employee(100, "Sample", "Student"); // object employee
            employee.SayName(); //calls method SayName (Person class)
        }
    }
}
