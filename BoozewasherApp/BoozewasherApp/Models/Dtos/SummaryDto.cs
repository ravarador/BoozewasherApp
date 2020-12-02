using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Models.Dtos
{
    public class SummaryDto
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string ServiceType { get; set; }
        public decimal Expense { get; set; }
        public string VehicleType { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string PlateNumber { get; set; }
        public decimal Cost { get; set; }
    }
}
