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
            this.UserName = userName;
            this.UserPassword = userPassword;
        }

        private string UserName {get; set;}
        private string UserPassword { get; set; }

    }
}
