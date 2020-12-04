using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BoozewasherApp_Web.Models.ContextModel;

namespace BoozewasherApp_Web.View_Models.Vehicles
{
    public class VehicleFormViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Vehicle" : "New Vehicle";
            }
        }

        public VehicleFormViewModel()
        {
            Id = 0;
        }
        public VehicleFormViewModel(Vehicle vehicle)
        {
            Type = vehicle.Type;
            Description = vehicle.Description;
            Brand = vehicle.Brand;
            Model = vehicle.Model;
        }
    }
}