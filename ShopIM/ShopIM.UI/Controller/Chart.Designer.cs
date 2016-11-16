namespace ShopIM.UI.Controller
{
    partial class Chart
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
            this.backgroundPanel = new MetroFramework.Controls.MetroPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ProductBox = new System.Windows.Forms.ComboBox();
            this.TimeBox = new System.Windows.Forms.ComboBox();
            this.HeaderLbl = new MetroFramework.Controls.MetroLabel();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ColumnChartPage = new System.Windows.Forms.TabPage();
            this.ColumnChart = new LiveCharts.WinForms.CartesianChart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.SelectionBox = new System.Windows.Forms.ComboBox();
            this.backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.ColumnChartPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.backgroundPanel.Controls.Add(this.splitContainer1);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.HorizontalScrollbarBarColor = true;
            this.backgroundPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.backgroundPanel.HorizontalScrollbarSize = 10;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Padding = new System.Windows.Forms.Padding(10);
            this.backgroundPanel.Size = new System.Drawing.Size(670, 485);
            this.backgroundPanel.TabIndex = 0;
            this.backgroundPanel.VerticalScrollbarBarColor = true;
            this.backgroundPanel.VerticalScrollbarHighlightOnWheel = false;
            this.backgroundPanel.VerticalScrollbarSize = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.SelectionBox);
            this.splitContainer1.Panel1.Controls.Add(this.ProductBox);
            this.splitContainer1.Panel1.Controls.Add(this.TimeBox);
            this.splitContainer1.Panel1.Controls.Add(this.HeaderLbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.TabControl);
            this.splitContainer1.Size = new System.Drawing.Size(646, 461);
            this.splitContainer1.SplitterDistance = 48;
            this.splitContainer1.TabIndex = 2;
            // 
            // ProductBox
            // 
            this.ProductBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ProductBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBox.FormattingEnabled = true;
            this.ProductBox.Location = new System.Drawing.Point(391, 10);
            this.ProductBox.Name = "ProductBox";
            this.ProductBox.Size = new System.Drawing.Size(121, 26);
            this.ProductBox.TabIndex = 4;
            this.ProductBox.Visible = false;
            this.ProductBox.SelectedIndexChanged += new System.EventHandler(this.ProductBox_SelectedIndexChanged);
            // 
            // TimeBox
            // 
            this.TimeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeBox.FormattingEnabled = true;
            this.TimeBox.Items.AddRange(new object[] {
            "Weekly",
            "Monthly",
            "Yearly"});
            this.TimeBox.Location = new System.Drawing.Point(518, 10);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(121, 26);
            this.TimeBox.TabIndex = 2;
            this.TimeBox.Text = "Monthly";
            this.TimeBox.SelectedIndexChanged += new System.EventHandler(this.TimeBox_SelectedIndexChanged);
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.HeaderLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.HeaderLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HeaderLbl.Location = new System.Drawing.Point(9, 10);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(88, 25);
            this.HeaderLbl.Style = MetroFramework.MetroColorStyle.Silver;
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "Statistics";
            this.HeaderLbl.UseCustomBackColor = true;
            this.HeaderLbl.UseCustomForeColor = true;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ColumnChartPage);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(646, 409);
            this.TabControl.TabIndex = 0;
            // 
            // ColumnChartPage
            // 
            this.ColumnChartPage.Controls.Add(this.ColumnChart);
            this.ColumnChartPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnChartPage.Location = new System.Drawing.Point(4, 29);
            this.ColumnChartPage.Name = "ColumnChartPage";
            this.ColumnChartPage.Padding = new System.Windows.Forms.Padding(5);
            this.ColumnChartPage.Size = new System.Drawing.Size(638, 376);
            this.ColumnChartPage.TabIndex = 0;
            this.ColumnChartPage.Text = "Column Index";
            this.ColumnChartPage.UseVisualStyleBackColor = true;
            // 
            // ColumnChart
            // 
            this.ColumnChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnChart.Location = new System.Drawing.Point(5, 5);
            this.ColumnChart.Name = "ColumnChart";
            this.ColumnChart.Size = new System.Drawing.Size(628, 366);
            this.ColumnChart.TabIndex = 0;
            this.ColumnChart.Text = "cartesianChart1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pieChart);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 376);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Pie Chart";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pieChart
            // 
            this.pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart.Location = new System.Drawing.Point(3, 3);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(632, 370);
            this.pieChart.TabIndex = 0;
            this.pieChart.Text = "pieChart1";
            // 
            // SelectionBox
            // 
            this.SelectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionBox.FormattingEnabled = true;
            this.SelectionBox.Items.AddRange(new object[] {
            "Single Product",
            "Overall"});
            this.SelectionBox.Location = new System.Drawing.Point(263, 11);
            this.SelectionBox.Name = "SelectionBox";
            this.SelectionBox.Size = new System.Drawing.Size(121, 26);
            this.SelectionBox.TabIndex = 5;
            this.SelectionBox.Text = "Overall";
            this.SelectionBox.SelectedIndexChanged += new System.EventHandler(this.SelectionBox_SelectedIndexChanged);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backgroundPanel);
            this.Name = "Chart";
            this.Size = new System.Drawing.Size(670, 485);
            this.backgroundPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.ColumnChartPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel backgroundPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroLabel HeaderLbl;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ColumnChartPage;
        private LiveCharts.WinForms.CartesianChart ColumnChart;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox ProductBox;
        private System.Windows.Forms.ComboBox TimeBox;
        private LiveCharts.WinForms.PieChart pieChart;
        private System.Windows.Forms.ComboBox SelectionBox;
    }
}
