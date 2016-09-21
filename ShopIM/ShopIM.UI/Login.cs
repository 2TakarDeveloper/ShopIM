using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using ShopIM.BLL;

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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var username = UserNameField.Text;
            var userPassword = PasswordField.Text;
            string type;
            var userRepo = new UserRepo();
            if (userRepo.ValidateUser(username, userPassword, out type))
            {
                //next page
                var adminDashboard = new AdminDashboard(username, type, this);
                adminDashboard.Show();
                Hide();
            }
            else
            {
                MetroMessageBox.Show(this, "Invalid Username/Password", "Wrong Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}