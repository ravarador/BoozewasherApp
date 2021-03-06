﻿using BoozewasherApp_Web.Models.ContextModel;
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
        //public IEnumerable<Item> Items { get; set; }
        public IEnumerable<Branch> Branches { get; set; }
       
        public int Id { get; set; }
        public DateTime DateTime { get; set; }


        [Required]
        [Display(Name = "Plate Number")]
        public string PlateNumber { get; set; }

        [Display(Name = "Service Type")]
        public int ServiceId { get; set; }

        [Display (Name = "Vehicle ID")]
        public int VehicleId { get; set; }

        public decimal Cost { get; set; }

        [Display(Name = "Item ID")]
        public string ItemsList { get; set; }

        [Display (Name = "Branch Name")]
        public int BranchId { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Transaction" : "New Transaction";
            }
        }

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
            ItemsList = transaction.ItemsList;
            Cost = transaction.Cost;
            BranchId = transaction.BranchId;
            
        }
    }
   
}