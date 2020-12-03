using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.View_Models.Vehicles
{
    public class VehicleViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}