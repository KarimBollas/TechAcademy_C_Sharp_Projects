using System;

namespace AbstractClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*----5. Inside the Main() method, instantiate an Employee object 
             * with firstName “Sample” and lastName “Student”. 
             * Call the SayName() method on the object.----*/

            Employee employee = new Employee(100, "Sample", "Student"); // object employee
            employee.SayName(); //calls method SayName (Overrided in Employee class inherits from Person class)
            Console.ReadLine();
        }
    }
}
