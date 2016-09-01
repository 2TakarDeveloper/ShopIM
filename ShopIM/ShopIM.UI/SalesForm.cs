
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework;
using ShopIM.DAL;
using ShopIM.Entity;

namespace ShopIM.UI
{
    public partial class SalesForm : MetroFramework.Forms.MetroForm
    {

        public InventoryContext InventoryContext;
        public List<Inventory> SelectedInventories;
        private List<Inventory> CartInventories;
        private List<Inventory> Inventories;
        private List<Inventory> selectedCartInventories;



        public SalesForm()
        {
            InventoryContext=new InventoryContext();
            CartInventories=new List<Inventory>();
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Inventories= InventoryContext.GetInventories();
            InventoryGrid.DataSource = Inventories;
            InventoryGrid.Columns[4].Visible = false;
            InventoryGrid.Click += InventoryGrid_Click;
            CartGrid.Click += CartGrid_Click;
           
         

        }

        private void CartGrid_Click(object sender, EventArgs e)
        {
            selectedCartInventories = new List<Inventory>();
            int length = CartGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            for (int i = 0; i < length; i++)
            {
                var I = (Inventory)CartGrid.SelectedRows[i].DataBoundItem;
                selectedCartInventories.Add(I);

            }
        }

        private void AddTocart(List<Inventory> inventories)
        {
            foreach (var inventory in inventories)
            {
                CartInventories.Add(inventory);
                foreach (var i in Inventories)
                {
                    if (i.Sl != inventory.Sl) continue;
                    i.Quantity -= inventory.Quantity;
                    break;
                }
            }



            
            UpdateInventories();
        }


        

        private void UpdateInventories()
        {
            CartGrid.DataSource = null;
            CartGrid.DataSource = CartInventories;
            CartGrid.Columns[4].Visible = false;


          

            InventoryGrid.DataSource = null;
            InventoryGrid.DataSource = Inventories;
            InventoryGrid.Columns[4].Visible = false;

        }


        private void InventoryGrid_Click(object sender, EventArgs e)
        {
            
                SelectedInventories = new List<Inventory>();
                int length = InventoryGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
                for (int i = 0; i < length; i++)
                {
                    Inventory I = (Inventory)InventoryGrid.SelectedRows[i].DataBoundItem;
                    if(I.Quantity>0)
                    SelectedInventories.Add(I);

                }

           
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = searchBox.Text;
                if (string.IsNullOrEmpty(searchText)) throw new Exception("Searchbox is Empty");
                

                var searchedInventories = InventoryContext.SearchWithName(searchText);
                if(searchedInventories==null) throw new Exception("No Data Found");
                InventoryGrid.DataSource = searchedInventories;



            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, exception.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (SelectedInventories!=null)
            {
                AddToCartForm addToCart = new AddToCartForm(SelectedInventories,AddTocart);
                addToCart.ShowDialog(this);
            }
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (selectedCartInventories == null) return;
            foreach (var inventories in selectedCartInventories)
            {
                foreach (var i in Inventories)
                {
                    if (i.Sl == inventories.Sl)
                    {
                        i.Quantity += inventories.Quantity;
                        CartInventories.Remove(inventories);
                        break;
                    }
                }

            }


            UpdateInventories();

        }
    }
}
