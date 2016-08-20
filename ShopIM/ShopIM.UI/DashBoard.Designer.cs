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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabPane = new MetroFramework.Controls.MetroTabControl();
            this.HomeTab = new MetroFramework.Controls.MetroTabPage();
            this.ProductTab = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel8 = new MetroFramework.Controls.MetroPanel();
            this.vendorTextbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.typeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NameLable = new MetroFramework.Controls.MetroLabel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.idTextbox = new MetroFramework.Controls.MetroTextBox();
            this.IdLable = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.RemoveButton = new MetroFramework.Controls.MetroButton();
            this.EditButton = new MetroFramework.Controls.MetroButton();
            this.AddButton = new MetroFramework.Controls.MetroButton();
            this.ProductGrid = new MetroFramework.Controls.MetroGrid();
            this.InventoryTab = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.ProductPicker = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.InventoryGrid = new MetroFramework.Controls.MetroGrid();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.PriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.InventoryNoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.DatePicker = new MetroFramework.Controls.MetroDateTime();
            this.TabPane.SuspendLayout();
            this.ProductTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel8.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.metroPanel7.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel1.SuspendLayout();
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
            this.TabPane.Controls.Add(this.ProductTab);
            this.TabPane.Controls.Add(this.HomeTab);
            this.TabPane.Controls.Add(this.InventoryTab);
            this.TabPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPane.Location = new System.Drawing.Point(20, 60);
            this.TabPane.Name = "TabPane";
            this.TabPane.SelectedIndex = 1;
            this.TabPane.Size = new System.Drawing.Size(677, 436);
            this.TabPane.TabIndex = 0;
            this.TabPane.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TabPane.UseSelectable = true;
            // 
            // HomeTab
            // 
            this.HomeTab.HorizontalScrollbarBarColor = true;
            this.HomeTab.HorizontalScrollbarHighlightOnWheel = false;
            this.HomeTab.HorizontalScrollbarSize = 10;
            this.HomeTab.Location = new System.Drawing.Point(4, 38);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Size = new System.Drawing.Size(669, 394);
            this.HomeTab.TabIndex = 1;
            this.HomeTab.Text = "Home";
            this.HomeTab.VerticalScrollbarBarColor = true;
            this.HomeTab.VerticalScrollbarHighlightOnWheel = false;
            this.HomeTab.VerticalScrollbarSize = 10;
            // 
            // ProductTab
            // 
            this.ProductTab.Controls.Add(this.tableLayoutPanel1);
            this.ProductTab.HorizontalScrollbarBarColor = true;
            this.ProductTab.HorizontalScrollbarHighlightOnWheel = false;
            this.ProductTab.HorizontalScrollbarSize = 10;
            this.ProductTab.Location = new System.Drawing.Point(4, 38);
            this.ProductTab.Name = "ProductTab";
            this.ProductTab.Padding = new System.Windows.Forms.Padding(10);
            this.ProductTab.Size = new System.Drawing.Size(669, 394);
            this.ProductTab.TabIndex = 0;
            this.ProductTab.Text = "Product";
            this.ProductTab.VerticalScrollbarBarColor = true;
            this.ProductTab.VerticalScrollbarHighlightOnWheel = false;
            this.ProductTab.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.68909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.31091F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProductGrid, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(649, 374);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.metroPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.07609F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.92391F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(199, 368);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroPanel8);
            this.metroPanel2.Controls.Add(this.metroPanel6);
            this.metroPanel2.Controls.Add(this.metroPanel7);
            this.metroPanel2.Controls.Add(this.metroPanel5);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(193, 285);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel8
            // 
            this.metroPanel8.Controls.Add(this.vendorTextbox);
            this.metroPanel8.Controls.Add(this.metroLabel4);
            this.metroPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel8.HorizontalScrollbarBarColor = true;
            this.metroPanel8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel8.HorizontalScrollbarSize = 10;
            this.metroPanel8.Location = new System.Drawing.Point(0, 182);
            this.metroPanel8.Name = "metroPanel8";
            this.metroPanel8.Size = new System.Drawing.Size(193, 66);
            this.metroPanel8.TabIndex = 4;
            this.metroPanel8.VerticalScrollbarBarColor = true;
            this.metroPanel8.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel8.VerticalScrollbarSize = 10;
            // 
            // vendorTextbox
            // 
            // 
            // 
            // 
            this.vendorTextbox.CustomButton.Image = null;
            this.vendorTextbox.CustomButton.Location = new System.Drawing.Point(171, 1);
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
            this.vendorTextbox.Size = new System.Drawing.Size(193, 23);
            this.vendorTextbox.TabIndex = 3;
            this.vendorTextbox.UseSelectable = true;
            this.vendorTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.vendorTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel4.Location = new System.Drawing.Point(0, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Vendor";
            // 
            // metroPanel6
            // 
            this.metroPanel6.Controls.Add(this.typeTextBox);
            this.metroPanel6.Controls.Add(this.metroLabel2);
            this.metroPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(0, 124);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(193, 58);
            this.metroPanel6.TabIndex = 4;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // typeTextBox
            // 
            // 
            // 
            // 
            this.typeTextBox.CustomButton.Image = null;
            this.typeTextBox.CustomButton.Location = new System.Drawing.Point(171, 1);
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
            this.typeTextBox.Size = new System.Drawing.Size(193, 23);
            this.typeTextBox.TabIndex = 3;
            this.typeTextBox.UseSelectable = true;
            this.typeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.typeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel2.Location = new System.Drawing.Point(0, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Type";
            // 
            // metroPanel7
            // 
            this.metroPanel7.Controls.Add(this.nameTextBox);
            this.metroPanel7.Controls.Add(this.NameLable);
            this.metroPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(0, 58);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(193, 66);
            this.metroPanel7.TabIndex = 3;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            // 
            // nameTextBox
            // 
            // 
            // 
            // 
            this.nameTextBox.CustomButton.Image = null;
            this.nameTextBox.CustomButton.Location = new System.Drawing.Point(171, 1);
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
            this.nameTextBox.Size = new System.Drawing.Size(193, 23);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.UseSelectable = true;
            this.nameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameLable.Location = new System.Drawing.Point(0, 0);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(45, 19);
            this.NameLable.TabIndex = 2;
            this.NameLable.Text = "Name";
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.idTextbox);
            this.metroPanel5.Controls.Add(this.IdLable);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(0, 0);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(193, 58);
            this.metroPanel5.TabIndex = 2;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // idTextbox
            // 
            // 
            // 
            // 
            this.idTextbox.CustomButton.Image = null;
            this.idTextbox.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.idTextbox.CustomButton.Name = "";
            this.idTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idTextbox.CustomButton.TabIndex = 1;
            this.idTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idTextbox.CustomButton.UseSelectable = true;
            this.idTextbox.CustomButton.Visible = false;
            this.idTextbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.idTextbox.Lines = new string[0];
            this.idTextbox.Location = new System.Drawing.Point(0, 19);
            this.idTextbox.MaxLength = 32767;
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.PasswordChar = '\0';
            this.idTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idTextbox.SelectedText = "";
            this.idTextbox.SelectionLength = 0;
            this.idTextbox.SelectionStart = 0;
            this.idTextbox.ShortcutsEnabled = true;
            this.idTextbox.Size = new System.Drawing.Size(193, 23);
            this.idTextbox.TabIndex = 3;
            this.idTextbox.UseSelectable = true;
            this.idTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // IdLable
            // 
            this.IdLable.AutoSize = true;
            this.IdLable.Dock = System.Windows.Forms.DockStyle.Top;
            this.IdLable.Location = new System.Drawing.Point(0, 0);
            this.IdLable.Name = "IdLable";
            this.IdLable.Size = new System.Drawing.Size(21, 19);
            this.IdLable.TabIndex = 2;
            this.IdLable.Text = "ID";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.RemoveButton);
            this.metroPanel1.Controls.Add(this.EditButton);
            this.metroPanel1.Controls.Add(this.AddButton);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 294);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(193, 71);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveButton.Location = new System.Drawing.Point(0, 46);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(193, 23);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseSelectable = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditButton.Location = new System.Drawing.Point(0, 23);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(193, 23);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseSelectable = true;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(193, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseSelectable = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ProductGrid
            // 
            this.ProductGrid.AllowUserToAddRows = false;
            this.ProductGrid.AllowUserToDeleteRows = false;
            this.ProductGrid.AllowUserToResizeRows = false;
            this.ProductGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.ProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductGrid.DefaultCellStyle = dataGridViewCellStyle29;
            this.ProductGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductGrid.EnableHeadersVisualStyles = false;
            this.ProductGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductGrid.Location = new System.Drawing.Point(208, 3);
            this.ProductGrid.Name = "ProductGrid";
            this.ProductGrid.ReadOnly = true;
            this.ProductGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.ProductGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGrid.Size = new System.Drawing.Size(438, 368);
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
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.68909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.31091F));
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(199, 368);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroButton1);
            this.metroPanel3.Controls.Add(this.metroButton2);
            this.metroPanel3.Controls.Add(this.metroButton3);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(3, 294);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(193, 71);
            this.metroPanel3.TabIndex = 0;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton1.Location = new System.Drawing.Point(0, 46);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(193, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Remove";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton2.Location = new System.Drawing.Point(0, 23);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(193, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Edit";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton3.Location = new System.Drawing.Point(0, 0);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(193, 23);
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "Add";
            this.metroButton3.UseSelectable = true;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.DatePicker);
            this.metroPanel4.Controls.Add(this.metroLabel6);
            this.metroPanel4.Controls.Add(this.InventoryNoTextBox);
            this.metroPanel4.Controls.Add(this.metroLabel5);
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
            this.metroPanel4.Size = new System.Drawing.Size(193, 285);
            this.metroPanel4.TabIndex = 1;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // ProductPicker
            // 
            this.ProductPicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductPicker.FormattingEnabled = true;
            this.ProductPicker.ItemHeight = 23;
            this.ProductPicker.Location = new System.Drawing.Point(0, 19);
            this.ProductPicker.Name = "ProductPicker";
            this.ProductPicker.Size = new System.Drawing.Size(193, 29);
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
            this.InventoryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InventoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InventoryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InventoryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.InventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryGrid.DefaultCellStyle = dataGridViewCellStyle32;
            this.InventoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryGrid.EnableHeadersVisualStyles = false;
            this.InventoryGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.InventoryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InventoryGrid.Location = new System.Drawing.Point(208, 3);
            this.InventoryGrid.Name = "InventoryGrid";
            this.InventoryGrid.ReadOnly = true;
            this.InventoryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.InventoryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.InventoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryGrid.Size = new System.Drawing.Size(438, 368);
            this.InventoryGrid.TabIndex = 1;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle35;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(10, 10);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(649, 374);
            this.metroGrid1.TabIndex = 2;
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
            // PriceTextBox
            // 
            // 
            // 
            // 
            this.PriceTextBox.CustomButton.Image = null;
            this.PriceTextBox.CustomButton.Location = new System.Drawing.Point(171, 1);
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
            this.PriceTextBox.Size = new System.Drawing.Size(193, 23);
            this.PriceTextBox.TabIndex = 5;
            this.PriceTextBox.UseSelectable = true;
            this.PriceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PriceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel5.Location = new System.Drawing.Point(0, 90);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(82, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Inventory no";
            // 
            // InventoryNoTextBox
            // 
            // 
            // 
            // 
            this.InventoryNoTextBox.CustomButton.Image = null;
            this.InventoryNoTextBox.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.InventoryNoTextBox.CustomButton.Name = "";
            this.InventoryNoTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InventoryNoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InventoryNoTextBox.CustomButton.TabIndex = 1;
            this.InventoryNoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InventoryNoTextBox.CustomButton.UseSelectable = true;
            this.InventoryNoTextBox.CustomButton.Visible = false;
            this.InventoryNoTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryNoTextBox.Lines = new string[0];
            this.InventoryNoTextBox.Location = new System.Drawing.Point(0, 109);
            this.InventoryNoTextBox.MaxLength = 32767;
            this.InventoryNoTextBox.Name = "InventoryNoTextBox";
            this.InventoryNoTextBox.PasswordChar = '\0';
            this.InventoryNoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InventoryNoTextBox.SelectedText = "";
            this.InventoryNoTextBox.SelectionLength = 0;
            this.InventoryNoTextBox.SelectionStart = 0;
            this.InventoryNoTextBox.ShortcutsEnabled = true;
            this.InventoryNoTextBox.Size = new System.Drawing.Size(193, 23);
            this.InventoryNoTextBox.TabIndex = 7;
            this.InventoryNoTextBox.UseSelectable = true;
            this.InventoryNoTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InventoryNoTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel6.Location = new System.Drawing.Point(0, 132);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(92, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Purchase Date";
            // 
            // DatePicker
            // 
            this.DatePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatePicker.Location = new System.Drawing.Point(0, 151);
            this.DatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(193, 29);
            this.DatePicker.TabIndex = 9;
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
            this.ProductTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel8.ResumeLayout(false);
            this.metroPanel8.PerformLayout();
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.metroPanel7.ResumeLayout(false);
            this.metroPanel7.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTabPage HomeTab;
        private MetroFramework.Controls.MetroTabPage InventoryTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid ProductGrid;
        private MetroFramework.Controls.MetroButton RemoveButton;
        private MetroFramework.Controls.MetroButton EditButton;
        private MetroFramework.Controls.MetroButton AddButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroGrid InventoryGrid;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroPanel metroPanel8;
        private MetroFramework.Controls.MetroTextBox vendorTextbox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private MetroFramework.Controls.MetroTextBox typeTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private MetroFramework.Controls.MetroLabel NameLable;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroTextBox idTextbox;
        private MetroFramework.Controls.MetroLabel IdLable;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroComboBox ProductPicker;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox PriceTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime DatePicker;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox InventoryNoTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}