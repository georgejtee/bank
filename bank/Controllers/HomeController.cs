using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bank.Models;

namespace bank.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        [Authorize]
        public ActionResult Index()
        {
            var userid = User.Identity.GetUserId();
            var checkingAccountiD = db.checkingAccount.Where(c => c.ApplicationUserId == userid).First().id;
            ViewBag.checkingAccountId = checkingAccountiD;
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