using BoozewasherApp_Web.Models;
using BoozewasherApp_Web.Models.ContextModel;
using BoozewasherApp_Web.View_Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoozewasherApp_Web.Controllers
{
    public class VehicleController : Controller
    {
        private ApplicationDbContext _context;
        public VehicleController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

        }
        public ActionResult Index()
        {
            var vehicles = _context.Vehicles.ToList();
            return View(vehicles);
        }

        public ActionResult New()
        {
            return View("VehicleForm");
        }

        public ActionResult Edit(int id)
        {
            var vehicle = _context.Vehicles.SingleOrDefault(v => v.Id == id);

            if (vehicle == null)
                return HttpNotFound();
            var viewModel = new VehicleFormViewModel(vehicle)
            {

            };
            return View("VehicleForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Vehicle vehicle)
        {
            if (!ModelState.IsValid)
            {
                return View("VehicleForm");
            }

            if (vehicle.Id == 0)
                _context.Vehicles.Add(vehicle);
            else
            {
                var vehicleInDb = _context.Vehicles.Single(s => s.Id == vehicle.Id);

                vehicleInDb.Type = vehicle.Type;
                vehicleInDb.Description = vehicle.Description;
                vehicleInDb.Brand = vehicle.Brand;
                vehicleInDb.Model = vehicle.Model;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Vehicle");
        }

    }
}