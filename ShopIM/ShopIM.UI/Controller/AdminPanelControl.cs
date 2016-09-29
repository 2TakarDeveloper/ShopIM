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
           
        }

       

        private void AddBtn_Click(object sender, EventArgs e)
        {
            UserForm userForm=new UserForm();
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                if (new UserRepo().AddUser(userForm.User, userForm.SourceFile))
                {
                    LoadUsers();
                }
               
            }
        }

        private void LoadUsers()
        {
            var users = new UserRepo().GetUsers();
            InventoryGrid.DataSource = null;
            InventoryGrid.DataSource = users;
            InventoryGrid.Columns[0].Visible = false;
            InventoryGrid.Columns[4].Visible = false;
            InventorySplitContainer.Panel2.Controls.Clear();
            InventorySplitContainer.Panel2.Controls.Add(new UserInfoControl(new User()));

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
           if(SelectedUsers.Count>0)
            InventorySplitContainer.Panel2.Controls.Add(new UserInfoControl(SelectedUsers[0]));
           
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            //if (InventoryGrid.SelectedRows.Count > 0)
            //{
            //    var inveontroyForm = new InveontroyForm(SelectedUsers[0]) {Text = @"Edit Inventory"};

            //    if (inveontroyForm.ShowDialog() == DialogResult.OK)
            //        if (new InventoryRepo().UpdateInventory(inveontroyForm.Inventory, SelectedUsers[0]))
            //            SelectedUsers();
            //}
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (SelectedUsers != null)
            {
                if (new UserRepo().RemoveUsers(SelectedUsers))
                    LoadUsers();
            }

        }




    }
}