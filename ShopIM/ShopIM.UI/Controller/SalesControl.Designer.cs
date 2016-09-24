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
            this.CartGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.StockInventoryGrid = new MetroFramework.Controls.MetroGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AddtoCartButton = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.InventoryInfoControlPanel = new MetroFramework.Controls.MetroPanel();
            this.splitContainerBackgriund = new System.Windows.Forms.SplitContainer();
            this.BackgroundTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockInventoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBackgriund)).BeginInit();
            this.splitContainerBackgriund.Panel1.SuspendLayout();
            this.splitContainerBackgriund.Panel2.SuspendLayout();
            this.splitContainerBackgriund.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundTablePanel
            // 
            this.BackgroundTablePanel.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundTablePanel.ColumnCount = 3;
            this.BackgroundTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.08362F));
            this.BackgroundTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.616725F));
            this.BackgroundTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.38676F));
            this.BackgroundTablePanel.Controls.Add(this.CartGrid, 2, 1);
            this.BackgroundTablePanel.Controls.Add(this.metroLabel3, 2, 0);
            this.BackgroundTablePanel.Controls.Add(this.metroButton1, 0, 2);
            this.BackgroundTablePanel.Controls.Add(this.metroLabel1, 0, 0);
            this.BackgroundTablePanel.Controls.Add(this.StockInventoryGrid, 0, 1);
            this.BackgroundTablePanel.Controls.Add(this.splitContainer1, 1, 1);
            this.BackgroundTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundTablePanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundTablePanel.Name = "BackgroundTablePanel";
            this.BackgroundTablePanel.RowCount = 3;
            this.BackgroundTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.BackgroundTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BackgroundTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.BackgroundTablePanel.Size = new System.Drawing.Size(782, 644);
            this.BackgroundTablePanel.TabIndex = 3;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CartGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.CartGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartGrid.EnableHeadersVisualStyles = false;
            this.CartGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CartGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CartGrid.Location = new System.Drawing.Point(414, 43);
            this.CartGrid.Name = "CartGrid";
            this.CartGrid.ReadOnly = true;
            this.CartGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CartGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CartGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartGrid.Size = new System.Drawing.Size(365, 558);
            this.CartGrid.Style = MetroFramework.MetroColorStyle.Teal;
            this.CartGrid.TabIndex = 7;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(0)))));
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.Location = new System.Drawing.Point(414, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(365, 40);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Cart";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.BackgroundTablePanel.SetColumnSpan(this.metroButton1, 3);
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton1.Location = new System.Drawing.Point(3, 607);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(776, 34);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Check Out";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(0)))));
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(369, 40);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Inventory";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
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
            this.StockInventoryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockInventoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.StockInventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockInventoryGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.StockInventoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockInventoryGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StockInventoryGrid.EnableHeadersVisualStyles = false;
            this.StockInventoryGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StockInventoryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StockInventoryGrid.Location = new System.Drawing.Point(3, 43);
            this.StockInventoryGrid.Name = "StockInventoryGrid";
            this.StockInventoryGrid.ReadOnly = true;
            this.StockInventoryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockInventoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.StockInventoryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StockInventoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockInventoryGrid.Size = new System.Drawing.Size(369, 558);
            this.StockInventoryGrid.Style = MetroFramework.MetroColorStyle.Teal;
            this.StockInventoryGrid.TabIndex = 4;
            this.StockInventoryGrid.Click += new System.EventHandler(this.StockInventoryGrid_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(378, 43);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AddtoCartButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.metroButton3);
            this.splitContainer1.Size = new System.Drawing.Size(30, 558);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 8;
            // 
            // AddtoCartButton
            // 
            this.AddtoCartButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddtoCartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddtoCartButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.AddtoCartButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddtoCartButton.Location = new System.Drawing.Point(0, 0);
            this.AddtoCartButton.Name = "AddtoCartButton";
            this.AddtoCartButton.Size = new System.Drawing.Size(30, 266);
            this.AddtoCartButton.TabIndex = 0;
            this.AddtoCartButton.Text = ">>";
            this.AddtoCartButton.UseCustomBackColor = true;
            this.AddtoCartButton.UseCustomForeColor = true;
            this.AddtoCartButton.UseSelectable = true;
            this.AddtoCartButton.Click += new System.EventHandler(this.AddtoCartButton_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.ForeColor = System.Drawing.SystemColors.Control;
            this.metroButton3.Location = new System.Drawing.Point(0, 0);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(30, 288);
            this.metroButton3.TabIndex = 1;
            this.metroButton3.Text = "<<";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseCustomForeColor = true;
            this.metroButton3.UseSelectable = true;
            // 
            // InventoryInfoControlPanel
            // 
            this.InventoryInfoControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryInfoControlPanel.HorizontalScrollbarBarColor = true;
            this.InventoryInfoControlPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.InventoryInfoControlPanel.HorizontalScrollbarSize = 10;
            this.InventoryInfoControlPanel.Location = new System.Drawing.Point(0, 0);
            this.InventoryInfoControlPanel.Name = "InventoryInfoControlPanel";
            this.InventoryInfoControlPanel.Size = new System.Drawing.Size(219, 644);
            this.InventoryInfoControlPanel.TabIndex = 4;
            this.InventoryInfoControlPanel.VerticalScrollbarBarColor = true;
            this.InventoryInfoControlPanel.VerticalScrollbarHighlightOnWheel = false;
            this.InventoryInfoControlPanel.VerticalScrollbarSize = 10;
            // 
            // splitContainerBackgriund
            // 
            this.splitContainerBackgriund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBackgriund.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBackgriund.Name = "splitContainerBackgriund";
            // 
            // splitContainerBackgriund.Panel1
            // 
            this.splitContainerBackgriund.Panel1.Controls.Add(this.InventoryInfoControlPanel);
            // 
            // splitContainerBackgriund.Panel2
            // 
            this.splitContainerBackgriund.Panel2.Controls.Add(this.BackgroundTablePanel);
            this.splitContainerBackgriund.Size = new System.Drawing.Size(1005, 644);
            this.splitContainerBackgriund.SplitterDistance = 219;
            this.splitContainerBackgriund.TabIndex = 5;
            // 
            // SalesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.splitContainerBackgriund);
            this.Name = "SalesControl";
            this.Size = new System.Drawing.Size(1005, 644);
            this.Load += new System.EventHandler(this.SalesControl_Load);
            this.BackgroundTablePanel.ResumeLayout(false);
            this.BackgroundTablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockInventoryGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainerBackgriund.Panel1.ResumeLayout(false);
            this.splitContainerBackgriund.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBackgriund)).EndInit();
            this.splitContainerBackgriund.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BackgroundTablePanel;
        private MetroFramework.Controls.MetroGrid CartGrid;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid StockInventoryGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroButton AddtoCartButton;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroPanel InventoryInfoControlPanel;
        private System.Windows.Forms.SplitContainer splitContainerBackgriund;
    }
}
