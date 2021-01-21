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
    public class BranchRepository : IBranchRepository
    {
        public List<Branch> GetAllBranches()
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/branch/getbranches/", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            var dataList = JsonConvert.DeserializeObject<List<Branch>>(response.Content);

            return dataList.ToList();
        }
    }
}
