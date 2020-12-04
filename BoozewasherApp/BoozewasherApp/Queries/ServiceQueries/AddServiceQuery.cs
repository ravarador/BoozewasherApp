using BoozewasherApp.Context;
using BoozewasherApp.Models.ContextModels;
using BoozewasherApp.Properties;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Queries.ServiceQueries
{
    public class AddServiceQuery
    {
        public void AddService(Service service)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/services/", Method.POST);
            request.AddJsonBody(service);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
        }
    }
}
