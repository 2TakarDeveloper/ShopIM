﻿using System;
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
           

             //new LogRepo().CreateLog(product.Name + " Added to the Products Table");
             //copy file in local Dir
             if (destinationFile != null && sourceFile!=null)
                {
                    File.Copy(sourceFile, destinationFile, true);
                }
               
             return true;

            
        }

        public bool RemoveProduct(Product product)
        {
            if (!new ProductContext().RemoveProduct(product)) return false;

           
            //new LogRepo().CreateLog(product.Name + " Removed from the Products Table");
              
                    
            return true;
            
        }

        public bool UpdateProduct(Product newProduct, Product selectedProduct,string destinationFile,string sourceFile)
        {
            if (!new ProductContext().UpdateProduct(newProduct, selectedProduct)) return false;
            //new LogRepo().CreateLog(selectedProduct.Name + " Was Modified");
            if (destinationFile != null && sourceFile != null)
            {
                File.Copy(sourceFile, destinationFile, true);
            }

            return true;
        }

    }
}
