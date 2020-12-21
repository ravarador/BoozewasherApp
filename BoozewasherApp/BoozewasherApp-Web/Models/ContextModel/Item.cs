using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ContextModel
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        [Display(Name = "Item Barcode")]
        public string Barcode { get; set; }
        public bool IsEmpty { get; set; }

        [Required]
        [Display (Name = "Usage Count")]
        public int UsageCount { get; set; }
        [Required]
        public decimal Expense { get; set; }
    }
}