using BoozewasherApp_Web.Models;
using BoozewasherApp_Web.Models.ContextModel;
using BoozewasherApp_Web.Models.ViewModels.Branches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoozewasherApp_Web.Controllers
{
    public class BranchController : Controller
    {

        private ApplicationDbContext _context;

        public BranchController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Branch
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            var viewModel = new BranchFormViewModel
            {
                Branch = new Branch()
            };

            return View("BranchForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var branch = _context.Branches.SingleOrDefault(b => b.Id == id);

            if (branch == null)
                return HttpNotFound();

            var viewModel = new BranchFormViewModel
            {
                Branch = branch
            };

            return View("BranchForm", viewModel);
        }

        public ActionResult Delete(int id)
        {
            var branch = _context.Branches.SingleOrDefault(b => b.Id == id);

            if (branch == null)
                return HttpNotFound();

            _context.Branches.Remove(branch);
            _context.SaveChanges();

            return RedirectToAction("Index", "Branch");
        }

        public ActionResult Save(Branch branch)
        {
            if (!ModelState.IsValid)
            {
                return View("BranchForm");
            }

            if (branch.Id == 0)
                _context.Branches.Add(branch);
            else
            {
                var branchInDB = _context.Branches.Single(b => b.Id == branch.Id);

                branchInDB.Name = branch.Name;
                branchInDB.Address = branch.Name;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Branch");
        }
    }
}