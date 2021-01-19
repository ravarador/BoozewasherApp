using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ContextModel
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        [Display(Name = "Plate Number")]
        public string PlateNumber { get; set; }

        public Service Service { get; set; }
        public int ServiceId { get; set; }

        public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }

        [Required]
        public decimal Cost { get; set; }
        public string ItemsList { get; set; }
        public Branch Branch { get; set; }
        public int BranchId { get; set; }
    }
}