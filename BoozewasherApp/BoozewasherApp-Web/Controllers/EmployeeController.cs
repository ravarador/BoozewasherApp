using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoozewasherApp_Web.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }


    }
}