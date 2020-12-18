using BoozewasherDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherDomain.Dtos
{
    public class SummaryDto
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string ServiceType { get; set; }
        public decimal Expense { get; set; }
        public string VehicleType { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string PlateNumber { get; set; }
        public decimal Cost { get; set; }

        //SUMMARY COUNT
        public int CarwashCount { get; set; }
        public int DetailingCount { get; set; }
        public int PaintjobCount { get; set; }
        public int BackToZeroCount { get; set; }
        public int OverallTotalCount { get; set; }

        //SUMMARY COST
        public decimal CarwashTotalCost { get; set; }
        public decimal DetailingTotalCost { get; set; }
        public decimal PaintjobTotalCost { get; set; }
        public decimal BackToZeroTotalCost { get; set; }
        public decimal OverallTotalCost { get; set; }

        //SUMMARY EXPENSE
        public decimal CarwashTotalExpense { get; set; }
        public decimal DetailingTotalExpense { get; set; }
        public decimal PaintjobTotalExpense { get; set; }
        public decimal BackToZeroTotalExpense { get; set; }
        public decimal OverallTotalExpense { get; set; }


        public decimal GrossProfit { get; set; }
        public decimal NetProfit { get; set; }

        public List<Item> ItemsList { get; set; }

    }
}
