using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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








    }
}
