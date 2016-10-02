namespace ShopIM.UI.Controller
{
    partial class LogControl
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.logTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SalesLogClear = new MetroFramework.Controls.MetroButton();
            this.ProfileBox = new System.Windows.Forms.GroupBox();
            this.SalesLogTab = new MetroFramework.Controls.MetroPanel();
            this.SalesLogGrid = new MetroFramework.Controls.MetroGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UserLogClear = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UserLogTab = new MetroFramework.Controls.MetroPanel();
            this.UserLogGrid = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.logTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ProfileBox.SuspendLayout();
            this.SalesLogTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesLogGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.UserLogTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserLogGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.splitContainer1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(10, 10);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(754, 460);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.logTab);
            this.splitContainer1.Size = new System.Drawing.Size(750, 456);
            this.splitContainer1.SplitterDistance = 39;
            this.splitContainer1.TabIndex = 17;
            // 
            // logTab
            // 
            this.logTab.Controls.Add(this.tabPage1);
            this.logTab.Controls.Add(this.tabPage2);
            this.logTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTab.Location = new System.Drawing.Point(0, 0);
            this.logTab.Name = "logTab";
            this.logTab.SelectedIndex = 0;
            this.logTab.Size = new System.Drawing.Size(750, 413);
            this.logTab.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SalesLogClear);
            this.tabPage1.Controls.Add(this.ProfileBox);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sales Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SalesLogClear
            // 
            this.SalesLogClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesLogClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.SalesLogClear.Location = new System.Drawing.Point(598, 344);
            this.SalesLogClear.Name = "SalesLogClear";
            this.SalesLogClear.Size = new System.Drawing.Size(142, 33);
            this.SalesLogClear.TabIndex = 16;
            this.SalesLogClear.Text = "Clear Log";
            this.SalesLogClear.UseCustomBackColor = true;
            this.SalesLogClear.UseSelectable = true;
            this.SalesLogClear.Click += new System.EventHandler(this.SalesLogClear_Click);
            // 
            // ProfileBox
            // 
            this.ProfileBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProfileBox.Controls.Add(this.SalesLogTab);
            this.ProfileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProfileBox.Location = new System.Drawing.Point(6, 6);
            this.ProfileBox.Name = "ProfileBox";
            this.ProfileBox.Size = new System.Drawing.Size(734, 332);
            this.ProfileBox.TabIndex = 11;
            this.ProfileBox.TabStop = false;
            this.ProfileBox.Text = "Sales Log List";
            // 
            // SalesLogTab
            // 
            this.SalesLogTab.Controls.Add(this.SalesLogGrid);
            this.SalesLogTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesLogTab.HorizontalScrollbarBarColor = true;
            this.SalesLogTab.HorizontalScrollbarHighlightOnWheel = false;
            this.SalesLogTab.HorizontalScrollbarSize = 10;
            this.SalesLogTab.Location = new System.Drawing.Point(3, 18);
            this.SalesLogTab.Name = "SalesLogTab";
            this.SalesLogTab.Size = new System.Drawing.Size(728, 311);
            this.SalesLogTab.TabIndex = 0;
            this.SalesLogTab.VerticalScrollbarBarColor = true;
            this.SalesLogTab.VerticalScrollbarHighlightOnWheel = false;
            this.SalesLogTab.VerticalScrollbarSize = 10;
            // 
            // SalesLogGrid
            // 
            this.SalesLogGrid.AllowUserToAddRows = false;
            this.SalesLogGrid.AllowUserToDeleteRows = false;
            this.SalesLogGrid.AllowUserToResizeRows = false;
            this.SalesLogGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesLogGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SalesLogGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SalesLogGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SalesLogGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesLogGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SalesLogGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesLogGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.SalesLogGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesLogGrid.EnableHeadersVisualStyles = false;
            this.SalesLogGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SalesLogGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SalesLogGrid.Location = new System.Drawing.Point(0, 0);
            this.SalesLogGrid.Name = "SalesLogGrid";
            this.SalesLogGrid.ReadOnly = true;
            this.SalesLogGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesLogGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SalesLogGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SalesLogGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SalesLogGrid.Size = new System.Drawing.Size(728, 311);
            this.SalesLogGrid.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.UserLogClear);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UserLogClear
            // 
            this.UserLogClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UserLogClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.UserLogClear.Location = new System.Drawing.Point(594, 341);
            this.UserLogClear.Name = "UserLogClear";
            this.UserLogClear.Size = new System.Drawing.Size(142, 33);
            this.UserLogClear.TabIndex = 18;
            this.UserLogClear.Text = "Clear Log";
            this.UserLogClear.UseCustomBackColor = true;
            this.UserLogClear.UseSelectable = true;
            this.UserLogClear.Click += new System.EventHandler(this.UserLogClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.UserLogTab);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 329);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Log List";
            // 
            // UserLogTab
            // 
            this.UserLogTab.Controls.Add(this.UserLogGrid);
            this.UserLogTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserLogTab.HorizontalScrollbarBarColor = true;
            this.UserLogTab.HorizontalScrollbarHighlightOnWheel = false;
            this.UserLogTab.HorizontalScrollbarSize = 10;
            this.UserLogTab.Location = new System.Drawing.Point(3, 18);
            this.UserLogTab.Name = "UserLogTab";
            this.UserLogTab.Size = new System.Drawing.Size(724, 308);
            this.UserLogTab.TabIndex = 0;
            this.UserLogTab.VerticalScrollbarBarColor = true;
            this.UserLogTab.VerticalScrollbarHighlightOnWheel = false;
            this.UserLogTab.VerticalScrollbarSize = 10;
            // 
            // UserLogGrid
            // 
            this.UserLogGrid.AllowUserToAddRows = false;
            this.UserLogGrid.AllowUserToDeleteRows = false;
            this.UserLogGrid.AllowUserToResizeRows = false;
            this.UserLogGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserLogGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserLogGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UserLogGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UserLogGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserLogGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UserLogGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserLogGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.UserLogGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserLogGrid.EnableHeadersVisualStyles = false;
            this.UserLogGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserLogGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserLogGrid.Location = new System.Drawing.Point(0, 0);
            this.UserLogGrid.Name = "UserLogGrid";
            this.UserLogGrid.ReadOnly = true;
            this.UserLogGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserLogGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.UserLogGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UserLogGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserLogGrid.Size = new System.Drawing.Size(724, 308);
            this.UserLogGrid.TabIndex = 2;
            // 
            // LogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "LogControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(774, 480);
            this.metroPanel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.logTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ProfileBox.ResumeLayout(false);
            this.SalesLogTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesLogGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.UserLogTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserLogGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.GroupBox ProfileBox;
        private System.Windows.Forms.TabControl logTab;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroButton SalesLogClear;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroButton UserLogClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroPanel SalesLogTab;
        private MetroFramework.Controls.MetroGrid SalesLogGrid;
        private MetroFramework.Controls.MetroPanel UserLogTab;
        private MetroFramework.Controls.MetroGrid UserLogGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
