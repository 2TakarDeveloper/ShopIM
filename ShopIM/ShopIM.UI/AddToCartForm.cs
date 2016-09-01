

using System.Collections.Generic;
using System.Windows.Forms;
using ShopIM.Entity;

namespace ShopIM.UI
{
    public partial class AddToCartForm : MetroFramework.Forms.MetroForm
    {
        private Inventory selectedInventory;
        private List<Inventory> inventories;
        private List<Inventory> returnList;

        public delegate void AddTocart(List<Inventory> inventories);

        private AddTocart addTocart;

        public AddToCartForm(List<Inventory> inventories,AddTocart addTocart)
        {
            this.addTocart = addTocart;
            this.inventories = inventories;
            updateNewList();

            InitializeComponent();
            CartGrid.DataSource = returnList;
            CartGrid.Columns[0].Visible = false;
            CartGrid.Columns[4].Visible = false;

            CartGrid.Click += CartGrid_Click;


            QuantityNum.Maximum = 99999999;
            PriceNum.Maximum = 99999999;


        }


        private void updateNewList()
        {
            returnList = new List<Inventory>();
            foreach (var inventory in inventories)
            {
                Inventory i = new Inventory(inventory);
                returnList.Add(i);
            }
        }

        private void CartGrid_Click(object sender, System.EventArgs e)
        {
            selectedInventory = (Inventory)CartGrid.SelectedRows[0].DataBoundItem;
            NameTextBox.Text = selectedInventory.ProductName;
            PriceNum.Minimum = (decimal)selectedInventory.Price;
            PriceNum.Value = (decimal)selectedInventory.Price;
            QuantityNum.Maximum = selectedInventory.Quantity;
            
            QuantityNum.Value = selectedInventory.Quantity;
            
        }


       

        private void EditButton_Click_1(object sender, System.EventArgs e)
        {
            int id;
            if (selectedInventory == null) return;
            id = selectedInventory.Sl;
            foreach (var inventory in returnList)
            {
                if (inventory.Sl != id) continue;
                inventory.Quantity = (int)QuantityNum.Value;
                inventory.Price = (double)PriceNum.Value;
                break;
            }


            CartGrid.DataSource = null;
            CartGrid.DataSource = returnList;
            CartGrid.Columns[0].Visible = false;
            CartGrid.Columns[4].Visible = false;
            CartGrid.Refresh();
        }

        private void NextButton_Click(object sender, System.EventArgs e)
        {

            addTocart(returnList);
            Close();
        }
    }
}
