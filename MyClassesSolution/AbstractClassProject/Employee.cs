using System;


namespace AbstractClassProject
{

    /*--3 Create another class called Employee and have it inherit from the Person class.-----*/

    public class Employee : Person
    {
        public Employee(int id, string firstName, string lastName="") //Constructor 
        {
            this.SetFirstName(firstName);
            this.SetLastName(lastName);
            this.SetId(id);
        }       

        public virtual void SetId(int value) //Set Id Method
        {
            Id = value;
        }
        public int GetId()
        {
            return Id;
        }
        private int Id;

        public override void SayName()
        {
            Console.WriteLine("Employee Id: "+this.GetId().ToString());
            base.SayName();
        }
    }
}
