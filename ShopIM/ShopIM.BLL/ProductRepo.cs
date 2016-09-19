using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopIM.DAL;
using ShopIM.Entity;

namespace ShopIM.BLL
{
    public class ProductRepo
    {
        public List<Product> GetProducts()
        {
            return new ProductContext().GetAlProducts();
        }

        public bool  AddProduct  (Product product, string sourceFile,string destinationFile)
        {
          
            if (!new ProductContext().AddProduct(product)) return false;
            using (var context = new DatabaseContext())
            {

                var log = new Log(product.Name + " Added to the Products Table");
                context.Logs.Add(log);
                context.SaveChanges();
                //copy file in local Dir
                if (destinationFile != null && sourceFile!=null)
                {
                    File.Copy(sourceFile, destinationFile, true);
                }
               
                return true;

            }
        }

        public bool RemoveProduct(Product product)
        {
            if (!new ProductContext().RemoveProduct(product)) return false;

            using (DatabaseContext context=new DatabaseContext())
            {

                var log = new Log(product.Name + " Removed from the Products Table");

                context.Logs.Add(log);
                context.SaveChanges();
                    
                return true;
            }
        }
    }
}
