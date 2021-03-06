﻿using BoozewasherApp_Web.Models.ContextModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.Dtos
{
    public class ItemDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public string Barcode { get; set; }
        public bool IsEmpty { get; set; }

        [Required]
        public int UsageCount { get; set; }
        [Required]
        public decimal Expense { get; set; }
        public Branch Branch { get; set; }
        public int BranchId { get; set; }
    }
}