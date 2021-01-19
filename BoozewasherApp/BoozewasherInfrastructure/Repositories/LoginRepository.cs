using BoozewasherDomain.Dtos;
using BoozewasherDomain.IRepositories;
using BoozewasherInfrastructure.Properties;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherInfrastructure.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        public AuthenticationMessageDto AuthenticateLogin(LoginDto login)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/Account/LoginFromApp/", Method.POST);
            request.AddJsonBody(login);
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<AuthenticationMessageDto>(response.Content);
            return result;
        }
    }
}
