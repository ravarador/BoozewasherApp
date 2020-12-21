﻿using AutoMapper;
using BoozewasherApp_Web.Interfaces;
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
    public class ItemsController : ApiController
    {
        private ApplicationDbContext _context;

        public ItemsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /API/Items

        public IEnumerable<ItemDto> GetItems()
        {
            return _context.Items.ToList()
                                  .Select(Mapper.Map<Item, ItemDto>);
        }

        //GET /API/Items/1
        public IHttpActionResult GetItem(int id)
        {
            var item = _context.Items.SingleOrDefault(s => s.Id == id);

            if (item == null)
                return NotFound();

            return Ok(Mapper.Map<Item, ItemDto>(item));
        }

        //POST /API/Items
        [HttpPost]
        public IHttpActionResult CreateItem(ItemDto itemDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var item = Mapper.Map<ItemDto, Item>(itemDto);
            _context.Items.Add(item);
            _context.SaveChanges();

            itemDto.Id = item.Id;

            return Created(new Uri(Request.RequestUri + "/" + item.Id), itemDto);
        }

        //PUT /API/Items/1
        [HttpPut]
        public void UpdateItem(ItemDto itemDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var itemInDb = _context.Items.SingleOrDefault(i => i.Id == itemDto.Id);

            if (itemInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(itemDto, itemInDb);

            _context.SaveChanges();
        }

        //DELETE /API/Items/1
        public void DeleteItem(int id)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var itemInDb = _context.Items.SingleOrDefault(i => i.Id == id);

            if (itemInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Items.Remove(itemInDb);
            _context.SaveChanges();
        }
    }
}
