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
       
        private ProductContext _productContext = new ProductContext();
 
        private readonly Login _loginForm;
        private List<Product> _selectedProducts=new List<Product>();

        public DashBoard(Login loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm ;
            



            SetupProductTab();
            SetupInventoryTab();
           

        }

        private void SetupProductTab()
        {
            RefreshProductGrid();
            ProductGrid.Click += ProductGrid_Click;
        }

        private void SetupInventoryTab()
        {
            RefreshInventoryGrid();
        
            InventoryGrid.Click += InventoryGrid_Click;
        }

        private void InventoryGrid_Click(object sender, EventArgs e)
        {
            try
            {
           
                //ProductPicker.SelectedText = inventory.Product.ToString();
                //PriceTextBox.Text = inventory.Price.ToString();
                //DatePicker.Value = (DateTime) inventory.PurchaseDate;
                //QuantityTextBox.Text = inventory.Quantity.ToString();
               
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
             
                MetroMessageBox.Show(this, exception.Message);

            }

        }


        private void RefreshProductGrid()
        {

            try
            {
                ProductGrid.DataSource = _productContext.GetAlProducts();
                //ProductPicker.DataSource = _productRepo.GetProducts();
            }
            catch (Exception exception)
            {
                //ignored
            }
            
        }

        private void RefreshInventoryGrid()
        {
            //InventoryGrid.DataSource = _inventoryRepo.GetInventories();
            //InventoryGrid.Columns[2].Visible = false;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            
            try{
               _productContext.RemoveProducts(_selectedProducts);
            }catch (Exception exception)
            {
                MetroMessageBox.Show(this, exception.Message);
            }

            RefreshProductGrid();
        }

        private void InventoryAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Inventory I = new Inventory();
                //Product p;
                //p = (Product)ProductPicker.SelectedValue;
                //I.Product = p;
                //I.Price = Int32.Parse(PriceTextBox.Text);
                //I.InventoryNo= Int32.Parse(InventoryNoTextBox.Text);
                //I.PurchaseDate = DatePicker.Value;
                //I.Quantity= Int32.Parse(QuantityTextBox.Text);
                //_inventoryRepo.AddInventory(I);
                RefreshInventoryGrid();
            }
            catch (Exception exception)
            {

                MetroMessageBox.Show(this, exception.Message);

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

                MetroMessageBox.Show(this, exception.Message);

            }

            
        }

        private void InventoryRemove_Click(object sender, EventArgs e)
        {

            //new InventoryRepo().Remove(_selectedInventories);

            RefreshInventoryGrid();
        }
    }
}
