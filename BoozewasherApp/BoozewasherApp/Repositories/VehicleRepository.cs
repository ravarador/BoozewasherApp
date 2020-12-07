﻿using BoozewasherApp.IRepositories;
using BoozewasherApp.Models.ContextModels;
using BoozewasherApp.Properties;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        public void AddVehicle(Vehicle vehicle)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/vehicles/", Method.POST);
            request.AddJsonBody(vehicle);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
        }

        public void DeleteVehicle(int id)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/vehicles/" + id, Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
        }

        public List<Vehicle> GetAllVehicles()
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/vehicles/", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            var dataList = JsonConvert.DeserializeObject<List<Vehicle>>(response.Content);

            return dataList;
        }

        //public Service GetServiceById(int id)
        //{
        //    var serviceById = context.Services.Where(a => a.Id == id).FirstOrDefault();

        //    return serviceById;
        //}

        public void UpdateVehicle(Vehicle vehicle)
        {
            var client = new RestClient(Resources.ConnectionString);
            var request = new RestRequest("/api/vehicles/" + vehicle.Id, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(vehicle);
            var response = client.Execute(request);

        }
    }
}