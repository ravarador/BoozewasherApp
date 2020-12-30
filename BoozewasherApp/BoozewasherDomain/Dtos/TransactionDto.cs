using BoozewasherDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherDomain.Dtos
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string PlateNumber { get; set; }
        public string ServiceType { get; set; }
        public string VehicleType { get; set; }
        public int ServiceId { get; set; }
        public int VehicleId { get; set; }

        public decimal Cost { get; set; }
        public string ItemsList { get; set; }
    }
}
