using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using ShopIM.DAL;
using ShopIM.Entity;

namespace ShopIM.UI
{
    public partial class UserList : MetroFramework.Forms.MetroForm
    {
        private List<User> selectedUsers;
        public UserList()
        {
            InitializeComponent();
         
            UserGrid.DataSource = new UserContext().GetUsers();
            UserGrid.Click += UserGrid_Click;
            TypePicker.Text = @"SalesMan";
        }


        private void RefreshUserGrid()
        {
            UserGrid.DataSource = new UserContext().GetUsers();
            UserGrid.Refresh();
        }

        private void UserGrid_Click(object sender, EventArgs e)
        {
            selectedUsers = new List<User>();
            int length = UserGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            for (int i = 0; i < length; i++)
            {
                User I = (User)UserGrid.SelectedRows[i].DataBoundItem;
                NameTextBox.Text = I.UserName;
                PasswordTextBox.Text = I.UserPassword;
                TypePicker.Text = I.UserType;
                selectedUsers.Add(I);

            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MetroMessageBox.Show(this, "Required Fields Are empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    User user = new User();
                    user.UserName = NameTextBox.Text;
                    user.UserPassword = PasswordTextBox.Text;
                    user.UserType = TypePicker.Text;
                    new UserContext().CreateNewUser(user);
                    RefreshUserGrid();
                }
                catch (DbUpdateException exception)
                {

                    MetroMessageBox.Show(this, exception.InnerException.InnerException.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

       

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (selectedUsers != null)
            {
                new UserContext().RemoveUsers(selectedUsers);
                RefreshUserGrid();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
       
            try
            {
                User user = new User
                {
                    UserName = NameTextBox.Text,
                    UserPassword = PasswordTextBox.Text,
                    UserType = TypePicker.Text
                };

                new UserContext().UpdateUser(user, selectedUsers[0]);
                RefreshUserGrid();
            }
            catch (Exception exception)
            {

                if (exception.InnerException != null)
                    MetroMessageBox.Show(this, exception.InnerException.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MetroMessageBox.Show(this, exception.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
