using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechAcadStudentsMVC.Models
{
    public class Instructor
    {
        public Instructor(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}