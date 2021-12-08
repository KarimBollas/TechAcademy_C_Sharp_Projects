using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    /* 1----Create an abstract class called Person with two properties: string firstName and string lastName.-----*/
    public abstract class Person
    {            
            protected Person()
            {               
            }
            public Person(string firstName, string lastName = "")
            {
                this.SetFirstName(firstName);                
                this.SetLastName(lastName);                
            }                
            private string FirstName;
            private string LastName;
            /*---- Methods to get and set FirstName and LastName -----*/
            public string GetFirstName()
            {
                return FirstName;
            }
            public void SetFirstName(string value)
            {
                FirstName = value;
            }
            public string GetLastName()
            {
                return LastName;
            }
            public void SetLastName(string value)
            {
                LastName = value;
            }
            /*-------2 Give it the method SayName().*/
            public virtual void SayName()
            {
                Console.WriteLine("Name: {0} {1}", this.GetFirstName(), this.GetLastName());
            }




        
    }
}
