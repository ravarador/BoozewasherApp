using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Models.ContextModels
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
