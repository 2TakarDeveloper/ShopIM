using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using ShopIM.BLL;
using ShopIM.Entity;

namespace ShopIM.UI.Controller
{
    public partial class ProductInfoControl : UserControl
    {
        readonly Product _product;
        private ProductRepo productRepo;
        public ProductInfoControl(Product product)
        {
            _product = product;
            productRepo=new ProductRepo();
            InitializeComponent();
            LoadProductInfo();
            
        }
        private void LoadProductInfo()
        {
            try
            {
                ProductImage.Image = Image.FromFile(_product.ImageURL);

            }
            catch (Exception)
            {
                ProductImage.Image = ProductImage.ErrorImage;
            }
            
            name.Text = _product.Name;
            Type.Text = _product.Type;
            VendorLable.Text = _product.Vendor;
        }

      
        private void CrossButton_Click(object sender, EventArgs e)
        {


            try
            {
                if (!productRepo.RemoveProduct(_product)) return;
                Dispose();
                File.Delete(_product.ImageURL);
            }
            catch (Exception exception)
            {
                if (exception.InnerException == null)
                {
                    MetroMessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MetroMessageBox.Show(this, exception.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
