﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherDomain.Entities
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
