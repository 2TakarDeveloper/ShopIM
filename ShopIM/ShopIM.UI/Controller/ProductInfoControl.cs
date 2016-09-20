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

        public delegate void Refresh();

        private Refresh refreshPanel;
        public ProductInfoControl(Product product,Refresh refreshPanel)
        {
            this.refreshPanel = refreshPanel;
            _product = product;
            productRepo=new ProductRepo();
            InitializeComponent();
            LoadProductInfo();
            
        }
        private void LoadProductInfo()
        {
            try
            {
                using (FileStream fileStream = new FileStream(_product.ImageURL, FileMode.Open, FileAccess.Read))
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
                if (!productRepo.RemoveProduct(_product)) return;
                Dispose();
                if (!string.IsNullOrEmpty(_product.ImageURL))
                {
                    File.Delete(_product.ImageURL);
                }
              
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
                        MetroMessageBox.Show(this, exception.InnerException.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void EditButton_Click(object sender, EventArgs e)
        {
           
            ProductForm productForm = new ProductForm(_product);
            try
            {
                if (productForm.ShowDialog() == DialogResult.OK)
                {
                    if (new ProductRepo().UpdateProduct(productForm.Product, _product, productForm._desitnationFile,
                        productForm._sourceFile))
                    {
                        refreshPanel();
                        File.Delete(_product.ImageURL);
                    }
                  
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
