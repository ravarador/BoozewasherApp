using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherDomain.Dtos
{
    public class SearchDto
    {
        public string SearchBy { get; set; }
        public string SearchText { get; set; }
        public int BranchId { get; set; }
    }
}
