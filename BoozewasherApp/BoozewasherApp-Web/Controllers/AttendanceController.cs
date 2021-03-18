using BoozewasherApp_Web.Models;
using BoozewasherApp_Web.Models.ContextModel;
using BoozewasherApp_Web.Models.ViewModels.Attendances;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoozewasherApp_Web.Controllers
{
    public class AttendanceController : Controller
    {
        private ApplicationDbContext _context;

        public AttendanceController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Attendance
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TimeIn(Attendance attendance)
        {

            var viewmodel = new AttendanceFormViewModel
            {
                TimeInDate = DateTime.Now,
                EmployeeId = attendance.EmployeeId
            };

            return View("TimeInForm", viewmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Attendance attendance)
        { 
            if (!ModelState.IsValid)
            {
                return View("TimeInForm");
            }

            if (attendance.Id == 0)
            {
                _context.Attendances.Add(attendance);
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Attendance");
        }
    }

 }



