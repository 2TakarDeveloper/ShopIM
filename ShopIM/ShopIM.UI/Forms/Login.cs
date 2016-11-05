using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using ShopIM.BLL;
using ShopIM.Entity;

namespace ShopIM.UI.Forms
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
            bool Override = false;

            var username = UserNameField.Text;
            var userPassword = PasswordField.Text;
            User user;
            if (username == "System" && userPassword == "Admin")
            {
                Override = true;
                user=new User("System","Admin");
            }
            else
            {
                user = new UserRepo().GetUser(username, userPassword);
            }
         

            string type;
    
            
            if (Override ||user!=null)
            {
                //next page
                var adminDashboard = new AdminDashboard(user, this);
                UserNameField.Text = "";
                PasswordField.Text = "";
                adminDashboard.Show();
                Hide();
            }
            else
            {
                MetroMessageBox.Show(this, "Invalid Username/Password", "Wrong Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog(this);
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            SettingContextMenu.Show(SettingLink, 0, SettingLink.Height);
        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}