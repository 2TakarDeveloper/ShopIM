

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopIM.Entity
{
    public class Inventory
    {
        [Key]
        public string sl { get; set; }
        public string productName { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public DateTime purchaseDate { get; set; }
    }
}
