using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;


namespace ShopIM.Data
{
    public class ProductRepo
    {
        public List<Product> GetProducts()
        {

            List<Product> productList;
            using (var context = new ShopIMDBEntities())
            {
                var products = from product in context.Products
                           
                            select product;

                productList = products.ToList();
            }
            return productList;
        }

        public static void  AddProduct(Product product)
        {
            using (var context = new ShopIMDBEntities())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public static void RemoveSelectedProducts(Product selectedProduct)
        {

            
                using (ShopIMDBEntities context = new ShopIMDBEntities())
                {
                //need to fix and delete from DB

                    context.Products.Attach(selectedProduct);
                    context.Products.Remove(selectedProduct);
                    context.SaveChanges();

                }
            


        }
    }
}
