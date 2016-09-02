using System;

using System.Windows.Forms;
using MetroFramework;
using ShopIM.DAL;
using ShopIM.Entity;

namespace ShopIM.UI
{
    public partial class AdminPanel : MetroFramework.Forms.MetroForm
    {
        UserContext _userContext= new UserContext();
        private readonly string _userName;

        public AdminPanel(string userName)
        {
         
            InitializeComponent();
            _userName = userName;
            Text = userName;

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


        private void clearSalesLogTrigger(string errorMsg, VerificationForm verificationForm)
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

       

        private void metroButton1_Click(object sender, EventArgs e)
        {
            VerificationForm verificationForm = new VerificationForm(UserListTrigger);
            verificationForm.ShowDialog(this);

        }


        private void UserListTrigger(string errorMsg, VerificationForm verificationForm)
        {
            if (errorMsg == "")
            {
                UserList userList = new UserList();
                userList.ShowDialog(this);
                verificationForm.Close();
            }
            else
            {
                MetroMessageBox.Show(this, errorMsg, "Notification", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }

    }
}
