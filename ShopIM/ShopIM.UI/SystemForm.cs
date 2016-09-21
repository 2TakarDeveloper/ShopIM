using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using ShopIM.BLL;
using ShopIM.Library;

namespace ShopIM.UI
{
    public partial class SystemForm : MetroForm
    {
        private int _tryPassword = 3;

        public SystemForm(string userName, Login login, AdminDashboard adminDashboard)
        {
            Login = login;
            AdminDashboard = adminDashboard;
            UserName = userName;
            InitializeComponent();
        }

        private string UserName { get; }
        private Login Login { get; }
        private AdminDashboard AdminDashboard { get; }

        private void SystemForm_Load(object sender, EventArgs e)
        {
            Width = Owner.Width;

            Location = Owner.Location;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = SystemSettings.isSystemLocked;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var password = PasswordField.Text;
            string type;
            if (new UserRepo().ValidateUser(UserName, password, out type))
            {
                SystemSettings.isSystemLocked = false;
                Close();
            }
            else
            {
                _tryPassword -= 1;
                MetroMessageBox.Show(this, "Password Invaild.Try:" + _tryPassword, "Notification", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                if (_tryPassword <= 0)
                    Logout();
            }
        }

        private void Logout()
        {
            Login.Show();
            Close();
            AdminDashboard.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Logout();
        }
    }
}