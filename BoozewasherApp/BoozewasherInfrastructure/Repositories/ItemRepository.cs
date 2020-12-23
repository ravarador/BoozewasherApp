using BoozewasherDomain.Entities;
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
    public class ItemRepository : IItemRepository
    {
        public void AddItem(Item item)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/items/createitem/", Method.POST);
            request.AddJsonBody(item);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
        }

        public void DeleteItem(int id)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/items/deleteitem/" + id, Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
        }

        public List<Item> GetAllItems()
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/items/getitems/", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            var dataList = JsonConvert.DeserializeObject<List<Item>>(response.Content);

            return dataList;
        }

        //public Service GetServiceById(int id)
        //{
        //    var serviceById = context.Services.Where(a => a.Id == id).FirstOrDefault();

        //    return serviceById;
        //}

        public void UpdateItem(Item item)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/items/updateitem/" + item.Id, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(item);
            var response = client.Execute(request);

        }
    }
}
