﻿using BoozewasherApp_Web.Models.ContextModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ViewModels.Employees
{
    public class EmployeeFormViewModel
    {
        public IEnumerable<Branch> Branches { get; set; }
        public Employee Employee { get; set; }
    }
}