using MetroFramework;
using ShopIM.Library;
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
    public partial class SystemForm : MetroFramework.Forms.MetroForm
    {
        int tryPassword = 3;
        public SystemForm()
        {
            InitializeComponent();
        }

        private void SystemForm_Load(object sender, EventArgs e)
        {
            this.Width = this.Owner.Width;
          
            this.Location = this.Owner.Location;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {


            if (SystemSettings.isSystemLocked)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //need to be implement using passwordField
            {
                if (PasswordField.Text.Equals("Admin"))
                {
                    this.Close();
                }
                else
                {

                    MetroMessageBox.Show(this, "Password Invaild.Try:" + tryPassword.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
