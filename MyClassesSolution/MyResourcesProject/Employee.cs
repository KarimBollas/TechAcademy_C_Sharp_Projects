using System;
using System.Collections.Generic;
using System.Linq;


namespace MyResourcesProject
{

    /*--3 Create another class called Employee and have it inherit from the Person class.-----*/

    public class Employee<T> : Person, IQuittable
    {
        public Employee(int id, string firstName, string lastName="") //Constructor 
        {
            this.SetFirstName(firstName);
            this.SetLastName(lastName);
            this.SetId(id);
        }       

        public void SetId(int value) //Set Id Method
        {
            Id = value;
        }
        public int GetId()
        {
            return Id;
        }
        /*---------PROPERTIES---------*/
        private int Id;
        //property to the Employee class called “things” and have its data type be a generic list
        //matching the generic type of the class.
        public List<T> things = new List<T>();
        




        public override void SayName()
        {
            Console.WriteLine("Employee Id: "+this.GetId().ToString());
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("------404-------");
            //this.SetLastName("Erased.");
        }

        //Overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.
        public static bool operator ==(Employee<T> employee1, Employee<T> employee2)
        {
            return (employee1.Id == employee2.Id);             
        }

        //Overload the “!=” operator so it checks if two Employee objects are diferents by comparing their Id property.
        public static bool operator !=(Employee<T> employee1, Employee<T> employee2)
        {
            return !(employee1.Id == employee2.Id);
        }
        
        
    }
}
