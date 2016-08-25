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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabPane = new MetroFramework.Controls.MetroTabControl();
            this.ProductTab = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.EditButton = new MetroFramework.Controls.MetroButton();
            this.AddButton = new MetroFramework.Controls.MetroButton();
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
            this.ProductGrid = new MetroFramework.Controls.MetroGrid();
            this.HomeTab = new MetroFramework.Controls.MetroTabPage();
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
            this.DeleteButton_Product = new MetroFramework.Controls.MetroButton();
            this.TabPane.SuspendLayout();
            this.ProductTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel8.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.metroPanel7.SuspendLayout();
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
            this.TabPane.SelectedIndex = 2;
            this.TabPane.Size = new System.Drawing.Size(677, 436);
            this.TabPane.TabIndex = 0;
            this.TabPane.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TabPane.UseSelectable = true;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.21264F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.78736F));
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
            this.tableLayoutPanel2.Controls.Add(this.metroPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroPanel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.53261F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.46739F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(242, 368);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.DeleteButton_Product);
            this.metroPanel1.Controls.Add(this.EditButton);
            this.metroPanel1.Controls.Add(this.AddButton);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 291);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(236, 74);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // EditButton
            // 
            this.EditButton.AutoSize = true;
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditButton.Location = new System.Drawing.Point(0, 23);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(236, 23);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseSelectable = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
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
            // metroPanel2
            // 
            this.metroPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroPanel2.Controls.Add(this.metroPanel8);
            this.metroPanel2.Controls.Add(this.metroPanel6);
            this.metroPanel2.Controls.Add(this.metroPanel7);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(236, 282);
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
            this.metroPanel8.Location = new System.Drawing.Point(0, 124);
            this.metroPanel8.Name = "metroPanel8";
            this.metroPanel8.Size = new System.Drawing.Size(236, 66);
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
            this.metroPanel6.Location = new System.Drawing.Point(0, 66);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(236, 58);
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
            this.metroPanel7.Location = new System.Drawing.Point(0, 0);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(236, 66);
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
            // ProductGrid
            // 
            this.ProductGrid.AllowUserToAddRows = false;
            this.ProductGrid.AllowUserToDeleteRows = false;
            this.ProductGrid.AllowUserToResizeRows = false;
            this.ProductGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProductGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProductGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.ProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductGrid.DefaultCellStyle = dataGridViewCellStyle17;
            this.ProductGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductGrid.EnableHeadersVisualStyles = false;
            this.ProductGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductGrid.Location = new System.Drawing.Point(251, 3);
            this.ProductGrid.Name = "ProductGrid";
            this.ProductGrid.ReadOnly = true;
            this.ProductGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.ProductGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGrid.Size = new System.Drawing.Size(395, 368);
            this.ProductGrid.StandardTab = true;
            this.ProductGrid.TabIndex = 1;
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
            this.InventoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.InventoryGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InventoryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InventoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InventoryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InventoryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.InventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.InventoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryGrid.EnableHeadersVisualStyles = false;
            this.InventoryGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.InventoryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InventoryGrid.Location = new System.Drawing.Point(218, 3);
            this.InventoryGrid.Name = "InventoryGrid";
            this.InventoryGrid.ReadOnly = true;
            this.InventoryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(10, 10);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(649, 374);
            this.metroGrid1.TabIndex = 2;
            // 
            // DeleteButton_Product
            // 
            this.DeleteButton_Product.AutoSize = true;
            this.DeleteButton_Product.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteButton_Product.Location = new System.Drawing.Point(0, 46);
            this.DeleteButton_Product.Name = "DeleteButton_Product";
            this.DeleteButton_Product.Size = new System.Drawing.Size(236, 23);
            this.DeleteButton_Product.TabIndex = 4;
            this.DeleteButton_Product.Text = "Delete";
            this.DeleteButton_Product.UseSelectable = true;
            this.DeleteButton_Product.Click += new System.EventHandler(this.DeleteButton_Product_Click);
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
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel8.ResumeLayout(false);
            this.metroPanel8.PerformLayout();
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.metroPanel7.ResumeLayout(false);
            this.metroPanel7.PerformLayout();
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
        private MetroFramework.Controls.MetroTabPage HomeTab;
        private MetroFramework.Controls.MetroTabPage ProductTab;
        private MetroFramework.Controls.MetroTabPage InventoryTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid ProductGrid;
        private MetroFramework.Controls.MetroButton EditButton;
        private MetroFramework.Controls.MetroButton AddButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton InventoryRemove;
        private MetroFramework.Controls.MetroButton InventoryEditButton;
        private MetroFramework.Controls.MetroButton InventoryAddButton;
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
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroComboBox ProductPicker;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox PriceTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime DatePicker;
        private MetroFramework.Controls.MetroLabel PurchaseDateLable;
        private MetroFramework.Controls.MetroTextBox QuantityTextBox;
        private MetroFramework.Controls.MetroLabel QuantityLable;
        private MetroFramework.Controls.MetroButton DeleteButton_Product;
    }
}