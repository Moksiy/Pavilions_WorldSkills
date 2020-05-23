using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavilions_WS.Models
{
    public class PavilionsContext1 : DbContext
    {
        public PavilionsContext1() : base("Pavilions_Connection")
        {

        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Pavilion> Pavilions { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<ShoppingCenter> ShoppingCenters { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Tenantry> Tenantries { get; set; }
    }
}
