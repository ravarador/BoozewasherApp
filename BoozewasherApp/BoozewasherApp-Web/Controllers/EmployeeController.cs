using BoozewasherApp_Web.Models;
using BoozewasherApp_Web.Models.ContextModel;
using BoozewasherApp_Web.Models.ViewModels.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoozewasherApp_Web.Controllers
{
    public class EmployeeController : Controller
    {
        public ApplicationDbContext _context;

        public EmployeeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
           _context.Dispose();
        }

        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            var viewModel = new EmployeeFormViewModel
            {
                Employee = new Employee()
            };

            return View("EmployeeForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == id);

            if (employee == null)
                return HttpNotFound();

            var viewModel = new EmployeeFormViewModel
            {
                Employee = employee
            };

            return View("EmployeeForm", viewModel);
        }

        public ActionResult Delete(int id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == id);

            if (employee == null)
                return HttpNotFound();

            _context.Employees.Remove(employee);
            _context.SaveChanges();

            return RedirectToAction("Index", "Employee");
        }

        public ActionResult Save (Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View("EmployeeForm");
            }

            if (employee.Id == 0)
                _context.Employees.Add(employee);
            else
            {
                var employeeInDB = _context.Employees.Single(e => e.Id == employee.Id);

                employeeInDB.FirstName = employee.FirstName;
                employeeInDB.MiddleName = employee.MiddleName;
                employeeInDB.LastName = employee.LastName;
                employeeInDB.Address = employee.Address;
                employeeInDB.Birthdate = employee.Birthdate;
                employeeInDB.TIN = employee.TIN;
                employeeInDB.Email = employee.Email;
                employeeInDB.ContactNo = employee.ContactNo;
                employeeInDB.BranchId = employee.BranchId;

                _context.SaveChanges();
            }
            return View("Index", "Employee");
        }


    }
}