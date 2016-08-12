using System;
using System.Collections.Generic;
using System.Linq;
using MetroFramework;
using MetroFramework.Forms;
using Data;

namespace ShopIM.UI
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

      

        private void metroButton2_Click(object sender, EventArgs e)
        {

            string userName = UserNameField.Text;
            string userPasword = PasswordField.Text;
            List<User> userList;
            using (var context = new SHOPIMDBEntities())
            {
                var users = from user in context.Users
                            where user.UserName == userName && user.UserPassword == userPasword
                            select user;

                userList = users.ToList();

            }
            MetroMessageBox.Show(this, userList.Count > 0 ? "User Found" : "User Not Found");
        }
    }
}
