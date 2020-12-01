using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ContextModel
{
    public class Service
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal? Expense { get; set; }
    }
}