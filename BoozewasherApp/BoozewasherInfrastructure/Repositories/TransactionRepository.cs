
using BoozewasherDomain.Dtos;
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
    public class TransactionRepository : ITransactionRepository
    {
        public void AddTransaction(Transaction transaction)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/transactions/createtransaction/", Method.POST);
            request.AddJsonBody(transaction);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
        }

        public void DeleteTransaction(int id)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/transactions/deletetransaction/" + id, Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
        }

        public List<TransactionDto> GetAllTransactions()
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/transactions/gettransactions/", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            var dataList = JsonConvert.DeserializeObject<List<Transaction>>(response.Content);

            return dataList.Select(a => new TransactionDto { Id = a.Id, 
                                                             DateTime = a.DateTime, 
                                                             ServiceId = a.ServiceId, 
                                                             ServiceType = a.Service.Type, 
                                                             ServiceExpense = a.Service.Expense.Value,
                                                             VehicleId = a.VehicleId, 
                                                             VehicleType = a.Vehicle.Type, 
                                                             VehicleBrand = a.Vehicle.Brand,
                                                             VehicleModel = a.Vehicle.Model,
                                                             PlateNumber = a.PlateNumber, 
                                                             Cost = a.Cost, 
                                                             ItemsList = a.ItemsList, 
                                                             BranchName = a.Branch.Name }).ToList();
        }

        public List<TransactionDto> GetTransactionsByBranchId(int id)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/transactions/GetTransactionsByBranchId/" + id, Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            var dataList = JsonConvert.DeserializeObject<List<Transaction>>(response.Content);

            return dataList.Select(a => new TransactionDto
            {
                Id = a.Id,
                DateTime = a.DateTime,
                ServiceId = a.ServiceId,
                ServiceType = a.Service.Type,
                ServiceExpense = a.Service.Expense.Value,
                VehicleId = a.VehicleId,
                VehicleType = a.Vehicle.Type,
                VehicleBrand = a.Vehicle.Brand,
                VehicleModel = a.Vehicle.Model,
                PlateNumber = a.PlateNumber,
                Cost = a.Cost,
                ItemsList = a.ItemsList,
                BranchName = a.Branch.Name
            }).ToList();
        }

        public List<Transaction> GetTransactionsByDateRange(SummaryDateAndDateRangeDto dateAndDateRangeDto)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/transactions/gettransactionsbydaterange/", Method.POST);
            var jsonObj = JsonConvert.SerializeObject(dateAndDateRangeDto);
            request.AddJsonBody(jsonObj);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            var dataList = JsonConvert.DeserializeObject<List<Transaction>>(response.Content);

            return dataList;
        }

        public List<Transaction> GetTransactionsByDate(SummaryDateAndDateRangeDto dateAndDateRangeDto)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/transactions/gettransactionsbydate/", Method.POST);
            var jsonObj = JsonConvert.SerializeObject(dateAndDateRangeDto);
            request.AddJsonBody(jsonObj);
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
            var request = new RestRequest("/api/transactions/updatetransaction/" + transaction.Id, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(transaction);
            var response = client.Execute(request);

        }
    }
}
