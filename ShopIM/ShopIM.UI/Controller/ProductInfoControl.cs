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
        readonly Product _product;
        public ProductInfoControl(Product product)
        {
            _product = product;
            InitializeComponent();
            LoadProductInfo();
            
        }
        private void LoadProductInfo()
        {
            ProductImage.Image = Image.FromFile(_product.ImageURL);
            ProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            name.Text = _product.Name;
            Type.Text = _product.Type;
            VendorLable.Text = _product.Vendor;
        }
    }
}
