using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using ShopIM.BLL;
using ShopIM.Entity;
using ShopIM.UI.Controller;

namespace ShopIM.UI.Controller
{
    public partial class ProductsControl : UserControl
    {
        private ProductRepo productRepo;
        public ProductsControl()
        {
            productRepo= new ProductRepo();
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            List<Product> products = productRepo.GetProducts();
            productListPanel.Controls.Clear();

            foreach (var product in products)
            {
                ProductInfoControl productsControl = new ProductInfoControl(product);
                productListPanel.Controls.Add(productsControl);
            }
            
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            
            ProductForm addProductForm = new ProductForm();
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (productRepo.AddProduct(addProductForm.Product, addProductForm._sourceFile, addProductForm._desitnationFile))
                    {
                        LoadProducts();
                    }
                  
                }
                catch (Exception exception)
                {
                    if (exception.InnerException != null)
                    {
                        if (exception.InnerException.InnerException != null)
                            MetroMessageBox.Show(this, exception.InnerException.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }
    }
}
