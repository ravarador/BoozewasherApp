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
        public Service Service { get; set; }

        
        public string Title
        {
            get
            {
                return Service.Id != 0 ? "Edit Service" : "New Service";
            }
        }
       
        
    }
}