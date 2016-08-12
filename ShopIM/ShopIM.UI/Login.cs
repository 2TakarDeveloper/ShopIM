using System;
using System.Collections.Generic;
using MetroFramework;
using MetroFramework.Forms;
using ShopIM.Entity;
using ShopIM.Repo;

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
            User user = new User(userName,userPasword);
            
            UserRepo userRepo= new UserRepo();
            List<User> userList =userRepo.GetUsers();

            if (userList.Contains(user))
            {
                MetroMessageBox.Show(this, "User Found");
            }



        }
    }
}
