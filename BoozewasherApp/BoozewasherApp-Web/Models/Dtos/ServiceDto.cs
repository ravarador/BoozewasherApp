using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Dtos
{
    public class ServiceDto
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal? Expense { get; set; }
    }
}