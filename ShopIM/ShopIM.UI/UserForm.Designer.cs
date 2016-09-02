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
            this.PasswordBox1 = new MetroFramework.Controls.MetroTextBox();
            this.PasswordBox2 = new MetroFramework.Controls.MetroTextBox();
            this.UpdateButton = new MetroFramework.Controls.MetroButton();
            this.oldPass = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Aqua;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(127, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Change Password";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // PasswordBox1
            // 
            // 
            // 
            // 
            this.PasswordBox1.CustomButton.Image = null;
            this.PasswordBox1.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.PasswordBox1.CustomButton.Name = "";
            this.PasswordBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PasswordBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordBox1.CustomButton.TabIndex = 1;
            this.PasswordBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordBox1.CustomButton.UseSelectable = true;
            this.PasswordBox1.CustomButton.Visible = false;
            this.PasswordBox1.Lines = new string[0];
            this.PasswordBox1.Location = new System.Drawing.Point(23, 150);
            this.PasswordBox1.MaxLength = 32767;
            this.PasswordBox1.Name = "PasswordBox1";
            this.PasswordBox1.PasswordChar = '●';
            this.PasswordBox1.PromptText = "New Password";
            this.PasswordBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordBox1.SelectedText = "";
            this.PasswordBox1.SelectionLength = 0;
            this.PasswordBox1.SelectionStart = 0;
            this.PasswordBox1.ShortcutsEnabled = true;
            this.PasswordBox1.Size = new System.Drawing.Size(127, 23);
            this.PasswordBox1.TabIndex = 1;
            this.PasswordBox1.UseSelectable = true;
            this.PasswordBox1.UseSystemPasswordChar = true;
            this.PasswordBox1.WaterMark = "New Password";
            this.PasswordBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PasswordBox2
            // 
            // 
            // 
            // 
            this.PasswordBox2.CustomButton.Image = null;
            this.PasswordBox2.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.PasswordBox2.CustomButton.Name = "";
            this.PasswordBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PasswordBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordBox2.CustomButton.TabIndex = 1;
            this.PasswordBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordBox2.CustomButton.UseSelectable = true;
            this.PasswordBox2.CustomButton.Visible = false;
            this.PasswordBox2.Lines = new string[0];
            this.PasswordBox2.Location = new System.Drawing.Point(23, 188);
            this.PasswordBox2.MaxLength = 32767;
            this.PasswordBox2.Name = "PasswordBox2";
            this.PasswordBox2.PasswordChar = '●';
            this.PasswordBox2.PromptText = "Confirm Password";
            this.PasswordBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordBox2.SelectedText = "";
            this.PasswordBox2.SelectionLength = 0;
            this.PasswordBox2.SelectionStart = 0;
            this.PasswordBox2.ShortcutsEnabled = true;
            this.PasswordBox2.Size = new System.Drawing.Size(127, 23);
            this.PasswordBox2.TabIndex = 2;
            this.PasswordBox2.UseSelectable = true;
            this.PasswordBox2.UseSystemPasswordChar = true;
            this.PasswordBox2.WaterMark = "Confirm Password";
            this.PasswordBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(23, 232);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(127, 23);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseSelectable = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // oldPass
            // 
            // 
            // 
            // 
            this.oldPass.CustomButton.Image = null;
            this.oldPass.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.oldPass.CustomButton.Name = "";
            this.oldPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.oldPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.oldPass.CustomButton.TabIndex = 1;
            this.oldPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.oldPass.CustomButton.UseSelectable = true;
            this.oldPass.CustomButton.Visible = false;
            this.oldPass.Lines = new string[0];
            this.oldPass.Location = new System.Drawing.Point(23, 109);
            this.oldPass.MaxLength = 32767;
            this.oldPass.Name = "oldPass";
            this.oldPass.PasswordChar = '●';
            this.oldPass.PromptText = "Old Password";
            this.oldPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.oldPass.SelectedText = "";
            this.oldPass.SelectionLength = 0;
            this.oldPass.SelectionStart = 0;
            this.oldPass.ShortcutsEnabled = true;
            this.oldPass.Size = new System.Drawing.Size(127, 23);
            this.oldPass.TabIndex = 4;
            this.oldPass.UseSelectable = true;
            this.oldPass.UseSystemPasswordChar = true;
            this.oldPass.WaterMark = "Old Password";
            this.oldPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.oldPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 350);
            this.Controls.Add(this.oldPass);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.PasswordBox2);
            this.Controls.Add(this.PasswordBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UserForm";
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox PasswordBox1;
        private MetroFramework.Controls.MetroTextBox PasswordBox2;
        private MetroFramework.Controls.MetroButton UpdateButton;
        private MetroFramework.Controls.MetroTextBox oldPass;
    }
}