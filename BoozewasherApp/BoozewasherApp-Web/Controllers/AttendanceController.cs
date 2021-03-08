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
        // GET: Attendance
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TimeIn()
        {
            var userId = User.Identity.GetUserId();
            var viewModel = new AttendanceFormViewModel
            {
                TimeInDate = DateTime.Now,
                EmployeeId = (Convert.ToInt32(userId))
            };
            return View(viewModel);
        }
    }
}