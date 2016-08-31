


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


        public SalesForm()
        {
            InventoryContext=new InventoryContext();
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            InventoryGrid.DataSource = InventoryContext.GetInventories();
            InventoryGrid.Columns[4].Visible = false;
            InventoryGrid.Click += InventoryGrid_Click;
        }

        private void InventoryGrid_Click(object sender, EventArgs e)
        {
            
                SelectedInventories = new List<Inventory>();
                int length = InventoryGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
                for (int i = 0; i < length; i++)
                {
                    Inventory I = (Inventory)InventoryGrid.SelectedRows[i].DataBoundItem;
                    SelectedInventories.Add(I);

                }

           
        }

        private void GoButton_Click(object sender, System.EventArgs e)
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
                AddToCartForm addToCart = new AddToCartForm(SelectedInventories);
                addToCart.ShowDialog(this);
            }
            
        }
    }
}
