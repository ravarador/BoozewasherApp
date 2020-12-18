using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using BoozewasherApp_Web.Interfaces;
using BoozewasherApp_Web.Models.ContextModel;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BoozewasherApp_Web.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDatabaseContext
    {
        public DbSet<Service> Services { get; set; }
        public DbSet<Summary> Summaries { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Item> Items { get; set; }

        public ApplicationDbContext()
            : base(@"Data Source=localhost\SQLEXPRESS; Initial Catalog=BoozewasherAppDb;Trusted_Connection=True;", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}