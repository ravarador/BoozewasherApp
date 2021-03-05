using BoozewasherApp_Web.Models.ContextModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ViewModels.Attendances
{
    public class AttendanceViewModel
    {
        public int Id { get; set; }
        public DateTime TimeInDate { get; set; }
        public DateTime? TimeOutDate { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
