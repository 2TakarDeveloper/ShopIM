using System;

using System.Windows.Forms;
using MetroFramework;
using ShopIM.DAL;
using ShopIM.Entity;

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

        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            
            VerificationForm verificationForm = new VerificationForm(clearLogTrigger);
            verificationForm.ShowDialog(this);
            

        }

        public void clearLogTrigger(string errorMsg,VerificationForm verificationForm)
        {
            if (errorMsg == "")
            {
                new LogContext().clearLog();
                MetroMessageBox.Show(this, "Log Cleared", "Notification", MessageBoxButtons.OK,
                      MessageBoxIcon.Information );
                verificationForm.Close();
            }
            else
            {
                MetroMessageBox.Show(this, errorMsg, "Notification", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }


        private void ClearSalesLog_Click(object sender, EventArgs e)
        {
     
            VerificationForm verificationForm = new VerificationForm(clearSalesLogTrigger);
            verificationForm.ShowDialog(this);
           
            

        }


        public void clearSalesLogTrigger(string errorMsg, VerificationForm verificationForm)
        {
            if (errorMsg == "")
            {
                new SalesLogContext().clearLog();
                MetroMessageBox.Show(this, "Sales Log Cleared", "Notification", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                verificationForm.Close();
            }
            else
            {
                MetroMessageBox.Show(this, errorMsg, "Notification", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if ( C_PTextbox.Text==C_C_Password.Text)
            {
                if (string.IsNullOrWhiteSpace(C_PTextbox.Text) || string.IsNullOrWhiteSpace(UserNameTextBox.Text))
                {
                    MetroMessageBox.Show(this, "Fields Can't be left Empty", "Notification", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        User user = new User();
                        user.userName = UserNameTextBox.Text;
                        user.userPassword = C_C_Password.Text;
                        //_userContext.CreateNewUser(user);
                    }
                    catch (Exception exception)
                    {
                        MetroMessageBox.Show(this, exception.Message, "Notification", MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                    }
                }
               
            }
            else
            {
                MetroMessageBox.Show(this, "Password mismatch", "Notification", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }

            
        }
    }
}
