using BoozewasherApp_Web.Models;
using BoozewasherApp_Web.Models.ContextModel;
using BoozewasherApp_Web.View_Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoozewasherApp_Web.Controllers
{
    public class ServiceController : Controller
    {
        private ApplicationDbContext _context;
        public ServiceController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var services = _context.Services.ToList();
            return View(services);
        }

        public ActionResult New()
        {
            return View ("ServiceForm");
        }

        public ActionResult Edit(int id)
        {
            var service = _context.Services.SingleOrDefault(s => s.Id == id);

            if (service == null)
                return HttpNotFound();

            var viewModel = new ServiceFormViewModel(service)
            {
               
            };

            return View("ServiceForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Service service)
        {
            if (service.Id == 0)
                _context.Services.Add(service);
            else
            {
                var serviceInDB = _context.Services.Single(s => s.Id == service.Id);

                serviceInDB.Type = service.Type;
                serviceInDB.Description = service.Description;
                serviceInDB.Expense = service.Expense;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Service");
        }
        public ActionResult Delete (int id)
        {
            var service = _context.Services.SingleOrDefault(s => s.Id == id);

            if (service == null)
                return HttpNotFound();

            _context.Services.Remove(service);
            _context.SaveChanges();

            return RedirectToAction("Index", "Service");
        }
    }
}