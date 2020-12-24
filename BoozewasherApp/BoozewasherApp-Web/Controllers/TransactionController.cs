using BoozewasherApp_Web.Models;
using BoozewasherApp_Web.Models.ContextModel;
using BoozewasherApp_Web.Models.ViewModels.Transactions;
using BoozewasherApp_Web.Models.ViewModels.Vehicles;
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
            if (User.IsInRole(RoleName.CanManageTransactions))
            return View("Index");

            return View("ReadOnlyIndex");
        }

        [Authorize(Roles = RoleName.CanManageTransactions)]
        public ActionResult New()
        {
            var services = _context.Services.ToList();
            var vehicles = _context.Vehicles.ToList();
            var viewModel = new TransactionFormViewModel
            {
                Services = services,
                Vehicles = vehicles
            };
            return View("TransactionForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageTransactions)]
        public ActionResult Edit(int id)
        {
            var transaction = _context.Transactions.Include("Service")
                                                   .Include("Vehicle")
                                                   .SingleOrDefault(t => t.Id == id);

            if (transaction == null)
                return HttpNotFound();

            var viewModel = new TransactionFormViewModel(transaction)
            {
                Vehicles = _context.Vehicles.ToList(),
                Services = _context.Services.ToList()
            };
            return View("TransactionForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save (Transaction transaction)
        {
            if (!ModelState.IsValid)
            {
                return View("TransactionForm");
            }

            if (transaction.Id == 0)
            {
                transaction.DateTime = DateTime.Now;
                _context.Transactions.Add(transaction);
            }
            else
            {
                var transactionInDB = _context.Transactions.SingleOrDefault(t => t.Id == transaction.Id);

                transactionInDB.VehicleId = transaction.VehicleId;
                transactionInDB.ServiceId = transaction.ServiceId;
                transactionInDB.PlateNumber = transaction.PlateNumber;
                transactionInDB.Cost = transaction.Cost;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Transaction");
        }

        [Authorize(Roles = RoleName.CanManageTransactions)]
        public ActionResult Delete(int id)
        {
            var transaction = _context.Transactions.SingleOrDefault(s => s.Id == id);

            if (transaction == null)
                return HttpNotFound();

            _context.Transactions.Remove(transaction);
            _context.SaveChanges();

            return RedirectToAction("Index", "Transaction");
        }

        public ActionResult VehicleLookup()
        {
            var vehicles = _context.Vehicles.ToList();
            return View(vehicles);
        }

        public ActionResult SelectedVehicle(int id)
        {
            var vehicle = _context.Vehicles.SingleOrDefault(t => t.Id == id);

            if (vehicle == null)
                return HttpNotFound();

            var viewModel = new TransactionFormViewModel()
            {
               VehicleId = vehicle.Id,
               Services = _context.Services.ToList()
            };
            return View("TransactionForm", viewModel);
        }
    }
}

