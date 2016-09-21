using System.ComponentModel.DataAnnotations;

namespace ShopIM.Entity
{
    public class Notification
    {
        public Notification()
        {
        }

        public Notification(string message)
        {
            this.message = message;
        }

        [Key]
        public int Sl { get; set; }

        public string message { get; set; }
    }
}