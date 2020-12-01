using BoozewasherApp.Context;
using BoozewasherApp.Models.ContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Queries.VehicleQueries
{
    public class UpdateVehicleQuery
    {
        private DatabaseContext context = new DatabaseContext();

        public void UpdateVehicle(Vehicle vehicle)
        {
            var vehicleToUpdate = context.Vehicles.Where(a => a.Id == vehicle.Id).FirstOrDefault();

            vehicleToUpdate.Type = vehicle.Type;
            vehicleToUpdate.Brand = vehicle.Brand;
            vehicleToUpdate.Model = vehicle.Model;
            vehicleToUpdate.Description = vehicle.Description;

            context.SaveChanges();
        }
    }
}
