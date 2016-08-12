using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UserRepo
    {
        public bool ValidateUser(string userName,string userPassword)
        {
            List<User> userList;
            using (var context = new SHOPIMDBEntities())
            {
                var users = from user in context.Users
                            where user.UserName == userName && user.UserPassword == userPassword
                            select user;

                userList = users.ToList();

            }
            return userList.Count > 0;
        }
       
    }
}
