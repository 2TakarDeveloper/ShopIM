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
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.CloseButton = new MetroFramework.Controls.MetroLink();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.PasswordField = new MetroFramework.Controls.MetroTextBox();
            this.UserNameField = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.metroPanel2.Controls.Add(this.CloseButton);
            this.metroPanel2.Controls.Add(this.groupBox1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(349, 298);
            this.metroPanel2.TabIndex = 9;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // CloseButton
            // 
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CloseButton.Image = global::ShopIM.UI.Properties.Resources.closebtn;
            this.CloseButton.ImageSize = 25;
            this.CloseButton.Location = new System.Drawing.Point(319, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NoFocusImage = global::ShopIM.UI.Properties.Resources.closebtn;
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.UseCustomBackColor = true;
            this.CloseButton.UseCustomForeColor = true;
            this.CloseButton.UseSelectable = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.groupBox1.Controls.Add(this.metroPanel1);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.LoginButton);
            this.groupBox1.Controls.Add(this.PasswordField);
            this.groupBox1.Controls.Add(this.UserNameField);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(15, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 228);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(30, 55);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(250, 1);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(134, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 25);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Login";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.LoginButton.DisplayFocus = true;
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(30, 172);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(0);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(250, 35);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseCustomBackColor = true;
            this.LoginButton.UseCustomForeColor = true;
            this.LoginButton.UseSelectable = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // 
            // 
            this.PasswordField.CustomButton.Image = null;
            this.PasswordField.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.PasswordField.CustomButton.Name = "";
            this.PasswordField.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.PasswordField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordField.CustomButton.TabIndex = 1;
            this.PasswordField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordField.CustomButton.UseSelectable = true;
            this.PasswordField.CustomButton.Visible = false;
            this.PasswordField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.PasswordField.Lines = new string[] {
        "admin"};
            this.PasswordField.Location = new System.Drawing.Point(30, 117);
            this.PasswordField.MaxLength = 32767;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '●';

            this.PasswordField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordField.SelectedText = "";
            this.PasswordField.SelectionLength = 0;
            this.PasswordField.SelectionStart = 0;
            this.PasswordField.ShortcutsEnabled = true;
            this.PasswordField.Size = new System.Drawing.Size(250, 30);
            this.PasswordField.Style = MetroFramework.MetroColorStyle.Silver;
            this.PasswordField.TabIndex = 3;
            this.PasswordField.Text = "admin";
            this.PasswordField.UseCustomBackColor = true;
            this.PasswordField.UseSelectable = true;
            this.PasswordField.UseSystemPasswordChar = true;
            this.PasswordField.WaterMark = "Password";
            this.PasswordField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // UserNameField
            // 
            this.UserNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // 
            // 
            this.UserNameField.CustomButton.Image = null;
            this.UserNameField.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.UserNameField.CustomButton.Name = "";
            this.UserNameField.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.UserNameField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserNameField.CustomButton.TabIndex = 1;
            this.UserNameField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserNameField.CustomButton.UseSelectable = true;
            this.UserNameField.CustomButton.Visible = false;
            this.UserNameField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.UserNameField.Lines = new string[] {
        "Admin"};
            this.UserNameField.Location = new System.Drawing.Point(30, 81);
            this.UserNameField.MaxLength = 32767;
            this.UserNameField.Name = "UserNameField";
            this.UserNameField.PasswordChar = '\0';
    
            this.UserNameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserNameField.SelectedText = "";
            this.UserNameField.SelectionLength = 0;
            this.UserNameField.SelectionStart = 0;
            this.UserNameField.ShortcutsEnabled = true;
            this.UserNameField.Size = new System.Drawing.Size(250, 30);
            this.UserNameField.Style = MetroFramework.MetroColorStyle.Silver;
            this.UserNameField.TabIndex = 3;
            this.UserNameField.Text = "Admin";
            this.UserNameField.UseCustomBackColor = true;
            this.UserNameField.UseCustomForeColor = true;
            this.UserNameField.UseSelectable = true;
            this.UserNameField.WaterMark = "User ID";
            this.UserNameField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserNameField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 298);
            this.Controls.Add(this.metroPanel2);
            this.Name = "Login";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.Login_Load);
            this.metroPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLink CloseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton LoginButton;
        private MetroFramework.Controls.MetroTextBox PasswordField;
        private MetroFramework.Controls.MetroTextBox UserNameField;
    }
}

