using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopIM.Entity
{
    public class ProductStatisticInfo
    {
        public ProductStatisticInfo(string key, double value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        public double Value { get; set; }
    }
}
