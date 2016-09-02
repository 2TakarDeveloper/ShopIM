using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using MetroFramework.Forms;


using MetroFramework;
using ShopIM.DAL;
using ShopIM.Entity;
using static ShopIM.UI.NotificationForm;


namespace ShopIM.UI
{
    public partial class DashBoard : MetroForm
    {
        public static bool IsLocked;
        
       
        private readonly ProductContext _productContext = new ProductContext();
        private readonly InventoryContext _inventoryContext = new InventoryContext();

        private readonly Login _loginForm;
        public List<Product> SelectedProducts;
        public List<Inventory> SelectedInventories;

        public static string UserName { get; set; }

        

        public DashBoard(Login loginForm,string userName)
        {
            

            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            _loginForm = loginForm ;
            UserName = userName;
           
            SettingsForm._config =  new ConfigContext().GetSettingses();

            SetupProductTab();
            SetupInventoryTab();

            UpdateNotification();
           

        }

        

        private void SetupProductTab()
        {
            RefreshProductGrid();
            ProductGrid.Click += ProductGrid_Click;
        }

        private void SetupInventoryTab()
        {
            
            RefreshInventoryGrid();
            ProductPicker.DataSource = _productContext.GetAlProducts();
            InventoryGrid.Click += InventoryGrid_Click;
        }

        private void InventoryGrid_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedInventories=new List<Inventory>();
                int length = InventoryGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
                for (int i = 0; i < length; i++)
                {
                    Inventory I = (Inventory)InventoryGrid.SelectedRows[i].DataBoundItem;
                    ProductPicker.Text = I.ProductName;
                    PriceTextBox.Text = I.Price.ToString();
                    DatePicker.Value = I.PurchaseDate;
                    QuantityTextBox.Text = I.Quantity.ToString();
                    SelectedInventories.Add(I);

                }

            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void ProductGrid_Click(object sender, EventArgs e)
        {
            int length = ProductGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            SelectedProducts=new List<Product>();
            for (int i = 0; i < length; i++)
            {
                Product p = (Product)ProductGrid.SelectedRows[i].DataBoundItem;
                
                nameTextBox.Text = p.name;
                typeTextBox.Text = p.Type;
                vendorTextbox.Text = p.Vendor;
                SelectedProducts.Add(p);
            }

        }

        protected override void OnClosed(EventArgs e)
        {
            _loginForm.Show();
          
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MetroMessageBox.Show(this,"Name can't be left Empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Product product = new Product
                    {

                        name = nameTextBox.Text,
                        Type = typeTextBox.Text,
                        Vendor = vendorTextbox.Text
                    };

                    _productContext.AddProduct(product);
                    RefreshProductGrid();
                }
                catch (DbUpdateException exception)
                {

                    MetroMessageBox.Show(this, exception.InnerException.InnerException.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
           

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            try
            {
                product.name = nameTextBox.Text;
                product.Type = typeTextBox.Text;
                product.Vendor = vendorTextbox.Text;
                _productContext.UpdateProduct(product, SelectedProducts[0]);
                RefreshProductGrid();
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

        private void DeleteButton_Product_Click(object sender, EventArgs e)
        {
            try
            {
                _productContext.RemoveProducts(SelectedProducts);
            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, exception.InnerException.InnerException.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshProductGrid();
        }


        private void RefreshProductGrid()
        {

            try
            {
                ProductGrid.DataSource = _productContext.GetAlProducts();
                ProductPicker.DataSource = _productContext.GetAlProducts();
            }
            catch (Exception)
            {
                //ignored
            }
            
        }

        

       

        private void InventoryAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory I = new Inventory
                {
                    ProductName = ProductPicker.Text,
                    Price = double.Parse(PriceTextBox.Text),
                    PurchaseDate = DatePicker.Value,
                    Quantity = int.Parse(QuantityTextBox.Text)
                };

                _inventoryContext.AddInventory(I);
                RefreshInventoryGrid();
                
                    UpdateNotification();
                
                
                
            }
            catch (Exception exception)
            {

                MetroMessageBox.Show(this, exception.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        

        private void InventoryRemove_Click(object sender, EventArgs e)
        {

            _inventoryContext.RemoveInventories(SelectedInventories);

            RefreshInventoryGrid();
            
                UpdateNotification();
            
        }

        

        private void InventoryEditButton_Click(object sender, EventArgs e)
        {

            Inventory inventory = new Inventory();
            try
            {
                inventory.Price = double.Parse(PriceTextBox.Text);
                inventory.PurchaseDate = DatePicker.Value;
                inventory.Quantity = int.Parse(QuantityTextBox.Text);
                inventory.Sl = SelectedInventories[0].Sl;
                inventory.ProductName = SelectedInventories[0].ProductName;

                _inventoryContext.UpdateInventory(inventory,SelectedInventories[0]);

               RefreshInventoryGrid();
                
                    UpdateNotification();
               
                MetroMessageBox.Show(this, "Successfully Modified", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {

                if(exception.InnerException!=null)
                    MetroMessageBox.Show(this, exception.InnerException.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MetroMessageBox.Show(this, exception.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }





        }


        private void UpdateNotification()
        {
            var length=0;
            Notifications = SettingsForm._config.Alert == 0 ? new List<Notification>() : _inventoryContext.CheckQuantity(SettingsForm._config.ThreshHold, out length);

            notificationTile.Text = @"Notification(" + length + @")";
            
        }

        private void RefreshInventoryGrid()
        {
            InventoryGrid.DataSource = _inventoryContext.GetInventories();
          

        }

        //Home Tiles

        private void userTile_Click(object sender, EventArgs e)
        {
            var userForm = new AdminPanel(UserName);
            userForm.ShowDialog(this);
        }

        private void logTile_Click(object sender, EventArgs e)
        {
            var logForm = new LogForm();
            logForm.ShowDialog(this);
        }

        private void notificationTile_Click(object sender, EventArgs e)
        {
            var notificationForm = new NotificationForm();
            notificationForm.ShowDialog(this);
        }

        private void LockTile_Click(object sender, EventArgs e)
        {
            IsLocked = !IsLocked;
            
            var verificationForm = new VerificationForm(LockTrigger);
            verificationForm.ShowDialog(this);

           

        }

        private void LockTrigger(string errorMsg,VerificationForm verificationForm)
        {
            if (errorMsg == "")
            {
                if (!IsLocked) return;
                IsLocked = false;
                verificationForm.Close();
            }
            else
            {
                MetroMessageBox.Show(this, errorMsg, "Notification", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

        }



        private void settingsTile_Click(object sender, EventArgs e)
        {
            var settingsForm=new SettingsForm(UpdateNotification);
            settingsForm.ShowDialog(this);
        }

        private void salesTile_Click(object sender, EventArgs e)
        {
            
                var salesForm = new SalesForm(UserName);
           
                salesForm.ShowDialog(this);
            
        }

        private void LogOutTile_Click(object sender, EventArgs e)
        {
            
            Close();

        }
    }
}
