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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.ProfileBox = new System.Windows.Forms.GroupBox();
            this.AddPictureBtn = new MetroFramework.Controls.MetroButton();
            this.flowPanelLog = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanel1.SuspendLayout();
            this.ProfileBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.ProfileBox);
            this.metroPanel1.Controls.Add(this.AddPictureBtn);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(10, 10);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(746, 460);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ProfileBox
            // 
            this.ProfileBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProfileBox.Controls.Add(this.flowPanelLog);
            this.ProfileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProfileBox.Location = new System.Drawing.Point(15, 13);
            this.ProfileBox.Name = "ProfileBox";
            this.ProfileBox.Size = new System.Drawing.Size(715, 405);
            this.ProfileBox.TabIndex = 11;
            this.ProfileBox.TabStop = false;
            this.ProfileBox.Text = "Log Details";
            // 
            // AddPictureBtn
            // 
            this.AddPictureBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPictureBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.AddPictureBtn.Location = new System.Drawing.Point(582, 421);
            this.AddPictureBtn.Name = "AddPictureBtn";
            this.AddPictureBtn.Size = new System.Drawing.Size(142, 33);
            this.AddPictureBtn.TabIndex = 15;
            this.AddPictureBtn.Text = "Clear Log";
            this.AddPictureBtn.UseCustomBackColor = true;
            this.AddPictureBtn.UseSelectable = true;
            // 
            // flowPanelLog
            // 
            this.flowPanelLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelLog.Location = new System.Drawing.Point(3, 18);
            this.flowPanelLog.Name = "flowPanelLog";
            this.flowPanelLog.Size = new System.Drawing.Size(709, 384);
            this.flowPanelLog.TabIndex = 0;
            // 
            // LogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "LogControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(766, 480);
            this.metroPanel1.ResumeLayout(false);
            this.ProfileBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.GroupBox ProfileBox;
        private System.Windows.Forms.FlowLayoutPanel flowPanelLog;
        private MetroFramework.Controls.MetroButton AddPictureBtn;
    }
}
