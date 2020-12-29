using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherDomain.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string PlateNumber { get; set; }

        public Service Service { get; set; }
        public int ServiceId { get; set; }

        public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }

        public decimal Cost { get; set; }
        public string ItemsList { get; set; }
    }
}
