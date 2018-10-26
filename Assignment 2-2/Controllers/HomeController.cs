using Assignment_2_2.Helper;
using Assignment_2_2.Models.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Assignment_2_2.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Age()
        {
            var Date1 = new DateTime(1990, 01, 01).ToAge();
            var Date2 = new DateTime(1987, 05, 07).ToAge();
            var Date3 = new DateTime(1975, 10, 10).ToAge();
            return View();
        }
        public ActionResult ToDigitsOnly()
        {
            var string1 = "abc123".ToDigitsOnly();
            var string2 = "z1x2c3v4".ToDigitsOnly();
            var string3 = "#$ss223%^".ToDigitsOnly();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}