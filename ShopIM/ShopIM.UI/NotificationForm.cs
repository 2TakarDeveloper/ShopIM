using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ShopIM.DAL;
using ShopIM.Entity;

namespace ShopIM.UI
{
    public partial class NotificationForm : MetroFramework.Forms.MetroForm
    {
     
        readonly List<Notification> _notifications=new List<Notification>();
        public  static List<Notification> Notifications= new List<Notification>();

 
        public NotificationForm()
        {
            
            InitializeComponent();
            NotificationGrid.DataSource = Notifications;
            NotificationGrid.Click += NotificationGrid_Click;
        }

        private void NotificationGrid_Click(object sender, EventArgs e)
        {
            int length = NotificationGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            for (int i = 0; i < length; i++)
            {
                Notification n = (Notification)NotificationGrid.SelectedRows[i].DataBoundItem;
                _notifications.Add(n);
            }
        }

      

       
    }
}
