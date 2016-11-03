namespace ShopIM.UI
{
    partial class ModifyCartItem
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
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.SellingPrice = new System.Windows.Forms.NumericUpDown();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.NameLable = new MetroFramework.Controls.MetroLabel();
            this.CancleButton = new MetroFramework.Controls.MetroLink();
            this.SubmitButton = new MetroFramework.Controls.MetroButton();
            this.SellingQuantity = new System.Windows.Forms.NumericUpDown();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductImage
            // 
            this.ProductImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductImage.ErrorImage = global::ShopIM.UI.Properties.Resources.product_images_not_available_img;
            this.ProductImage.Location = new System.Drawing.Point(23, 35);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(204, 194);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImage.TabIndex = 5;
            this.ProductImage.TabStop = false;
            // 
            // SellingPrice
            // 
            this.SellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingPrice.Location = new System.Drawing.Point(108, 257);
            this.SellingPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.Size = new System.Drawing.Size(119, 29);
            this.SellingPrice.TabIndex = 33;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(23, 261);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(53, 25);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel8.TabIndex = 32;
            this.metroLabel8.Text = "Price:";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(23, 232);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "Name:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // NameLable
            // 
            this.NameLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLable.AutoSize = true;
            this.NameLable.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.NameLable.Location = new System.Drawing.Point(108, 235);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(100, 19);
            this.NameLable.Style = MetroFramework.MetroColorStyle.White;
            this.NameLable.TabIndex = 34;
            this.NameLable.Text = "Product Name:";
            this.NameLable.UseCustomBackColor = true;
            this.NameLable.UseStyleColors = true;
            // 
            // CancleButton
            // 
            this.CancleButton.BackColor = System.Drawing.Color.Transparent;
            this.CancleButton.Image = global::ShopIM.UI.Properties.Resources.ClosrRedBtn;
            this.CancleButton.ImageSize = 25;
            this.CancleButton.Location = new System.Drawing.Point(233, 3);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(30, 30);
            this.CancleButton.TabIndex = 35;
            this.CancleButton.UseCustomBackColor = true;
            this.CancleButton.UseSelectable = true;
            this.CancleButton.Click += new System.EventHandler(this.CancleButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.SubmitButton.DisplayFocus = true;
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(140, 325);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(0);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(87, 31);
            this.SubmitButton.TabIndex = 36;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseCustomBackColor = true;
            this.SubmitButton.UseCustomForeColor = true;
            this.SubmitButton.UseSelectable = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SellingQuantity
            // 
            this.SellingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingQuantity.Location = new System.Drawing.Point(108, 293);
            this.SellingQuantity.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.SellingQuantity.Name = "SellingQuantity";
            this.SellingQuantity.Size = new System.Drawing.Size(119, 29);
            this.SellingQuantity.TabIndex = 38;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 297);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "Quantity:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // ModifyCartItem
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(270, 377);
            this.Controls.Add(this.SellingQuantity);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CancleButton);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.SellingPrice);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.ProductImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyCartItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "news";
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProductImage;
        private System.Windows.Forms.NumericUpDown SellingPrice;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel NameLable;
        private MetroFramework.Controls.MetroLink CancleButton;
        private MetroFramework.Controls.MetroButton SubmitButton;
        private System.Windows.Forms.NumericUpDown SellingQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}