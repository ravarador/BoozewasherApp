using BoozewasherApp.Context;
using BoozewasherApp.Models.ContextModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Queries.ServiceQueries
{
    public class AddServiceQuery
    {
        private DatabaseContext context = new DatabaseContext();

        public void AddService(Service service)
        {
            context.Services.Add(service);
            context.SaveChanges();
        }
    }
}
