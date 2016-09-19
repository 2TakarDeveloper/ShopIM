using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopIM.DAL;
using ShopIM.Entity;

namespace ShopIM.BLL
{
    public class UserRepo
    {
        public bool ValidateUser(string name, string password, out string type)
        {

            UserContext userContext = new UserContext();
            if (userContext.ValidateUser(name, password, out type))
            {
                using (DatabaseContext context=new DatabaseContext())
                {
                    var log = new Log(name + " logged in");

                    context.Logs.Add(log);
                    context.SaveChanges();
                }

                return true;
            }
            return false;
        }
    }
}
