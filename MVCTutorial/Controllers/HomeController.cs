using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string user1 = "Koert";
            string user2 = "Rob";

            string[] users = new string[] { user1, user2 };

            ViewBag.AllUsers = users;
           


            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }
    }
}