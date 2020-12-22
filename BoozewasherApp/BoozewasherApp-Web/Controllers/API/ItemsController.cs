using AutoMapper;
using BoozewasherApp_Web.Interfaces;
using BoozewasherApp_Web.Models;
using BoozewasherApp_Web.Models.ContextModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace BoozewasherApp_Web.Controllers.API
{
    public class ItemsController : ApiController
    {
        private IDatabaseContext _context;

        public ItemsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /API/Items

        public List<Item> GetItems()
        {
            return _context.Items.ToList();
        }

        //GET /API/Items/1
        public IHttpActionResult GetItem(int id)
        {
            var item = _context.Items.SingleOrDefault(s => s.Id == id);

            if (item == null)
                return NotFound();

            return Ok(item);
        }

        //POST /API/Items
        [HttpPost]
        public IHttpActionResult CreateItem(Item item)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.Items.Add(item);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + item.Id), item);
        }

        //PUT /API/Items/1
        [HttpPut]
        public void UpdateItem(Item item)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var itemInDb = _context.Items.SingleOrDefault(s => s.Id == item.Id);

            if (itemInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.SaveChanges();
        }

        //DELETE /API/Item/1
        public void DeleteItem(int id)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var itemInDb = _context.Items.SingleOrDefault(s => s.Id == id);

            if (itemInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Items.Remove(itemInDb);
            _context.SaveChanges();
        }
    }
}