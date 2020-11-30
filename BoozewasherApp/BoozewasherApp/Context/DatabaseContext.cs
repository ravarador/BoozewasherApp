using BoozewasherApp.Models.ContextModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base(@"Data Source=localhost\SQLEXPRESS; Initial Catalog=BoozewasherAppDb;Trusted_Connection=True;")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Summary> Summaries { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

    }
}
