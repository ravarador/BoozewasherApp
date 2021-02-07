using BoozewasherApp_Web.Models;
using BoozewasherApp_Web.Models.ContextModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BoozewasherApp_Web.Controllers.API
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }
        //POST /API/Attendances/TimeInEmployee
        public IHttpActionResult TimeInEmployee(Attendance attendance)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.Attendances.Add(attendance);
            _context.SaveChanges();
            return Ok(attendance);
        }
        //POST /API/Attendances/TimeOutEmployee
        public IHttpActionResult TimeOutEmployee(Attendance attendance)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var attendanceToUpdate = _context.Attendances.SingleOrDefault(i => i.Id == attendance.Id);

            if (attendanceToUpdate == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            attendanceToUpdate.TimeOutDate = attendance.TimeOutDate;

            _context.SaveChanges();
            return Ok();
        }
        //POST /API/Attendances/GetAttendancesByDate
        public IHttpActionResult GetAttendancesByDate(Attendance attendance)
        {
            var attendances = _context.Attendances.Include("Employee").Where(a => a.TimeInDate.Date == attendance.TimeInDate.Date).ToList();

            if (attendances == null)
                return NotFound();

            return Ok(attendances);
        }

    }
}