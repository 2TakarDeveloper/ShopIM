

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopIM.Entity
{
    public class Inventory
    {
        [Key]
        public int Sl { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
