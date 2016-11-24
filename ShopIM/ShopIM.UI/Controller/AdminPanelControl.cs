using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShopIM.BLL;
using ShopIM.Entity;
using ShopIM.UI.Forms;

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
            UserGrid.DataSource = null;
            UserGrid.DataSource = users;
            UserGrid.Columns[0].Visible = false;
            UserGrid.Columns[4].Visible = false;
            UserSplitContainer.Panel2.Controls.Clear();
            UserSplitContainer.Panel2.Controls.Add(new UserInfoControl(new User()));

        }

        private void UserGrid_Click(object sender, EventArgs e)
        {
            var length = UserGrid.SelectedRows.Count;
            SelectedUsers = new List<User>();
            for (var i = 0; i < length; i++)
            {
                SelectedUsers.Add((User)UserGrid.SelectedRows[i].DataBoundItem);
            }
                
            UserSplitContainer.Panel2.Controls.Clear();
           if(SelectedUsers.Count>0)
            UserSplitContainer.Panel2.Controls.Add(new UserInfoControl(SelectedUsers[0]));
           
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (UserGrid.SelectedRows.Count > 0)
            {
                var UserForm = new UserForm(SelectedUsers[0]);

                if (UserForm.ShowDialog() == DialogResult.OK)
                    if (new UserRepo().UpdateUser(UserForm.User))
                    {
                      LoadUsers();  
                    }
                       
            }
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