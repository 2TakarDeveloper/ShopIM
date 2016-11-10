using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using ShopIM.Entity;
using ShopIM.Library;
using ShopIM.UI.Controller;
using System.Collections.Generic;

namespace ShopIM.UI.Forms
{
    public partial class AdminDashboard : MetroForm
    {
        
        private User User { get; set; }
        private static MetroLink Link { get; set; }
        private Login Login { get; }
        public AdminDashboard(User user, Login login)
        {
            
            Login = login;
            User = user;
            SystemSettings.IsNotificationsOn = true;
            InitializeComponent();
            Header.Text = @"Sales";
            Link = NotificationLink;
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
            
            if(SystemSettings.IsNotificationsOn)
            UpdateNotification();
        }

        public static void UpdateNotification()
        {
            
            Link.Text = @"(" + NotificationManager.Notifications.Count + @")";
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
            Header.Text = @"Products";
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
            Header.Text = @"Sales";
            LoadSales();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            var inventoryControl = new InventoryControl();
            metroPanelBackground.Controls.Clear();
            inventoryControl.Dock = DockStyle.Fill;
            metroPanelBackground.Controls.Add(inventoryControl);
            Header.Text = @"Inventory";
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
            Header.Text = @"User";
            var userEditControl = new UserEditControl(User,UserButton);
            metroPanelBackground.Controls.Clear();
            userEditControl.Dock = DockStyle.Fill;
            metroPanelBackground.Controls.Add(userEditControl);
        }

        private void LogButton_click(object sender, EventArgs e)
        {
            Header.Text = @"Logs";
            var logControl = new LogControl();
            metroPanelBackground.Controls.Clear();
            logControl.Dock = DockStyle.Fill;
            metroPanelBackground.Controls.Add(logControl);
        }

        private void AdminPanelButton_Click(object sender, EventArgs e)
        {
            Header.Text = @"Admin Panel";
            var adminPanelControl = new TableViewControl();
            metroPanelBackground.Controls.Clear();
            adminPanelControl.Dock = DockStyle.Fill;
            metroPanelBackground.Controls.Add(adminPanelControl);
  
        }

        private void NotificationLink_Click(object sender, EventArgs e)
        {
            ContextMenuStrip notificationContextMenu=new ContextMenuStrip();
            foreach (var notification in NotificationManager.Notifications)
            {
                notificationContextMenu.Items.Add(notification.message);
                
            }
            
            notificationContextMenu.Show(NotificationLink,NotificationLink.Location,ToolStripDropDownDirection.BelowLeft);
           


        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Header.Text = @"Settings";
            var settingsControl = new SettingsControl();
            metroPanelBackground.Controls.Clear();
            settingsControl.Dock = DockStyle.Fill;
            metroPanelBackground.Controls.Add(settingsControl);
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void SettingLink_Click(object sender, EventArgs e)
        {
            SettingContextMenu.Show(SettingLink, 0, SettingLink.Height);
        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var systemForm = new SystemForm(User.UserName, Login, this);
            systemForm.ShowDialog(this);
        }

        private void StatisticButton_Click(object sender, EventArgs e)
        {
            List<String> nameList = new List<string>();
            nameList.Add("January");
            nameList.Add("February");
            nameList.Add("March");

            List<double> priceList = new List<double>();
            priceList.Add(50.0);
            priceList.Add(70);
            priceList.Add(100);



            Header.Text = @"Settings";
            var charts = new Chart(nameList, priceList);
            metroPanelBackground.Controls.Clear();
            charts.Dock = DockStyle.Fill;
            metroPanelBackground.Controls.Add(charts);
        }
    }
}