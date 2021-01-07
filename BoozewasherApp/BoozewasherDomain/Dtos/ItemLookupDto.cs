using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherDomain.Dtos
{
    public class ItemLookupDto
    {
        public string Name { get; set; }
        public int UsageCount { get; set; }
        public decimal Expense { get; set; }
    }
}
