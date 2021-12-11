using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using MVC_WebApp_Video.Models;

namespace MVC_WebApp_Video.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Karim was here :)";
            //System.IO.File.WriteAllText(@"C:\Users\Karim\source\repos\TechAcademy_C_Sharp_Projects\MVC_WebApp_Video\log\log.txt",text);

            //Random rnd = new Random(10);
            //var num = rnd.Next();

            //if (num>20000)
            //{
            //    return View("About");
            //}

            //return View();

            //return Content("");

            //return RedirectToAction("Contact");

            //return View("Contact");

            //List<string> names = new List<string>
            //{
            //    "David",
            //    "Manuel",
            //    "Ubaldo"
            //};
            //return View(names);

            //int number = 5;
            //return View(number);

            User user = new User(1, "Karim","Bollas",34);
            return View(user);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            throw new Exception("Invalid page");

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}