using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopIM.Entity;

namespace ShopIM.DAL
{
    public class UserContext
    {
        public bool ValidateUser(string name, string pass)
        {
            using (var context = new DatabaseContext())
            {
                var User = (from user in context.Users
                    where user.userName == name && user.userPassword == pass
                    select user).FirstOrDefault();

                return User != null;
            }
        }


        public bool ChangePassword(string name,string oldPass, string pass)
        {
            using (var context = new DatabaseContext())
            {
                var User = (from user in context.Users
                    where user.userName == name && user.userPassword==oldPass
                    select user).FirstOrDefault();

                if (User == null) return false;

                User.userPassword = pass;
                context.SaveChanges();
                return true;
            }
        }
    }
}
