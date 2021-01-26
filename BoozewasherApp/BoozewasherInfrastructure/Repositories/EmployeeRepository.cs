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
    public class EmployeeRepository : IEmployeeRepository
    {
        public void AddEmployee(Employee employee)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/employees/createemployee/", Method.POST);
            request.AddJsonBody(employee);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
        }

        public void DeleteEmployee(int id)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/employees/deleteemployee/" + id, Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
        }

        public List<Employee> GetAllEmployees()
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/employees/getemployees/", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            var dataList = JsonConvert.DeserializeObject<List<Employee>>(response.Content);

            return dataList.ToList();
        }

        public List<Employee> GetEmployeesByBranchId(int id)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/employees/getemployeesbybranchid/" + id, Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            var dataList = JsonConvert.DeserializeObject<List<Employee>>(response.Content);

            return dataList.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/employees/getemployee/" + id, Method.GET);

            var response = client.Execute(request);

            var data = JsonConvert.DeserializeObject<Employee>(response.Content);

            return data;
        }

        public void UpdateItem(Employee employee)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/employees/updateemployee/" + employee.Id, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(employee);
            var response = client.Execute(request);

        }
    }
}
