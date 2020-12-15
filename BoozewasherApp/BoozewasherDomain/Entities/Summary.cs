using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherDomain.Entities
{
    public class Summary
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public decimal CostTotal { get; set; }
        public decimal ExpenseTotal { get; set; }
        public int CarwashCountTotal { get; set; }
        public int DetailingCountTotal { get; set; }
        public int PaintJobCountTotal { get; set; }
        public int BackToZeroCountTotal { get; set; }

    }
}
