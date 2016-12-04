using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.Models;
using MVCTutorial.Models.DataModel;
using MVCTutorial.DataAccess;

namespace MVCTutorial.Controllers
{
    public class AccountController : Controller
    {
        private AccountContext db = new AccountContext();

        // GET: Account
        public ActionResult Index()
        {
            var myModel = new AccountViewModel();

            myModel.Account = db.GetCurrentAcount();

            return View(myModel);
        }

        public ActionResult Save(AccountViewModel data)
        {
            if(this.ModelState.IsValid)
            {
                //                db.SaveAccount(data.Account);
                //ModelState.AddModelError(string.Empty, "Not niet gebouwd");
                data.Bericht = "Jaja zover zijn we nog niet";
            }

            return View("Index", data);
        }
    }
}