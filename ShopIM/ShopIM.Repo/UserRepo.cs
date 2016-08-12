using System;
using System.Collections.Generic;
using System.Linq;
using ShopIM.DAL;
using ShopIM.Entity;

namespace ShopIM.Repo
{
    public class UserRepo
    {
        public List<User> GetUsers()
        {
            using (var dbContext=new DemoContext())
            {
                return dbContext.Users.ToList();
            }
        }

    }
}
