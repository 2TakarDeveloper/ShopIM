namespace ShopIM.UI
{
    partial class UserForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.submitButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.oldPassTextBox = new MetroFramework.Controls.MetroTextBox();
            this.newPassTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.confirmPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.ClearLogButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel1.Location = new System.Drawing.Point(23, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(127, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Change Password";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseMnemonic = false;
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.BackColor = System.Drawing.Color.Aquamarine;
            this.submitButton.ForeColor = System.Drawing.Color.Teal;
            this.submitButton.Location = new System.Drawing.Point(161, 294);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(164, 47);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseCustomBackColor = true;
            this.submitButton.UseCustomForeColor = true;
            this.submitButton.UseSelectable = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 139);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Old Password:";
            // 
            // oldPassTextBox
            // 
            // 
            // 
            // 
            this.oldPassTextBox.CustomButton.Image = null;
            this.oldPassTextBox.CustomButton.Location = new System.Drawing.Point(140, 2);
            this.oldPassTextBox.CustomButton.Name = "";
            this.oldPassTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.oldPassTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.oldPassTextBox.CustomButton.TabIndex = 1;
            this.oldPassTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.oldPassTextBox.CustomButton.UseSelectable = true;
            this.oldPassTextBox.CustomButton.Visible = false;
            this.oldPassTextBox.Lines = new string[0];
            this.oldPassTextBox.Location = new System.Drawing.Point(161, 139);
            this.oldPassTextBox.MaxLength = 32767;
            this.oldPassTextBox.Name = "oldPassTextBox";
            this.oldPassTextBox.PasswordChar = '●';
            this.oldPassTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.oldPassTextBox.SelectedText = "";
            this.oldPassTextBox.SelectionLength = 0;
            this.oldPassTextBox.SelectionStart = 0;
            this.oldPassTextBox.ShortcutsEnabled = true;
            this.oldPassTextBox.Size = new System.Drawing.Size(164, 26);
            this.oldPassTextBox.TabIndex = 6;
            this.oldPassTextBox.UseSelectable = true;
            this.oldPassTextBox.UseSystemPasswordChar = true;
            this.oldPassTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.oldPassTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // newPassTextBox
            // 
            // 
            // 
            // 
            this.newPassTextBox.CustomButton.Image = null;
            this.newPassTextBox.CustomButton.Location = new System.Drawing.Point(140, 2);
            this.newPassTextBox.CustomButton.Name = "";
            this.newPassTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.newPassTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.newPassTextBox.CustomButton.TabIndex = 1;
            this.newPassTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newPassTextBox.CustomButton.UseSelectable = true;
            this.newPassTextBox.CustomButton.Visible = false;
            this.newPassTextBox.Lines = new string[0];
            this.newPassTextBox.Location = new System.Drawing.Point(161, 185);
            this.newPassTextBox.MaxLength = 32767;
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.PasswordChar = '●';
            this.newPassTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newPassTextBox.SelectedText = "";
            this.newPassTextBox.SelectionLength = 0;
            this.newPassTextBox.SelectionStart = 0;
            this.newPassTextBox.ShortcutsEnabled = true;
            this.newPassTextBox.Size = new System.Drawing.Size(164, 26);
            this.newPassTextBox.TabIndex = 8;
            this.newPassTextBox.UseSelectable = true;
            this.newPassTextBox.UseSystemPasswordChar = true;
            this.newPassTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.newPassTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(23, 192);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(111, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "New Password:";
            // 
            // confirmPasswordTextBox
            // 
            // 
            // 
            // 
            this.confirmPasswordTextBox.CustomButton.Image = null;
            this.confirmPasswordTextBox.CustomButton.Location = new System.Drawing.Point(140, 2);
            this.confirmPasswordTextBox.CustomButton.Name = "";
            this.confirmPasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.confirmPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirmPasswordTextBox.CustomButton.TabIndex = 1;
            this.confirmPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirmPasswordTextBox.CustomButton.UseSelectable = true;
            this.confirmPasswordTextBox.CustomButton.Visible = false;
            this.confirmPasswordTextBox.Lines = new string[0];
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(161, 236);
            this.confirmPasswordTextBox.MaxLength = 32767;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '●';
            this.confirmPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirmPasswordTextBox.SelectedText = "";
            this.confirmPasswordTextBox.SelectionLength = 0;
            this.confirmPasswordTextBox.SelectionStart = 0;
            this.confirmPasswordTextBox.ShortcutsEnabled = true;
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(164, 26);
            this.confirmPasswordTextBox.TabIndex = 10;
            this.confirmPasswordTextBox.UseSelectable = true;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            this.confirmPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confirmPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(23, 236);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(135, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Confrim Password:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.metroPanel1.Controls.Add(this.ClearLogButton);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(429, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 330);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.BackColor = System.Drawing.Color.Red;
            this.ClearLogButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClearLogButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ClearLogButton.Location = new System.Drawing.Point(0, 0);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(200, 55);
            this.ClearLogButton.TabIndex = 2;
            this.ClearLogButton.Text = "Clear Log";
            this.ClearLogButton.UseCustomBackColor = true;
            this.ClearLogButton.UseCustomForeColor = true;
            this.ClearLogButton.UseMnemonic = false;
            this.ClearLogButton.UseSelectable = true;
            this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 410);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.newPassTextBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.oldPassTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UserForm";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "User Name Here";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton submitButton;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox oldPassTextBox;
        private MetroFramework.Controls.MetroTextBox newPassTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox confirmPasswordTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton ClearLogButton;
    }
}