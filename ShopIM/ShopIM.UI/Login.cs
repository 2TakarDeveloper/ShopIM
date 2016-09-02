using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using ShopIM.DAL;

namespace ShopIM.UI
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

      

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string userType;
            string userName = UserNameField.Text;
            string userPasword = PasswordField.Text;
            UserContext userContext=new UserContext();
            if (userContext.ValidateUser(userName, userPasword,out userType))
            {
                Hide();

                if (userType == "Admin")
                {
                    new DashBoard(this, userName).Show();
                }
                else
                {
                    //give different dashBoard

                }
                
            }
            else
            {
                MetroMessageBox.Show(this, "Wrong Username/Passoword", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
