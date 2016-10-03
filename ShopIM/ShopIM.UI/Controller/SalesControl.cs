using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework;
using ShopIM.BLL;
using ShopIM.Entity;

namespace ShopIM.UI.Controller
{
    public partial class SalesControl : UserControl
    {
        List<Inventory> StockInventories { get; set; }
        List<Inventory> SelectedInventories { get; set; }
        List<Inventory> CartInventories { get; set; }
        List<Inventory> SelectedCartInventories { get; set; }

        private string UserName { get; set; }

        public SalesControl(string userName)
        {
            InitializeComponent();
            UserName = userName;
            CartInventories=new List<Inventory>();
            StockInventories = new List<Inventory>();
            ProductViewPanel.Controls.Clear();
            ProductViewPanel.Controls.Add(new InventoryInfoControl(new Inventory()));
            StockInventories = new InventoryRepo().GetInventories();
            LoadInventories();


        }

        private void LoadInventories()
        {
            StockInventoryGrid.DataSource = null;
            StockInventoryGrid.DataSource = StockInventories;
            StockInventoryGrid.Columns[0].Visible = false;
            StockInventoryGrid.Columns[2].Visible = false;
            StockInventoryGrid.Columns[4].Visible = false;
            StockInventoryGrid.Columns[7].Visible = false;
            StockInventoryGrid.Columns[8].Visible = false;
            StockInventoryGrid.Columns[9].Visible = false;
            StockInventoryGrid.Columns[10].Visible = false;
            StockInventoryGrid.Columns[11].Visible = false;

        }

        private void LoadCart()
        {
            CartGrid.DataSource = null;
            CartGrid.DataSource = CartInventories;

            //hidden columns
            CartGrid.Columns[0].Visible = false;
            CartGrid.Columns[2].Visible = false;
            CartGrid.Columns[4].Visible = false;
            CartGrid.Columns[5].Visible = false;
            CartGrid.Columns[7].Visible = false;
            CartGrid.Columns[8].Visible = false;
            CartGrid.Columns[9].Visible = false;
            CartGrid.Columns[10].Visible = false;
            CartGrid.Columns[11].Visible = false;



        }

  

        private void StockInventoryGrid_Click(object sender, System.EventArgs e)
        {
            var length = StockInventoryGrid.SelectedRows.Count;
            SelectedInventories = new List<Inventory>();
            for (var i = 0; i < length; i++)
            {
                SelectedInventories.Add((Inventory)StockInventoryGrid.SelectedRows[i].DataBoundItem);
             
            }
            ProductViewPanel.Controls.Clear();
            if (SelectedInventories.Count > 0)
                ProductViewPanel.Controls.Add(new InventoryInfoControl(SelectedInventories[0]));


        }

        private void SalesControl_Load(object sender, System.EventArgs e)
        {

        }

   

        private void metroButton4_Click(object sender, System.EventArgs e)
        {
            if (SelectedInventories == null) return;

            foreach (var inventory in SelectedInventories)
            {
                if (inventory.Quantity <= 0)
                {
                    MetroMessageBox.Show(this, "No more item's in Stock", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                    
                }
                inventory.Quantity -= 1;
                Inventory cartInventory = new Inventory(inventory);
                cartInventory.Quantity = 1;
                cartInventory.TotalPrice = cartInventory.Quantity*cartInventory.SellingPrice;
                cartInventory.TotalCost = cartInventory.Quantity*cartInventory.Cost;
                CartInventories.Add(cartInventory);


            }
            LoadInventories();
            LoadCart();
        }

        private void CartGrid_DoubleClick(object sender, System.EventArgs e)
        {
            if(SelectedCartInventories.Count<=0)return;
            
            Inventory selectedCartInventory= (Inventory)CartGrid.SelectedRows[0].DataBoundItem;
            Inventory sampleInventory = StockInventories.Find(i => i.ProductName == selectedCartInventory.ProductName);
            if (selectedCartInventory != null)
            {
                ModifyCartItem modifyCartItem= new ModifyCartItem(selectedCartInventory,sampleInventory);
                if (modifyCartItem.ShowDialog()==DialogResult.OK)
                {
                   LoadCart();
                   LoadInventories();
                }
            }
              
            
        }

        private void CartGrid_Click(object sender, System.EventArgs e)
        {
            var length = CartGrid.SelectedRows.Count;
            SelectedCartInventories = new List<Inventory>();
            for (var i = 0; i < length; i++)
            {
                SelectedCartInventories.Add((Inventory)CartGrid.SelectedRows[i].DataBoundItem);

            }
        }

        private void RemoveCartButton_Click(object sender, System.EventArgs e)
        {
            if (SelectedCartInventories != null)
            {
                foreach (var inventory in SelectedCartInventories)
                {
                    Inventory stockInventory = StockInventories.Find(i => i.ProductName == inventory.ProductName);
                    stockInventory.Quantity += inventory.Quantity;
                    CartInventories.Remove(inventory);
                }
            }

            LoadCart();
            LoadInventories();
        }

        private void CheckoutButton_Click(object sender, System.EventArgs e)
        {
            if(CartInventories.Count<=0)return;
            
            CheckoutForm checkoutForm = new CheckoutForm(CartInventories,UserName);
            if (checkoutForm.ShowDialog() == DialogResult.OK)
            {
                CartInventories = new List<Inventory>();
                StockInventories = new List<Inventory>();
                ProductViewPanel.Controls.Add(new InventoryInfoControl(new Inventory()));
                StockInventories = new InventoryRepo().GetInventories();
                AdminDashboard.UpdateNotification();
                LoadInventories();
                CartGrid.DataSource = null;


            }
        }
    }
}