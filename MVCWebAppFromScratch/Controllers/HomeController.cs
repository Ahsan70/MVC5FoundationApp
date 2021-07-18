using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebAppFromScratch.Models;

namespace MVCWebAppFromScratch.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetEmployee();
            return View(data);
        }
        [HttpPost]
        public ActionResult Index(Employee emp)
        {

            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        private Employee GetEmployee()
        {
            return new Employee()
            {
               Id = 1,
               Name = "Ahsan",
               Address = "Dallas Texas"

            };
        }
    }
}