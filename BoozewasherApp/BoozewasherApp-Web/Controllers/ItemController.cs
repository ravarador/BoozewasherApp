using BoozewasherApp_Web.Interfaces;
using BoozewasherApp_Web.Models;
using BoozewasherApp_Web.Models.ContextModel;
using BoozewasherApp_Web.Models.ViewModels.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoozewasherApp_Web.Controllers
{
    public class ItemController : Controller
    {
        private ApplicationDbContext _context;

        public ItemController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();  
        }
        // GET: Item
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageItems))
            return View("Index");

            return View("ReadOnlyIndex");
        }

        [Authorize(Roles = RoleName.CanManageItems)]
        public ActionResult New()
        {
            var branches = _context.Branches.ToList();

            var viewModel = new ItemsFormViewModel
            {
                Branches = branches,
                Item = new Item()
            };

            return View("ItemForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageItems)]
        public ActionResult Edit(int id)
        {
            var branches = _context.Branches.ToList();
            var item = _context.Items.SingleOrDefault(i => i.Id == id);

            if (item == null)
                return HttpNotFound();

            var viewModel = new ItemsFormViewModel
            {
                Branches = branches,
                Item = item
            };

            return View("ItemForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save (Item item)
        {
            if (!ModelState.IsValid)
            {
                return View("ItemForm");
            }
            if (item.Id == 0)
                _context.Items.Add(item);

            else
            {
                var itemInDB = _context.Items.Single(i => i.Id == item.Id);

                itemInDB.Name = item.Name;
                itemInDB.Description = item.Description;
                itemInDB.Barcode = item.Barcode;
                itemInDB.IsEmpty = item.IsEmpty;
                itemInDB.UsageCount = item.UsageCount;
                itemInDB.Expense = item.Expense;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Item");
        }

        [Authorize(Roles = RoleName.CanManageItems)]
        public ActionResult Delete(int id)
        {
            var item = _context.Items.SingleOrDefault(i => i.Id == id);

            if (item == null)
                return HttpNotFound();

            _context.Items.Remove(item);
            _context.SaveChanges();

            return RedirectToAction("Index", "Item");
        }

    }
}