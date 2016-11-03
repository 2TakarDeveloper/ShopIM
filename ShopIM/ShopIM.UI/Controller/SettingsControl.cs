using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopIM.BLL;
using ShopIM.Entity;
using ShopIM.Library;

namespace ShopIM.UI.Controller
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
            SettingsToggle.CheckState = SystemSettings.IsNotificationsOn ? CheckState.Checked : CheckState.Unchecked;
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (SettingsToggle.Checked)
            {
                SystemSettings.IsNotificationsOn = true;
               
            }
            else
            {
                SystemSettings.IsNotificationsOn = false;
                NotificationManager.Notifications = new List<Notification>();
            }

           
            AdminDashboard.UpdateNotification();
        }
    }
}
