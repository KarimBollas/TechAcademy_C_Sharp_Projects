using System;


namespace OperatorsSubmission
{

    /*--3 Create another class called Employee and have it inherit from the Person class.-----*/

    public class Employee : Person, IQuittable
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

        public void Quit()
        {
            Console.WriteLine("------404-------");
            //this.SetLastName("Erased.");
        }

        //Overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return (employee1.Id == employee2.Id);             
        }

        //Overload the “!=” operator so it checks if two Employee objects are diferents by comparing their Id property.
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1.Id == employee2.Id);
        }
    }
}
