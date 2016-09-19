namespace ShopIM.UI
{
    partial class AddProductForm
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
            this.AddPictureBtn = new MetroFramework.Controls.MetroButton();
            this.VendorTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TypeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SubmitButton = new MetroFramework.Controls.MetroButton();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.AddPictureBtn);
            this.metroPanel1.Controls.Add(this.VendorTextBox);
            this.metroPanel1.Controls.Add(this.TypeTextBox);
            this.metroPanel1.Controls.Add(this.NameTextBox);
            this.metroPanel1.Controls.Add(this.SubmitButton);
            this.metroPanel1.Controls.Add(this.ProductImage);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.metroPanel1.Size = new System.Drawing.Size(441, 210);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // AddPictureBtn
            // 
            this.AddPictureBtn.Location = new System.Drawing.Point(184, 116);
            this.AddPictureBtn.Name = "AddPictureBtn";
            this.AddPictureBtn.Size = new System.Drawing.Size(75, 23);
            this.AddPictureBtn.TabIndex = 15;
            this.AddPictureBtn.Text = "Add Image";
            this.AddPictureBtn.UseSelectable = true;
            this.AddPictureBtn.Click += new System.EventHandler(this.AddPictureBtn_Click);
            // 
            // VendorTextBox
            // 
            // 
            // 
            // 
            this.VendorTextBox.CustomButton.Image = null;
            this.VendorTextBox.CustomButton.Location = new System.Drawing.Point(188, 2);
            this.VendorTextBox.CustomButton.Name = "";
            this.VendorTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.VendorTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VendorTextBox.CustomButton.TabIndex = 1;
            this.VendorTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VendorTextBox.CustomButton.UseSelectable = true;
            this.VendorTextBox.CustomButton.Visible = false;
            this.VendorTextBox.DisplayIcon = true;
            this.VendorTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.VendorTextBox.Lines = new string[0];
            this.VendorTextBox.Location = new System.Drawing.Point(184, 80);
            this.VendorTextBox.MaxLength = 20;
            this.VendorTextBox.Name = "VendorTextBox";
            this.VendorTextBox.PasswordChar = '\0';
            this.VendorTextBox.WaterMark = "Vendor";
            this.VendorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VendorTextBox.SelectedText = "";
            this.VendorTextBox.SelectionLength = 0;
            this.VendorTextBox.SelectionStart = 0;
            this.VendorTextBox.ShortcutsEnabled = true;
            this.VendorTextBox.ShowClearButton = true;
            this.VendorTextBox.Size = new System.Drawing.Size(216, 30);
            this.VendorTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.VendorTextBox.TabIndex = 14;
            this.VendorTextBox.UseSelectable = true;
            this.VendorTextBox.WaterMark = "Vendor";
            this.VendorTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VendorTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TypeTextBox
            // 
            // 
            // 
            // 
            this.TypeTextBox.CustomButton.Image = null;
            this.TypeTextBox.CustomButton.Location = new System.Drawing.Point(188, 2);
            this.TypeTextBox.CustomButton.Name = "";
            this.TypeTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TypeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TypeTextBox.CustomButton.TabIndex = 1;
            this.TypeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TypeTextBox.CustomButton.UseSelectable = true;
            this.TypeTextBox.CustomButton.Visible = false;
            this.TypeTextBox.DisplayIcon = true;
            this.TypeTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TypeTextBox.Lines = new string[0];
            this.TypeTextBox.Location = new System.Drawing.Point(184, 44);
            this.TypeTextBox.MaxLength = 20;
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.PasswordChar = '\0';
            this.TypeTextBox.WaterMark = "Type";
            this.TypeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TypeTextBox.SelectedText = "";
            this.TypeTextBox.SelectionLength = 0;
            this.TypeTextBox.SelectionStart = 0;
            this.TypeTextBox.ShortcutsEnabled = true;
            this.TypeTextBox.ShowClearButton = true;
            this.TypeTextBox.Size = new System.Drawing.Size(216, 30);
            this.TypeTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.TypeTextBox.TabIndex = 13;
            this.TypeTextBox.UseSelectable = true;
            this.TypeTextBox.WaterMark = "Type";
            this.TypeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TypeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // NameTextBox
            // 
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
            this.NameTextBox.Location = new System.Drawing.Point(184, 8);
            this.NameTextBox.MaxLength = 20;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.WaterMark = "Name";
            this.NameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.SelectionLength = 0;
            this.NameTextBox.SelectionStart = 0;
            this.NameTextBox.ShortcutsEnabled = true;
            this.NameTextBox.ShowClearButton = true;
            this.NameTextBox.Size = new System.Drawing.Size(216, 30);
            this.NameTextBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.NameTextBox.TabIndex = 12;
            this.NameTextBox.UseSelectable = true;
            this.NameTextBox.WaterMark = "Name";
            this.NameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(350, 173);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 11;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseSelectable = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ProductImage
            // 
            this.ProductImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProductImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductImage.InitialImage = global::ShopIM.UI.Properties.Resources.close;
            this.ProductImage.Location = new System.Drawing.Point(8, 8);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(170, 194);
            this.ProductImage.TabIndex = 4;
            this.ProductImage.TabStop = false;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 290);
            this.Controls.Add(this.metroPanel1);
            this.Name = "AddProductForm";
            this.Resizable = false;
            this.Text = "Header Text";
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton SubmitButton;
        private System.Windows.Forms.PictureBox ProductImage;
        private MetroFramework.Controls.MetroButton AddPictureBtn;
        private MetroFramework.Controls.MetroTextBox VendorTextBox;
        private MetroFramework.Controls.MetroTextBox TypeTextBox;
        private MetroFramework.Controls.MetroTextBox NameTextBox;
    }
}