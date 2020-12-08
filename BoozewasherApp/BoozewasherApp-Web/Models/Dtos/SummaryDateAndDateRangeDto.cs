using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.Dtos
{
    public class SummaryDateAndDateRangeDto
    {
        public DateTime DateTimeFrom { get; set; }
        public DateTime DateTimeTo { get; set; }
        public DateTime DateTime { get; set; }
    }
}