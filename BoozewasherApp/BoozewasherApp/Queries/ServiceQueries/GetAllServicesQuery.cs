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
    public class GetAllServicesQuery
    {
        public List<Service> GetAllServices()
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/services/", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            var dataList = JsonConvert.DeserializeObject<List<Service>>(response.Content);

            return dataList;
        }


    }
}
