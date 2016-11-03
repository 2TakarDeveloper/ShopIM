
using System;
using System.Collections.Generic;
using System.Diagnostics;
using ShopIM.Entity;
using System.Linq;
using ShopIM.Library;

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

                NotificationManager.Notifications=new List<Notification>();

                foreach (var inventory in inventories)
                {
                    var i = inventory.inventory;
                    i.Product = inventory.product;
                    //Update Notifications according to statusChange
                    if (i.Due > 0)
                    {
                        i.Status = "Due";
                        NotificationManager.Notifications.Add(new Notification(i.ProductName+" Has Due Payment"));
                    }
                    if (i.Quantity == 0)
                    {
                        i.Status = "Out Of Stock";
                        NotificationManager.Notifications.Add(new Notification(i.ProductName + " is out of stock"));
                    }
                    else if (i.Quantity < i.Threashold)
                    {
                        i.Status = "Stock Short";
                        NotificationManager.Notifications.Add(new Notification(i.ProductName + " is Short On stock"));
                        
                    }
                   
                    else
                    {
                        i.Status = "In Stock";
                    }
                    


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


                    
                    I.Cost = inventory.Cost;
                    I.PurchaseDate = inventory.PurchaseDate;
                    I.Quantity = inventory.Quantity;
                    I.SellingPrice = inventory.SellingPrice;
                    I.StockLocation = inventory.StockLocation;
                    I.Threashold = inventory.Threashold;
                    I.Vendor = inventory.Vendor;
                    I.Due = inventory.Due;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                

               

            }


        }

       

        public List<Inventory> SearchWithName(string name)
        {
            List<Inventory> InventoryList = new List<Inventory>();
            using (var context = new DatabaseContext())
            {
                var inventories =
                        from inventory in context.Inventories
                        join product in context.Products on inventory.ProductName equals product.Name
                        where inventory.Product.Name==name
                        select new { inventory, product };
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


         
        public List<Inventory> SearchWithPriceRange(double upper,double lower)
        {
            using (var context = new DatabaseContext())
            {
                return (from inventory in context.Inventories where inventory.Cost <=upper && inventory.Cost>=lower select  inventory).ToList();
            }
        }





        public bool SalesUpdate(Inventory inventory)
        {
            
            using (var context = new DatabaseContext())
            {
                try
                {
                    var i = (from Inventory in context.Inventories
                        where Inventory.Sl == inventory.Sl
                        select Inventory).FirstOrDefault();



                    i.Quantity -= inventory.Quantity;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
               
                


            }




        }


      
    }
}
