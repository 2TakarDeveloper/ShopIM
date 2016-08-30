
using System;
using System.Windows.Forms;
using MetroFramework;
using ShopIM.DAL;
using ShopIM.Entity;



namespace ShopIM.UI
{
    public partial class SettingsForm : MetroFramework.Forms.MetroForm
    {
        public static Config _config;

        public delegate void UpdateNotification();

        private UpdateNotification updateNotification;

        public SettingsForm(UpdateNotification updateNotification)
        {
            this.updateNotification = updateNotification;
            InitializeComponent();
            AlertToggle.CheckState = _config.Alert != 0 ? CheckState.Checked : CheckState.Unchecked;
            QuantityThreshHold.Text = _config.ThreshHold.ToString();
        }

       

        

        

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                _config.ThreshHold = int.Parse(QuantityThreshHold.Text);
                _config.Alert = AlertToggle.Checked ? 1 : 0;

                if (!new ConfigContext().updateConfig(_config))
                    MetroMessageBox.Show(this, "Database Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MetroMessageBox.Show(this, "Settings Saved", "Notification", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, exception.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            //updateNotifications
            
            updateNotification();
            
        }
    }
}
