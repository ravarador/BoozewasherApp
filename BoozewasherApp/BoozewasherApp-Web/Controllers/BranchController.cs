using BoozewasherApp_Web.Models;
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
    }
}