

using System;
using System.Collections.Generic;
using System.Linq;
using ShopIM.Entity;

namespace ShopIM.DAL
{
    public class ProductContext
    {
        public List<Product> GetAlProducts()
        {
            using (var context = new DatabaseContext())
            {
                return (from product in context.Products select product).ToList();

            }

        }

        public bool AddProduct(Product product)
        {
            using (var context = new DatabaseContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
                return true;
            }
        }

        public bool RemoveProduct(Product product)
        {
            using (var context = new DatabaseContext())
            {
                
                var item = context.Set<Product>().FirstOrDefault(r => r.Name == product.Name);
                if (item == null) return false;
                context.Products.Remove(item);
                context.SaveChanges();
                return true;

                
            }
        }

        public void UpdateProduct(Product product,Product selectedProduct)
        {
     
              using (var context = new DatabaseContext())
                {
                    var Product = context.Products.SingleOrDefault(a => a.Name == selectedProduct.Name);

                    if (Product == null) return;
                    Product.Name = product.Name;
                    Product.Type = product.Type;
                    Product.Vendor = product.Vendor;
                    context.SaveChanges();

                    var log = new Log(selectedProduct.Name + " Was Modified");

                    context.Logs.Add(log);
                    context.SaveChanges();

               }
            
            
        }


    }
}
