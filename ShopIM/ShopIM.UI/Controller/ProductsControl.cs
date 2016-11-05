using System;
using System.Windows.Forms;
using MetroFramework;
using ShopIM.BLL;
using ShopIM.UI.Forms;

namespace ShopIM.UI.Controller
{
    public partial class ProductsControl : UserControl
    {
        private readonly ProductRepo _productRepo;

        public ProductsControl()
        {
            _productRepo = new ProductRepo();
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = _productRepo.GetProducts();
            productListPanel.Controls.Clear();

            foreach (var product in products)
            {
                var productsControl = new ProductInfoControl(product);
                productListPanel.Controls.Add(productsControl);
            }
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            var addProductForm = new ProductForm();
            if (addProductForm.ShowDialog() == DialogResult.OK)
                try
                {
                    if (_productRepo.AddProduct(addProductForm.Product, addProductForm.SourceFile,
                        addProductForm.DesitnationFile))
                        LoadProducts();
                }
                catch (Exception exception)
                {
                    if (exception.InnerException != null)
                    {
                        if (exception.InnerException.InnerException != null)
                            MetroMessageBox.Show(this, exception.InnerException.InnerException.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchPicker.Text == @"Name")
            {
                if (!string.IsNullOrWhiteSpace(SearchBox.Text))
                {
                    var products = new ProductRepo().SearchByName(SearchBox.Text);
        
                    productListPanel.Controls.Clear();

                    foreach (var product in products)
                    {
                        var productsControl = new ProductInfoControl(product);
                        productListPanel.Controls.Add(productsControl);
                    }

                }
            }
            else if (SearchPicker.Text == @"Type")
            {
                if (string.IsNullOrWhiteSpace(SearchBox.Text)) return;
                var products = new ProductRepo().SearchByType(SearchBox.Text);

                productListPanel.Controls.Clear();

                foreach (var product in products)
                {
                    var productsControl = new ProductInfoControl(product);
                    productListPanel.Controls.Add(productsControl);
                }
            }
        }
    }
}