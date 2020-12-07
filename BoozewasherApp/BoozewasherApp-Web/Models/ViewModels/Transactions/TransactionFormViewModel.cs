using BoozewasherApp_Web.Models.ContextModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ViewModels.Transactions
{
    public class TransactionFormViewModel
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string PlateNumber { get; set; }

        public Service Service { get; set; }
        public int ServiceId { get; set; }

        public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }

        public decimal Cost { get; set; }

        public TransactionFormViewModel()
        {
            Id = 0;
        }
        public TransactionFormViewModel(Transaction transaction)
        {
            DateTime = transaction.DateTime;
            PlateNumber = transaction.PlateNumber;
            ServiceId = transaction.ServiceId;
            VehicleId = transaction.VehicleId;
            Cost = transaction.Cost;
        }
    }
   
}