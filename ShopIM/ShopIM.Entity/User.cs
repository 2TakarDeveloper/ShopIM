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
        public string ImageURL { get; set; }
        public User() { }

        public User(string name,string Type)
        {
            UserName = name;
            UserType = Type;
        }
    }
}