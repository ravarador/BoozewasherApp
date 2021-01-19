using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherDomain.Dtos
{
    public class AuthenticationMessageDto
    {
        public bool IsAuthenticated { get; set; }
        public string ResponseMessage { get; set; }
    }
}
