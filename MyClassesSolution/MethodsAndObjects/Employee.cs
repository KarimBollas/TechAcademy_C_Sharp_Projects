using System;


namespace MethodsAndObjects
{

    /*----------3 Create another class called Employee and have it inherit from the Person class. 
     * Give the Employee class a property called Id and have it be of data type int.-----*/

    public class Employee : Person
    {
               
        private int Id;

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

    }
}
