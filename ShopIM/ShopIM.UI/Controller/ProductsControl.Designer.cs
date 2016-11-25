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
            this.SearchPicker = new System.Windows.Forms.ComboBox();
            this.SearchBox = new MetroFramework.Controls.MetroTextBox();
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
            this.backgroundPanel.Controls.Add(this.splitContainer1);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.HorizontalScrollbarBarColor = true;
            this.backgroundPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.backgroundPanel.HorizontalScrollbarSize = 10;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(1100, 600);
            this.backgroundPanel.TabIndex = 0;
            this.backgroundPanel.VerticalScrollbarBarColor = true;
            this.backgroundPanel.VerticalScrollbarHighlightOnWheel = false;
            this.backgroundPanel.VerticalScrollbarSize = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AddBtn);
            this.splitContainer1.Panel1.Controls.Add(this.SearchPicker);
            this.splitContainer1.Panel1.Controls.Add(this.SearchBox);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.productListPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 600);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 4;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(3, 5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 28);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseSelectable = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SearchPicker
            // 
            this.SearchPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPicker.DisplayMember = "Name";
            this.SearchPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPicker.FormattingEnabled = true;
            this.SearchPicker.Items.AddRange(new object[] {
            "Name",
            "Type"});
            this.SearchPicker.Location = new System.Drawing.Point(705, 3);
            this.SearchPicker.Name = "SearchPicker";
            this.SearchPicker.Size = new System.Drawing.Size(136, 28);
            this.SearchPicker.TabIndex = 20;
            this.SearchPicker.Text = "Name";
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.SearchBox.CustomButton.Image = global::ShopIM.UI.Properties.Resources.search;
            this.SearchBox.CustomButton.Location = new System.Drawing.Point(224, 2);
            this.SearchBox.CustomButton.Name = "";
            this.SearchBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.SearchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchBox.CustomButton.TabIndex = 1;
            this.SearchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchBox.CustomButton.UseSelectable = true;
            this.SearchBox.CustomButton.Visible = false;
            this.SearchBox.DisplayIcon = true;
            this.SearchBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.SearchBox.Icon = global::ShopIM.UI.Properties.Resources.search;
            this.SearchBox.Lines = new string[0];
            this.SearchBox.Location = new System.Drawing.Point(847, 3);
            this.SearchBox.MaxLength = 32767;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PromptText = "Search";
            this.SearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchBox.SelectedText = "";
            this.SearchBox.SelectionLength = 0;
            this.SearchBox.SelectionStart = 0;
            this.SearchBox.ShortcutsEnabled = true;
            this.SearchBox.ShowClearButton = true;
            this.SearchBox.Size = new System.Drawing.Size(250, 28);
            this.SearchBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.SearchBox.TabIndex = 19;
            this.SearchBox.UseSelectable = true;
            this.SearchBox.WaterMark = "Search";
            this.SearchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchButton_Click);
            // 
            // productListPanel
            // 
            this.productListPanel.AutoScroll = true;
            this.productListPanel.BackColor = System.Drawing.Color.White;
            this.productListPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productListPanel.Location = new System.Drawing.Point(0, 0);
            this.productListPanel.Name = "productListPanel";
            this.productListPanel.Padding = new System.Windows.Forms.Padding(10);
            this.productListPanel.Size = new System.Drawing.Size(1100, 556);
            this.productListPanel.TabIndex = 3;
            // 
            // ProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backgroundPanel);
            this.Name = "ProductsControl";
            this.Size = new System.Drawing.Size(1100, 600);
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
        private System.Windows.Forms.ComboBox SearchPicker;
        private MetroFramework.Controls.MetroTextBox SearchBox;
    }
}
