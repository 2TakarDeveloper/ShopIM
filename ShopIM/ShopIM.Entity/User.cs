

using System.ComponentModel.DataAnnotations;

namespace ShopIM.Entity
{
    public class User
    {
        [Key]
        public string userName { get; set; }
        public string userPassword { get; set; }
    }
}
