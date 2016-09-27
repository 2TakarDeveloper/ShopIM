namespace ShopIM.UI.Controller
{
    partial class SalesControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BackgroundTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.StockInventoryGrid = new MetroFramework.Controls.MetroGrid();
            this.CartGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SplitLine = new MetroFramework.Controls.MetroPanel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.RemoveCartButton = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.table = new MetroFramework.Controls.MetroPanel();
            this.splitContainerBackgriund = new System.Windows.Forms.SplitContainer();
            this.InventoryInfoControlPanel = new System.Windows.Forms.SplitContainer();
            this.BackgroundTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockInventoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartGrid)).BeginInit();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBackgriund)).BeginInit();
            this.splitContainerBackgriund.Panel1.SuspendLayout();
            this.splitContainerBackgriund.Panel2.SuspendLayout();
            this.splitContainerBackgriund.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryInfoControlPanel)).BeginInit();
            this.InventoryInfoControlPanel.Panel2.SuspendLayout();
            this.InventoryInfoControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundTablePanel
            // 
            this.BackgroundTablePanel.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundTablePanel.ColumnCount = 4;
            this.BackgroundTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.96265F));
            this.BackgroundTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.BackgroundTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.51867F));
            this.BackgroundTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.51867F));
            this.BackgroundTablePanel.Controls.Add(this.metroPanel1, 1, 0);
            this.BackgroundTablePanel.Controls.Add(this.StockInventoryGrid, 0, 1);
            this.BackgroundTablePanel.Controls.Add(this.CartGrid, 2, 1);
            this.BackgroundTablePanel.Controls.Add(this.metroLabel1, 0, 0);
            this.BackgroundTablePanel.Controls.Add(this.metroLabel3, 2, 0);
            this.BackgroundTablePanel.Controls.Add(this.SplitLine, 0, 2);
            this.BackgroundTablePanel.Controls.Add(this.metroButton4, 0, 3);
            this.BackgroundTablePanel.Controls.Add(this.RemoveCartButton, 2, 3);
            this.BackgroundTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundTablePanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundTablePanel.Name = "BackgroundTablePanel";
            this.BackgroundTablePanel.RowCount = 4;
            this.BackgroundTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.BackgroundTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BackgroundTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.BackgroundTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.BackgroundTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BackgroundTablePanel.Size = new System.Drawing.Size(587, 473);
            this.BackgroundTablePanel.TabIndex = 3;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(288, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.BackgroundTablePanel.SetRowSpan(this.metroPanel1, 2);
            this.metroPanel1.Size = new System.Drawing.Size(1, 407);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // StockInventoryGrid
            // 
            this.StockInventoryGrid.AllowUserToAddRows = false;
            this.StockInventoryGrid.AllowUserToDeleteRows = false;
            this.StockInventoryGrid.AllowUserToResizeRows = false;
            this.StockInventoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockInventoryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StockInventoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StockInventoryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockInventoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StockInventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockInventoryGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.StockInventoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockInventoryGrid.EnableHeadersVisualStyles = false;
            this.StockInventoryGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StockInventoryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StockInventoryGrid.Location = new System.Drawing.Point(3, 43);
            this.StockInventoryGrid.Name = "StockInventoryGrid";
            this.StockInventoryGrid.ReadOnly = true;
            this.StockInventoryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockInventoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StockInventoryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StockInventoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockInventoryGrid.Size = new System.Drawing.Size(279, 367);
            this.StockInventoryGrid.Style = MetroFramework.MetroColorStyle.Teal;
            this.StockInventoryGrid.TabIndex = 8;
            this.StockInventoryGrid.Click += new System.EventHandler(this.StockInventoryGrid_Click);
            // 
            // CartGrid
            // 
            this.CartGrid.AllowUserToAddRows = false;
            this.CartGrid.AllowUserToDeleteRows = false;
            this.CartGrid.AllowUserToResizeRows = false;
            this.CartGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CartGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CartGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CartGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BackgroundTablePanel.SetColumnSpan(this.CartGrid, 2);
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CartGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.CartGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartGrid.EnableHeadersVisualStyles = false;
            this.CartGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CartGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CartGrid.Location = new System.Drawing.Point(292, 43);
            this.CartGrid.Name = "CartGrid";
            this.CartGrid.ReadOnly = true;
            this.CartGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CartGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CartGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartGrid.Size = new System.Drawing.Size(292, 367);
            this.CartGrid.Style = MetroFramework.MetroColorStyle.Teal;
            this.CartGrid.TabIndex = 7;
            this.CartGrid.Click += new System.EventHandler(this.CartGrid_Click);
            this.CartGrid.DoubleClick += new System.EventHandler(this.CartGrid_DoubleClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(0)))));
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(285, 40);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Inventory";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(0)))));
            this.BackgroundTablePanel.SetColumnSpan(this.metroLabel3, 2);
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.Location = new System.Drawing.Point(291, 0);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(296, 40);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Cart";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // SplitLine
            // 
            this.SplitLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BackgroundTablePanel.SetColumnSpan(this.SplitLine, 4);
            this.SplitLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitLine.HorizontalScrollbarBarColor = true;
            this.SplitLine.HorizontalScrollbarHighlightOnWheel = false;
            this.SplitLine.HorizontalScrollbarSize = 10;
            this.SplitLine.Location = new System.Drawing.Point(3, 416);
            this.SplitLine.Name = "SplitLine";
            this.SplitLine.Size = new System.Drawing.Size(581, 8);
            this.SplitLine.TabIndex = 5;
            this.SplitLine.UseCustomBackColor = true;
            this.SplitLine.VerticalScrollbarBarColor = true;
            this.SplitLine.VerticalScrollbarHighlightOnWheel = false;
            this.SplitLine.VerticalScrollbarSize = 10;
            // 
            // metroButton4
            // 
            this.metroButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton4.Location = new System.Drawing.Point(3, 430);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(279, 40);
            this.metroButton4.TabIndex = 5;
            this.metroButton4.Text = "Add To Cart";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // RemoveCartButton
            // 
            this.BackgroundTablePanel.SetColumnSpan(this.RemoveCartButton, 2);
            this.RemoveCartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveCartButton.Location = new System.Drawing.Point(292, 430);
            this.RemoveCartButton.Name = "RemoveCartButton";
            this.RemoveCartButton.Size = new System.Drawing.Size(292, 40);
            this.RemoveCartButton.TabIndex = 6;
            this.RemoveCartButton.Text = "Remove From Cart";
            this.RemoveCartButton.UseSelectable = true;
            this.RemoveCartButton.Click += new System.EventHandler(this.RemoveCartButton_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton2.Location = new System.Drawing.Point(0, 0);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(147, 104);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Check Out";
            this.metroButton2.UseSelectable = true;
            // 
            // table
            // 
            this.table.Controls.Add(this.BackgroundTablePanel);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.HorizontalScrollbarBarColor = true;
            this.table.HorizontalScrollbarHighlightOnWheel = false;
            this.table.HorizontalScrollbarSize = 10;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(587, 473);
            this.table.TabIndex = 4;
            this.table.VerticalScrollbarBarColor = true;
            this.table.VerticalScrollbarHighlightOnWheel = false;
            this.table.VerticalScrollbarSize = 10;
            // 
            // splitContainerBackgriund
            // 
            this.splitContainerBackgriund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBackgriund.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBackgriund.Name = "splitContainerBackgriund";
            // 
            // splitContainerBackgriund.Panel1
            // 
            this.splitContainerBackgriund.Panel1.Controls.Add(this.table);
            // 
            // splitContainerBackgriund.Panel2
            // 
            this.splitContainerBackgriund.Panel2.AccessibleName = "panel2";
            this.splitContainerBackgriund.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.splitContainerBackgriund.Panel2.Controls.Add(this.InventoryInfoControlPanel);
            this.splitContainerBackgriund.Size = new System.Drawing.Size(738, 473);
            this.splitContainerBackgriund.SplitterDistance = 587;
            this.splitContainerBackgriund.TabIndex = 5;
            // 
            // InventoryInfoControlPanel
            // 
            this.InventoryInfoControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryInfoControlPanel.Location = new System.Drawing.Point(0, 0);
            this.InventoryInfoControlPanel.Name = "InventoryInfoControlPanel";
            this.InventoryInfoControlPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // InventoryInfoControlPanel.Panel1
            // 
            this.InventoryInfoControlPanel.Panel1.AccessibleName = "Panel1";
            this.InventoryInfoControlPanel.Panel1.BackColor = System.Drawing.Color.White;
            // 
            // InventoryInfoControlPanel.Panel2
            // 
            this.InventoryInfoControlPanel.Panel2.Controls.Add(this.metroButton2);
            this.InventoryInfoControlPanel.Size = new System.Drawing.Size(147, 473);
            this.InventoryInfoControlPanel.SplitterDistance = 365;
            this.InventoryInfoControlPanel.TabIndex = 6;
            // 
            // SalesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.splitContainerBackgriund);
            this.Name = "SalesControl";
            this.Size = new System.Drawing.Size(738, 473);
            this.Load += new System.EventHandler(this.SalesControl_Load);
            this.BackgroundTablePanel.ResumeLayout(false);
            this.BackgroundTablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockInventoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartGrid)).EndInit();
            this.table.ResumeLayout(false);
            this.splitContainerBackgriund.Panel1.ResumeLayout(false);
            this.splitContainerBackgriund.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBackgriund)).EndInit();
            this.splitContainerBackgriund.ResumeLayout(false);
            this.InventoryInfoControlPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryInfoControlPanel)).EndInit();
            this.InventoryInfoControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BackgroundTablePanel;
        private MetroFramework.Controls.MetroGrid CartGrid;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel table;
        private System.Windows.Forms.SplitContainer splitContainerBackgriund;
        private MetroFramework.Controls.MetroPanel SplitLine;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton RemoveCartButton;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroGrid StockInventoryGrid;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.SplitContainer InventoryInfoControlPanel;
    }
}
