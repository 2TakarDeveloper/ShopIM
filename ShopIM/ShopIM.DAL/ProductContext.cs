using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            }
        }

        public void RemoveProducts(List<Product> Products)
        {
            using (var context = new DatabaseContext())
            {
                foreach (var product in Products)
                {
                    Product item = context.Set<Product>().FirstOrDefault(r => r.name == product.name);
                    context.Products.Remove(item);
                    context.SaveChanges();
                }
            }
        }

        public void UpdateProduct(Product product,Product selectedProduct)
        {
     
              using (var context = new DatabaseContext())
                {
                    Product Product = context.Products.SingleOrDefault(a => a.name == selectedProduct.name);

                    Product.name = product.name;
                    Product.Type = product.Type;
                    Product.Vendor = product.Vendor;
                   
                    context.SaveChanges();
                    
                }
            
            
        }


    }
}
