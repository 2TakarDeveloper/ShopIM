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
    public partial class AddProductForm : MetroFramework.Forms.MetroForm
    {
        private string _fileName;
        private string _sourceFile;
        public Product Product { get; set; }
        private ProductRepo productRepo;

        public AddProductForm()
        {
            productRepo=new ProductRepo();
            InitializeComponent();
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
                ProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
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


                    string destinationFile=null;
                    if (_fileName != null)
                    {
                        destinationFile = Path.Combine(destinationPath, _fileName);
                     }
                


                    Product = new Product
                    {
                        Name = NameTextBox.Text,
                        Type = TypeTextBox.Text,
                        Vendor = VendorTextBox.Text,
                        ImageURL = destinationFile
                    };


                    productRepo.AddProduct(Product, _sourceFile, destinationFile);

                    DialogResult = DialogResult.OK;
                    Close();
                
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
