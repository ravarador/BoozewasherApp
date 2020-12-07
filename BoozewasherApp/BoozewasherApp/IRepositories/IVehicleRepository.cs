﻿using BoozewasherApp.Models.ContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.IRepositories
{
    public interface IVehicleRepository
    {
        void AddVehicle(Vehicle vehicle);
        void DeleteVehicle(int id);
        List<Vehicle> GetAllVehicles();
        void UpdateVehicle(Vehicle vehicle);
    }
}