

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
        public string Vendor { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double SellingPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string StockLocation { get; set; }
        [ForeignKey("ProductName")]
        public  Product Product { get; set; }

        public Inventory()
        {
            
        }

        public Inventory(Inventory inventory)
        {
            Sl = inventory.Sl;
            Vendor = inventory.Vendor;
            ProductName = inventory.ProductName;
            Quantity = inventory.Quantity;
            Price = inventory.Price;
            SellingPrice = inventory.SellingPrice;
            PurchaseDate = inventory.PurchaseDate;
            StockLocation = inventory.StockLocation;
            Product = inventory.Product;
        }

    }
}
