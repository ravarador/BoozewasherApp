using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ContextModel
{
    public class Attendance
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Time In")]
        public DateTime TimeInDate { get; set; }
        public DateTime? TimeOutDate { get; set; }
        public Employee Employee { get; set; }

        [Required]
        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }
    }
}