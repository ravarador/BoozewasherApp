﻿using BoozewasherApp_Web.Models.ContextModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ViewModels.Transactions
{
    public class TransactionViewModel
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string PlateNumber { get; set; }

        public Service Service { get; set; }
        public int ServiceId { get; set; }

        public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }
        public Branch Branch { get; set; }
        public int BranchId { get; set; }

        public decimal Cost { get; set; }
    }
}