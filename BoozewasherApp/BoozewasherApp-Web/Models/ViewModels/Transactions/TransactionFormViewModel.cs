using BoozewasherApp_Web.Models.ContextModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ViewModels.Transactions
{
    public class TransactionFormViewModel
    {
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Vehicle> Vehicles { get; set; }
       
        public int Id { get; set; }
        public DateTime DateTime { get; set; }

        [Display(Name = "Plate Number")]
        public string PlateNumber { get; set; }

        [Display(Name = "Service Type")]
        public int ServiceId { get; set; }

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