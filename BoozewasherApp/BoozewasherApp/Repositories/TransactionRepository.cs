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
    public class TransactionRepository : ITransactionRepository
    {
        public void AddTransaction(Transaction transaction)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/transactions/", Method.POST);
            request.AddJsonBody(transaction);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
        }

        public void DeleteTransaction(int id)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/transactions/" + id, Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
        }

        public List<Transaction> GetAllTransactions()
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/transactions/", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            var dataList = JsonConvert.DeserializeObject<List<Transaction>>(response.Content);

            return dataList;
        }

        //public Service GetServiceById(int id)
        //{
        //    var serviceById = context.Services.Where(a => a.Id == id).FirstOrDefault();

        //    return serviceById;
        //}

        public void UpdateTransaction(Transaction transaction)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/transactions/" + transaction.Id, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(transaction);
            var response = client.Execute(request);

        }
    }
}
