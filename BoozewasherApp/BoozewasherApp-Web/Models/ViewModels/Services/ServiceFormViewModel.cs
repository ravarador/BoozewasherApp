using BoozewasherApp_Web.Models.ContextModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ViewModels.Services
{
    public class ServiceFormViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Service Type")]
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal? Expense { get; set; }

        public string Title
        {
            get
            {
                return Id == 0 ? "New Service" : "Edit Service";
            }
        }
        public ServiceFormViewModel()
        {
            Id = 0;
        }
        public ServiceFormViewModel(Service service)
        {
            Type = service.Type;
            Description = service.Description;
            Expense = service.Expense;
        }
    }
}