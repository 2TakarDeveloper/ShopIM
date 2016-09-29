using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShopIM.BLL;
using ShopIM.Entity;

namespace ShopIM.UI.Controller
{
    public partial class TableViewControl : UserControl
    {
        private List<User> SelectedUsers { get; set; }

        public TableViewControl()
        {
            
            InitializeComponent();
            LoadUsers();
            //InventorySplitContainer.Panel2.Controls.Clear();
           // InventorySplitContainer.Panel2.Controls.Add(new InventoryInfoControl(new Inventory()));
        }

       

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var UserForm = new UserForm {Text = @"Create New User"};
            if (UserForm.ShowDialog() == DialogResult.OK)
            {
                new UserRepo().AddUser(UserForm.User);
                LoadUsers();
            }
        }

        private void LoadUsers()
        {
            var users = new UserRepo().GetUsers();
            InventoryGrid.DataSource = null;
            InventoryGrid.DataSource = users;
          
        }

        private void InventoryGrid_Click(object sender, EventArgs e)
        {
            var length = InventoryGrid.SelectedRows.Count;
            SelectedUsers = new List<User>();
            for (var i = 0; i < length; i++)
            {
                SelectedUsers.Add((User)InventoryGrid.SelectedRows[i].DataBoundItem);
            }
                
            InventorySplitContainer.Panel2.Controls.Clear();
           // if(SelectedUsers.Count>0)
           // InventorySplitContainer.Panel2.Controls.Add(new InventoryInfoControl(SelectedUsers[0]));
           
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (InventoryGrid.SelectedRows.Count > 0)
            {
                //var inveontroyForm = new InveontroyForm(SelectedUsers[0]) {Text = @"Edit Inventory"};

                //if (inveontroyForm.ShowDialog() == DialogResult.OK)
                //    if (new InventoryRepo().UpdateInventory(inveontroyForm.Inventory, SelectedUsers[0]))
                //        SelectedUsers();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //if (SelectedInventories != null)
            //{
            //    if (new InventoryRepo().RemoveInventories(SelectedInventories))
            //        LoadInventories();
            //}
           
        }

   

     
    }
}