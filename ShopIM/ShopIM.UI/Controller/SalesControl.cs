using System.Collections.Generic;
using System.Windows.Forms;
using ShopIM.BLL;
using ShopIM.Entity;

namespace ShopIM.UI.Controller
{
    public partial class SalesControl : UserControl
    {
        List<Inventory> StockInventories { get; set; }
        List<Inventory> SelectedInventories { get; set; }
        List<Inventory> CartInventories { get; set; }

        public SalesControl()
        {
            InitializeComponent();
            LoadInventories();
            CartInventories=new List<Inventory>();
           
        }

        private void LoadInventories()
        {
            StockInventories = new List<Inventory>();
            StockInventories = new InventoryRepo().GetInventories();
            StockInventoryGrid.DataSource = StockInventories;
            StockInventoryGrid.Columns[4].Visible = false;
            StockInventoryGrid.Columns[7].Visible = false;
            StockInventoryGrid.Columns[8].Visible = false;
            StockInventoryGrid.Columns[9].Visible = false;


        }

        private void LoadCart()
        {
            CartGrid.DataSource = null;
            CartGrid.DataSource = CartInventories;

            //hidden columns
            CartGrid.Columns[2].Visible = false;
            CartGrid.Columns[4].Visible = false;
            CartGrid.Columns[5].Visible = false;
            CartGrid.Columns[7].Visible = false;
            CartGrid.Columns[8].Visible = false;
            CartGrid.Columns[9].Visible = false;

           

        }

        private void AddtoCartButton_Click(object sender, System.EventArgs e)
        {   
            if(SelectedInventories==null)return;
            
            foreach (var inventory in SelectedInventories)
            {
                Inventory cartInventory= new Inventory(inventory);
                cartInventory.Quantity = 1;
                CartInventories.Add(cartInventory);


            }

            LoadCart();
        }

        private void StockInventoryGrid_Click(object sender, System.EventArgs e)
        {
            var length = StockInventoryGrid.SelectedRows.Count;
            SelectedInventories = new List<Inventory>();
            for (var i = 0; i < length; i++)
            {
                SelectedInventories.Add((Inventory)StockInventoryGrid.SelectedRows[i].DataBoundItem);
            }

          
        }
    }
}