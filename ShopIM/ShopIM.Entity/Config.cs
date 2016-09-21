using System.ComponentModel.DataAnnotations;

namespace ShopIM.Entity
{
    public class Config
    {
        [Key]
        public int Sl { get; set; }

        public int ThreshHold { get; set; }
        public int Alert { get; set; }
    }
}