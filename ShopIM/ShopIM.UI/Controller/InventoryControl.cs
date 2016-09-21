using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShopIM.BLL;
using ShopIM.Entity;

namespace ShopIM.UI.Controller
{
    public partial class InventoryControl : UserControl
    {
        public InventoryControl()
        {
            
            InitializeComponent();
            LoadInventories();
        }

        private List<Inventory> SelectedInventories { get; set; }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var inveontroyForm = new InveontroyForm {Text = @"Add New Inventory"};
            if (inveontroyForm.ShowDialog() == DialogResult.OK)
            {
                new InventoryRepo().AddInventory(inveontroyForm.Inventory);
                LoadInventories();
            }
        }

        private void LoadInventories()
        {
            var inventories = new InventoryRepo().GetInventories();
            InventoryGrid.DataSource = null;
            InventoryGrid.DataSource = inventories;
            InventoryGrid.Columns[9].Visible = false;
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

                if (inveontroyForm.ShowDialog() == DialogResult.OK)
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
    }
}