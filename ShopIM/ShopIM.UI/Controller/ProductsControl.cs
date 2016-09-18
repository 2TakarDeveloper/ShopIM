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
        private Product Product { get; set; }
        public ProductsControl()
        {
            InitializeComponent();
         
        }
       

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
            AddProductForm addProductForm = new AddProductForm();
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                Product = addProductForm.Product;
                ProductInfoControl productsControl = new ProductInfoControl(Product);
                productListPanel.Controls.Add(productsControl);

            }
        }
    }
}
