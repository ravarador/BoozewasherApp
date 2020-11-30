using BoozewasherApp.Context;
using BoozewasherApp.Models.ContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Queries.ServiceQueries
{
    public class UpdateServiceQuery
    {
        private DatabaseContext context = new DatabaseContext();

        public void UpdateService(Service service)
        {
            var serviceToUpdate = context.Services.Where(a => a.Id == service.Id).FirstOrDefault();

            serviceToUpdate.Type = service.Type;
            serviceToUpdate.Description = service.Description;
            serviceToUpdate.Expense = service.Expense;

            context.SaveChanges();
        }
    }
}
