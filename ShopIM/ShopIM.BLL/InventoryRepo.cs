﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopIM.DAL;
using ShopIM.Entity;

namespace ShopIM.BLL
{
    public class InventoryRepo
    {
        public List<Inventory> GetInventories()
        {
            return new InventoryContext().GetInventories();
        }

        public bool AddInventory(Inventory inventory)
        {
            if (!new InventoryContext().AddInventory(inventory))
            {
                return false;
            }
            else
            {
                //new LogContext().CreateLog(inventory.ProductName + " Added to the Inventory Table");
                return false;
            }
        }

        public bool UpdateInventory(Inventory inventory,Inventory selectedInventory)
        {
            if (new InventoryContext().UpdateInventory(inventory, selectedInventory))
            {
                //new LogContext().CreateLog(selectedInventory.ProductName + " Was Modified");
                return true;
            }
            return false;
        }

        public bool RemoveInventories(List<Inventory> selectedInventories)
        {
            foreach (var inventory in selectedInventories)
            {
                if (new InventoryContext().RemoveInventories(inventory))
                {
                    //new LogContext().CreateLog(inventory.ProductName + " was removed from database"); 
                }
                else
                {
                    return false;
                }
            }
            return true;

            
           
        }


    }
}
