using BoozewasherApp_Web.Models.ContextModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ViewModels.Vehicles
{
    public class VehicleFormViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Vehicle Type")]
        public string Type { get; set; }
        public string Description { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
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