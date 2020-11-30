using BoozewasherApp.Context;
using BoozewasherApp.Models.ContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Queries.ServiceQueries
{
    public class GetServiceByIdQuery
    {
        private DatabaseContext context = new DatabaseContext();

        public Service GetServiceById(int id)
        {
            var serviceById = context.Services.Where(a => a.Id == id).FirstOrDefault();

            return serviceById;
        }
    }
}
