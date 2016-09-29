
using System;
using System.Collections.Generic;
using System.IO;
using ShopIM.DAL;
using ShopIM.Entity;


namespace ShopIM.BLL
{
    public class UserRepo
    {
        public bool ValidateUser(string name, string password)
        {

            UserContext userContext = new UserContext();
            if (!userContext.ValidateUser(name, password)) return false;
            

            return true;
        }


        public User GetUser(string name, string password)
        {
            UserContext userContext = new UserContext();
            User user= userContext.GetUser(name, password);
            if (user!=null)
            {
                new LogRepo().CreateUserLog(name + " logged in");
               
            }
            return user;
        }

        public bool UpdateUser(User user)
        {
           
            return new UserContext().UpdateUser(user);
        }

        public List<User> GetUsers()
        {
            return  new UserContext().GetUsers();
        }

        public bool AddUser(User user,string sourceFile)
        {
            if (new UserContext().CreateNewUser(user))
            {
                new LogRepo().CreateUserLog(user.UserName + " Created");
                //copy file in local Dir
                if (user.ImageURL != null && sourceFile != null)
                {
                    File.Copy(sourceFile, user.ImageURL, true);
                }
                return true;


            }
            return false;
        }

        public bool RemoveUsers(List<User> selectedUsers)
        {
            try
            {
                foreach (var user in selectedUsers)
                {
                    new UserContext().RemoveUsers(user);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
