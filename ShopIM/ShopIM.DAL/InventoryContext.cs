
using System;
using System.Collections.Generic;
using System.Diagnostics;
using ShopIM.Entity;
using System.Linq;

namespace ShopIM.DAL
{
    public class InventoryContext
    {

        public List<Inventory> GetInventories()
        {
            List<Inventory> InventoryList=new List<Inventory>();
            using (var context = new DatabaseContext())
            {
                var inventories =
                        from inventory in context.Inventories
                        join product in context.Products on inventory.ProductName equals product.Name
                        select new { inventory,product };
                foreach (var inventory in inventories)
                {
                    Inventory i = new Inventory();
                    i = inventory.inventory;
                    i.Product = inventory.product;
                    InventoryList.Add(i);

                }
                return InventoryList;
            }
        }


        public bool AddInventory(Inventory inventory)
        {
            using (var context = new DatabaseContext())
            {
                try
                {
                    context.Inventories.Add(inventory);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                
               


            }
        }

        public bool RemoveInventories(Inventory inventory)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    
                        Inventory item = context.Set<Inventory>().FirstOrDefault(r => r.Sl == inventory.Sl);
                        if (item == null) return false;
                        context.Inventories.Remove(item);
                        context.SaveChanges();
                        return true;


                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
          
        }

        public bool UpdateInventory(Inventory inventory, Inventory selectedInventory)
        {

            using (var context = new DatabaseContext())
            {
                try
                {
                    var I = context.Inventories.SingleOrDefault(a => a.Sl == selectedInventory.Sl);


                    
                    I.Price = inventory.Price;
                    I.PurchaseDate = inventory.PurchaseDate;
                    I.Quantity = inventory.Quantity;
                    I.SellingPrice = inventory.SellingPrice;
                    I.StockLocation = inventory.StockLocation;
                    I.Threashold = inventory.Threashold;
                    I.Vendor = inventory.Vendor;

                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                

               

            }


        }

        public List<Notification> CheckQuantity(int threashHold,out int length)
        {
            using (var context = new DatabaseContext())
            {
                List<Inventory> I = (from inventory in context.Inventories
                                          where inventory.Quantity<threashHold
                                         select inventory).ToList();
               

                length = I.Count;
                List<Notification> notifications=new List<Notification>();

                foreach (var inventory in I)
                {
                    
                    Notification n = new Notification(inventory.ProductName+" Is short on stock");
                    notifications.Add(n);


                }

                return notifications;

            }
        }

        public List<Inventory> SearchWithName(string name)
        {
            using (var context = new DatabaseContext())
            {
                return (from inventory in context.Inventories where inventory.ProductName==name select inventory).ToList();
            }
        }

        public double SalesUpdate(Inventory inventory)
        {
           
            using (var context = new DatabaseContext())
            {
                var i = (from Inventory in context.Inventories
                    where Inventory.Sl == inventory.Sl
                    select Inventory).FirstOrDefault();


                
                i.Quantity -= inventory.Quantity;
                context.SaveChanges();
                return i.Price;


            }




        }





    }
}
