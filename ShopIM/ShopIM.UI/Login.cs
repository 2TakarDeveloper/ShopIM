using System;
using System.Collections.Generic;
using System.Linq;
using MetroFramework;
using MetroFramework.Forms;
using ShopIM.Data;

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
            LoginRepo loginRepo = new LoginRepo();
            if (loginRepo.ValidateUser(userName, userPasword))
            {
                Hide();
                new DashBoard(this).Show();
            }
            else
            {
                MetroMessageBox.Show(this, "Wrong User Name or Password");
            }
        }
    }
}
