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
            var items = _context.Items.ToList();
            return View(items);
        }

        public ActionResult New()
        {
            var viewModel = new ItemsFormViewModel
            {
                Items = new Item()
            };

            return View("ItemForm");
        }

        public ActionResult Edit(int id)
        {
            var item = _context.Items.SingleOrDefault(i => i.Id == id);

            if (item == null)
                return HttpNotFound();

            var viewModel = new ItemsFormViewModel
            {
                Items = item
            };

            return View("ItemForm", viewModel);
        }
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