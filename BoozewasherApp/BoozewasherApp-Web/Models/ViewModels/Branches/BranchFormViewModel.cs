using BoozewasherApp_Web.Models.ContextModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ViewModels.Branches
{
    public class BranchFormViewModel
    {
        public Branch Branch { get; set; }
        public string Title
        {
            get
            {
                if (Branch != null && Branch.Id != 0)
                    return "Edit Branch";

                return "New Branch";
            }
        }
    }
}