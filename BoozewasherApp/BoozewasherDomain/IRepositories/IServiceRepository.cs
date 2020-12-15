using BoozewasherApp.Models.ContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.IRepositories
{
    public interface IServiceRepository
    {
        void AddService(Service service);
        void DeleteService(int id);
        List<Service> GetAllServices();
        void UpdateService(Service service);
    }
}
