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

namespace ShopIM.UI
{
    public partial class NormalDashBoard : MetroFramework.Forms.MetroForm
    {
        private Login login;
        private string userName;
        public static bool IsLocked;


        public NormalDashBoard(Login loginForm, string userName)
        {
            login = loginForm;
            this.userName = userName;
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }


        protected override void OnClosed(EventArgs e)
        {
            login.Show();

        }

        private void LogOutTile_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void LockTile_Click(object sender, EventArgs e)
        {
            IsLocked = !IsLocked;

            var verificationForm = new VerificationForm(userName,LockTrigger);
            verificationForm.ShowDialog(this);



        }

        private void LockTrigger(string errorMsg, VerificationForm verificationForm)
        {
            if (errorMsg == "")
            {
                if (!IsLocked) return;
                IsLocked = false;
                verificationForm.Close();
            }
            else
            {
                MetroMessageBox.Show(this, errorMsg, "Notification", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

        }

        private void SalesTile_Click(object sender, EventArgs e)
        {
           SalesForm salesForm = new SalesForm(userName);
           salesForm.ShowDialog(this);
        }

        private void UserTile_Click(object sender, EventArgs e)
        {
            UserForm userForm= new UserForm(userName);
            userForm.ShowDialog(this);
        }
    }
}
