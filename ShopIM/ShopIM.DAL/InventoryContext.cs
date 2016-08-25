
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
            }
        }

        public void RemoveInventories(List<Inventory> inventories)
        {
            using (var context = new DatabaseContext())
            {
                foreach (var inventory in inventories)
                {
                    Inventory item = context.Set<Inventory>().FirstOrDefault(r => r.ProductName == inventory.ProductName);
                    if(item!=null)
                    {
                        context.Inventories.Remove(item);
                        context.SaveChanges();
                    }
                }
            }
        }





    }
}
