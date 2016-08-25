using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopIM.Entity;

namespace ShopIM.Context
{
    public class UserContext
    {
        public bool ValidateUser(string name, string pass)
        {
            using (var context=new DatabaseContext())
            {
                User User = (from user in context.Users
                    where user.userName == name && user.userPassword == pass
                    select user).FirstOrDefault();

                return User != null;
            }
        }
    }
}
