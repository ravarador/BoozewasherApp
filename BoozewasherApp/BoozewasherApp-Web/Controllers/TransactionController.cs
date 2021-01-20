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
            var branches = _context.Branches.ToList();

            var viewModel = new TransactionFormViewModel
            {
                Services = services,
                Vehicles = vehicles,
                Branches = branches
            };
            return View("TransactionForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageTransactions)]
        public ActionResult Edit(int id)
        {
            var transaction = _context.Transactions.Include("Service")
                                                   .Include("Vehicle")
                                                   .Include("Branch")
                                                   .SingleOrDefault(t => t.Id == id);

            if (transaction == null)
                return HttpNotFound();

            var viewModel = new TransactionFormViewModel(transaction)
            {
                Vehicles = _context.Vehicles.ToList(),
                Services = _context.Services.ToList(),
                Branches = _context.Branches.ToList()
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

            if (transaction.Id == transaction.VehicleId)
            {
               transaction.DateTime = DateTime.Now;
                _context.Transactions.Add(transaction);
            }
            else
            {
                var transactionInDB = _context.Transactions.SingleOrDefault(t => t.Id == transaction.Id);

                if (transactionInDB == null)
                    return HttpNotFound();

                transactionInDB.VehicleId = transaction.VehicleId;
                transactionInDB.ServiceId = transaction.ServiceId;
                transactionInDB.BranchId = transaction.BranchId;
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

        #region Lookup
        [Authorize(Roles = RoleName.CanManageTransactions)]
        public ActionResult VehicleLookup()
        {
            var vehicles = _context.Vehicles.ToList();
            return View(vehicles);
        }

        [Authorize(Roles = RoleName.CanManageTransactions)]
        public ActionResult ItemLookup()
        {
            var items = _context.Items.ToList();
            return View(items);
        }
        #endregion

        #region Selected
        public ActionResult SelectedVehicle(int id)
        {
            var vehicle = _context.Vehicles.SingleOrDefault(i => i.Id == id);

            if (vehicle == null)
                return HttpNotFound();

            var viewModel = new TransactionFormViewModel
            {
                VehicleId = id,
                Services = _context.Services.ToList()
            };

            return View("TransactionForm", viewModel);
        }

  
        public ActionResult SelectedItem(int id)
        {
            var item = _context.Items.SingleOrDefault(i => i.Id == id);

            if (item == null)
                return HttpNotFound();

            var viewModel = new TransactionFormViewModel
            {
                ItemId = id,
                Services = _context.Services.ToList()
            };

            return View("TransactionForm", viewModel);
        }

        #endregion

    }
}

