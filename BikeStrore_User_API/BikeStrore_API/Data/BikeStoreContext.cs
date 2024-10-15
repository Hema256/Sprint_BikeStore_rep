using BikeStrore_API.Models;
using Microsoft.EntityFrameworkCore;


namespace BikeStrore_API.Data
{
    public class BikeStoreContext:DbContext
    {
        public BikeStoreContext(DbContextOptions<BikeStoreContext> options):base(options) { }
        public DbSet<User> Users { get; set; }
    }
  
}
