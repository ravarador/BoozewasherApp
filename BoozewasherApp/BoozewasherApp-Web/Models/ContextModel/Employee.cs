﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ContextModel
{
    public class Employee
    {

        public int Id { get; set; }

        [Display (Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string  Address { get; set; }

        [Display(Name = "Date of Birth")]
        public string Birthdate { get; set; }
        public string TIN { get; set; }
        public string Email { get; set; }

        [Display(Name = "Contact Number")]
        public string ContactNo { get; set; }
        public Branch Branch { get; set; }

        [Display(Name = "Branch ID")]
        public int BranchId { get; set; }
    }
}