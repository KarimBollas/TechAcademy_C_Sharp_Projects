using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_WebApp_Video.Models
{
    public class User
    {
        public User(int id, string firstName, string lastName, int age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


    }
}