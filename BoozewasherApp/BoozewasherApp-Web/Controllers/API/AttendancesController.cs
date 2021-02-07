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
        public IHttpActionResult TimeOutEmployee(int Id, DateTime TimeOutTime)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var attendanceToUpdate = _context.Attendances.SingleOrDefault(i => i.Id == Id);

            if (attendanceToUpdate == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            attendanceToUpdate.TimeOutDate = TimeOutTime;

            _context.SaveChanges();
            return Ok();
        }
        //GET /API/Attendances/GetAttendancesByDate
        public IHttpActionResult GetAttendancesByDate(DateTime dateToday)
        {
            var attendances = _context.Attendances.Include("Employee").Where(a => a.TimeInDate.Date == dateToday.Date).ToList();

            if (attendances == null)
                return NotFound();

            return Ok(attendances);
        }

        ////GET /API/Attendances

        //public IHttpActionResult GetAttendances()
        //{
        //    var attendances = _context.Attendances.Include("Employee").ToList();

        //    return Ok(attendances);
        //}

        ////GET /API/Attendances/GetAttendance
        //public IHttpActionResult GetAttendance(int id)
        //{
        //    var attendance = _context.Attendances.Include("Employee").SingleOrDefault(s => s.Id == id);

        //    if (attendance == null)
        //        return NotFound();

        //    return Ok(attendance);
        //}
        ////GET /API/Items/GetAttendanceByBranchId
        //public IHttpActionResult GetItemsByBranchId(int id)
        //{
        //    var itemsDto = _context.Items.Include("Branch")
        //                                 .Where(a => a.BranchId == id)
        //                                 .ToList()
        //                                 .Select(Mapper.Map<Item, ItemDto>);

        //    return Ok(itemsDto);
        //}
        ////POST /API/Items/CreateItem
        //[HttpPost]
        //public IHttpActionResult CreateItem(ItemDto itemDto)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest();

        //    var item = Mapper.Map<ItemDto, Item>(itemDto);
        //    _context.Items.Add(item);
        //    _context.SaveChanges();

        //    itemDto.Id = item.Id;

        //    return Created(new Uri(Request.RequestUri + "/" + item.Id), itemDto);
        //}

        ////PUT /API/Items/1
        //[HttpPut]
        //public void UpdateItem(ItemDto itemDto)
        //{
        //    if (!ModelState.IsValid)
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);

        //    var itemInDb = _context.Items.SingleOrDefault(i => i.Id == itemDto.Id);

        //    if (itemInDb == null)
        //        throw new HttpResponseException(HttpStatusCode.NotFound);

        //    Mapper.Map(itemDto, itemInDb);

        //    _context.SaveChanges();
        //}

        ////DELETE /API/Items/1
        //public void DeleteItem(int id)
        //{
        //    if (!ModelState.IsValid)
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);

        //    var itemInDb = _context.Items.SingleOrDefault(i => i.Id == id);

        //    if (itemInDb == null)
        //        throw new HttpResponseException(HttpStatusCode.NotFound);

        //    _context.Items.Remove(itemInDb);
        //    _context.SaveChanges();
        //}
        ////POST /API/Items/GetItemsBySearchParameter
        //[HttpPost]
        //public IHttpActionResult GetItemsBySearchParameter(SearchDto searchDto)
        //{
        //    if (!ModelState.IsValid)
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);

        //    var items = _context.Items.Include("Branch")
        //                                 .Where(a => a.BranchId == searchDto.BranchId);

        //    switch (searchDto.SearchBy.ToUpper().Trim())
        //    {
        //        case "NAME":
        //            items = items.Where(a => a.Name.Contains(searchDto.SearchText));
        //            break;
        //        case "DESCRIPTION":
        //            items = items.Where(a => a.Description.Contains(searchDto.SearchText));
        //            break;
        //        case "BARCODE":
        //            items = items.Where(a => a.Barcode.Contains(searchDto.SearchText));
        //            break;
        //        case "BRANCHNAME":
        //            items = items.Where(a => a.Branch.Name.Contains(searchDto.SearchText));
        //            break;
        //        default:
        //            break;

        //    }
        //    //.ToList()
        //    //.Select(Mapper.Map<Item, ItemDto>);

        //    return Ok(items.ToList().Select(Mapper.Map<Item, ItemDto>));
        //}
    }
}