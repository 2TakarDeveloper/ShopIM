using System;

using System.Windows.Forms;
using MetroFramework;
using ShopIM.DAL;

namespace ShopIM.UI
{
    public partial class VerificationForm : MetroFramework.Forms.MetroForm
    {
        private readonly string _userName;


        public delegate void Trigger(String errorMsg,VerificationForm verificationForm);

        private readonly Trigger _trigger;    

        public VerificationForm(string userName,Trigger trigger)
        {
            this._trigger = trigger;
            Text = DashBoard.IsLocked ? "Locked" : "Verify Password";
            _userName = userName;
            
            InitializeComponent();
            
        

        }

        

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (DashBoard.IsLocked ||NormalDashBoard.IsLocked)
            {
                e.Cancel = true;
            }
            

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            string password = PasswordTextBox.Text;
            var validUser = new UserContext().ValidateUser(_userName, password);
            if (validUser)
            {
                _trigger("", this);
            }
            else
            {
                _trigger("Wrong Password", this);
            }
        }
    }
}
