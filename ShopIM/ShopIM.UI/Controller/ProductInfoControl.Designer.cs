namespace ShopIM.UI.Controller
{
    partial class ProductInfoControl
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Type = new MetroFramework.Controls.MetroLabel();
            this.nameLable = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.EditButton = new MetroFramework.Controls.MetroLink();
            this.CrossButton = new MetroFramework.Controls.MetroLink();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.Type);
            this.metroPanel1.Controls.Add(this.nameLable);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.ProductImage);
            this.metroPanel1.Controls.Add(this.EditButton);
            this.metroPanel1.Controls.Add(this.CrossButton);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.metroPanel1.Size = new System.Drawing.Size(180, 250);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Type
            // 
            this.Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Type.AutoSize = true;
            this.Type.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Type.Location = new System.Drawing.Point(74, 211);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(50, 25);
            this.Type.TabIndex = 9;
            this.Type.Text = "Type:";
            // 
            // nameLable
            // 
            this.nameLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLable.AutoSize = true;
            this.nameLable.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.nameLable.Location = new System.Drawing.Point(74, 186);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(62, 25);
            this.nameLable.TabIndex = 8;
            this.nameLable.Text = "Name:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(8, 211);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 25);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Type:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(8, 186);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Name:";
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Location = new System.Drawing.Point(95, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(55, 23);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseSelectable = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CrossButton
            // 
            this.CrossButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrossButton.Location = new System.Drawing.Point(142, 3);
            this.CrossButton.Name = "CrossButton";
            this.CrossButton.Size = new System.Drawing.Size(35, 23);
            this.CrossButton.TabIndex = 2;
            this.CrossButton.Text = "X";
            this.CrossButton.UseSelectable = true;
            this.CrossButton.Click += new System.EventHandler(this.CrossButton_Click);
            // 
            // ProductImage
            // 
            this.ProductImage.ErrorImage = global::ShopIM.UI.Properties.Resources.product_images_not_available_img;
            this.ProductImage.Location = new System.Drawing.Point(8, 29);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(162, 154);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImage.TabIndex = 4;
            this.ProductImage.TabStop = false;
            // 
            // ProductInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "ProductInfoControl";
            this.Size = new System.Drawing.Size(180, 250);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox ProductImage;
        private MetroFramework.Controls.MetroLink EditButton;
        private MetroFramework.Controls.MetroLink CrossButton;
        private MetroFramework.Controls.MetroLabel Type;
        private MetroFramework.Controls.MetroLabel nameLable;
    }
}
