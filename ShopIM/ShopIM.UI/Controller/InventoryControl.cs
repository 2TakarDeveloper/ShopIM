using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShopIM.BLL;
using ShopIM.Entity;
using ShopIM.Library;
using ShopIM.UI.Forms;

namespace ShopIM.UI.Controller
{
    public partial class InventoryControl : UserControl
    {
        private List<Inventory> SelectedInventories { get; set; }

        public InventoryControl()
        {
            
            InitializeComponent();
            LoadInventories();
            InventorySplitContainer.Panel2.Controls.Clear();
            InventorySplitContainer.Panel2.Controls.Add(new InventoryInfoControl(new Inventory()));
        }

       

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var inveontroyForm = new InveontroyForm {Text = @"Add New Inventory"};
            if (inveontroyForm.ShowDialog() != DialogResult.OK) return;
            new InventoryRepo().AddInventory(inveontroyForm.Inventory);
            LoadInventories();
        }

        private void LoadInventories()
        {
            
            var inventories = new InventoryRepo().GetInventories();
            if (SystemSettings.IsNotificationsOn)
                AdminDashboard.UpdateNotification();
            InventoryGrid.DataSource = null;
            InventoryGrid.DataSource = inventories;
            InventoryGrid.Columns[0].Visible = false;
            InventoryGrid.Columns[9].Visible = false;
            InventoryGrid.Columns[11].Visible = false;
        }

        private void InventoryGrid_Click(object sender, EventArgs e)
        {
            var length = InventoryGrid.SelectedRows.Count;
            SelectedInventories = new List<Inventory>();
            for (var i = 0; i < length; i++)
            {
                SelectedInventories.Add((Inventory)InventoryGrid.SelectedRows[i].DataBoundItem);
            }
                
            InventorySplitContainer.Panel2.Controls.Clear();
            if(SelectedInventories.Count>0)
            InventorySplitContainer.Panel2.Controls.Add(new InventoryInfoControl(SelectedInventories[0]));
           
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (InventoryGrid.SelectedRows.Count > 0)
            {
                var inveontroyForm = new InveontroyForm(SelectedInventories[0]) {Text = @"Edit Inventory"};

                if (inveontroyForm.ShowDialog() != DialogResult.OK) return;
                if (new InventoryRepo().UpdateInventory(inveontroyForm.Inventory, SelectedInventories[0]))
                    LoadInventories();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (SelectedInventories != null)
            {
                if (new InventoryRepo().RemoveInventories(SelectedInventories))
                    LoadInventories();
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Searchpicker.Text == @"Name")
            {
                SearchBox.WaterMark = "Ex.Rose";
            }
            else if (Searchpicker.Text == @"Price Range")
            {
                SearchBox.WaterMark = "Ex:100-1000";
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (Searchpicker.Text == @"Name")
            {
                if (string.IsNullOrWhiteSpace(SearchBox.Text)) return;
                var inventories = new InventoryRepo().SearchByName(SearchBox.Text);
                InventoryGrid.DataSource = null;
                InventoryGrid.DataSource = inventories;
                InventoryGrid.Columns[9].Visible = false;
            }
            else if (Searchpicker.Text == @"Price Range")
            {
                if (!string.IsNullOrWhiteSpace(SearchBox.Text))
                {
                    //implement later
                }
            }

        }
    }
}