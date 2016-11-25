using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using ShopIM.Entity;
using ShopIM.Library;
using ShopIM.UI.Controller;

namespace ShopIM.UI.Forms
{
    public partial class AdminDashboard : MetroForm
    {
        
        private User User { get;}
        private static MetroLink Link { get; set; }
        private Login Login { get; }
        static int NotificationCounter { get; set; }

        

        public AdminDashboard(User user, Login login)
        {
            
            Login = login;
            User = user;
           
            InitializeComponent();
            NotificationCounter = NotificationManager.Notifications.Count;

            SystemSettings.LoadSettings();

            Header.Text = @"Sales";
            Link = NotificationLink;
            if (User.UserType != "Admin")
            {
                AdminPanelButton.Dispose();
                ProductButton.Dispose();
                InventoryButton.Dispose();
                LogButton.Dispose();
                StatisticButton.Dispose();
               
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
            Speech.ReadString("Welcome"+User.UserName);

            LoadSales();
            
            if(SystemSettings.IsNotificationsOn)
            UpdateNotification();
       
        }

        public static void UpdateNotification()
        {
            
            Link.Text = @"(" + NotificationManager.Notifications.Count + @")";
            if(NotificationCounter== NotificationManager.Notifications.Count)return;
            NotificationCounter = NotificationManager.Notifications.Count;
            Speech.ReadString("You have " + NotificationManager.Notifications.Count + " Notification");

        }

        private void ExitButton_click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ProductButton_Click(object sender, EventArgs e)
        {
            var productsControl = new ProductsControl();
            productsControl.Dock = DockStyle.Fill;
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
            SystemSettings.IsSystemLocked = true;
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
            //Speech.ReadNotification();
            ContextMenu notificationContextMenu=new ContextMenu();
         
            foreach (var notification in NotificationManager.Notifications)
            {
                MenuItem menuItem = new MenuItem(notification.ToolTip);
                menuItem.Click += delegate { NotificationClick(notification.Name); };
                notificationContextMenu.MenuItems.Add(menuItem);
                
            }

            notificationContextMenu.Show(NotificationLink,NotificationLink.Location);
           


        }

        private void NotificationClick(string notification)
        {
            if (User.UserType != "Admin") return;
            var inventoryControl = new InventoryControl();
            metroPanelBackground.Controls.Clear();
            inventoryControl.Dock = DockStyle.Fill;
            metroPanelBackground.Controls.Add(inventoryControl);
            Header.Text = @"Inventory";
            inventoryControl.NotificationClicked(notification);
            
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
            WindowState = FormWindowState.Minimized;
        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
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
            Header.Text = @"Statistics";
            var charts = new Chart();
            metroPanelBackground.Controls.Clear();
            charts.Dock = DockStyle.Fill;
            metroPanelBackground.Controls.Add(charts);
        }
    }
}