using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using ShopIM.BLL;
using ShopIM.Entity;

namespace ShopIM.UI
{
    public partial class CheckoutForm : Form
    {
        private List<Inventory> Inventories { get; set; }
        private String UserName { get; set; }

        public CheckoutForm(List<Inventory> inventories,string userName )
        {
            UserName = userName;
            Inventories = inventories;
            InitializeComponent();
            CheckoutGrid.DataSource = Inventories;
            CheckoutGrid.Columns[0].Visible = false;
            CheckoutGrid.Columns[2].Visible = false;
            CheckoutGrid.Columns[4].Visible = false;
            CheckoutGrid.Columns[9].Visible = false;
            CheckoutGrid.Columns[10].Visible = false;
            CheckoutGrid.Columns[11].Visible = false;

            double grandTotal=0;

            foreach (var inventory in Inventories)
            {
                grandTotal += inventory.TotalPrice;
            }

            TotalLable.Text = @"Total:"+grandTotal;
        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (new InventoryRepo().SellProduct(Inventories,UserName))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MetroMessageBox.Show(this, "Database Error","Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
          
        }
    }
}
