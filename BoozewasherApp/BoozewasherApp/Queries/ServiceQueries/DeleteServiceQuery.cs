using BoozewasherApp.Context;
using BoozewasherApp.Models.ContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Queries.ServiceQueries
{
    public class DeleteServiceQuery
    {
        private DatabaseContext context = new DatabaseContext();

        public void DeleteService(int id)
        {
            var serviceToDelete = context.Services.Where(a => a.Id == id).FirstOrDefault();
            if (serviceToDelete != null)
            {
                context.Services.Remove(serviceToDelete);
                context.SaveChanges();
            }
        }

    }
}
