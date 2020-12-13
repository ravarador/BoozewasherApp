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
        public Vehicle Vehicle { get; set; }


        public string Title
        {
            get
            {
                if (Vehicle != null && Vehicle.Id != 0)
                    return "Edit Vehicle";

                return "New Vehicle";
            }
        }

       
    }
}