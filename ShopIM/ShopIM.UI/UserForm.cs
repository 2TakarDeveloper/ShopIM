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
using ShopIM.Entity;

namespace ShopIM.UI
{
    public partial class UserForm : MetroFramework.Forms.MetroForm
    {
        private string userName;
        public UserForm(string username)
        {
            this.userName = username;
            InitializeComponent();
            Text = username;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(PasswordBox1.Text) || string.IsNullOrWhiteSpace(PasswordBox2.Text)|| string.IsNullOrWhiteSpace(oldPass.Text)) 
            {
                MetroMessageBox.Show(this, "Required fields can't be left empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (PasswordBox1.Text == PasswordBox2.Text)
                {
                    try
                    {
                        if(new UserContext().ChangePassword(userName,oldPass.Text,PasswordBox2.Text))
                        MetroMessageBox.Show(this, "Password Changed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            MetroMessageBox.Show(this, "Password Change Failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception exception)
                    {
                        MetroMessageBox.Show(this,
                            exception.InnerException != null ? exception.InnerException.Message : exception.Message,
                            "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Password mismatch", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
