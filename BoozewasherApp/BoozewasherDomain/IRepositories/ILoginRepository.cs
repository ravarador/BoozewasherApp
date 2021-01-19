using BoozewasherDomain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherDomain.IRepositories
{
    public interface ILoginRepository
    {
        string AuthenticateLogin(LoginDto login);
    }
}
