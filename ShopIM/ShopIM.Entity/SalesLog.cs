using System;
using System.ComponentModel.DataAnnotations;

namespace ShopIM.Entity
{
    public class SalesLog
    {
        [Key]
        public int Sl { get; set; }

        public string ProductName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime SoldDate { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double NetProfit { get; set; }
        public string UserName { get; set; }

        public SalesLog() { }

        public SalesLog(Inventory soldInventory,String userName)
        {
            ProductName = soldInventory.ProductName;
            PurchaseDate = soldInventory.PurchaseDate;
            SoldDate=DateTime.Now;
            Cost = soldInventory.Cost;
            Price = soldInventory.SellingPrice;
            Quantity = soldInventory.Quantity;
            NetProfit = ( Quantity*Price- Quantity * Cost);
            UserName = userName;
        }

    }
}