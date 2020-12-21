using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ViewModels.Items
{
    public class ItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Barcode { get; set; }
        public bool IsEmpty { get; set; }
        public int UsageCount { get; set; }
        public decimal Expense { get; set; }
    }
}