namespace ShopIM.UI
{
    partial class NormalDashBoard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SalesTile = new MetroFramework.Controls.MetroTile();
            this.LockTile = new MetroFramework.Controls.MetroTile();
            this.UserTile = new MetroFramework.Controls.MetroTile();
            this.LogOutTile = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SalesTile, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LockTile, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UserTile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LogOutTile, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(713, 358);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SalesTile
            // 
            this.SalesTile.ActiveControl = null;
            this.SalesTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SalesTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesTile.Location = new System.Drawing.Point(3, 182);
            this.SalesTile.Name = "SalesTile";
            this.SalesTile.Size = new System.Drawing.Size(350, 173);
            this.SalesTile.TabIndex = 5;
            this.SalesTile.Text = "Sales";
            this.SalesTile.UseCustomBackColor = true;
            this.SalesTile.UseSelectable = true;
            this.SalesTile.Click += new System.EventHandler(this.SalesTile_Click);
            // 
            // LockTile
            // 
            this.LockTile.ActiveControl = null;
            this.LockTile.BackColor = System.Drawing.Color.Chocolate;
            this.LockTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LockTile.Location = new System.Drawing.Point(359, 3);
            this.LockTile.Name = "LockTile";
            this.LockTile.Size = new System.Drawing.Size(351, 173);
            this.LockTile.TabIndex = 4;
            this.LockTile.Text = "Lock";
            this.LockTile.UseCustomBackColor = true;
            this.LockTile.UseMnemonic = false;
            this.LockTile.UseSelectable = true;
            this.LockTile.Click += new System.EventHandler(this.LockTile_Click);
            // 
            // UserTile
            // 
            this.UserTile.ActiveControl = null;
            this.UserTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserTile.Location = new System.Drawing.Point(3, 3);
            this.UserTile.Name = "UserTile";
            this.UserTile.Size = new System.Drawing.Size(350, 173);
            this.UserTile.TabIndex = 3;
            this.UserTile.Text = "User";
            this.UserTile.UseSelectable = true;
            this.UserTile.Click += new System.EventHandler(this.UserTile_Click);
            // 
            // LogOutTile
            // 
            this.LogOutTile.ActiveControl = null;
            this.LogOutTile.BackColor = System.Drawing.Color.Green;
            this.LogOutTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogOutTile.Location = new System.Drawing.Point(359, 182);
            this.LogOutTile.Name = "LogOutTile";
            this.LogOutTile.Size = new System.Drawing.Size(351, 173);
            this.LogOutTile.TabIndex = 0;
            this.LogOutTile.Text = "Log Out";
            this.LogOutTile.UseCustomBackColor = true;
            this.LogOutTile.UseSelectable = true;
            this.LogOutTile.Click += new System.EventHandler(this.LogOutTile_Click);
            // 
            // NormalDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 438);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NormalDashBoard";
            this.Text = "DashBoard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTile SalesTile;
        private MetroFramework.Controls.MetroTile LockTile;
        private MetroFramework.Controls.MetroTile UserTile;
        private MetroFramework.Controls.MetroTile LogOutTile;
    }
}