using System;


namespace MethodsAndObjects
{

    /*--------1 Create a class called Person and give it two properties, each of data type string. 
     * One called FirstName, the other LastName.----------*/
    public class Person
    {
        protected Person()
        {
            //this.SetFirstName(firstName);
            //this.SetLastName(lastName);
        }
        public Person(string firstName, string lastName="")
        {
            //this.SetFirstName(firstName);
            this.FirstName = firstName;
            //this.SetLastName(lastName);
            this.LastName = lastName;
        }

        

        //public Person()
        //{
        //    this.SetFirstName("");
        //    this.SetLastName("");
        //}
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

        /*-------2 Give this class a void method called SayName() that takes no parameters 
         * and simply writes the person's full name to the console in the format of: “Name: [full name]”.*/
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}",this.GetFirstName(),this.GetLastName());
        }




    }
}
