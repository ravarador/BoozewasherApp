using AutoMapper;
using BoozewasherApp_Web.Dtos;
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
using System.Web.ModelBinding;

namespace BoozewasherApp_Web.Controllers.API
{
    public class ServicesController : ApiController
    {
        private IDatabaseContext _context;

        public ServicesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /API/Services

        public IHttpActionResult GetServices()
        {
            var servicesDto = _context.Services.ToList()
                                               .Select(Mapper.Map<Service, ServiceDto>);
            return Ok(servicesDto);
        } 

        //GET /API/Services/1
        public IHttpActionResult GetService(int id)
        {
            var service = _context.Services.SingleOrDefault(s => s.Id == id);

            if (service == null)
                return NotFound();

            return Ok(Mapper.Map<Service, ServiceDto>(service));
        }

        //POST /API/Services
        [HttpPost]
        public IHttpActionResult CreateService(ServiceDto serviceDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var service = Mapper.Map<ServiceDto, Service>(serviceDto);
            _context.Services.Add(service);
            _context.SaveChanges();

            serviceDto.Id = service.Id;

            return Created(new Uri(Request.RequestUri + "/" + service.Id), serviceDto);
        }

        //PUT /API/Services/1
        [HttpPut]
        public void UpdateService(ServiceDto serviceDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var serviceInDb = _context.Services.SingleOrDefault(s => s.Id == serviceDto.Id);

            if (serviceInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(serviceDto, serviceInDb);

            _context.SaveChanges();
        }

        //DELETE /API/Services/1
        public void DeleteService (int id)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var serviceInDb = _context.Services.SingleOrDefault(s => s.Id == id);

            if (serviceInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Services.Remove(serviceInDb);
            _context.SaveChanges();
        }

        //POST /API/Services/GetServicesBySearchParameter
        [HttpPost]
        public IHttpActionResult GetServicesBySearchParameter(SearchDto searchDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var services = _context.Services.AsEnumerable();

            switch (searchDto.SearchBy.ToUpper().Trim())
            {
                case "TYPE":
                    services = services.Where(a => a.Type.Contains(searchDto.SearchText));
                    break;
                case "DESCRIPTION":
                    services = services.Where(a => a.Description.Contains(searchDto.SearchText));
                    break;
                default:
                    break;

            }
            //.ToList()
            //.Select(Mapper.Map<Item, ItemDto>);

            return Ok(services.ToList().Select(Mapper.Map<Service, ServiceDto>));
        }
    }
}
