using System;
using MetroFramework.Forms;
using ShopIM.Entity;
using ShopIM.DAL;

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

      

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string userName = UserNameField.Text;
            string userPasword = PasswordField.Text;
            User user = new User(userName,userPasword);
            LoginRepo loginRepo= new LoginRepo();
            if (loginRepo.ValidUser(user))
            {
                Console.WriteLine("UserFound");
            }


        }
    }
}
