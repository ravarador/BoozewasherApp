
using BoozewasherDomain.Dtos;
using BoozewasherDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherDomain.IRepositories
{
    public interface IServiceRepository
    {
        void AddService(Service service);
        void DeleteService(int id);
        List<Service> GetAllServices();
        void UpdateService(Service service);
        List<Service> GetServicesBySearchParameter(SearchDto searchParameter);
    }
}
