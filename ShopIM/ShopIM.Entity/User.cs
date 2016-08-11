using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopIM.Entity
{
    public class User
    {
        public User(string userName, string userPassword)
        {
            UserName = userName;
            UserPassword = userPassword;
        }

        public User()
        {

        }

        public string UserName {get; set;}
        public string UserPassword { get; set; }

    }
}
