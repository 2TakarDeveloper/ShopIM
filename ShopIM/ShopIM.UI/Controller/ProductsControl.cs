using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework;
using ShopIM.BLL;
using ShopIM.Entity;
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
            List<Product> products=new  List<Product>();

            switch (SearchPicker.Text)
            {
                case @"Name":
                    products = new ProductRepo().SearchByName(string.IsNullOrWhiteSpace(SearchBox.Text) ? "" : SearchBox.Text);
                    break;
                case @"Type":
                    products = new ProductRepo().SearchByType(string.IsNullOrWhiteSpace(SearchBox.Text) ? "" : SearchBox.Text);
                    break;
            }

            productListPanel.Controls.Clear();
            foreach (var product in products)
            {
                var productsControl = new ProductInfoControl(product);
                productListPanel.Controls.Add(productsControl);
            }



        }
    }
}