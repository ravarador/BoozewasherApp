using BoozewasherApp_Web.Models.ContextModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.Dtos
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string PlateNumber { get; set; }
        public int ServiceId { get; set; }
        public int VehicleId { get; set; }

        public decimal Cost { get; set; }
        
    }
}