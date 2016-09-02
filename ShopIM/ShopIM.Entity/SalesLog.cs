

using System;
using System.ComponentModel.DataAnnotations;

namespace ShopIM.Entity
{
    public class SalesLog
    {
        [Key]
        public int Sl { get; set; }
        public  string ProductName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime SoldDate { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
        public string UserName { get; set; }
        public int Quantity { get; set; }
        public double NetProfit { get; set; }
    }
}
