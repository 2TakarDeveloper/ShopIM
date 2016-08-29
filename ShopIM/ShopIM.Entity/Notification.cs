
using System.ComponentModel.DataAnnotations;


namespace ShopIM.Entity
{
    public class Notification
    {
        [Key]
        public int Sl { get; set; }
        public string message { get; set; }
    }
}
