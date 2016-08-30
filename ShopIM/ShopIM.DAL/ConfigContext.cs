
using System;
using System.Collections.Generic;
using System.Linq;

using ShopIM.Entity;

namespace ShopIM.DAL
{
    public class ConfigContext
    {
        public Config GetSettingses()
        {
            using (var context = new DatabaseContext())
            {
                return (from Config in context.Configs where Config.Sl == 1 select Config).FirstOrDefault();

            }

        }


        public bool updateConfig(Config config)
        {
            using (var context = new DatabaseContext())
            {
                try
                {
                    var c = (from Config in context.Configs where config.Sl==1 select Config).FirstOrDefault();
                    c.Alert = config.Alert;
                    c.ThreshHold = config.ThreshHold;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    
                    return false;
                }
                

            }

        }


    }
}
