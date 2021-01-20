using BoozewasherApp_Web.Models.ContextModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ViewModels.Items
{
    public class ItemsFormViewModel
    {
        public IEnumerable <Branch> Branches { get; set; }

        public Item Item { get; set; }
    }
}