using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopIM.Data
{
    public class LoginRepo
    {
        public bool ValidateUser(string userName, string userPasword)
        {

            List<User> userList;
            using (var context = new ShopIMDBEntities())
            {
                var users = from user in context.Users
                            where user.userName == userName && user.userPassword == userPasword
                            select user;

                userList = users.ToList();

            }
            return userList.Count > 0;
        }
    }
}
