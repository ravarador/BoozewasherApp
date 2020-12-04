using BoozewasherApp.Context;
using BoozewasherApp.Models.ContextModels;
using BoozewasherApp.Properties;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Queries.ServiceQueries
{
    public class DeleteServiceQuery
    {
        public void DeleteService(int id)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/services/" + id, Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
        }

    }
}
