namespace ShopIM.UI
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SettingsTabPane = new MetroFramework.Controls.MetroTabControl();
            this.NotificationTab = new MetroFramework.Controls.MetroTabPage();
            this.QuantityThreshHold = new MetroFramework.Controls.MetroTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.AlertToggle = new MetroFramework.Controls.MetroToggle();
            this.SettingsTabPane.SuspendLayout();
            this.NotificationTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsTabPane
            // 
            this.SettingsTabPane.Controls.Add(this.NotificationTab);
            this.SettingsTabPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsTabPane.Location = new System.Drawing.Point(20, 60);
            this.SettingsTabPane.Name = "SettingsTabPane";
            this.SettingsTabPane.SelectedIndex = 0;
            this.SettingsTabPane.Size = new System.Drawing.Size(695, 385);
            this.SettingsTabPane.TabIndex = 0;
            this.SettingsTabPane.UseSelectable = true;
            // 
            // NotificationTab
            // 
            this.NotificationTab.BackColor = System.Drawing.Color.Transparent;
            this.NotificationTab.Controls.Add(this.QuantityThreshHold);
            this.NotificationTab.Controls.Add(this.SaveButton);
            this.NotificationTab.Controls.Add(this.metroLabel2);
            this.NotificationTab.Controls.Add(this.AlertToggle);
            this.NotificationTab.HorizontalScrollbarBarColor = true;
            this.NotificationTab.HorizontalScrollbarHighlightOnWheel = false;
            this.NotificationTab.HorizontalScrollbarSize = 10;
            this.NotificationTab.Location = new System.Drawing.Point(4, 38);
            this.NotificationTab.Name = "NotificationTab";
            this.NotificationTab.Size = new System.Drawing.Size(687, 343);
            this.NotificationTab.TabIndex = 0;
            this.NotificationTab.Text = "Notification";
            this.NotificationTab.VerticalScrollbarBarColor = true;
            this.NotificationTab.VerticalScrollbarHighlightOnWheel = false;
            this.NotificationTab.VerticalScrollbarSize = 10;
            // 
            // QuantityThreshHold
            // 
            // 
            // 
            // 
            this.QuantityThreshHold.CustomButton.Image = null;
            this.QuantityThreshHold.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.QuantityThreshHold.CustomButton.Name = "";
            this.QuantityThreshHold.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.QuantityThreshHold.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QuantityThreshHold.CustomButton.TabIndex = 1;
            this.QuantityThreshHold.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QuantityThreshHold.CustomButton.UseSelectable = true;
            this.QuantityThreshHold.CustomButton.Visible = false;
            this.QuantityThreshHold.Lines = new string[0];
            this.QuantityThreshHold.Location = new System.Drawing.Point(146, 76);
            this.QuantityThreshHold.MaxLength = 32767;
            this.QuantityThreshHold.Name = "QuantityThreshHold";
            this.QuantityThreshHold.PasswordChar = '\0';
            this.QuantityThreshHold.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QuantityThreshHold.SelectedText = "";
            this.QuantityThreshHold.SelectionLength = 0;
            this.QuantityThreshHold.SelectionStart = 0;
            this.QuantityThreshHold.ShortcutsEnabled = true;
            this.QuantityThreshHold.Size = new System.Drawing.Size(122, 23);
            this.QuantityThreshHold.TabIndex = 7;
            this.QuantityThreshHold.UseSelectable = true;
            this.QuantityThreshHold.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuantityThreshHold.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LightGreen;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SaveButton.Location = new System.Drawing.Point(3, 173);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(111, 30);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save Settings";
            this.SaveButton.UseMnemonic = false;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(3, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(128, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Minimum Quanity";
            // 
            // AlertToggle
            // 
            this.AlertToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AlertToggle.AutoSize = true;
            this.AlertToggle.Checked = true;
            this.AlertToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AlertToggle.Location = new System.Drawing.Point(3, 23);
            this.AlertToggle.Name = "AlertToggle";
            this.AlertToggle.Size = new System.Drawing.Size(80, 17);
            this.AlertToggle.TabIndex = 2;
            this.AlertToggle.Text = "On";
            this.AlertToggle.UseSelectable = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 465);
            this.Controls.Add(this.SettingsTabPane);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.SettingsTabPane.ResumeLayout(false);
            this.NotificationTab.ResumeLayout(false);
            this.NotificationTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl SettingsTabPane;
        private MetroFramework.Controls.MetroTabPage NotificationTab;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle AlertToggle;
        private System.Windows.Forms.Button SaveButton;
        private MetroFramework.Controls.MetroTextBox QuantityThreshHold;
    }
}