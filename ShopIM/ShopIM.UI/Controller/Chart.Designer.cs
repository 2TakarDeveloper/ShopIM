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
            this.HeaderLbl = new MetroFramework.Controls.MetroLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ColumnChartPage = new System.Windows.Forms.TabPage();
            this.PriceChart = new LiveCharts.WinForms.CartesianChart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PieChart = new LiveCharts.WinForms.CartesianChart();
            this.backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.HeaderLbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(646, 461);
            this.splitContainer1.SplitterDistance = 48;
            this.splitContainer1.TabIndex = 2;
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.HeaderLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.HeaderLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HeaderLbl.Location = new System.Drawing.Point(9, 10);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(80, 25);
            this.HeaderLbl.Style = MetroFramework.MetroColorStyle.Silver;
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "Statistic";
            this.HeaderLbl.UseCustomBackColor = true;
            this.HeaderLbl.UseCustomForeColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ColumnChartPage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 409);
            this.tabControl1.TabIndex = 0;
            // 
            // ColumnChartPage
            // 
            this.ColumnChartPage.Controls.Add(this.PriceChart);
            this.ColumnChartPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnChartPage.Location = new System.Drawing.Point(4, 29);
            this.ColumnChartPage.Name = "ColumnChartPage";
            this.ColumnChartPage.Padding = new System.Windows.Forms.Padding(5);
            this.ColumnChartPage.Size = new System.Drawing.Size(638, 376);
            this.ColumnChartPage.TabIndex = 0;
            this.ColumnChartPage.Text = "Monthly Price";
            this.ColumnChartPage.UseVisualStyleBackColor = true;
            // 
            // PriceChart
            // 
            this.PriceChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceChart.Location = new System.Drawing.Point(5, 5);
            this.PriceChart.Name = "PriceChart";
            this.PriceChart.Size = new System.Drawing.Size(628, 366);
            this.PriceChart.TabIndex = 0;
            this.PriceChart.Text = "cartesianChart1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PieChart);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 376);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PieChart
            // 
            this.PieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PieChart.Location = new System.Drawing.Point(3, 3);
            this.PieChart.Name = "PieChart";
            this.PieChart.Size = new System.Drawing.Size(632, 370);
            this.PieChart.TabIndex = 1;
            this.PieChart.Text = "cartesianChart1";
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
            this.tabControl1.ResumeLayout(false);
            this.ColumnChartPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel backgroundPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroLabel HeaderLbl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ColumnChartPage;
        private LiveCharts.WinForms.CartesianChart PriceChart;
        private System.Windows.Forms.TabPage tabPage1;
        private LiveCharts.WinForms.CartesianChart PieChart;
    }
}
