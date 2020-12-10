using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.Dtos
{
    public class VehicleDto
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }
        public string Description { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
    }
}