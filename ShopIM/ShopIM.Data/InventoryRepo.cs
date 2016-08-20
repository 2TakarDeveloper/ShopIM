using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShopIM.Data
{
    public class InventoryRepo
    {

        public List<Inventory> GetInventories()
        {
            List<Inventory> productList=new List<Inventory>();
            using (var context = new ShopIMDBEntities())
            {
                var inventories = context.Inventories.Join(context.Products, inventory => inventory.Product.Id,
                    product => product.Id, (inventory, product) => new {inventory, product});

                foreach (var variable in inventories)
                {
                    Inventory inventory = variable.inventory;
                    inventory.Product = variable.product;
                  
                    productList.Add(inventory);
                }

            }


      
  
            return productList;


        }

    }
}
