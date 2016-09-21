using System.ComponentModel.DataAnnotations;

namespace ShopIM.Entity
{
    public class User
    {
        [Key]
        public int Sl { get; set; }

        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserType { get; set; }
    }
}