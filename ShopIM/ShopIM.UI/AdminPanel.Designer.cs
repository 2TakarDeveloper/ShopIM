namespace ShopIM.UI
{
    partial class AdminPanel
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.ClearSalesLog = new MetroFramework.Controls.MetroButton();
            this.ClearLogButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.metroPanel1.Controls.Add(this.ClearSalesLog);
            this.metroPanel1.Controls.Add(this.ClearLogButton);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 318);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(323, 114);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ClearSalesLog
            // 
            this.ClearSalesLog.BackColor = System.Drawing.Color.Red;
            this.ClearSalesLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClearSalesLog.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ClearSalesLog.Location = new System.Drawing.Point(0, 55);
            this.ClearSalesLog.Name = "ClearSalesLog";
            this.ClearSalesLog.Size = new System.Drawing.Size(323, 56);
            this.ClearSalesLog.TabIndex = 3;
            this.ClearSalesLog.Text = "Clear Sales Log";
            this.ClearSalesLog.UseCustomBackColor = true;
            this.ClearSalesLog.UseCustomForeColor = true;
            this.ClearSalesLog.UseMnemonic = false;
            this.ClearSalesLog.UseSelectable = true;
            this.ClearSalesLog.Click += new System.EventHandler(this.ClearSalesLog_Click);
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.BackColor = System.Drawing.Color.Red;
            this.ClearLogButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClearLogButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ClearLogButton.Location = new System.Drawing.Point(0, 0);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(323, 55);
            this.ClearLogButton.TabIndex = 2;
            this.ClearLogButton.Text = "Clear Log";
            this.ClearLogButton.UseCustomBackColor = true;
            this.ClearLogButton.UseCustomForeColor = true;
            this.ClearLogButton.UseMnemonic = false;
            this.ClearLogButton.UseSelectable = true;
            this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroButton1);
            this.metroPanel2.Controls.Add(this.metroPanel1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(323, 432);
            this.metroPanel2.TabIndex = 12;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DarkKhaki;
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(323, 55);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "UserList";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseMnemonic = false;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 512);
            this.Controls.Add(this.metroPanel2);
            this.Name = "AdminPanel";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "User Name Here";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton ClearLogButton;
        private MetroFramework.Controls.MetroButton ClearSalesLog;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}