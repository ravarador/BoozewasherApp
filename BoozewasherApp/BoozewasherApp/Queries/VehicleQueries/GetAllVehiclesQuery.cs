using BoozewasherApp.Context;
using BoozewasherApp.Models.ContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Queries.VehicleQueries
{
    public class GetAllVehiclesQuery
    {
        private DatabaseContext context = new DatabaseContext();
        public List<Vehicle> GetAllVehicles()
        {
            var vehicles = context.Vehicles.ToList();

            return vehicles;
        }
    }
}
