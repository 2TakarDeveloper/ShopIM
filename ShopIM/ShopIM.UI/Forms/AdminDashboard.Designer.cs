﻿namespace ShopIM.UI.Forms
{
    partial class AdminDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.metroPanelSide = new MetroFramework.Controls.MetroPanel();
            this.menuSidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AdminPanelButton = new MetroFramework.Controls.MetroLink();
            this.SalesButton = new MetroFramework.Controls.MetroLink();
            this.ProductButton = new MetroFramework.Controls.MetroLink();
            this.InventoryButton = new MetroFramework.Controls.MetroLink();
            this.SettingsButton = new MetroFramework.Controls.MetroLink();
            this.LockButton = new MetroFramework.Controls.MetroLink();
            this.StatisticButton = new MetroFramework.Controls.MetroLink();
            this.LogButton = new MetroFramework.Controls.MetroLink();
            this.LogoutButton = new MetroFramework.Controls.MetroLink();
            this.UserImage = new System.Windows.Forms.PictureBox();
            this.UserButton = new MetroFramework.Controls.MetroLink();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanelBackground = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.Header = new MetroFramework.Controls.MetroLabel();
            this.NotificationLink = new MetroFramework.Controls.MetroLink();
            this.ExitButton = new MetroFramework.Controls.MetroLink();
            this.SettingContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingLink = new MetroFramework.Controls.MetroLink();
            this.metroPanelSide.SuspendLayout();
            this.menuSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SettingContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelSide
            // 
            this.metroPanelSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.metroPanelSide.Controls.Add(this.UserImage);
            this.metroPanelSide.Controls.Add(this.menuSidePanel);
            this.metroPanelSide.Controls.Add(this.UserButton);
            this.metroPanelSide.Controls.Add(this.metroPanel1);
            this.metroPanelSide.HorizontalScrollbarBarColor = true;
            this.metroPanelSide.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelSide.HorizontalScrollbarSize = 10;
            this.metroPanelSide.Location = new System.Drawing.Point(0, 35);
            this.metroPanelSide.Name = "metroPanelSide";
            this.metroPanelSide.Size = new System.Drawing.Size(217, 517);
            this.metroPanelSide.TabIndex = 0;
            this.metroPanelSide.UseCustomBackColor = true;
            this.metroPanelSide.VerticalScrollbarBarColor = true;
            this.metroPanelSide.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelSide.VerticalScrollbarSize = 10;
            // 
            // menuSidePanel
            // 
            this.menuSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuSidePanel.AutoScroll = true;
            this.menuSidePanel.Controls.Add(this.AdminPanelButton);
            this.menuSidePanel.Controls.Add(this.SalesButton);
            this.menuSidePanel.Controls.Add(this.ProductButton);
            this.menuSidePanel.Controls.Add(this.InventoryButton);
            this.menuSidePanel.Controls.Add(this.SettingsButton);
            this.menuSidePanel.Controls.Add(this.LockButton);
            this.menuSidePanel.Controls.Add(this.StatisticButton);
            this.menuSidePanel.Controls.Add(this.LogButton);
            this.menuSidePanel.Controls.Add(this.LogoutButton);
            this.menuSidePanel.Location = new System.Drawing.Point(0, 80);
            this.menuSidePanel.Name = "menuSidePanel";
            this.menuSidePanel.Size = new System.Drawing.Size(217, 437);
            this.menuSidePanel.TabIndex = 19;
            // 
            // AdminPanelButton
            // 
            this.AdminPanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.AdminPanelButton.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.AdminPanelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.AdminPanelButton.Location = new System.Drawing.Point(1, 1);
            this.AdminPanelButton.Margin = new System.Windows.Forms.Padding(1);
            this.AdminPanelButton.Name = "AdminPanelButton";
            this.AdminPanelButton.Size = new System.Drawing.Size(215, 50);
            this.AdminPanelButton.Style = MetroFramework.MetroColorStyle.White;
            this.AdminPanelButton.TabIndex = 26;
            this.AdminPanelButton.Text = "Admin Panel";
            this.AdminPanelButton.UseCustomBackColor = true;
            this.AdminPanelButton.UseSelectable = true;
            this.AdminPanelButton.UseStyleColors = true;
            this.AdminPanelButton.Click += new System.EventHandler(this.AdminPanelButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.SalesButton.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.SalesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SalesButton.Location = new System.Drawing.Point(1, 53);
            this.SalesButton.Margin = new System.Windows.Forms.Padding(1);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(215, 50);
            this.SalesButton.Style = MetroFramework.MetroColorStyle.White;
            this.SalesButton.TabIndex = 25;
            this.SalesButton.Text = "Sales";
            this.SalesButton.UseCustomBackColor = true;
            this.SalesButton.UseSelectable = true;
            this.SalesButton.UseStyleColors = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ProductButton.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.ProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ProductButton.Location = new System.Drawing.Point(1, 105);
            this.ProductButton.Margin = new System.Windows.Forms.Padding(1);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(215, 50);
            this.ProductButton.Style = MetroFramework.MetroColorStyle.White;
            this.ProductButton.TabIndex = 20;
            this.ProductButton.Text = "Products";
            this.ProductButton.UseCustomBackColor = true;
            this.ProductButton.UseSelectable = true;
            this.ProductButton.UseStyleColors = true;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // InventoryButton
            // 
            this.InventoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.InventoryButton.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.InventoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.InventoryButton.Location = new System.Drawing.Point(1, 157);
            this.InventoryButton.Margin = new System.Windows.Forms.Padding(1);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(215, 50);
            this.InventoryButton.Style = MetroFramework.MetroColorStyle.White;
            this.InventoryButton.TabIndex = 21;
            this.InventoryButton.Text = "Inventory";
            this.InventoryButton.UseCustomBackColor = true;
            this.InventoryButton.UseSelectable = true;
            this.InventoryButton.UseStyleColors = true;
            this.InventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.SettingsButton.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.SettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SettingsButton.Location = new System.Drawing.Point(1, 209);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(1);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(215, 50);
            this.SettingsButton.Style = MetroFramework.MetroColorStyle.White;
            this.SettingsButton.TabIndex = 22;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseCustomBackColor = true;
            this.SettingsButton.UseSelectable = true;
            this.SettingsButton.UseStyleColors = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // LockButton
            // 
            this.LockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.LockButton.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.LockButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.LockButton.Location = new System.Drawing.Point(1, 261);
            this.LockButton.Margin = new System.Windows.Forms.Padding(1);
            this.LockButton.Name = "LockButton";
            this.LockButton.Size = new System.Drawing.Size(215, 50);
            this.LockButton.Style = MetroFramework.MetroColorStyle.White;
            this.LockButton.TabIndex = 23;
            this.LockButton.Text = "Lock";
            this.LockButton.UseCustomBackColor = true;
            this.LockButton.UseSelectable = true;
            this.LockButton.UseStyleColors = true;
            this.LockButton.Click += new System.EventHandler(this.LockButton_Click);
            // 
            // StatisticButton
            // 
            this.StatisticButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.StatisticButton.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.StatisticButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.StatisticButton.Location = new System.Drawing.Point(1, 313);
            this.StatisticButton.Margin = new System.Windows.Forms.Padding(1);
            this.StatisticButton.Name = "StatisticButton";
            this.StatisticButton.Size = new System.Drawing.Size(215, 50);
            this.StatisticButton.Style = MetroFramework.MetroColorStyle.White;
            this.StatisticButton.TabIndex = 28;
            this.StatisticButton.Text = "Statistics";
            this.StatisticButton.UseCustomBackColor = true;
            this.StatisticButton.UseSelectable = true;
            this.StatisticButton.UseStyleColors = true;
            this.StatisticButton.Click += new System.EventHandler(this.StatisticButton_Click);
            // 
            // LogButton
            // 
            this.LogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.LogButton.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.LogButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.LogButton.Location = new System.Drawing.Point(1, 365);
            this.LogButton.Margin = new System.Windows.Forms.Padding(1);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(215, 50);
            this.LogButton.Style = MetroFramework.MetroColorStyle.White;
            this.LogButton.TabIndex = 27;
            this.LogButton.Text = "Log";
            this.LogButton.UseCustomBackColor = true;
            this.LogButton.UseSelectable = true;
            this.LogButton.UseStyleColors = true;
            this.LogButton.Click += new System.EventHandler(this.LogButton_click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.LogoutButton.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.LogoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.LogoutButton.Location = new System.Drawing.Point(1, 417);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(1);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(215, 50);
            this.LogoutButton.Style = MetroFramework.MetroColorStyle.White;
            this.LogoutButton.TabIndex = 24;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseCustomBackColor = true;
            this.LogoutButton.UseSelectable = true;
            this.LogoutButton.UseStyleColors = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // UserImage
            // 
            this.UserImage.BackColor = System.Drawing.Color.Transparent;
            this.UserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UserImage.ErrorImage = global::ShopIM.UI.Properties.Resources.DefaultUserImage1;
            this.UserImage.Location = new System.Drawing.Point(0, 0);
            this.UserImage.Name = "UserImage";
            this.UserImage.Size = new System.Drawing.Size(80, 79);
            this.UserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserImage.TabIndex = 18;
            this.UserImage.TabStop = false;
            // 
            // UserButton
            // 
            this.UserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(138)))), ((int)(((byte)(212)))));
            this.UserButton.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.UserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.UserButton.Location = new System.Drawing.Point(74, 0);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(143, 79);
            this.UserButton.Style = MetroFramework.MetroColorStyle.White;
            this.UserButton.TabIndex = 16;
            this.UserButton.Text = "    User";
            this.UserButton.UseCustomBackColor = true;
            this.UserButton.UseSelectable = true;
            this.UserButton.UseStyleColors = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 78);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(217, 1);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanelBackground
            // 
            this.metroPanelBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanelBackground.AutoScroll = true;
            this.metroPanelBackground.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroPanelBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanelBackground.HorizontalScrollbar = true;
            this.metroPanelBackground.HorizontalScrollbarBarColor = true;
            this.metroPanelBackground.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelBackground.HorizontalScrollbarSize = 10;
            this.metroPanelBackground.Location = new System.Drawing.Point(223, 131);
            this.metroPanelBackground.Name = "metroPanelBackground";
            this.metroPanelBackground.Size = new System.Drawing.Size(688, 407);
            this.metroPanelBackground.TabIndex = 2;
            this.metroPanelBackground.UseCustomBackColor = true;
            this.metroPanelBackground.VerticalScrollbar = true;
            this.metroPanelBackground.VerticalScrollbarBarColor = true;
            this.metroPanelBackground.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelBackground.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.AutoScroll = true;
            this.metroPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroPanel2.Controls.Add(this.Header);
            this.metroPanel2.HorizontalScrollbar = true;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(223, 35);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(688, 79);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbar = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Header.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Header.Location = new System.Drawing.Point(3, 12);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(74, 25);
            this.Header.Style = MetroFramework.MetroColorStyle.Silver;
            this.Header.TabIndex = 2;
            this.Header.Text = "Header";
            this.Header.UseCustomBackColor = true;
            this.Header.UseStyleColors = true;
            // 
            // NotificationLink
            // 
            this.NotificationLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.NotificationLink.ForeColor = System.Drawing.SystemColors.Desktop;
            this.NotificationLink.Image = global::ShopIM.UI.Properties.Resources.Notification;
            this.NotificationLink.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NotificationLink.ImageSize = 30;
            this.NotificationLink.Location = new System.Drawing.Point(767, 0);
            this.NotificationLink.Name = "NotificationLink";
            this.NotificationLink.Size = new System.Drawing.Size(56, 35);
            this.NotificationLink.TabIndex = 21;
            this.NotificationLink.Text = "(0)";
            this.NotificationLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotificationLink.UseCustomBackColor = true;
            this.NotificationLink.UseCustomForeColor = true;
            this.NotificationLink.UseSelectable = true;
            this.NotificationLink.Click += new System.EventHandler(this.NotificationLink_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageSize = 28;
            this.ExitButton.Location = new System.Drawing.Point(876, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(35, 35);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.UseCustomBackColor = true;
            this.ExitButton.UseCustomForeColor = true;
            this.ExitButton.UseSelectable = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_click);
            // 
            // SettingContextMenu
            // 
            this.SettingContextMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem,
            this.maximizeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.lockToolStripMenuItem});
            this.SettingContextMenu.Name = "SettingContextMenu";
            this.SettingContextMenu.Size = new System.Drawing.Size(132, 76);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.maximizeToolStripMenuItem.Text = "Maximize";
            this.maximizeToolStripMenuItem.Click += new System.EventHandler(this.maximizeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 6);
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.lockToolStripMenuItem.Text = "Lock";
            this.lockToolStripMenuItem.Click += new System.EventHandler(this.lockToolStripMenuItem_Click);
            // 
            // SettingLink
            // 
            this.SettingLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingLink.BackColor = System.Drawing.Color.White;
            this.SettingLink.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SettingLink.Image = global::ShopIM.UI.Properties.Resources.Setting;
            this.SettingLink.ImageSize = 25;
            this.SettingLink.Location = new System.Drawing.Point(838, 0);
            this.SettingLink.Name = "SettingLink";
            this.SettingLink.Size = new System.Drawing.Size(35, 35);
            this.SettingLink.TabIndex = 23;
            this.SettingLink.UseCustomBackColor = true;
            this.SettingLink.UseCustomForeColor = true;
            this.SettingLink.UseSelectable = true;
            this.SettingLink.Click += new System.EventHandler(this.SettingLink_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 552);
            this.ControlBox = false;
            this.Controls.Add(this.SettingLink);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.NotificationLink);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.metroPanelBackground);
            this.Controls.Add(this.metroPanelSide);
            this.Name = "AdminDashboard";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.metroPanelSide.ResumeLayout(false);
            this.menuSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.SettingContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelSide;
        private MetroFramework.Controls.MetroPanel metroPanelBackground;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink UserButton;
        private MetroFramework.Controls.MetroLink ExitButton;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel Header;
        private MetroFramework.Controls.MetroLink LogButton;
        private MetroFramework.Controls.MetroLink AdminPanelButton;
        private MetroFramework.Controls.MetroLink SalesButton;
        private MetroFramework.Controls.MetroLink LogoutButton;
        private MetroFramework.Controls.MetroLink SettingsButton;
        private MetroFramework.Controls.MetroLink LockButton;
        private MetroFramework.Controls.MetroLink InventoryButton;
        private MetroFramework.Controls.MetroLink ProductButton;
        private System.Windows.Forms.PictureBox UserImage;
        private System.Windows.Forms.FlowLayoutPanel menuSidePanel;
        public MetroFramework.Controls.MetroLink NotificationLink;
        private MetroFramework.Controls.MetroContextMenu SettingContextMenu;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private MetroFramework.Controls.MetroLink SettingLink;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private MetroFramework.Controls.MetroLink StatisticButton;
    }
}