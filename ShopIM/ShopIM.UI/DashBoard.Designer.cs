namespace ShopIM.UI
{
    partial class DashBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabPane = new MetroFramework.Controls.MetroTabControl();
            this.HomeTab = new MetroFramework.Controls.MetroTabPage();
            this.TileHolder = new System.Windows.Forms.TableLayoutPanel();
            this.userTile = new MetroFramework.Controls.MetroTile();
            this.notificationTile = new MetroFramework.Controls.MetroTile();
            this.settingsTile = new MetroFramework.Controls.MetroTile();
            this.logTile = new MetroFramework.Controls.MetroTile();
            this.salesTile = new MetroFramework.Controls.MetroTile();
            this.LockTile = new MetroFramework.Controls.MetroTile();
            this.ProductTab = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.AddButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel9 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel10 = new MetroFramework.Controls.MetroPanel();
            this.vendorTextbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel11 = new MetroFramework.Controls.MetroPanel();
            this.typeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel12 = new MetroFramework.Controls.MetroPanel();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.ProductGrid = new MetroFramework.Controls.MetroGrid();
            this.InventoryTab = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.InventoryRemove = new MetroFramework.Controls.MetroButton();
            this.InventoryEditButton = new MetroFramework.Controls.MetroButton();
            this.InventoryAddButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.DatePicker = new MetroFramework.Controls.MetroDateTime();
            this.PurchaseDateLable = new MetroFramework.Controls.MetroLabel();
            this.QuantityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.QuantityLable = new MetroFramework.Controls.MetroLabel();
            this.PriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ProductPicker = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.InventoryGrid = new MetroFramework.Controls.MetroGrid();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.TabPane.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.TileHolder.SuspendLayout();
            this.ProductTab.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel9.SuspendLayout();
            this.metroPanel10.SuspendLayout();
            this.metroPanel11.SuspendLayout();
            this.metroPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).BeginInit();
            this.InventoryTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabPane
            // 
            this.TabPane.Controls.Add(this.HomeTab);
            this.TabPane.Controls.Add(this.ProductTab);
            this.TabPane.Controls.Add(this.InventoryTab);
            this.TabPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPane.Location = new System.Drawing.Point(20, 60);
            this.TabPane.Name = "TabPane";
            this.TabPane.SelectedIndex = 0;
            this.TabPane.Size = new System.Drawing.Size(677, 436);
            this.TabPane.TabIndex = 0;
            this.TabPane.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TabPane.UseSelectable = true;
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.TileHolder);
            this.HomeTab.HorizontalScrollbarBarColor = true;
            this.HomeTab.HorizontalScrollbarHighlightOnWheel = false;
            this.HomeTab.HorizontalScrollbarSize = 10;
            this.HomeTab.Location = new System.Drawing.Point(4, 38);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(10);
            this.HomeTab.Size = new System.Drawing.Size(669, 394);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.VerticalScrollbarBarColor = true;
            this.HomeTab.VerticalScrollbarHighlightOnWheel = false;
            this.HomeTab.VerticalScrollbarSize = 10;
            // 
            // TileHolder
            // 
            this.TileHolder.ColumnCount = 4;
            this.TileHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.47619F));
            this.TileHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.52381F));
            this.TileHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.TileHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.TileHolder.Controls.Add(this.userTile, 0, 0);
            this.TileHolder.Controls.Add(this.notificationTile, 2, 0);
            this.TileHolder.Controls.Add(this.settingsTile, 3, 0);
            this.TileHolder.Controls.Add(this.logTile, 1, 0);
            this.TileHolder.Controls.Add(this.salesTile, 0, 1);
            this.TileHolder.Controls.Add(this.LockTile, 3, 1);
            this.TileHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TileHolder.Location = new System.Drawing.Point(10, 10);
            this.TileHolder.Name = "TileHolder";
            this.TileHolder.RowCount = 2;
            this.TileHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.53476F));
            this.TileHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.46524F));
            this.TileHolder.Size = new System.Drawing.Size(649, 374);
            this.TileHolder.TabIndex = 7;
            // 
            // userTile
            // 
            this.userTile.ActiveControl = null;
            this.userTile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.userTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTile.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.userTile.Location = new System.Drawing.Point(3, 3);
            this.userTile.Name = "userTile";
            this.userTile.Size = new System.Drawing.Size(145, 183);
            this.userTile.TabIndex = 2;
            this.userTile.Text = "User";
            this.userTile.UseCustomBackColor = true;
            this.userTile.UseMnemonic = false;
            this.userTile.UseSelectable = true;
            this.userTile.Click += new System.EventHandler(this.userTile_Click);
            // 
            // notificationTile
            // 
            this.notificationTile.ActiveControl = null;
            this.notificationTile.BackColor = System.Drawing.Color.DarkSlateGray;
            this.notificationTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationTile.Location = new System.Drawing.Point(302, 3);
            this.notificationTile.Name = "notificationTile";
            this.TileHolder.SetRowSpan(this.notificationTile, 2);
            this.notificationTile.Size = new System.Drawing.Size(175, 368);
            this.notificationTile.TabIndex = 5;
            this.notificationTile.Text = "Notification";
            this.notificationTile.UseCustomBackColor = true;
            this.notificationTile.UseSelectable = true;
            this.notificationTile.Click += new System.EventHandler(this.notificationTile_Click);
            // 
            // settingsTile
            // 
            this.settingsTile.ActiveControl = null;
            this.settingsTile.BackColor = System.Drawing.Color.Violet;
            this.settingsTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTile.Location = new System.Drawing.Point(483, 3);
            this.settingsTile.Name = "settingsTile";
            this.settingsTile.Size = new System.Drawing.Size(163, 183);
            this.settingsTile.TabIndex = 6;
            this.settingsTile.Text = "Settings";
            this.settingsTile.UseCustomBackColor = true;
            this.settingsTile.UseSelectable = true;
            this.settingsTile.Click += new System.EventHandler(this.settingsTile_Click);
            // 
            // logTile
            // 
            this.logTile.ActiveControl = null;
            this.logTile.BackColor = System.Drawing.Color.YellowGreen;
            this.logTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTile.Location = new System.Drawing.Point(154, 3);
            this.logTile.Name = "logTile";
            this.logTile.Size = new System.Drawing.Size(142, 183);
            this.logTile.TabIndex = 4;
            this.logTile.Text = "Log";
            this.logTile.UseCustomBackColor = true;
            this.logTile.UseMnemonic = false;
            this.logTile.UseSelectable = true;
            this.logTile.Click += new System.EventHandler(this.logTile_Click);
            // 
            // salesTile
            // 
            this.salesTile.ActiveControl = null;
            this.salesTile.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TileHolder.SetColumnSpan(this.salesTile, 2);
            this.salesTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesTile.Location = new System.Drawing.Point(3, 192);
            this.salesTile.Name = "salesTile";
            this.salesTile.Size = new System.Drawing.Size(293, 179);
            this.salesTile.TabIndex = 3;
            this.salesTile.Text = "Sales";
            this.salesTile.UseCustomBackColor = true;
            this.salesTile.UseSelectable = true;
            this.salesTile.Click += new System.EventHandler(this.salesTile_Click);
            // 
            // LockTile
            // 
            this.LockTile.ActiveControl = null;
            this.LockTile.BackColor = System.Drawing.Color.Bisque;
            this.LockTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LockTile.Location = new System.Drawing.Point(483, 192);
            this.LockTile.Name = "LockTile";
            this.LockTile.Size = new System.Drawing.Size(163, 179);
            this.LockTile.TabIndex = 7;
            this.LockTile.Text = "Lock";
            this.LockTile.UseCustomBackColor = true;
            this.LockTile.UseCustomForeColor = true;
            this.LockTile.UseMnemonic = false;
            this.LockTile.UseSelectable = true;
            this.LockTile.Click += new System.EventHandler(this.LockTile_Click);
            // 
            // ProductTab
            // 
            this.ProductTab.Controls.Add(this.tableLayoutPanel5);
            this.ProductTab.HorizontalScrollbarBarColor = true;
            this.ProductTab.HorizontalScrollbarHighlightOnWheel = false;
            this.ProductTab.HorizontalScrollbarSize = 10;
            this.ProductTab.Location = new System.Drawing.Point(4, 38);
            this.ProductTab.Name = "ProductTab";
            this.ProductTab.Padding = new System.Windows.Forms.Padding(10);
            this.ProductTab.Size = new System.Drawing.Size(669, 394);
            this.ProductTab.TabIndex = 1;
            this.ProductTab.Text = "Product";
            this.ProductTab.VerticalScrollbarBarColor = true;
            this.ProductTab.VerticalScrollbarHighlightOnWheel = false;
            this.ProductTab.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.21264F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.78736F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.ProductGrid, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(649, 374);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.metroPanel5, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.metroPanel9, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.53261F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.46739F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(242, 368);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.metroButton1);
            this.metroPanel5.Controls.Add(this.metroButton2);
            this.metroPanel5.Controls.Add(this.AddButton);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(3, 291);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(236, 74);
            this.metroPanel5.TabIndex = 0;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.AutoSize = true;
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton1.Location = new System.Drawing.Point(0, 46);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(236, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Delete";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.DeleteButton_Product_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.AutoSize = true;
            this.metroButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton2.Location = new System.Drawing.Point(0, 23);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(236, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Edit";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(236, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseSelectable = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // metroPanel9
            // 
            this.metroPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroPanel9.Controls.Add(this.metroPanel10);
            this.metroPanel9.Controls.Add(this.metroPanel11);
            this.metroPanel9.Controls.Add(this.metroPanel12);
            this.metroPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel9.HorizontalScrollbarBarColor = true;
            this.metroPanel9.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel9.HorizontalScrollbarSize = 10;
            this.metroPanel9.Location = new System.Drawing.Point(3, 3);
            this.metroPanel9.Name = "metroPanel9";
            this.metroPanel9.Size = new System.Drawing.Size(236, 282);
            this.metroPanel9.TabIndex = 1;
            this.metroPanel9.VerticalScrollbarBarColor = true;
            this.metroPanel9.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel9.VerticalScrollbarSize = 10;
            // 
            // metroPanel10
            // 
            this.metroPanel10.Controls.Add(this.vendorTextbox);
            this.metroPanel10.Controls.Add(this.metroLabel5);
            this.metroPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel10.HorizontalScrollbarBarColor = true;
            this.metroPanel10.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel10.HorizontalScrollbarSize = 10;
            this.metroPanel10.Location = new System.Drawing.Point(0, 124);
            this.metroPanel10.Name = "metroPanel10";
            this.metroPanel10.Size = new System.Drawing.Size(236, 66);
            this.metroPanel10.TabIndex = 4;
            this.metroPanel10.VerticalScrollbarBarColor = true;
            this.metroPanel10.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel10.VerticalScrollbarSize = 10;
            // 
            // vendorTextbox
            // 
            // 
            // 
            // 
            this.vendorTextbox.CustomButton.Image = null;
            this.vendorTextbox.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.vendorTextbox.CustomButton.Name = "";
            this.vendorTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.vendorTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.vendorTextbox.CustomButton.TabIndex = 1;
            this.vendorTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.vendorTextbox.CustomButton.UseSelectable = true;
            this.vendorTextbox.CustomButton.Visible = false;
            this.vendorTextbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.vendorTextbox.Lines = new string[0];
            this.vendorTextbox.Location = new System.Drawing.Point(0, 19);
            this.vendorTextbox.MaxLength = 32767;
            this.vendorTextbox.Name = "vendorTextbox";
            this.vendorTextbox.PasswordChar = '\0';
            this.vendorTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vendorTextbox.SelectedText = "";
            this.vendorTextbox.SelectionLength = 0;
            this.vendorTextbox.SelectionStart = 0;
            this.vendorTextbox.ShortcutsEnabled = true;
            this.vendorTextbox.Size = new System.Drawing.Size(236, 23);
            this.vendorTextbox.TabIndex = 3;
            this.vendorTextbox.UseSelectable = true;
            this.vendorTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.vendorTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel5.Location = new System.Drawing.Point(0, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Vendor";
            // 
            // metroPanel11
            // 
            this.metroPanel11.Controls.Add(this.typeTextBox);
            this.metroPanel11.Controls.Add(this.metroLabel6);
            this.metroPanel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel11.HorizontalScrollbarBarColor = true;
            this.metroPanel11.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel11.HorizontalScrollbarSize = 10;
            this.metroPanel11.Location = new System.Drawing.Point(0, 66);
            this.metroPanel11.Name = "metroPanel11";
            this.metroPanel11.Size = new System.Drawing.Size(236, 58);
            this.metroPanel11.TabIndex = 4;
            this.metroPanel11.VerticalScrollbarBarColor = true;
            this.metroPanel11.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel11.VerticalScrollbarSize = 10;
            // 
            // typeTextBox
            // 
            // 
            // 
            // 
            this.typeTextBox.CustomButton.Image = null;
            this.typeTextBox.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.typeTextBox.CustomButton.Name = "";
            this.typeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.typeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.typeTextBox.CustomButton.TabIndex = 1;
            this.typeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.typeTextBox.CustomButton.UseSelectable = true;
            this.typeTextBox.CustomButton.Visible = false;
            this.typeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.typeTextBox.Lines = new string[0];
            this.typeTextBox.Location = new System.Drawing.Point(0, 19);
            this.typeTextBox.MaxLength = 32767;
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.PasswordChar = '\0';
            this.typeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.typeTextBox.SelectedText = "";
            this.typeTextBox.SelectionLength = 0;
            this.typeTextBox.SelectionStart = 0;
            this.typeTextBox.ShortcutsEnabled = true;
            this.typeTextBox.Size = new System.Drawing.Size(236, 23);
            this.typeTextBox.TabIndex = 3;
            this.typeTextBox.UseSelectable = true;
            this.typeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.typeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel6.Location = new System.Drawing.Point(0, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(36, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Type";
            // 
            // metroPanel12
            // 
            this.metroPanel12.Controls.Add(this.nameTextBox);
            this.metroPanel12.Controls.Add(this.metroLabel7);
            this.metroPanel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel12.HorizontalScrollbarBarColor = true;
            this.metroPanel12.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel12.HorizontalScrollbarSize = 10;
            this.metroPanel12.Location = new System.Drawing.Point(0, 0);
            this.metroPanel12.Name = "metroPanel12";
            this.metroPanel12.Size = new System.Drawing.Size(236, 66);
            this.metroPanel12.TabIndex = 3;
            this.metroPanel12.VerticalScrollbarBarColor = true;
            this.metroPanel12.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel12.VerticalScrollbarSize = 10;
            // 
            // nameTextBox
            // 
            // 
            // 
            // 
            this.nameTextBox.CustomButton.Image = null;
            this.nameTextBox.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.nameTextBox.CustomButton.Name = "";
            this.nameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTextBox.CustomButton.TabIndex = 1;
            this.nameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTextBox.CustomButton.UseSelectable = true;
            this.nameTextBox.CustomButton.Visible = false;
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameTextBox.Lines = new string[0];
            this.nameTextBox.Location = new System.Drawing.Point(0, 19);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.ShortcutsEnabled = true;
            this.nameTextBox.Size = new System.Drawing.Size(236, 23);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.UseSelectable = true;
            this.nameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel7.Location = new System.Drawing.Point(0, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(51, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Name*";
            // 
            // ProductGrid
            // 
            this.ProductGrid.AllowUserToAddRows = false;
            this.ProductGrid.AllowUserToDeleteRows = false;
            this.ProductGrid.AllowUserToResizeColumns = false;
            this.ProductGrid.AllowUserToResizeRows = false;
            this.ProductGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.ProductGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.ProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.ProductGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductGrid.EnableHeadersVisualStyles = false;
            this.ProductGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductGrid.Location = new System.Drawing.Point(251, 3);
            this.ProductGrid.Name = "ProductGrid";
            this.ProductGrid.ReadOnly = true;
            this.ProductGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.ProductGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGrid.Size = new System.Drawing.Size(395, 368);
            this.ProductGrid.StandardTab = true;
            this.ProductGrid.TabIndex = 1;
            // 
            // InventoryTab
            // 
            this.InventoryTab.Controls.Add(this.tableLayoutPanel3);
            this.InventoryTab.Controls.Add(this.metroGrid1);
            this.InventoryTab.HorizontalScrollbarBarColor = true;
            this.InventoryTab.HorizontalScrollbarHighlightOnWheel = false;
            this.InventoryTab.HorizontalScrollbarSize = 10;
            this.InventoryTab.Location = new System.Drawing.Point(4, 38);
            this.InventoryTab.Name = "InventoryTab";
            this.InventoryTab.Padding = new System.Windows.Forms.Padding(10);
            this.InventoryTab.Size = new System.Drawing.Size(669, 394);
            this.InventoryTab.TabIndex = 2;
            this.InventoryTab.Text = "Inventory";
            this.InventoryTab.VerticalScrollbarBarColor = true;
            this.InventoryTab.VerticalScrollbarHighlightOnWheel = false;
            this.InventoryTab.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.12789F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.87211F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.InventoryGrid, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(649, 374);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.metroPanel3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.metroPanel4, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.07609F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.92391F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(209, 368);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.InventoryRemove);
            this.metroPanel3.Controls.Add(this.InventoryEditButton);
            this.metroPanel3.Controls.Add(this.InventoryAddButton);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(3, 294);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(203, 71);
            this.metroPanel3.TabIndex = 0;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // InventoryRemove
            // 
            this.InventoryRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryRemove.Location = new System.Drawing.Point(0, 46);
            this.InventoryRemove.Name = "InventoryRemove";
            this.InventoryRemove.Size = new System.Drawing.Size(203, 23);
            this.InventoryRemove.TabIndex = 4;
            this.InventoryRemove.Text = "Remove";
            this.InventoryRemove.UseSelectable = true;
            this.InventoryRemove.Click += new System.EventHandler(this.InventoryRemove_Click);
            // 
            // InventoryEditButton
            // 
            this.InventoryEditButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryEditButton.Location = new System.Drawing.Point(0, 23);
            this.InventoryEditButton.Name = "InventoryEditButton";
            this.InventoryEditButton.Size = new System.Drawing.Size(203, 23);
            this.InventoryEditButton.TabIndex = 3;
            this.InventoryEditButton.Text = "Edit";
            this.InventoryEditButton.UseSelectable = true;
            this.InventoryEditButton.Click += new System.EventHandler(this.InventoryEditButton_Click);
            // 
            // InventoryAddButton
            // 
            this.InventoryAddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryAddButton.Location = new System.Drawing.Point(0, 0);
            this.InventoryAddButton.Name = "InventoryAddButton";
            this.InventoryAddButton.Size = new System.Drawing.Size(203, 23);
            this.InventoryAddButton.TabIndex = 2;
            this.InventoryAddButton.Text = "Add";
            this.InventoryAddButton.UseSelectable = true;
            this.InventoryAddButton.Click += new System.EventHandler(this.InventoryAddButton_Click);
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.DatePicker);
            this.metroPanel4.Controls.Add(this.PurchaseDateLable);
            this.metroPanel4.Controls.Add(this.QuantityTextBox);
            this.metroPanel4.Controls.Add(this.QuantityLable);
            this.metroPanel4.Controls.Add(this.PriceTextBox);
            this.metroPanel4.Controls.Add(this.metroLabel3);
            this.metroPanel4.Controls.Add(this.ProductPicker);
            this.metroPanel4.Controls.Add(this.metroLabel1);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(3, 3);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(203, 285);
            this.metroPanel4.TabIndex = 1;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // DatePicker
            // 
            this.DatePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatePicker.Location = new System.Drawing.Point(0, 151);
            this.DatePicker.MinimumSize = new System.Drawing.Size(4, 29);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(203, 29);
            this.DatePicker.TabIndex = 13;
            // 
            // PurchaseDateLable
            // 
            this.PurchaseDateLable.AutoSize = true;
            this.PurchaseDateLable.Dock = System.Windows.Forms.DockStyle.Top;
            this.PurchaseDateLable.Location = new System.Drawing.Point(0, 132);
            this.PurchaseDateLable.Name = "PurchaseDateLable";
            this.PurchaseDateLable.Size = new System.Drawing.Size(88, 19);
            this.PurchaseDateLable.TabIndex = 12;
            this.PurchaseDateLable.Text = "PurchaseDate";
            // 
            // QuantityTextBox
            // 
            // 
            // 
            // 
            this.QuantityTextBox.CustomButton.Image = null;
            this.QuantityTextBox.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.QuantityTextBox.CustomButton.Name = "";
            this.QuantityTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.QuantityTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QuantityTextBox.CustomButton.TabIndex = 1;
            this.QuantityTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QuantityTextBox.CustomButton.UseSelectable = true;
            this.QuantityTextBox.CustomButton.Visible = false;
            this.QuantityTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuantityTextBox.Lines = new string[0];
            this.QuantityTextBox.Location = new System.Drawing.Point(0, 109);
            this.QuantityTextBox.MaxLength = 32767;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.PasswordChar = '\0';
            this.QuantityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QuantityTextBox.SelectedText = "";
            this.QuantityTextBox.SelectionLength = 0;
            this.QuantityTextBox.SelectionStart = 0;
            this.QuantityTextBox.ShortcutsEnabled = true;
            this.QuantityTextBox.Size = new System.Drawing.Size(203, 23);
            this.QuantityTextBox.TabIndex = 11;
            this.QuantityTextBox.UseSelectable = true;
            this.QuantityTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuantityTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // QuantityLable
            // 
            this.QuantityLable.AutoSize = true;
            this.QuantityLable.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuantityLable.Location = new System.Drawing.Point(0, 90);
            this.QuantityLable.Name = "QuantityLable";
            this.QuantityLable.Size = new System.Drawing.Size(58, 19);
            this.QuantityLable.TabIndex = 10;
            this.QuantityLable.Text = "Quantity";
            // 
            // PriceTextBox
            // 
            // 
            // 
            // 
            this.PriceTextBox.CustomButton.Image = null;
            this.PriceTextBox.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.PriceTextBox.CustomButton.Name = "";
            this.PriceTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PriceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PriceTextBox.CustomButton.TabIndex = 1;
            this.PriceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PriceTextBox.CustomButton.UseSelectable = true;
            this.PriceTextBox.CustomButton.Visible = false;
            this.PriceTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PriceTextBox.Lines = new string[0];
            this.PriceTextBox.Location = new System.Drawing.Point(0, 67);
            this.PriceTextBox.MaxLength = 32767;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.PasswordChar = '\0';
            this.PriceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PriceTextBox.SelectedText = "";
            this.PriceTextBox.SelectionLength = 0;
            this.PriceTextBox.SelectionStart = 0;
            this.PriceTextBox.ShortcutsEnabled = true;
            this.PriceTextBox.Size = new System.Drawing.Size(203, 23);
            this.PriceTextBox.TabIndex = 5;
            this.PriceTextBox.UseSelectable = true;
            this.PriceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PriceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel3.Location = new System.Drawing.Point(0, 48);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Price";
            // 
            // ProductPicker
            // 
            this.ProductPicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductPicker.FormattingEnabled = true;
            this.ProductPicker.ItemHeight = 23;
            this.ProductPicker.Location = new System.Drawing.Point(0, 19);
            this.ProductPicker.Name = "ProductPicker";
            this.ProductPicker.Size = new System.Drawing.Size(203, 29);
            this.ProductPicker.TabIndex = 3;
            this.ProductPicker.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Product";
            // 
            // InventoryGrid
            // 
            this.InventoryGrid.AllowUserToAddRows = false;
            this.InventoryGrid.AllowUserToDeleteRows = false;
            this.InventoryGrid.AllowUserToResizeRows = false;
            this.InventoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventoryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InventoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InventoryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InventoryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.InventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryGrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.InventoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryGrid.EnableHeadersVisualStyles = false;
            this.InventoryGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.InventoryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InventoryGrid.Location = new System.Drawing.Point(218, 3);
            this.InventoryGrid.Name = "InventoryGrid";
            this.InventoryGrid.ReadOnly = true;
            this.InventoryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.InventoryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.InventoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryGrid.Size = new System.Drawing.Size(428, 368);
            this.InventoryGrid.TabIndex = 1;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle17;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(10, 10);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(649, 374);
            this.metroGrid1.TabIndex = 2;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 516);
            this.Controls.Add(this.TabPane);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.TabPane.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.TileHolder.ResumeLayout(false);
            this.ProductTab.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.metroPanel9.ResumeLayout(false);
            this.metroPanel10.ResumeLayout(false);
            this.metroPanel10.PerformLayout();
            this.metroPanel11.ResumeLayout(false);
            this.metroPanel11.PerformLayout();
            this.metroPanel12.ResumeLayout(false);
            this.metroPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).EndInit();
            this.InventoryTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabPane;
        private MetroFramework.Controls.MetroTabPage ProductTab;
        private MetroFramework.Controls.MetroTabPage InventoryTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton InventoryRemove;
        private MetroFramework.Controls.MetroButton InventoryEditButton;
        private MetroFramework.Controls.MetroButton InventoryAddButton;
        private MetroFramework.Controls.MetroGrid InventoryGrid;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroComboBox ProductPicker;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox PriceTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime DatePicker;
        private MetroFramework.Controls.MetroLabel PurchaseDateLable;
        private MetroFramework.Controls.MetroTextBox QuantityTextBox;
        private MetroFramework.Controls.MetroLabel QuantityLable;
        private MetroFramework.Controls.MetroTabPage HomeTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton AddButton;
        private MetroFramework.Controls.MetroPanel metroPanel9;
        private MetroFramework.Controls.MetroPanel metroPanel10;
        private MetroFramework.Controls.MetroTextBox vendorTextbox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroPanel metroPanel11;
        private MetroFramework.Controls.MetroTextBox typeTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel metroPanel12;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroGrid ProductGrid;
        private MetroFramework.Controls.MetroTile logTile;
        private MetroFramework.Controls.MetroTile salesTile;
        private MetroFramework.Controls.MetroTile userTile;
        private MetroFramework.Controls.MetroTile settingsTile;
        private MetroFramework.Controls.MetroTile notificationTile;
        private System.Windows.Forms.TableLayoutPanel TileHolder;
        private MetroFramework.Controls.MetroTile LockTile;
    }
}