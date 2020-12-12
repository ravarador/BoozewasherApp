﻿using BoozewasherApp_Web.Models.ContextModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BoozewasherApp_Web.Interfaces
{
    public interface IDatabaseContext
    {
        DbSet<Service> Services { get; set; }
        DbSet<Summary> Summaries { get; set; }
        //test push
        DbSet<Transaction> Transactions { get; set; }
        DbSet<Vehicle> Vehicles { get; set; }
        int SaveChanges();
    }
}