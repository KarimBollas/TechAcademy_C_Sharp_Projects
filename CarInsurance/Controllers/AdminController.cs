using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {

                var insureesVm = new List<InsureeVm>();
                foreach(var insuree in db.Insurees.ToList())
                {
                    InsureeVm insureeVm = new InsureeVm();
                    insureeVm.FirstName = insuree.FirstName;
                    insureeVm.LastName = insuree.LastName;
                    insureeVm.EmailAddress = insuree.EmailAddress;
                    insureeVm.Quote = insuree.Quote;
                    insureesVm.Add(insureeVm);
                }
                return View(insureesVm);
            }
            
        }
    }
}