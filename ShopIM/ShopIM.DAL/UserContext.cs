using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopIM.Entity;

namespace ShopIM.DAL
{
    public class UserContext
    {
        public User GetUser(string name, string pass)
        {
            using (var context = new DatabaseContext())
            {
                return (from user in context.Users
                    where user.UserName == name && user.UserPassword == pass
                    select user).FirstOrDefault();

               
            }
        }


        public bool ValidateUser(string name, string pass)
        {
            using (var context = new DatabaseContext())
            {
                var User = (from user in context.Users
                    where user.UserName == name && user.UserPassword == pass
                    select user).FirstOrDefault();
                return User != null;
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
                    var item = context.Set<User>().FirstOrDefault(r => r.Sl == user.Sl);
                    if (item == null) continue;
                    context.Users.Remove(item);
                    context.SaveChanges();
                }
            }
        }


        public bool UpdateUser(User user)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var User = context.Users.SingleOrDefault(a => a.Sl == user.Sl);

                    if (User == null) return false;
                    User.UserName = user.UserName;
                    User.UserPassword = user.UserPassword;
                    User.UserType = user.UserType;
                    if (User.ImageURL != user.ImageURL)
                    {
                        //delete old file
                        File.Delete(User.ImageURL);
                        User.ImageURL = user.ImageURL;
                    }
                    
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
