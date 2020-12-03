﻿using AutoMapper;
using BoozewasherApp_Web.Dtos;
using BoozewasherApp_Web.Models.ContextModel;
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
        }
    }
}