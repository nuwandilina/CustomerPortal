using CustomerPortal.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerPortal.API.Data
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
