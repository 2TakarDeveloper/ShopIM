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

                if (User == null) return false;
                var log = new Log(name + " logged in");

                context.Logs.Add(log);
                context.SaveChanges();
                return true;
            }
        }


        public bool ValidateUser(string name, string pass,out string userType)
        {
            using (var context = new DatabaseContext())
            {
                var User = (from user in context.Users
                            where user.userName == name && user.userPassword == pass
                            select user).FirstOrDefault();


                userType = null;
                if (User == null) return false;
                userType = User.userType;

                var log = new Log(name + " logged in");

                context.Logs.Add(log);
                context.SaveChanges();
                return true;
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
                var log = new Log(name + "'s Password was changed");

                context.Logs.Add(log);
                context.SaveChanges();


                return true;
            }
        }

        public void CreateNewUser(User user)
        {
            using (var context = new DatabaseContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

    }
}
