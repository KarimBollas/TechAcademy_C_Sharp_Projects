using System;
using PolymorphismProject;
using System.Collections.Generic;
using System.Linq;

namespace LambdaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of employees 
            List<Employee> listEmployees = new List<Employee>();
            //loop to create 15 employees
            for (int i=1; i<=15; i++)
            {
                //instance an employee
                Employee employee = new Employee(i, "Name" + i, "Last" + i);
                //one of each 3 employees named Joe
                if (i % 3 == 0)
                {
                    employee.SetFirstName("Joe");
                }
                //add instance employee to listEmployees
                listEmployees.Add(employee);
            }
            //Create a new list of employees, add the employees Named Joe form the original list 
            List<Employee> listEmployees2 = new List<Employee>();
            foreach (Employee employee in listEmployees)
            {
                if (employee.GetFirstName()=="Joe")
                {
                    listEmployees2.Add(employee);
                    employee.SayName();//display to console, just to check
                }                
            }


            //Create a new list of employees, add the employees Named Joe form the original list 
            //now with lambda expression
            List<Employee> listEmployees3 = listEmployees.Where(employee => employee.GetFirstName() == "Joe").ToList();

            //display the third list, just to check
            Console.WriteLine("\nEmployees List created with lambda:");
            foreach(Employee employee in listEmployees3)
            {
                employee.SayName();
            }

            //Create a new list of employees, add the employees with Id>5 form the original list  with lambda expression
            List<Employee> listEmployees4 = listEmployees.Where(employee => employee.GetId() >5).ToList();

            //display the fourth list, just to check
            Console.WriteLine("\nEmployees with Id>5.");
            foreach (Employee employee in listEmployees4)
            {
                employee.SayName();
            }

            Console.ReadLine();
        }
    }
}
