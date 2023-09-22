using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkWinFormApp.DAL.Entities;

namespace EntityFrameworkWinFormApp.DAL.Contexts
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base(ConfigurationManager.ConnectionStrings["EntityFrameworkWinFormApp.Properties.Settings.EFDBTestConnectionString"].ConnectionString)
        {

        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConfigurationManager.ConnectionStrings["BloggingDatabase"].ConnectionString
        }*/

        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
