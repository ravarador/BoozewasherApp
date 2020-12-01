using BoozewasherApp.Context;
using BoozewasherApp.Models.ContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Queries.VehicleQueries
{
    public class GetVehicleByIdQuery
    {
        private DatabaseContext context = new DatabaseContext();

        public Vehicle GetVehicleById(int id)
        {
            var vehicleById = context.Vehicles.Where(a => a.Id == id).FirstOrDefault();

            return vehicleById;
        }
    }
}
