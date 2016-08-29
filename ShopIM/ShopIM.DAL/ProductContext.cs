
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
            using (var context=new DatabaseContext())
            {
                   return (from product in context.Products select product).ToList();

            }
            
        }

        public void AddProduct(Product product)
        {
            using (var context = new DatabaseContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
                var log = new Log(product.name + " Added to the Products Table");
               
                context.Logs.Add(log);
                context.SaveChanges();


            }
        }

        public void RemoveProducts(List<Product> Products)
        {
            using (var context = new DatabaseContext())
            {
                foreach (var product in Products)
                {
                    var item = context.Set<Product>().FirstOrDefault(r => r.name == product.name);
                    if (item == null) continue;
                    context.Products.Remove(item);
                    context.SaveChanges();
                    var log = new Log(product.name + " Removed from the Products Table");

                    context.Logs.Add(log);
                    context.SaveChanges();
                }
            }
        }

        public void UpdateProduct(Product product,Product selectedProduct)
        {
     
              using (var context = new DatabaseContext())
                {
                    var Product = context.Products.SingleOrDefault(a => a.name == selectedProduct.name);

                    if (Product == null) return;
                    Product.name = product.name;
                    Product.Type = product.Type;
                    Product.Vendor = product.Vendor;
                    context.SaveChanges();

                    var log = new Log(selectedProduct.name + " Was Modified");

                    context.Logs.Add(log);
                    context.SaveChanges();

            }
            
            
        }


    }
}
