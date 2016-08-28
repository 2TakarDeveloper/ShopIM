using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using ShopIM.DAL;

namespace ShopIM.UI
{
    public partial class UserForm : MetroFramework.Forms.MetroForm
    {
        UserContext _userContext= new UserContext();
        private string _userName;

        public UserForm(string userName)
        {
         
            InitializeComponent();
            _userName = userName;
            Text = userName;

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (validatePass())
            {
                if (!_userContext.ChangePassword(_userName,oldPassTextBox.Text, newPassTextBox.Text))
                {
                    MetroMessageBox.Show(this, "Couldn't Update Passowrd","Notification",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    MetroMessageBox.Show(this, "Password Change successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Password Did not Match", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                newPassTextBox.Text = "";
                confirmPasswordTextBox.Text = "";
                oldPassTextBox.Text = "";

            }
        }

        private bool validatePass()
        {
            return newPassTextBox.Text.Equals(confirmPasswordTextBox.Text);
        }
    }
}
