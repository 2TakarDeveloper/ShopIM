using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;
using ShopIM.Entity;
using ShopIM.Library;
using ShopIM.UI.Controller;

namespace ShopIM.UI
{
    public partial class AdminDashboard : MetroForm
    {
        private User User { get; set; }
     
        private Login Login { get; }
        public AdminDashboard(User user, Login login)
        {
            Login = login;
            User = user;
            InitializeComponent();
            if (User.UserType != "Admin")
            {
                AdminPanelButton.Dispose();
                ProductButton.Dispose();
                InventoryButton.Dispose();
                LogButton.Dispose();
               
            }

            UserButton.Text = User.UserName;
            try
            {
                using (var fileStream = new FileStream(User.ImageURL, FileMode.Open, FileAccess.Read))
                {
                    UserImage.Image = Image.FromStream(fileStream);
                    
                }

            }
            catch (Exception)
            {
                UserImage.Image = UserImage.ErrorImage;

            }


            LoadSales();
            UpdateNotification();
        }

        public static void UpdateNotification()
        {
            NotificationLink.Text = @"(" + NotificationManager.Notifications.Count + @")";
        }

        private void ExitButton_click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ProductButton_Click(object sender, EventArgs e)
        {
            var productsControl = new ProductsControl();
            metroPanelBackground.Controls.Clear();
            metroPanelBackground.Controls.Add(productsControl);
        }

        private void LoadSales()
        {
            var salesControl = new SalesControl(User.UserName);
            metroPanelBackground.Controls.Clear();
            salesControl.Dock = DockStyle.Fill;
            metroPanelBackground.Controls.Add(salesControl);
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            LoadSales();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            var inventoryControl = new InventoryControl();
            metroPanelBackground.Controls.Clear();
            inventoryControl.Dock = DockStyle.Fill;
            metroPanelBackground.Controls.Add(inventoryControl);
        }

        private void LockButton_Click(object sender, EventArgs e)
        {
            var systemForm = new SystemForm(User.UserName, Login, this);
            systemForm.ShowDialog(this);
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Login.Show();
            Close();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            var userEditControl = new UserEditControl(User,UserButton);
            metroPanelBackground.Controls.Clear();
            userEditControl.Dock = DockStyle.Fill;
            metroPanelBackground.Controls.Add(userEditControl);
        }

        private void LogButton_click(object sender, EventArgs e)
        {
            var LogControl = new LogControl();
            metroPanelBackground.Controls.Clear();
            LogControl.Dock = DockStyle.Fill;
            metroPanelBackground.Controls.Add(LogControl);
        }

        private void AdminPanelButton_Click(object sender, EventArgs e)
        {
            var adminPanelControl = new TableViewControl();
            metroPanelBackground.Controls.Clear();
            adminPanelControl.Dock = DockStyle.Fill;
            metroPanelBackground.Controls.Add(adminPanelControl);
  
        }

       

    }
}