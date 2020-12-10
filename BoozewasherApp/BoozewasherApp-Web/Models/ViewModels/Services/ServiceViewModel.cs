using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ViewModels.Services
{
    public class ServiceViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal? Expense { get; set; }
    }
}