using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopIM.Entity;
using ShopIM.UI.Controller;

namespace ShopIM.UI.Controller
{
    public partial class ProductsControl : UserControl
    {
        public ProductsControl()
        {
            InitializeComponent();
            loadProductList();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadProductList()
        {
            Product product = new Product();
            product.name = "Lily";
            product.Type = "Flower";
            product.Vendor = "SHihab";
            product.ImageURL = @"download.jpg";
            productListPanel.Controls.Clear();

            for (int i = 0; i < 10; i++)
            {
                ProductInfoControl productsControl = new ProductInfoControl(product);
                productListPanel.Controls.Add(productsControl);

            }
       
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog(this);
        }
    }
}
