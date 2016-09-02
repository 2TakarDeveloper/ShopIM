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
                    where user.UserName == name && user.UserPassword == pass
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
                            where user.UserName == name && user.UserPassword == pass
                            select user).FirstOrDefault();


                userType = null;
                if (User == null) return false;
                userType = User.UserType;

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
                    where user.UserName == name && user.UserPassword==oldPass
                    select user).FirstOrDefault();

                if (User == null) return false;

                User.UserPassword = pass;
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

        public List<User> GetUsers()
        {
            using (var context = new DatabaseContext())
            {
                return (from user in context.Users
                        where user.Sl!=1
                        select user).ToList();

            }
        }

        public void RemoveUsers(List<User> users)
        {
            using (var context = new DatabaseContext())
            {
                foreach (var user in users)
                {
                    var item = context.Set<User>().FirstOrDefault(r => r.UserName == user.UserName);
                    if (item == null) continue;
                    context.Users.Remove(item);
                    context.SaveChanges();
                }
            }
        }


        public void UpdateUser(User user, User selectedUser)
        {
            using (var context = new DatabaseContext())
            {
                var User = context.Users.SingleOrDefault(a => a.UserName == selectedUser.UserName);

                if (User == null) return;
                User.UserName = user.UserName;
                User.UserPassword = user.UserPassword;
                User.UserType = user.UserType;
                context.SaveChanges();

                

            }
        }
    }
}
