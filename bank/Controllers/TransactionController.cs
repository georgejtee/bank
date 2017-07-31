using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bank.Models;

namespace bank.Controllers
{
    [Authorize]
    public class TransactionController : Controller
    {

        private ApplicationDbContext  db = new ApplicationDbContext();


        // GET: Transaction/Deposit
        public ActionResult Deposit(int checkingAccountId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Deposit(transactions transaction)
        {
            if (ModelState.IsValid)
            {
                
                db.transactions.Add(transaction);
               int CheckingAccountId = transaction.CheckingAccountId;
                updatebalance(CheckingAccountId);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public void updatebalance(int CheckingAccountId)
        {
            var ca = db.checkingAccount.Where(c => c.id == CheckingAccountId).First();
            ca.balance = db.transactions.Where(c => c.CheckingAccountId == CheckingAccountId).Sum(c => c.amount);
            db.SaveChanges();
        }


        public ActionResult bidd(int checkingAccountId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult bidd(bids bid)
        {
            if (ModelState.IsValid)
            {
                db.bids.Add(bid);
                int CheckingAccountId = bid.CheckingAccountId;
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        
    }
}