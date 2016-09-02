

using System.ComponentModel.DataAnnotations;

namespace ShopIM.Entity
{
    public class User
    {
        [Key]
        public int Sl { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string userType { get; set; }
    }
}
