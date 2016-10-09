namespace ShopIM.UI
{
    partial class InveontroyForm
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
            this.Type = new MetroFramework.Controls.MetroLabel();
            this.name = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.DatePicker = new MetroFramework.Controls.MetroDateTime();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ProductNamePanel = new MetroFramework.Controls.MetroPanel();
            this.ProductPicker = new System.Windows.Forms.ComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.Threashold = new System.Windows.Forms.NumericUpDown();
            this.SellingPrice = new System.Windows.Forms.NumericUpDown();
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.StockLocation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.PriceLable = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.VendorTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SubmitButton = new MetroFramework.Controls.MetroButton();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ProductNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Threashold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(79, 242);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(36, 19);
            this.Type.Style = MetroFramework.MetroColorStyle.White;
            this.Type.TabIndex = 14;
            this.Type.Text = "Type";
            this.Type.UseCustomBackColor = true;
            this.Type.UseStyleColors = true;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(79, 217);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 19);
            this.name.Style = MetroFramework.MetroColorStyle.White;
            this.name.TabIndex = 13;
            this.name.Text = "Name";
            this.name.UseCustomBackColor = true;
            this.name.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(9, 236);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Type:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(9, 211);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Name:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // ProductImage
            // 
            this.ProductImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductImage.ErrorImage = global::ShopIM.UI.Properties.Resources.product_images_not_available_img;
            this.ProductImage.Location = new System.Drawing.Point(6, 19);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(196, 189);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImage.TabIndex = 10;
            this.ProductImage.TabStop = false;
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(177, 92);
            this.Quantity.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(226, 29);
            this.Quantity.TabIndex = 16;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(177, 162);
            this.DatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(226, 29);
            this.DatePicker.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductImage);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.Type);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(11, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 332);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProductNamePanel);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.Threashold);
            this.groupBox2.Controls.Add(this.SellingPrice);
            this.groupBox2.Controls.Add(this.Price);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.StockLocation);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.PriceLable);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.VendorTextBox);
            this.groupBox2.Controls.Add(this.SubmitButton);
            this.groupBox2.Controls.Add(this.Quantity);
            this.groupBox2.Controls.Add(this.DatePicker);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(225, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 332);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventory Details";
            // 
            // ProductNamePanel
            // 
            this.ProductNamePanel.Controls.Add(this.ProductPicker);
            this.ProductNamePanel.HorizontalScrollbarBarColor = true;
            this.ProductNamePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ProductNamePanel.HorizontalScrollbarSize = 10;
            this.ProductNamePanel.Location = new System.Drawing.Point(177, 29);
            this.ProductNamePanel.Name = "ProductNamePanel";
            this.ProductNamePanel.Size = new System.Drawing.Size(226, 26);
            this.ProductNamePanel.TabIndex = 22;
            this.ProductNamePanel.UseCustomBackColor = true;
            this.ProductNamePanel.VerticalScrollbarBarColor = true;
            this.ProductNamePanel.VerticalScrollbarHighlightOnWheel = false;
            this.ProductNamePanel.VerticalScrollbarSize = 10;
            // 
            // ProductPicker
            // 
            this.ProductPicker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ProductPicker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductPicker.FormattingEnabled = true;
            this.ProductPicker.Location = new System.Drawing.Point(0, 0);
            this.ProductPicker.Name = "ProductPicker";
            this.ProductPicker.Size = new System.Drawing.Size(226, 26);
            this.ProductPicker.TabIndex = 33;
            this.ProductPicker.SelectedIndexChanged += new System.EventHandler(this.ProductPicker_SelectedIndexChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(27, 131);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(103, 25);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel10.TabIndex = 32;
            this.metroLabel10.Text = "Threashold:";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseStyleColors = true;
            // 
            // Threashold
            // 
            this.Threashold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Threashold.Location = new System.Drawing.Point(177, 127);
            this.Threashold.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Threashold.Name = "Threashold";
            this.Threashold.Size = new System.Drawing.Size(226, 29);
            this.Threashold.TabIndex = 31;
            // 
            // SellingPrice
            // 
            this.SellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingPrice.Location = new System.Drawing.Point(177, 229);
            this.SellingPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.Size = new System.Drawing.Size(226, 29);
            this.SellingPrice.TabIndex = 30;
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(177, 194);
            this.Price.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(226, 29);
            this.Price.TabIndex = 29;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(26, 264);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(131, 25);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel9.TabIndex = 28;
            this.metroLabel9.Text = "Stock Location:";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseStyleColors = true;
            // 
            // StockLocation
            // 
            // 
            // 
            // 
            this.StockLocation.CustomButton.Image = null;
            this.StockLocation.CustomButton.Location = new System.Drawing.Point(200, 2);
            this.StockLocation.CustomButton.Name = "";
            this.StockLocation.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.StockLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StockLocation.CustomButton.TabIndex = 1;
            this.StockLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StockLocation.CustomButton.UseSelectable = true;
            this.StockLocation.CustomButton.Visible = false;
            this.StockLocation.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.StockLocation.Lines = new string[0];
            this.StockLocation.Location = new System.Drawing.Point(177, 264);
            this.StockLocation.MaxLength = 32767;
            this.StockLocation.Name = "StockLocation";
            this.StockLocation.PasswordChar = '\0';
            this.StockLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StockLocation.SelectedText = "";
            this.StockLocation.SelectionLength = 0;
            this.StockLocation.SelectionStart = 0;
            this.StockLocation.ShortcutsEnabled = true;
            this.StockLocation.Size = new System.Drawing.Size(226, 28);
            this.StockLocation.TabIndex = 27;
            this.StockLocation.UseSelectable = true;
            this.StockLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StockLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(27, 234);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(110, 25);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel8.TabIndex = 26;
            this.metroLabel8.Text = "Selling Price:";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseStyleColors = true;
            // 
            // PriceLable
            // 
            this.PriceLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PriceLable.AutoSize = true;
            this.PriceLable.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PriceLable.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.PriceLable.Location = new System.Drawing.Point(27, 200);
            this.PriceLable.Name = "PriceLable";
            this.PriceLable.Size = new System.Drawing.Size(53, 25);
            this.PriceLable.Style = MetroFramework.MetroColorStyle.White;
            this.PriceLable.TabIndex = 25;
            this.PriceLable.Text = "Price:";
            this.PriceLable.UseCustomBackColor = true;
            this.PriceLable.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(27, 166);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(53, 25);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel6.TabIndex = 23;
            this.metroLabel6.Text = "Date:";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(27, 96);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(84, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Quantity:";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(27, 61);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(73, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Vendor:";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(27, 27);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(130, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Product Name:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // VendorTextBox
            // 
            // 
            // 
            // 
            this.VendorTextBox.CustomButton.Image = null;
            this.VendorTextBox.CustomButton.Location = new System.Drawing.Point(200, 2);
            this.VendorTextBox.CustomButton.Name = "";
            this.VendorTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.VendorTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VendorTextBox.CustomButton.TabIndex = 1;
            this.VendorTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VendorTextBox.CustomButton.UseSelectable = true;
            this.VendorTextBox.CustomButton.Visible = false;
            this.VendorTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.VendorTextBox.Lines = new string[0];
            this.VendorTextBox.Location = new System.Drawing.Point(177, 58);
            this.VendorTextBox.MaxLength = 32767;
            this.VendorTextBox.Name = "VendorTextBox";
            this.VendorTextBox.PasswordChar = '\0';
            this.VendorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VendorTextBox.SelectedText = "";
            this.VendorTextBox.SelectionLength = 0;
            this.VendorTextBox.SelectionStart = 0;
            this.VendorTextBox.ShortcutsEnabled = true;
            this.VendorTextBox.Size = new System.Drawing.Size(226, 28);
            this.VendorTextBox.TabIndex = 20;
            this.VendorTextBox.UseSelectable = true;
            this.VendorTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VendorTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.SubmitButton.DisplayFocus = true;
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(316, 298);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(0);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(87, 31);
            this.SubmitButton.TabIndex = 19;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseCustomBackColor = true;
            this.SubmitButton.UseCustomForeColor = true;
            this.SubmitButton.UseSelectable = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.BackColor = System.Drawing.Color.Transparent;
            this.metroLink1.Image = global::ShopIM.UI.Properties.Resources.ClosrRedBtn;
            this.metroLink1.ImageSize = 25;
            this.metroLink1.Location = new System.Drawing.Point(616, -1);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(30, 30);
            this.metroLink1.TabIndex = 21;
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // InveontroyForm
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(646, 370);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InveontroyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InveontroyForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ProductNamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Threashold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel Type;
        private MetroFramework.Controls.MetroLabel name;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox ProductImage;
        private System.Windows.Forms.NumericUpDown Quantity;
        private MetroFramework.Controls.MetroDateTime DatePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton SubmitButton;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox VendorTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel PriceLable;
        private System.Windows.Forms.NumericUpDown SellingPrice;
        private System.Windows.Forms.NumericUpDown Price;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox StockLocation;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.NumericUpDown Threashold;
        private System.Windows.Forms.ComboBox ProductPicker;
        private MetroFramework.Controls.MetroPanel ProductNamePanel;
    }
}