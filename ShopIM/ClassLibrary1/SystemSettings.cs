using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopIM.Library
{
    public class SystemSettings
    {
        public SystemSettings()
        {
            isSystemLocked = false;
        }
        public static bool isSystemLocked { get; set; }
    }
}
