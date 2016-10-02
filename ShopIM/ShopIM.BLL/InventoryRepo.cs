using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopIM.DAL;
using ShopIM.Entity;
using ShopIM.Library;

namespace ShopIM.BLL
{
    public class InventoryRepo
    {
        public List<Inventory> GetInventories()
        {
            NotificationManager.Notifications = new InventoryContext().CheckAvailablity();
            return new InventoryContext().GetInventories();
        }

        public bool AddInventory(Inventory inventory)
        {
            if (new InventoryContext().AddInventory(inventory))
            {
                new LogRepo().CreateUserLog(inventory.ProductName + " Added to the Inventory Table");
                if (SystemSettings.IsNotificationsOn)
                {
                        CheckAvailability();
                }
                
                return false;
            }
            else
            {
                return false;
            }
            
        }

        public bool UpdateInventory(Inventory inventory,Inventory selectedInventory)
        {
            if (!new InventoryContext().UpdateInventory(inventory, selectedInventory)) return false;
            new LogRepo().CreateUserLog(selectedInventory.ProductName + " Was Modified");
            if (SystemSettings.IsNotificationsOn)
            {
                CheckAvailability();
            }

            return true;
        }

        public bool RemoveInventories(List<Inventory> selectedInventories)
        {
            foreach (var inventory in selectedInventories)
            {
                if (new InventoryContext().RemoveInventories(inventory))
                {
                   new LogRepo().CreateUserLog(inventory.ProductName + " was removed from database");
                    if (SystemSettings.IsNotificationsOn)
                    {
                        CheckAvailability();
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;

            
           
        }

      

        public List<Inventory> SearchByName(string text)
        {
          return  new InventoryContext().SearchWithName(text);
        }



        public bool SellProduct(List<Inventory> inventories,string userName)
        {
            foreach (var inventory in inventories)
            {
                if (!new InventoryContext().SalesUpdate(inventory))
                {
                    return false;
                }
                //Add sales log
                SalesLog salesLog=new SalesLog(inventory,userName);
                new SalesLogContext().AddSalesLog(salesLog);
                if (SystemSettings.IsNotificationsOn)
                {
                    CheckAvailability();
                }
            }
            return true;
        }

        public void CheckAvailability()
        {
            NotificationManager.Notifications = new InventoryContext().CheckAvailablity();
        }

    }
}
