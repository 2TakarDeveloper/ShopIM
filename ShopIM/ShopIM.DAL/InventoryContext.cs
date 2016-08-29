
using System.Collections.Generic;
using ShopIM.Entity;
using System.Linq;

namespace ShopIM.DAL
{
    public class InventoryContext
    {

        public List<Inventory> GetInventories()
        {
            using (var context = new DatabaseContext())
            {
                return (from inventory in context.Inventories select inventory).ToList();
            }
        }


        public void AddInventory(Inventory inventory)
        {
            using (var context = new DatabaseContext())
            {
                context.Inventories.Add(inventory);
                context.SaveChanges();
                var log = new Log(inventory.ProductName + " Added to the Inventory Table");

                context.Logs.Add(log);
                context.SaveChanges();


            }
        }

        public void RemoveInventories(List<Inventory> inventories)
        {
            using (var context = new DatabaseContext())
            {
                foreach (var inventory in inventories)
                {
                    Inventory item = context.Set<Inventory>().FirstOrDefault(r => r.Sl == inventory.Sl);
                    if (item == null) continue;
                    context.Inventories.Remove(item);
                    context.SaveChanges();

                    var log = new Log(item.ProductName + " Was Removed from Inventory");

                    context.Logs.Add(log);
                    context.SaveChanges();


                }
            }
        }

        public void UpdateInventory(Inventory inventory, Inventory selectedInventory)
        {

            using (var context = new DatabaseContext())
            {
                Inventory I = context.Inventories.SingleOrDefault(a => a.Sl == selectedInventory.Sl);

                I.Price = inventory.Price;
                I.PurchaseDate = inventory.PurchaseDate;
                I.Quantity = inventory.Quantity;

                context.SaveChanges();

                var log = new Log(I.ProductName + "'s Information was Updated");

                context.Logs.Add(log);
                context.SaveChanges();

            }


        }





    }
}
