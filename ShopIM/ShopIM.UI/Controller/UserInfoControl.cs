using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopIM.Entity;

namespace ShopIM.UI.Controller
{
    public partial class UserInfoControl : UserControl
    {
        private User User { get; set; }
        public UserInfoControl(User user)
        {
            User = user;
            InitializeComponent();
            LoadUserInfo();

        }

        public void LoadUserInfo()
        {
            try
            {
                using (var fileStream = new FileStream(User.ImageURL, FileMode.Open, FileAccess.Read))
                {
                    ProductImage.Image = Image.FromStream(fileStream);
                }
            }
            catch (Exception)
            {
                ProductImage.Image = ProductImage.ErrorImage;
            }

            NameLable.Text = User.UserName;
            TypeLable.Text = User.UserType;
            PasswordLable.Text = User.UserPassword;
        }

    }
}
