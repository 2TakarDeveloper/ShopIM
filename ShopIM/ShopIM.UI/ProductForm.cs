using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework;
using ShopIM.BLL;
using ShopIM.Entity;

namespace ShopIM.UI
{
    public partial class ProductForm : MetroFramework.Forms.MetroForm
    {
        private string _fileName;
        public string _sourceFile;
        public string _desitnationFile;
        public Product Product { get; set; }
        private ProductRepo productRepo;

        public ProductForm()
        {
            productRepo=new ProductRepo();
            InitializeComponent();
            Text = @"Add Product";
        }

        public ProductForm(Product product)
        {
            productRepo = new ProductRepo();
            InitializeComponent();
            Text = @"Edit Product";
            NameTextBox.Text = product.Name;
            NameTextBox.ReadOnly = true;
            TypeTextBox.Text = product.Type;
            try
            {
                ProductImage.Image = Image.FromFile(product.ImageURL);
            }
            catch (Exception)
            {
                ProductImage.Image = ProductImage.ErrorImage;
            }
           

        }


        private void AddPictureBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var fileDialog = new OpenFileDialog
                {
                    InitialDirectory = "C:/Picture/",
                    Filter = @"BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff| All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff"
                };
                fileDialog.FilterIndex = 6;
                if (fileDialog.ShowDialog() != DialogResult.OK) return;

                ProductImage.Image = Image.FromFile(fileDialog.FileName);

                _fileName = fileDialog.SafeFileName;
                _sourceFile = fileDialog.FileName;


            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                {
                    throw new Exception("Name Can't be left Empty");
                        
                }
                //Save the image in a local Directory
                //get appdata/local
                var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                //Folder location defined
                var destinationPath = Path.Combine(appDataPath, @"2takarDeveloper\IMSM\");
                if (!Directory.Exists(destinationPath))
                    Directory.CreateDirectory(destinationPath);


                     _desitnationFile = null;
                    if (_fileName != null)
                    {
                       _desitnationFile = Path.Combine(destinationPath, _fileName);
                    }
                


                    Product = new Product
                    {
                        Name = NameTextBox.Text,
                        Type = TypeTextBox.Text,
                        ImageURL = _desitnationFile
                    };


                
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exception)
            {
               
               MetroMessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
            }
            
            
        }
    }
}
