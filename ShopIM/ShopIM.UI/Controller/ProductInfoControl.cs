using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using ShopIM.BLL;
using ShopIM.Entity;

namespace ShopIM.UI.Controller
{
    public partial class ProductInfoControl : UserControl
    {
        private readonly ProductRepo _productRepo;
        private Product _product;


        public ProductInfoControl(Product product)
        {
            _product = product;
            _productRepo = new ProductRepo();
            InitializeComponent();
            LoadProductInfo();
        }

        private void LoadProductInfo()
        {
            try
            {
                using (var fileStream = new FileStream(_product.ImageURL, FileMode.Open, FileAccess.Read))
                {
                    ProductImage.Image = Image.FromStream(fileStream);
                }
            }
            catch (Exception)
            {
                ProductImage.Image = ProductImage.ErrorImage;
            }

            name.Text = _product.Name;
            Type.Text = _product.Type;
        }


        private void CrossButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_productRepo.RemoveProduct(_product)) return;
                Dispose();
                if (!string.IsNullOrEmpty(_product.ImageURL))
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
                    if (exception.InnerException.InnerException != null)
                        MetroMessageBox.Show(this, exception.InnerException.InnerException.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var productForm = new ProductForm(_product);
            try
            {
                if (productForm.ShowDialog() == DialogResult.OK)
                    if (new ProductRepo().UpdateProduct(productForm.Product, _product, productForm.DesitnationFile,
                        productForm.SourceFile))
                    {
                        var oldImage = _product.ImageURL;
                        _product = productForm.Product;
                        LoadProductInfo();
                        if (!productForm.Product.ImageURL.Equals(oldImage))
                            File.Delete(oldImage);
                    }
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
                    MetroMessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}