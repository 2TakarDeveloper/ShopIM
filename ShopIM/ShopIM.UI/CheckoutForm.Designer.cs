namespace ShopIM.UI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CancleButton = new MetroFramework.Controls.MetroLink();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckoutGrid = new MetroFramework.Controls.MetroGrid();
            this.TotalLable = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckoutGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CancleButton
            // 
            this.CancleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancleButton.BackColor = System.Drawing.Color.Transparent;
            this.CancleButton.Image = global::ShopIM.UI.Properties.Resources.ClosrRedBtn;
            this.CancleButton.ImageSize = 25;
            this.CancleButton.Location = new System.Drawing.Point(663, 2);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(30, 30);
            this.CancleButton.TabIndex = 36;
            this.CancleButton.UseCustomBackColor = true;
            this.CancleButton.UseSelectable = true;
            this.CancleButton.Click += new System.EventHandler(this.CancleButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CheckoutGrid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 416);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checkout";
            // 
            // CheckoutGrid
            // 
            this.CheckoutGrid.AllowUserToAddRows = false;
            this.CheckoutGrid.AllowUserToDeleteRows = false;
            this.CheckoutGrid.AllowUserToResizeRows = false;
            this.CheckoutGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CheckoutGrid.BackgroundColor = System.Drawing.Color.DimGray;
            this.CheckoutGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CheckoutGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CheckoutGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckoutGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CheckoutGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CheckoutGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.CheckoutGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckoutGrid.EnableHeadersVisualStyles = false;
            this.CheckoutGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CheckoutGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CheckoutGrid.Location = new System.Drawing.Point(3, 22);
            this.CheckoutGrid.Name = "CheckoutGrid";
            this.CheckoutGrid.ReadOnly = true;
            this.CheckoutGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckoutGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CheckoutGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CheckoutGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CheckoutGrid.Size = new System.Drawing.Size(675, 391);
            this.CheckoutGrid.TabIndex = 0;
            // 
            // TotalLable
            // 
            this.TotalLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLable.AutoSize = true;
            this.TotalLable.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TotalLable.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.TotalLable.ForeColor = System.Drawing.SystemColors.Control;
            this.TotalLable.Location = new System.Drawing.Point(566, 457);
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
            this.metroButton1.Location = new System.Drawing.Point(15, 460);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(126, 30);
            this.metroButton1.TabIndex = 40;
            this.metroButton1.Text = "Confirm Purchase";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(705, 500);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.TotalLable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckoutForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CheckoutGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink CancleButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid CheckoutGrid;
        private MetroFramework.Controls.MetroLabel TotalLable;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}