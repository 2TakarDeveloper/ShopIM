namespace ShopIM.UI.Controller
{
    partial class SettingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SpeechToggle = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SettingsToggle = new MetroFramework.Controls.MetroToggle();
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.SpeechToggle);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.SettingsToggle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings Panel";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(64, 87);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Speech:";
            // 
            // SpeechToggle
            // 
            this.SpeechToggle.AutoSize = true;
            this.SpeechToggle.Checked = true;
            this.SpeechToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpeechToggle.Location = new System.Drawing.Point(161, 82);
            this.SpeechToggle.Name = "SpeechToggle";
            this.SpeechToggle.Size = new System.Drawing.Size(80, 24);
            this.SpeechToggle.TabIndex = 2;
            this.SpeechToggle.Text = "On";
            this.SpeechToggle.UseSelectable = true;
            this.SpeechToggle.CheckedChanged += new System.EventHandler(this.SpeechToggle_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(64, 44);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Notification:";
            // 
            // SettingsToggle
            // 
            this.SettingsToggle.AutoSize = true;
            this.SettingsToggle.Checked = true;
            this.SettingsToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SettingsToggle.Location = new System.Drawing.Point(161, 39);
            this.SettingsToggle.Name = "SettingsToggle";
            this.SettingsToggle.Size = new System.Drawing.Size(80, 24);
            this.SettingsToggle.TabIndex = 0;
            this.SettingsToggle.Text = "On";
            this.SettingsToggle.UseSelectable = true;
            this.SettingsToggle.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(64, 278);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(240, 38);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save Settings";
            this.SaveButton.UseSelectable = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(609, 380);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroToggle SettingsToggle;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle SpeechToggle;
        private MetroFramework.Controls.MetroButton SaveButton;
    }
}
