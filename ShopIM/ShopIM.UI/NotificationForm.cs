using System;
using System.Collections.Generic;

using System.Windows.Forms;
using ShopIM.DAL;
using ShopIM.Entity;

namespace ShopIM.UI
{
    public partial class NotificationForm : MetroFramework.Forms.MetroForm
    {
        readonly NotificationContext _notificationContext = new NotificationContext();
        readonly List<Notification> _notifications=new List<Notification>();
        public NotificationForm()
        {
            InitializeComponent();
            NotificationGrid.DataSource = _notificationContext.GetLogs();
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

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _notificationContext.Remove(_notifications);
        }
    }
}
