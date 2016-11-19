using System.ComponentModel.DataAnnotations;

namespace ShopIM.Entity
{
    public class Notification
    {
       

        public Notification(string name, string message)
        {
            Message = message;
            Name = name;
            ToolTip = name +" "+ message;
        }

        [Key]

        public string Name { get;  }
        public string ToolTip { get; }
        public string Message { get; set; }

       
    }
}