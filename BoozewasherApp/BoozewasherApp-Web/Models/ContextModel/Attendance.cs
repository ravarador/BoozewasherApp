using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ContextModel
{
    public class Attendance
    {
        public int Id { get; set; }
        public DateTime TimeInDate { get; set; }
        public DateTime? TimeOutDate { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}