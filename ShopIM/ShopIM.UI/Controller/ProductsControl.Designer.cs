namespace ShopIM.UI.Controller
{
    partial class ProductsControl
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
            this.AddBtn = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.productListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.backgroundPanel.Location = new System.Drawing.Point(10, 10);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(1148, 668);
            this.backgroundPanel.TabIndex = 0;
            this.backgroundPanel.VerticalScrollbarBarColor = true;
            this.backgroundPanel.VerticalScrollbarHighlightOnWheel = false;
            this.backgroundPanel.VerticalScrollbarSize = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AddBtn);
            this.splitContainer1.Panel1.Controls.Add(this.metroButton1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.metroTextBox1);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.productListPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1144, 664);
            this.splitContainer1.SplitterDistance = 37;
            this.splitContainer1.TabIndex = 4;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(3, 5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 31);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseSelectable = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1023, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(82, 28);
            this.metroButton1.TabIndex = 21;
            this.metroButton1.Text = "Search";
            this.metroButton1.UseSelectable = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "Type",
            "Vendor",
            "Price Range"});
            this.comboBox1.Location = new System.Drawing.Point(625, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 28);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Text = "Name";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = global::ShopIM.UI.Properties.Resources.search;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.DisplayIcon = true;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox1.Icon = global::ShopIM.UI.Properties.Resources.search;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(767, 1);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Search";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.ShowClearButton = true;
            this.metroTextBox1.Size = new System.Drawing.Size(250, 30);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBox1.TabIndex = 19;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Search";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // productListPanel
            // 
            this.productListPanel.AutoScroll = true;
            this.productListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productListPanel.Location = new System.Drawing.Point(0, 0);
            this.productListPanel.Name = "productListPanel";
            this.productListPanel.Size = new System.Drawing.Size(1144, 623);
            this.productListPanel.TabIndex = 3;
            // 
            // ProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backgroundPanel);
            this.Name = "ProductsControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1168, 688);
            this.backgroundPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel backgroundPanel;
        private MetroFramework.Controls.MetroButton AddBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel productListPanel;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}
