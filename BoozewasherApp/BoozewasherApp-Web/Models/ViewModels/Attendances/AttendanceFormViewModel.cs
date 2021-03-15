using BoozewasherApp_Web.Models.ContextModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ViewModels.Attendances
{
    public class AttendanceFormViewModel
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