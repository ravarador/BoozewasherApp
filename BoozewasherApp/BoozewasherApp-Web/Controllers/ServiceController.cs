﻿using BoozewasherApp_Web.Models;
using BoozewasherApp_Web.Models.ContextModel;
using BoozewasherApp_Web.Models.ViewModels.Services;
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
            if (User.IsInRole(RoleName.CanManageServices))
                return View("Index");

                return View("ReadOnlyIndex");
        }

        [Authorize(Roles = RoleName.CanManageServices)]
        public ActionResult New()
        {
            var viewModel = new ServiceFormViewModel
            {
                Service = new Service()
            };
            return View ("ServiceForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageServices)]
        public ActionResult Edit(int id)
        {
            var service = _context.Services.SingleOrDefault(s => s.Id == id);

            if (service == null)
                return HttpNotFound();

            var viewModel = new ServiceFormViewModel()
            {
               Service = service
            };

            return View("ServiceForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Service service)
        {
            if (!ModelState.IsValid)
            {
                return View("ServiceForm");
            }

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

        [Authorize(Roles = RoleName.CanManageServices)]
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