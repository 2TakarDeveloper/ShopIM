using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopIM.Entity
{
    [Table("ProductInfo")]
    class ProductInfo
    {
         public int Quantity { get; set; }
         public double price { get; set; }
         
         [ForeignKey("Product")]
         public int ProductId { get; set; }

         public virtual Product Product { get; set; }

    }
}
