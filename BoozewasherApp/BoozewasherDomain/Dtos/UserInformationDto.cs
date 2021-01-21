using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherDomain.Dtos
{
    public class UserInformationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BranchId { get; set; }
    }
}
