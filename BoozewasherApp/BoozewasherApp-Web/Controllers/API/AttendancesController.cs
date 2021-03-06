﻿using BoozewasherApp_Web.Models;
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
        //PUT /API/Attendances/TimeOutEmployee
        [HttpPut]
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
        //GET /API/Attendances/GetAttendancesByDate
        [HttpGet]
        public IHttpActionResult GetAttendancesByDate()
        {

            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var attendances = _context.Attendances.Include("Employee").Where(a => a.TimeInDate.Year == DateTime.Now.Year &&
                                                                                  a.TimeInDate.Month == DateTime.Now.Month &&
                                                                                  a.TimeInDate.Day == DateTime.Now.Day).ToList();

            return Ok(attendances);
        }

    }
}