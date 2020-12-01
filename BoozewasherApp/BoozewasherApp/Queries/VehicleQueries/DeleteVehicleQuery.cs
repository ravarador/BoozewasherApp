using BoozewasherApp.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Queries.VehicleQueries
{
    public class DeleteVehicleQuery
    {
        private DatabaseContext context = new DatabaseContext();
        public void DeleteVehicle(int id)
        {
            var vehicleToDelete = context.Vehicles.Where(a => a.Id == id).FirstOrDefault();
            if (vehicleToDelete != null)
            {
                context.Vehicles.Remove(vehicleToDelete);
                context.SaveChanges();
            }
        }
    }
}
