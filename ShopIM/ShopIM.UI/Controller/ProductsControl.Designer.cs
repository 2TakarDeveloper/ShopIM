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
            this.AddBtn = new MetroFramework.Controls.MetroButton();
            this.productListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
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
            this.backgroundPanel.Location = new System.Drawing.Point(10, 10);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(1148, 668);
            this.backgroundPanel.TabIndex = 0;
            this.backgroundPanel.VerticalScrollbarBarColor = true;
            this.backgroundPanel.VerticalScrollbarHighlightOnWheel = false;
            this.backgroundPanel.VerticalScrollbarSize = 10;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(1051, 5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 31);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseSelectable = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // productListPanel
            // 
            this.productListPanel.AutoScroll = true;
            this.productListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productListPanel.Location = new System.Drawing.Point(0, 0);
            this.productListPanel.Name = "productListPanel";
            this.productListPanel.Size = new System.Drawing.Size(1148, 625);
            this.productListPanel.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AddBtn);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.productListPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1148, 668);
            this.splitContainer1.SplitterDistance = 39;
            this.splitContainer1.TabIndex = 4;
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
    }
}
