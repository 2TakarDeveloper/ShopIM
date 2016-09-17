﻿using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using ShopIM.DAL;

namespace ShopIM.UI
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

      

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string userType;
            string userName = UserNameField.Text;
            string userPasword = PasswordField.Text;
            UserContext userContext=new UserContext();
            if (userContext.ValidateUser(userName, userPasword,out userType))
            {
                Hide();

                if (userType == "Admin")
                {
                    new DashBoard(this, userName).Show();
                }
                else
                {
                    new NormalDashBoard(this, userName).Show();

                }


                UserNameField.Text = "";
                PasswordField.Text = "";

            }
            else
            {
                MetroMessageBox.Show(this, "Wrong Username/Passoword", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PasswordField_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
