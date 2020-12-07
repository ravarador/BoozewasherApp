using BoozewasherApp_Web.Models;
using BoozewasherApp_Web.Models.ViewModels.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoozewasherApp_Web.Controllers
{
    public class TransactionController : Controller
    {
        private ApplicationDbContext _context;

        public TransactionController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var transaction = _context.Transactions.ToList();
            return View(transaction);
        }

        public ActionResult New()
        {
            return View("TransactionForm");
        }

        public ActionResult Edit(int id)
        {
            var transaction = _context.Transactions.SingleOrDefault(t => t.Id == id);

            if (transaction == null)
                return HttpNotFound();

            var viewModel = new TransactionFormViewModel
            {

            };
            return View("TransactionForm", viewModel);
        }
    }
}