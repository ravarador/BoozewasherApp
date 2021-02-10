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
    public class AttendanceRepository : IAttendanceRepository
    {
        public void TimeInEmployee(Attendance attendance)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/attendances/timeinemployee/", Method.POST);
            request.AddJsonBody(attendance);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
        }
        public void TimeOutEmployee(Attendance attendance)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/attendances/timeoutemployee/", Method.POST);
            request.AddJsonBody(attendance);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
        }

        public List<Attendance> GetAttendancesByDate()
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/attendances/getattendancesbydate/", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            var dataList = JsonConvert.DeserializeObject<List<Attendance>>(response.Content);

            return dataList;
        }
    }
}
