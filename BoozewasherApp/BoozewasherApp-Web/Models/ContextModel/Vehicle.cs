using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ContextModel
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Display(Name = "Vehicle Type")]
        [Required]
        [StringLength(255)]
        public string Type { get; set; }

        public string Description { get; set; }

        [Display(Name = "Vehicle Brand")]
        [Required]
        public string Brand { get; set; }

        [Required]
        [Display(Name = "Vehicle Model")]
        public string Model { get; set; }

    }
}