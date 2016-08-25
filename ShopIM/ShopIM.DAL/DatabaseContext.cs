using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopIM.Entity;

namespace ShopIM.DAL
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext() : base("name=ShopIMDatabase") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
    }
}
