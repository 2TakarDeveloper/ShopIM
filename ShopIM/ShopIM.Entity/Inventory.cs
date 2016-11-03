using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopIM.Entity
{
    public class Inventory
    {
        public Inventory()
        {
        }

        public Inventory(Inventory inventory)
        {
            Sl = inventory.Sl;
            Vendor = inventory.Vendor;
            Status = inventory.Status;
            Due = inventory.Due;
            ProductName = inventory.ProductName;
            Quantity = inventory.Quantity;
            Cost = inventory.Cost;
            SellingPrice = inventory.SellingPrice;
            PurchaseDate = inventory.PurchaseDate;
            TotalCost = inventory.TotalCost;
            TotalPrice = inventory.TotalPrice;
            StockLocation = inventory.StockLocation;
            Product = inventory.Product;
        }

        [Key]
        public int Sl { get; set; }

        public string ProductName { get; set; }
        public string Vendor { get; set; }
        public string Status { get; set; }
        public int Quantity { get; set; }
        public int Threashold { get; set; }
        public double Cost { get; set; }
        public double Due { get; set; }
        public double SellingPrice { get; set; }
        public double TotalCost { get; set; }
        public double TotalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string StockLocation { get; set; }

        [ForeignKey("ProductName")]
        public Product Product { get; set; }
    }
}