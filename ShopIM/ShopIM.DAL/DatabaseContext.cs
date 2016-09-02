
using System.Data.Entity;
using ShopIM.Entity;

namespace ShopIM.DAL
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext() : base("name=ShopIMDatabase") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<SalesLog> SalesLogs { get; set; }
        
    }
}
