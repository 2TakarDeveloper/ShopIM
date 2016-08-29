using System;

using System.Windows.Forms;
using MetroFramework;
using ShopIM.DAL;

namespace ShopIM.UI
{
    public partial class VerificationForm : MetroFramework.Forms.MetroForm
    {
        private string userName;
        public VerificationForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
            
        

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string password = PasswordTextBox.Text;
            if (new UserContext().ValidateUser(userName, password))
            {
                new LogContext().clearLog();
                MetroMessageBox.Show(this, "Operation Successful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
            else
            {
                MetroMessageBox.Show(this, "Wrong Password", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
