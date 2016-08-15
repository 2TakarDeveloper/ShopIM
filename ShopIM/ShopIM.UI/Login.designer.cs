namespace ShopIM.UI
{
    partial class Login
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
            this.UserNameField = new MetroFramework.Controls.MetroTextBox();
            this.PasswordField = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ExitButton = new MetroFramework.Controls.MetroButton();
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // UserNameField
            // 
            this.UserNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.UserNameField.CustomButton.Image = null;
            this.UserNameField.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.UserNameField.CustomButton.Name = "";
            this.UserNameField.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UserNameField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserNameField.CustomButton.TabIndex = 1;
            this.UserNameField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserNameField.CustomButton.UseSelectable = true;
            this.UserNameField.CustomButton.Visible = false;
            this.UserNameField.Lines = new string[] {
        "Admin"};
            this.UserNameField.Location = new System.Drawing.Point(167, 77);
            this.UserNameField.MaxLength = 32767;
            this.UserNameField.Name = "UserNameField";
            this.UserNameField.PasswordChar = '\0';
            this.UserNameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserNameField.SelectedText = "";
            this.UserNameField.SelectionLength = 0;
            this.UserNameField.SelectionStart = 0;
            this.UserNameField.ShortcutsEnabled = true;
            this.UserNameField.Size = new System.Drawing.Size(217, 23);
            this.UserNameField.TabIndex = 3;
            this.UserNameField.Text = "Admin";
            this.UserNameField.UseSelectable = true;
            this.UserNameField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserNameField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PasswordField
            // 
            this.PasswordField.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.PasswordField.CustomButton.Image = null;
            this.PasswordField.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.PasswordField.CustomButton.Name = "";
            this.PasswordField.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PasswordField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordField.CustomButton.TabIndex = 1;
            this.PasswordField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordField.CustomButton.UseSelectable = true;
            this.PasswordField.CustomButton.Visible = false;
            this.PasswordField.Lines = new string[] {
        "admin"};
            this.PasswordField.Location = new System.Drawing.Point(167, 106);
            this.PasswordField.MaxLength = 32767;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '●';
            this.PasswordField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordField.SelectedText = "";
            this.PasswordField.SelectionLength = 0;
            this.PasswordField.SelectionStart = 0;
            this.PasswordField.ShortcutsEnabled = true;
            this.PasswordField.Size = new System.Drawing.Size(217, 23);
            this.PasswordField.TabIndex = 3;
            this.PasswordField.Text = "admin";
            this.PasswordField.UseSelectable = true;
            this.PasswordField.UseSystemPasswordChar = true;
            this.PasswordField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(67, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "USERNAME :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(67, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "PASSWORD :";
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton.Location = new System.Drawing.Point(167, 161);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(95, 30);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "E&XIT";
            this.ExitButton.UseSelectable = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.Location = new System.Drawing.Point(286, 161);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(95, 30);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseSelectable = true;
            this.LoginButton.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 249);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.UserNameField);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox UserNameField;
        private MetroFramework.Controls.MetroTextBox PasswordField;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton ExitButton;
        private MetroFramework.Controls.MetroButton LoginButton;
    }
}

