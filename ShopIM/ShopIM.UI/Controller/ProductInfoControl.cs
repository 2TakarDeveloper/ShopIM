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

namespace ShopIM.UI.Controller
{
    public partial class ProductInfoControl : UserControl
    {
        Product product;
        public ProductInfoControl(Product product)
        {
            this.product = product;
            InitializeComponent();
            
        }
        private void loadProductInfo()
        {
            ProductImage.ImageLocation = product.ImageURL;
            name.Text = product.name;
            Type.Text = product.Type;
            metroLabel4.Text = product.Vendor;
        }
    }
}
