using AutoMapper;
using BoozewasherApp_Web.Dtos;
using BoozewasherApp_Web.Models.ContextModel;
using BoozewasherApp_Web.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Service, ServiceDto>();
            Mapper.CreateMap<ServiceDto, Service>();

            Mapper.CreateMap<Vehicle, VehicleDto>();
            Mapper.CreateMap<VehicleDto, Vehicle>();

            Mapper.CreateMap<Item, ItemDto>();
            Mapper.CreateMap<ItemDto, Item>();

            Mapper.CreateMap<Transaction, TransactionDto>();
            Mapper.CreateMap<TransactionDto, Transaction>();

            Mapper.CreateMap<Branch, BranchDto>();
            Mapper.CreateMap<BranchDto, Branch>();
        }
    }
}