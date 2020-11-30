using BoozewasherApp.Context;
using BoozewasherApp.Models.ContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Queries.ServiceQueries
{
    public class GetAllServiceQuery
    {
        private DatabaseContext context = new DatabaseContext();
        public List<Service> GetAllService()
        {
            var service = context.Services.ToList();

            return service;
        }
    }
}
