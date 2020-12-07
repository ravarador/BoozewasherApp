using BoozewasherApp.IRepositories;
using BoozewasherApp.Models.ContextModels;
using BoozewasherApp.Properties;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        public void AddService(Service service)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/services/createservice/", Method.POST);
            request.AddJsonBody(service);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
        }

        public void DeleteService(int id)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/services/deleteservice/" + id, Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
        }

        public List<Service> GetAllServices()
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/services/getservices/", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            var dataList = JsonConvert.DeserializeObject<List<Service>>(response.Content);

            return dataList;
        }

        //public Service GetServiceById(int id)
        //{
        //    var serviceById = context.Services.Where(a => a.Id == id).FirstOrDefault();

        //    return serviceById;
        //}

        public void UpdateService(Service service)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/services/updateservice/" + service.Id, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(service);
            var response = client.Execute(request);

        }
    }
}
