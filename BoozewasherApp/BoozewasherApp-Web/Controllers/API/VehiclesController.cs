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
    public class VehiclesController : ApiController
    {
        private ApplicationDbContext _context;
        public VehiclesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /API/Vehicles
        public IEnumerable<VehicleDto> GetVehicles()
        {
            return _context.Vehicles.ToList().Select(Mapper.Map<Vehicle, VehicleDto>);
        }

        //GET /API/Vehicles/1
        public IHttpActionResult GetVehicle(int id)
        {
            var vehicle = _context.Vehicles.SingleOrDefault(v => v.Id == id);

            if (vehicle == null)
                return NotFound();

            return Ok(Mapper.Map<Vehicle, VehicleDto>(vehicle));
        }

        //POST /API/Vehicles
        [HttpPost]
        public IHttpActionResult CreateVehicle(VehicleDto vehicleDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var vehicle = Mapper.Map<VehicleDto, Vehicle>(vehicleDto);
            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();

            vehicleDto.Id = vehicle.Id;

            return Created(new Uri(Request.RequestUri + "/" + vehicle.Id), vehicleDto);
        }

        //PUT /API/Vehicles/1
        [HttpPut]
        public void UpdateVehicle(VehicleDto vehicleDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var vehicleInDb = _context.Vehicles.Single(v => v.Id == vehicleDto.Id);

            if (vehicleInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(vehicleDto, vehicleInDb);

            _context.SaveChanges();
             
        }

        //DELETE /API/Vehicles/1
        [HttpDelete]
        public void DeleteVehicle(int id)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var vehicleInDb = _context.Vehicles.SingleOrDefault(v => v.Id == id);

            if (vehicleInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Vehicles.Remove(vehicleInDb);
            _context.SaveChanges();
        }
    }
}
