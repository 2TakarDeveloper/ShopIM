using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using ShopIM.UI.Controller;

namespace ShopIM.UI
{
    public partial class AdminDashboard : MetroForm
    {
        public AdminDashboard(string userName, string userType, Login login)
        {
            Login = login;
            UserName = userName;
            InitializeComponent();
            UserButton.Text = UserName;
            LoadSales();
        }

        private string UserName { get; }
        private Login Login { get; }

        private void ExitButton_click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ProductButton_Click(object sender, EventArgs e)
        {
            var productsControl = new ProductsControl();
            metroPanelBackground.Controls.Clear();
            metroPanelBackground.Controls.Add(productsControl);
        }

        private void LoadSales()
        {
            var salesControl = new SalesControl();
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
            var inventoryControl = new InventoryControl();
            metroPanelBackground.Controls.Clear();
            inventoryControl.Dock = DockStyle.Fill;
            metroPanelBackground.Controls.Add(inventoryControl);
        }

        private void LockButton_Click(object sender, EventArgs e)
        {
            var systemForm = new SystemForm(UserName, Login, this);
            systemForm.ShowDialog(this);
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Login.Show();
            Close();
        }
    }
}