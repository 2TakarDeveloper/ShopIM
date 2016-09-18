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
using ShopIM.Entity;

namespace ShopIM.UI
{
    public partial class AddProductForm : MetroFramework.Forms.MetroForm
    {
        private string _fileName;
        private string _sourceFile;
        public Product Product { get; set; }

        public AddProductForm()
        {
            
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
                //Save the image in a local Directory
                //get appdata/local
                var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                //Folder location defined
                var destinationPath = Path.Combine(appDataPath, @"2takarDeveloper\IMSM\");
                if (!Directory.Exists(destinationPath))
                    Directory.CreateDirectory(destinationPath);

                if (_fileName == null) return;
                var destinationFile = Path.Combine(destinationPath, _fileName);

                File.Copy(_sourceFile, destinationFile, true);

                Product = new Product
                {
                    Name = NameTextBox.Text,
                    Type = TypeTextBox.Text,
                    Vendor = VendorTextBox.Text,
                    ImageURL = destinationFile
                };
                DialogResult = DialogResult.OK;



            }
            catch (Exception)
            {
                //alert user that something has failed
                DialogResult=DialogResult.No;
            }
            finally
            {
                
                Close(); 
            }
            
        }
    }
}
