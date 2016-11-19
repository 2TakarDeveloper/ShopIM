namespace ShopIM.UI.Forms
{
    partial class CheckoutForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CancleButton = new MetroFramework.Controls.MetroLink();
            this.CheckoutGrid = new MetroFramework.Controls.MetroGrid();
            this.TotalLable = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.ContactTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.AddressTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CheckoutGrid)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancleButton
            // 
            this.CancleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancleButton.BackColor = System.Drawing.Color.Transparent;
            this.CancleButton.Image = global::ShopIM.UI.Properties.Resources.closebtn;
            this.CancleButton.ImageSize = 25;
            this.CancleButton.Location = new System.Drawing.Point(652, 3);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(30, 30);
            this.CancleButton.TabIndex = 36;
            this.CancleButton.UseCustomBackColor = true;
            this.CancleButton.UseSelectable = true;
            this.CancleButton.Click += new System.EventHandler(this.CancleButton_Click);
            // 
            // CheckoutGrid
            // 
            this.CheckoutGrid.AllowUserToAddRows = false;
            this.CheckoutGrid.AllowUserToDeleteRows = false;
            this.CheckoutGrid.AllowUserToResizeRows = false;
            this.CheckoutGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CheckoutGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.CheckoutGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CheckoutGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CheckoutGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckoutGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CheckoutGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CheckoutGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.CheckoutGrid.EnableHeadersVisualStyles = false;
            this.CheckoutGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CheckoutGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CheckoutGrid.Location = new System.Drawing.Point(15, 126);
            this.CheckoutGrid.Name = "CheckoutGrid";
            this.CheckoutGrid.ReadOnly = true;
            this.CheckoutGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckoutGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CheckoutGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CheckoutGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CheckoutGrid.Size = new System.Drawing.Size(654, 308);
            this.CheckoutGrid.TabIndex = 0;
            // 
            // TotalLable
            // 
            this.TotalLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLable.AutoSize = true;
            this.TotalLable.BackColor = System.Drawing.Color.Transparent;
            this.TotalLable.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TotalLable.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.TotalLable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TotalLable.Location = new System.Drawing.Point(544, 440);
            this.TotalLable.Name = "TotalLable";
            this.TotalLable.Size = new System.Drawing.Size(53, 25);
            this.TotalLable.Style = MetroFramework.MetroColorStyle.Silver;
            this.TotalLable.TabIndex = 38;
            this.TotalLable.Text = "Total:";
            this.TotalLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalLable.UseCustomBackColor = true;
            this.TotalLable.UseCustomForeColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroButton1.Location = new System.Drawing.Point(25, 450);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(126, 30);
            this.metroButton1.TabIndex = 40;
            this.metroButton1.Text = "Create Invoice";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(15, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Shop Name :";
            // 
            // NameTextBox
            // 
            // 
            // 
            // 
            this.NameTextBox.CustomButton.Image = null;
            this.NameTextBox.CustomButton.Location = new System.Drawing.Point(352, 2);
            this.NameTextBox.CustomButton.Name = "";
            this.NameTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.NameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameTextBox.CustomButton.TabIndex = 1;
            this.NameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameTextBox.CustomButton.UseSelectable = true;
            this.NameTextBox.CustomButton.Visible = false;
            this.NameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.NameTextBox.Lines = new string[] {
        "Abir Flower Shop"};
            this.NameTextBox.Location = new System.Drawing.Point(98, 18);
            this.NameTextBox.MaxLength = 32767;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.SelectionLength = 0;
            this.NameTextBox.SelectionStart = 0;
            this.NameTextBox.ShortcutsEnabled = true;
            this.NameTextBox.Size = new System.Drawing.Size(380, 30);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.Text = "Abir Flower Shop";
            this.NameTextBox.UseSelectable = true;
            this.NameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.ContactTextBox);
            this.metroPanel1.Controls.Add(this.TotalLable);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.AddressTextBox);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.CheckoutGrid);
            this.metroPanel1.Controls.Add(this.NameTextBox);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.CancleButton);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(10, 10);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(685, 480);
            this.metroPanel1.TabIndex = 41;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ContactTextBox
            // 
            // 
            // 
            // 
            this.ContactTextBox.CustomButton.Image = null;
            this.ContactTextBox.CustomButton.Location = new System.Drawing.Point(497, 2);
            this.ContactTextBox.CustomButton.Name = "";
            this.ContactTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.ContactTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ContactTextBox.CustomButton.TabIndex = 1;
            this.ContactTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ContactTextBox.CustomButton.UseSelectable = true;
            this.ContactTextBox.CustomButton.Visible = false;
            this.ContactTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ContactTextBox.Lines = new string[] {
        "Mobile : 01818655875,01943364636 ,Telephone:621858"};
            this.ContactTextBox.Location = new System.Drawing.Point(98, 54);
            this.ContactTextBox.MaxLength = 32767;
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.PasswordChar = '\0';
            this.ContactTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ContactTextBox.SelectedText = "";
            this.ContactTextBox.SelectionLength = 0;
            this.ContactTextBox.SelectionStart = 0;
            this.ContactTextBox.ShortcutsEnabled = true;
            this.ContactTextBox.Size = new System.Drawing.Size(525, 30);
            this.ContactTextBox.TabIndex = 40;
            this.ContactTextBox.Text = "Mobile : 01818655875,01943364636 ,Telephone:621858";
            this.ContactTextBox.UseSelectable = true;
            this.ContactTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ContactTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(15, 65);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 19);
            this.metroLabel3.TabIndex = 39;
            this.metroLabel3.Text = "Contact:";
            // 
            // AddressTextBox
            // 
            // 
            // 
            // 
            this.AddressTextBox.CustomButton.Image = null;
            this.AddressTextBox.CustomButton.Location = new System.Drawing.Point(497, 2);
            this.AddressTextBox.CustomButton.Name = "";
            this.AddressTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.AddressTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AddressTextBox.CustomButton.TabIndex = 1;
            this.AddressTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AddressTextBox.CustomButton.UseSelectable = true;
            this.AddressTextBox.CustomButton.Visible = false;
            this.AddressTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.AddressTextBox.Lines = new string[] {
        "2/3 hazi Golamrosul Market(2nd floor), Tinpuler Matha,Jublee Road,Chittagong."};
            this.AddressTextBox.Location = new System.Drawing.Point(98, 90);
            this.AddressTextBox.MaxLength = 32767;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.PasswordChar = '\0';
            this.AddressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AddressTextBox.SelectedText = "";
            this.AddressTextBox.SelectionLength = 0;
            this.AddressTextBox.SelectionStart = 0;
            this.AddressTextBox.ShortcutsEnabled = true;
            this.AddressTextBox.Size = new System.Drawing.Size(525, 30);
            this.AddressTextBox.TabIndex = 38;
            this.AddressTextBox.Text = "2/3 hazi Golamrosul Market(2nd floor), Tinpuler Matha,Jublee Road,Chittagong.";
            this.AddressTextBox.UseSelectable = true;
            this.AddressTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AddressTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(15, 101);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "Address :";
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(705, 500);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckoutForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckoutForm";
            ((System.ComponentModel.ISupportInitialize)(this.CheckoutGrid)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink CancleButton;
        private MetroFramework.Controls.MetroGrid CheckoutGrid;
        private MetroFramework.Controls.MetroLabel TotalLable;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox NameTextBox;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox ContactTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox AddressTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}