using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;


using MetroFramework;
using ShopIM.DAL;
using ShopIM.Entity;


namespace ShopIM.UI
{
    public partial class DashBoard : MetroForm
    {
       
        private readonly ProductContext _productContext = new ProductContext();
        private readonly InventoryContext _inventoryContext = new InventoryContext();

        private readonly Login _loginForm;
        private readonly List<Product> _selectedProducts=new List<Product>();
        private readonly List<Inventory> _selectedInventories = new List<Inventory>();

        private string UserName { get; set; }

        

        public DashBoard(Login loginForm,string userName)
        {
            InitializeComponent();
            _loginForm = loginForm ;
            UserName = userName;



            SetupProductTab();
            SetupInventoryTab();
           

        }

        private void SetupHomeTab()
        {
            
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

                int length = InventoryGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
                for (int i = 0; i < length; i++)
                {
                    Inventory I = (Inventory)InventoryGrid.SelectedRows[i].DataBoundItem;
                    ProductPicker.Text = I.ProductName;
                    PriceTextBox.Text = I.Price.ToString();
                    DatePicker.Value = I.PurchaseDate;
                    QuantityTextBox.Text = I.Quantity.ToString();
                    _selectedInventories.Add(I);

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
            for (int i = 0; i < length; i++)
            {
                Product p = (Product)ProductGrid.SelectedRows[i].DataBoundItem;
                
                nameTextBox.Text = p.name;
                typeTextBox.Text = p.Type;
                vendorTextbox.Text = p.Vendor;
                _selectedProducts.Add(p);
            }

        }

        protected override void OnClosed(EventArgs e)
        {
            _loginForm.Dispose();
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
                catch (Exception exception)
                {

                    MetroMessageBox.Show(this, exception.InnerException.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
           

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

        private void RefreshInventoryGrid()
        {
            InventoryGrid.DataSource = _inventoryContext.GetInventories();
            
        }

       

        private void InventoryAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory I = new Inventory
                {
                    ProductName = ProductPicker.Text,
                    Price = int.Parse(PriceTextBox.Text),
                    PurchaseDate = DatePicker.Value,
                    Quantity = int.Parse(QuantityTextBox.Text)
                };

                _inventoryContext.AddInventory(I);
                RefreshInventoryGrid();
            }
            catch (Exception exception)
            {

                MetroMessageBox.Show(this, exception.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                _productContext.UpdateProduct(product,_selectedProducts[0]);
                RefreshProductGrid();
            }
            catch (Exception exception)
            {

                MetroMessageBox.Show(this, exception.InnerException.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            
        }

        private void InventoryRemove_Click(object sender, EventArgs e)
        {

            _inventoryContext.RemoveInventories(_selectedInventories);

            RefreshInventoryGrid();
        }

        private void DeleteButton_Product_Click(object sender, EventArgs e)
        {
            try
            {
                _productContext.RemoveProducts(_selectedProducts);
            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, exception.InnerException.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshProductGrid();
        }

        private void InventoryEditButton_Click(object sender, EventArgs e)
        {

            Inventory inventory = new Inventory();
            try
            {
                inventory.Price = int.Parse(PriceTextBox.Text);
                inventory.PurchaseDate = DatePicker.Value;
                inventory.Quantity = int.Parse(QuantityTextBox.Text);
                inventory.Sl = _selectedInventories[0].Sl;
                inventory.ProductName = _selectedInventories[0].ProductName;

                _inventoryContext.UpdateInventory(inventory,_selectedInventories[0]);

               RefreshInventoryGrid();
            }
            catch (Exception exception)
            {

                MetroMessageBox.Show(this, exception.InnerException.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        //Home Tiles

        private void userTile_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(UserName);
            userForm.ShowDialog(this);
        }
    }
}
