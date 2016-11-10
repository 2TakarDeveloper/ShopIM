namespace ShopIM.UI.Forms
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.TypePicker = new System.Windows.Forms.ComboBox();
            this.ConfirmtextBox = new MetroFramework.Controls.MetroTextBox();
            this.AddPictureBtn = new MetroFramework.Controls.MetroButton();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SubmitButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.TypePicker);
            this.metroPanel1.Controls.Add(this.ConfirmtextBox);
            this.metroPanel1.Controls.Add(this.AddPictureBtn);
            this.metroPanel1.Controls.Add(this.PasswordTextBox);
            this.metroPanel1.Controls.Add(this.NameTextBox);
            this.metroPanel1.Controls.Add(this.SubmitButton);
            this.metroPanel1.Controls.Add(this.ProductImage);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(18, 57);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.metroPanel1.Size = new System.Drawing.Size(289, 386);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // TypePicker
            // 
            this.TypePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.TypePicker.DisplayMember = "Name";
            this.TypePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypePicker.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TypePicker.FormattingEnabled = true;
            this.TypePicker.Items.AddRange(new object[] {
            "Admin",
            "Salesman"});
            this.TypePicker.Location = new System.Drawing.Point(8, 185);
            this.TypePicker.Name = "TypePicker";
            this.TypePicker.Size = new System.Drawing.Size(216, 28);
            this.TypePicker.TabIndex = 21;
            this.TypePicker.Text = "Salesman";
            // 
            // ConfirmtextBox
            // 
            this.ConfirmtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // 
            // 
            this.ConfirmtextBox.CustomButton.Image = null;
            this.ConfirmtextBox.CustomButton.Location = new System.Drawing.Point(188, 2);
            this.ConfirmtextBox.CustomButton.Name = "";
            this.ConfirmtextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.ConfirmtextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ConfirmtextBox.CustomButton.TabIndex = 1;
            this.ConfirmtextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ConfirmtextBox.CustomButton.UseSelectable = true;
            this.ConfirmtextBox.CustomButton.Visible = false;
            this.ConfirmtextBox.DisplayIcon = true;
            this.ConfirmtextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ConfirmtextBox.Lines = new string[0];
            this.ConfirmtextBox.Location = new System.Drawing.Point(8, 291);
            this.ConfirmtextBox.MaxLength = 20;
            this.ConfirmtextBox.Name = "ConfirmtextBox";
            this.ConfirmtextBox.PasswordChar = '●';
            this.ConfirmtextBox.PromptText = "Confirm Password";
            this.ConfirmtextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConfirmtextBox.SelectedText = "";
            this.ConfirmtextBox.SelectionLength = 0;
            this.ConfirmtextBox.SelectionStart = 0;
            this.ConfirmtextBox.ShortcutsEnabled = true;
            this.ConfirmtextBox.ShowClearButton = true;
            this.ConfirmtextBox.Size = new System.Drawing.Size(216, 30);
            this.ConfirmtextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.ConfirmtextBox.TabIndex = 16;
            this.ConfirmtextBox.UseCustomBackColor = true;
            this.ConfirmtextBox.UseSelectable = true;
            this.ConfirmtextBox.UseSystemPasswordChar = true;
            this.ConfirmtextBox.WaterMark = "Confirm Password";
            this.ConfirmtextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ConfirmtextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // AddPictureBtn
            // 
            this.AddPictureBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.AddPictureBtn.Location = new System.Drawing.Point(184, 8);
            this.AddPictureBtn.Name = "AddPictureBtn";
            this.AddPictureBtn.Size = new System.Drawing.Size(86, 23);
            this.AddPictureBtn.TabIndex = 15;
            this.AddPictureBtn.Text = "Upload Image";
            this.AddPictureBtn.UseCustomBackColor = true;
            this.AddPictureBtn.UseSelectable = true;
            this.AddPictureBtn.Click += new System.EventHandler(this.AddPictureBtn_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // 
            // 
            this.PasswordTextBox.CustomButton.Image = null;
            this.PasswordTextBox.CustomButton.Location = new System.Drawing.Point(188, 2);
            this.PasswordTextBox.CustomButton.Name = "";
            this.PasswordTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextBox.CustomButton.TabIndex = 1;
            this.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTextBox.CustomButton.UseSelectable = true;
            this.PasswordTextBox.CustomButton.Visible = false;
            this.PasswordTextBox.DisplayIcon = true;
            this.PasswordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.PasswordTextBox.Lines = new string[0];
            this.PasswordTextBox.Location = new System.Drawing.Point(8, 255);
            this.PasswordTextBox.MaxLength = 20;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.PromptText = "Password";
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.ShortcutsEnabled = true;
            this.PasswordTextBox.ShowClearButton = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(216, 30);
            this.PasswordTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.PasswordTextBox.TabIndex = 13;
            this.PasswordTextBox.UseCustomBackColor = true;
            this.PasswordTextBox.UseSelectable = true;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.WaterMark = "Password";
            this.PasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // 
            // 
            this.NameTextBox.CustomButton.Image = null;
            this.NameTextBox.CustomButton.Location = new System.Drawing.Point(188, 2);
            this.NameTextBox.CustomButton.Name = "";
            this.NameTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.NameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameTextBox.CustomButton.TabIndex = 1;
            this.NameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameTextBox.CustomButton.UseSelectable = true;
            this.NameTextBox.CustomButton.Visible = false;
            this.NameTextBox.DisplayIcon = true;
            this.NameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.NameTextBox.Lines = new string[0];
            this.NameTextBox.Location = new System.Drawing.Point(8, 219);
            this.NameTextBox.MaxLength = 20;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.PromptText = "Name";
            this.NameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.SelectionLength = 0;
            this.NameTextBox.SelectionStart = 0;
            this.NameTextBox.ShortcutsEnabled = true;
            this.NameTextBox.ShowClearButton = true;
            this.NameTextBox.Size = new System.Drawing.Size(216, 30);
            this.NameTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.NameTextBox.TabIndex = 12;
            this.NameTextBox.UseCustomBackColor = true;
            this.NameTextBox.UseSelectable = true;
            this.NameTextBox.WaterMark = "Name";
            this.NameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.SubmitButton.Location = new System.Drawing.Point(8, 355);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 11;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseCustomBackColor = true;
            this.SubmitButton.UseSelectable = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 411);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink1.BackColor = System.Drawing.Color.Transparent;
            this.metroLink1.Image = global::ShopIM.UI.Properties.Resources.ClosrRedBtn;
            this.metroLink1.ImageSize = 25;
            this.metroLink1.Location = new System.Drawing.Point(283, 2);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(30, 30);
            this.metroLink1.TabIndex = 5;
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // ProductImage
            // 
            this.ProductImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProductImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductImage.ErrorImage = global::ShopIM.UI.Properties.Resources.product_images_not_available_img;
            this.ProductImage.InitialImage = global::ShopIM.UI.Properties.Resources.close;
            this.ProductImage.Location = new System.Drawing.Point(8, 8);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(170, 159);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImage.TabIndex = 4;
            this.ProductImage.TabStop = false;
            // 
            // UserForm
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(325, 461);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserForm";
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton AddPictureBtn;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroTextBox NameTextBox;
        private MetroFramework.Controls.MetroButton SubmitButton;
        private System.Windows.Forms.PictureBox ProductImage;
        private MetroFramework.Controls.MetroTextBox ConfirmtextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TypePicker;
    }
}