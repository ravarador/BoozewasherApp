using BoozewasherApp.Context;
using BoozewasherApp.Models.ContextModels;
using BoozewasherApp.Properties;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Queries.ServiceQueries
{
    public class UpdateServiceQuery
    {

        public void UpdateService(Service service)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/services/" + service.Id, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(service);
            var response = client.Execute(request);

        }
    }
}
