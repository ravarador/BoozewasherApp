using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Models.Dtos
{
    public class AuthenticationMessageDto
    {
        public bool IsAuthenticated { get; set; }
        public string ResponseMessage { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}