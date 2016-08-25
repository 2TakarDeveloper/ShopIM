
using System.ComponentModel.DataAnnotations;


namespace ShopIM.Entity
{
    public class Product
    {
        [Key]
        public string name { get; set; }
        public string Vendor { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
