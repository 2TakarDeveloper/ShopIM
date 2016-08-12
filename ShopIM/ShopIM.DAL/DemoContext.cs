using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopIM.Entity;

namespace ShopIM.DAL
{
    public class DemoContext : DbContext
    {
        public DemoContext() : base("name: SHOPIMDB")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
