using AutoMapper;
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

        public IHttpActionResult GetItems()
        {
            var itemsDto = _context.Items.Include("Branch")
                                         .ToList()
                                         .Select(Mapper.Map<Item, ItemDto>);

            return Ok(itemsDto);
        }

        //GET /API/Items/GetItem
        public IHttpActionResult GetItem(int id)
        {
            var item = _context.Items.Include("Branch").SingleOrDefault(s => s.Id == id);

            if (item == null)
                return NotFound();

            return Ok(Mapper.Map<Item, ItemDto>(item));
        }
        //GET /API/Items/GetItemsByBranchId
        public IHttpActionResult GetItemsByBranchId(int id)
        {
            var itemsDto = _context.Items.Include("Branch")
                                         .Where(a => a.BranchId == id)
                                         .ToList()
                                         .Select(Mapper.Map<Item, ItemDto>);

            return Ok(itemsDto);
        }
        //POST /API/Items/CreateItem
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
        public IHttpActionResult GetItemsBySearchParameter(SearchDto searchDto)
        {
            var items = _context.Items.Include("Branch")
                                         .Where(a => a.BranchId == searchDto.BranchId);

            switch(searchDto.SearchBy.ToUpper().Trim())
            {
                case "ID":
                    items = items.Where(a => a.Id == int.Parse(searchDto.SearchText));
                    break;
                case "NAME":
                    items = items.Where(a => a.Name.Contains(searchDto.SearchText));
                    break;
                case "DESCRIPTION": 
                    items = items.Where(a => a.Description.Contains(searchDto.SearchText));
                    break;
                case "BARCODE": 
                    items = items.Where(a => a.Barcode.Contains(searchDto.SearchText));
                    break;
                case "USAGECOUNT":
                    items = items.Where(a => a.UsageCount == int.Parse(searchDto.SearchText));
                    break;
                case "EXPENSE":
                    items = items.Where(a => a.Expense == decimal.Parse(searchDto.SearchText));
                    break;
                case "BRANCHNAME":
                    items = items.Where(a => a.Branch.Name.Contains(searchDto.SearchText));
                    break;
                default:
                    break;

            }
                                         //.ToList()
                                         //.Select(Mapper.Map<Item, ItemDto>);

            return Ok(items.ToList());
        }
    }
}
