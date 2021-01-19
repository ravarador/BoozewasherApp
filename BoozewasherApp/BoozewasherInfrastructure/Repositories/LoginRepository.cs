using BoozewasherDomain.Dtos;
using BoozewasherInfrastructure.Properties;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherInfrastructure.Repositories
{
    public class LoginRepository
    {
        public string AuthenticateLogin(LoginDto login)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/Account/LoginFromApp/", Method.POST);
            request.AddJsonBody(login);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
            return response.Content;
        }
    }
}
