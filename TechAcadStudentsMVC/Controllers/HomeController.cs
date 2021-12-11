using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page- The Tech Academy";

            return View();
        }
        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor(1,"Rick","Ramen"),
                new Instructor(2,"Brett","Calendar"),
                new Instructor(1,"Adam","Smithsonian")
        };
            return View(instructors);
        }
        public ActionResult Instructor(int id)
        {

            ViewBag.Id = id;
            Instructor dayTimeStructor = new Instructor(100,"Erik","Gross");
            return View(dayTimeStructor);
        }
    }
}