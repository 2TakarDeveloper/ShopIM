using ShopIM.UI.Controller;
using System;
using System.Windows.Forms;

namespace ShopIM.UI
{
    public partial class AdminDashboard : MetroFramework.Forms.MetroForm
    {
        private  string UserName { get; set; }
        public AdminDashboard(string userName,string userType)
        {
            UserName = userName;
            InitializeComponent();
            UserButton.Text = UserName;
            LoadSales();
        }

        private void ExitButton_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void ProductButton_Click(object sender, EventArgs e)
        {
            ProductsControl productsControl = new ProductsControl();
            metroPanelBackground.Controls.Clear();
            metroPanelBackground.Controls.Add(productsControl);
        }
        private void LoadSales()
        {
            SalesControl salesControl = new SalesControl();
            metroPanelBackground.Controls.Clear();
            salesControl.Dock = DockStyle.Fill;
            metroPanelBackground.Controls.Add(salesControl);
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            LoadSales();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            InventoryControl inventoryControl = new InventoryControl();
            metroPanelBackground.Controls.Clear();
            inventoryControl.Dock = DockStyle.Fill;
            metroPanelBackground.Controls.Add(inventoryControl);
        }
    }
}
