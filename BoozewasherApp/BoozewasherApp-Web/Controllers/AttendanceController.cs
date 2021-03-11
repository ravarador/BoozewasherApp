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
        // GET: Attendance
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TimeIn()
        {
            var userId = User.Identity.GetUserName();

            var viewmodel = new AttendanceFormViewModel
            {
               Attendance = new Attendance()
            };

            return View("TimeInForm", viewmodel);
        }

    }

}


