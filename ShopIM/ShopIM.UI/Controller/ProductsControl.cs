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
        private Product Product { get; set; }
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
            
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Text = @"NEW PRODUCT";
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
               
                LoadProducts();
            }
        }
    }
}
