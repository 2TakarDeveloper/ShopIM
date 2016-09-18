using ShopIM.UI.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopIM.UI
{
    public partial class AdminDashboard : MetroFramework.Forms.MetroForm
    {
        public AdminDashboard()
        {
            InitializeComponent();
            LoadSales();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void metroLink13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroPanelBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLink3_Click(object sender, EventArgs e)
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

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }
    }
}
