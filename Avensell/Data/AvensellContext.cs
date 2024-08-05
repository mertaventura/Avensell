using Avensell.Model;
using Microsoft.EntityFrameworkCore;

namespace Avensell.Concrete
{
    public class AvensellContext : DbContext
    {
        public AvensellContext(DbContextOptions<AvensellContext> options) : base(options)
        {

        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }


    }
}
