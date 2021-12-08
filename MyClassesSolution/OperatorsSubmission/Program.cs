using System;

namespace OperatorsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee1 = new Employee(100, "Pepe", "Perez"); 
            Employee employee2 = new Employee(100, "Pedro", "Navajas");
            Employee employee3 = new Employee(101, "Mario", "Bros");

            if (employee1==employee2)
            {
                Console.WriteLine("Employee Id: {0} already exists.", employee1.GetId().ToString());
            }

            if (employee1 != employee3)
            {
                Console.WriteLine("Employee Id: {0} and Employee Id: {1} are not the same employee.", employee1.GetId().ToString(), employee3.GetId().ToString());
            }

            Console.ReadLine();

        }
    }
}
