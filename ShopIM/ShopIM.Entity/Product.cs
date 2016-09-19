
using System;
using System.ComponentModel.DataAnnotations;


namespace ShopIM.Entity
{
    public class Product
    {
        [Key]
        public string Name { get; set; }
        public string Vendor { get; set; }
        public string Type { get; set; }
        public string ImageURL { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
