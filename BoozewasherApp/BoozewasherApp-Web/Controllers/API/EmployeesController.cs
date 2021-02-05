using AutoMapper;
using BoozewasherApp_Web.Models;
using BoozewasherApp_Web.Models.ContextModel;
using BoozewasherApp_Web.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BoozewasherApp_Web.Controllers.API
{
    public class EmployeesController : ApiController
    {
        private ApplicationDbContext _context;

        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /API/Employees    

        public IHttpActionResult GetEmployees()
        {
            var employees = _context.Employees.Include("Branch")
                                         .ToList();

            return Ok(employees);
        }

        //GET /API/Employees/GetEmployee
        public IHttpActionResult GetEmployee(int id)
        {
            var employee = _context.Employees.Include("Branch").SingleOrDefault(s => s.Id == id);

            if (employee == null)
                return NotFound();

            return Ok(employee);
        }
        //GET /API/Employees/GetEmployeesByBranchId
        public IHttpActionResult GetEmployeesByBranchId(int id)
        {
            var employees = _context.Employees.Include("Branch")
                                         .Where(a => a.BranchId == id)
                                         .ToList();

            return Ok(employees);
        }
        //POST /API/Employees/CreateEmployee
        [HttpPost]
        public IHttpActionResult CreateEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _context.Employees.Add(employee);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + employee.Id), employee);
        }

        //PUT /API/Employee/1
        [HttpPut]
        public void UpdateEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var employeeToUpdate = _context.Employees.SingleOrDefault(i => i.Id == employee.Id);

            if (employeeToUpdate == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.SaveChanges();
        }

        //DELETE /API/Employees/1
        public void DeleteEmployee(int id)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var employee = _context.Employees.SingleOrDefault(i => i.Id == id);

            if (employee == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }
        //POST /API/Employees/GetEmployeesBySearchParameter
        [HttpPost]
        public IHttpActionResult GetEmployeesBySearchParameter(SearchDto searchDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var employees = _context.Employees.Include("Branch")
                                                    .Where(a => a.BranchId == searchDto.BranchId)
                                                    .AsEnumerable();

            switch (searchDto.SearchBy.ToUpper().Trim())
            {
                case "FIRSTNAME":
                    employees = employees.Where(a => a.FirstName.Contains(searchDto.SearchText));
                    break;
                case "MIDDLENAME":
                    employees = employees.Where(a => a.MiddleName.Contains(searchDto.SearchText));
                    break;
                case "LASTNAME":
                    employees = employees.Where(a => a.LastName.Contains(searchDto.SearchText));
                    break;
                case "ADDRESS":
                    employees = employees.Where(a => a.Address.Contains(searchDto.SearchText));
                    break;
                case "TIN":
                    employees = employees.Where(a => a.TIN.Contains(searchDto.SearchText));
                    break;
                case "EMAIL":
                    employees = employees.Where(a => a.Email.Contains(searchDto.SearchText));
                    break;
                case "CONTACTNO":
                    employees = employees.Where(a => a.ContactNo.Contains(searchDto.SearchText));
                    break;
                default:
                    break;

            }

            return Ok(employees.ToList());
        }
    }
}