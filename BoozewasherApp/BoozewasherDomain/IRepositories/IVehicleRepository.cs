
using BoozewasherDomain.Dtos;
using BoozewasherDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherDomain.IRepositories
{
    public interface IVehicleRepository
    {
        void AddVehicle(Vehicle vehicle);
        void DeleteVehicle(int id);
        List<Vehicle> GetAllVehicles();
        void UpdateVehicle(Vehicle vehicle);
        List<Vehicle> GetVehiclesBySearchParameter(SearchDto searchParameter);
    }
}
