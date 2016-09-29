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




        public bool CreateNewUser(User user)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
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

        public void RemoveUsers(User user)
        {
            using (var context = new DatabaseContext())
            {
                
                    var item = context.Set<User>().FirstOrDefault(r => r.Sl == user.Sl);
                    if (item == null) return;
                    context.Users.Remove(item);
                    context.SaveChanges();
                
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
                    if (User.ImageURL!=null && User.ImageURL != user.ImageURL)
                    {
                        //delete old file
                        File.Delete(User.ImageURL);
                        
                    }
                    User.ImageURL = user.ImageURL;
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
