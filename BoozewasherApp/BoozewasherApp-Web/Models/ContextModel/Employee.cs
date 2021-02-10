using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.ContextModel
{
    public class Employee
    {

        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [Required]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Required]
        public string  Address { get; set; }

        [Display(Name = "Date of Birth")]
        [Required]
        public string Birthdate { get; set; }

        public string TIN { get; set; }

        [Required]
        public string Email { get; set; }

        [Display(Name = "Contact Number")]
        [Required]
        public string ContactNo { get; set; }
        public Branch Branch { get; set; }

        [Display(Name = "Branch Name")]
        [Required]
        public int BranchId { get; set; }
    }
}