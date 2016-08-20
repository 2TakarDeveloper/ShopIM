using System;
using System.Drawing;
using MetroFramework.Forms;
using ShopIM.Data;
using System.Collections.Generic;
using System.Linq;
using MetroFramework;

namespace ShopIM.UI
{
    public partial class DashBoard : MetroForm
    {
        readonly ProductRepo _productRepo = new ProductRepo();
        readonly InventoryRepo _inventoryRepo=new InventoryRepo();
        Product _selectedProduct;


        private readonly Login _loginForm;
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
            ProductPicker.DataSource = _productRepo.GetProducts();
        }


        private void ProductGrid_Click(object sender, EventArgs e)
        {
            _selectedProduct=(Product) ProductGrid.SelectedRows[0].DataBoundItem;
            idTextbox.Text = _selectedProduct.Id.ToString();
            nameTextBox.Text = _selectedProduct.Name;
            typeTextBox.Text = _selectedProduct.Type;
            vendorTextbox.Text = _selectedProduct.Vendor;
        }

        protected override void OnClosed(EventArgs e)
        {
            _loginForm.Dispose();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.Id = Int32.Parse(idTextbox.Text);
                product.Name = nameTextBox.Text;
                product.Type = typeTextBox.Text;
                product.Vendor = vendorTextbox.Text;
                ProductRepo.AddProduct(product);
                RefreshProductGrid();
            }
            catch (Exception exception)
            {
             
                MetroMessageBox.Show(this, exception.Message);

            }

        }


        private void RefreshProductGrid()
        {
            ProductGrid.DataSource = _productRepo.GetProducts();
            ProductGrid.Columns[4].Visible = false;
            ProductPicker.DataSource = _productRepo.GetProducts();
        }

        private void RefreshInventoryGrid()
        {
            InventoryGrid.DataSource = _inventoryRepo.GetInventories();
            InventoryGrid.Columns[2].Visible = false;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            
            try{
                ProductRepo.RemoveSelectedProducts(_selectedProduct);
            }catch (Exception exception)
            {
                MetroMessageBox.Show(this, exception.Message);
            }

            RefreshProductGrid();
        }

        
    }
}
