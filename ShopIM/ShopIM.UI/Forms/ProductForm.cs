using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using ShopIM.Entity;

namespace ShopIM.UI.Forms
{
    public partial class ProductForm : Form
    {
        public string DesitnationFile;
        private string _fileName;
        public string SourceFile;

        public ProductForm()
        {
            InitializeComponent();

            Text = @"Add Product";
            DesitnationFile = null;
        }

        public ProductForm(Product product)
        {
            InitializeComponent();
            Text = @"Edit Product";

            NameTextBox.Text = product.Name;
            NameTextBox.ReadOnly = true;
            TypeTextBox.Text = product.Type;
            try
            {
                using (var fileStream = new FileStream(product.ImageURL, FileMode.Open, FileAccess.Read))
                {
                    ProductImage.Image = Image.FromStream(fileStream);
                }

                DesitnationFile = product.ImageURL;
            }
            catch (Exception)
            {
                ProductImage.Image = ProductImage.ErrorImage;
                DesitnationFile = null;
            }
        }

        public Product Product { get; set; }


        private void AddPictureBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var fileDialog = new OpenFileDialog
                {
                    InitialDirectory = "C:/Picture/",
                    Filter =
                        @"BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff| All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff"
                };
                fileDialog.FilterIndex = 6;
                if (fileDialog.ShowDialog() != DialogResult.OK) return;


                using (var fileStream = new FileStream(fileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    ProductImage.Image = Image.FromStream(fileStream);
                }

                _fileName = fileDialog.SafeFileName;
                SourceFile = fileDialog.FileName;
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
                    throw new Exception("Name Can't be left Empty");
                //Save the image in a local Directory
                //get appdata/local
                var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                //Folder location defined
                var destinationPath = Path.Combine(appDataPath, @"2takarDeveloper\IMSM\");
                if (!Directory.Exists(destinationPath))
                    Directory.CreateDirectory(destinationPath);


                if (_fileName != null)
                    DesitnationFile = Path.Combine(destinationPath, _fileName);


                Product = new Product
                {
                    Name = NameTextBox.Text,
                    Type = TypeTextBox.Text,
                    ImageURL = DesitnationFile
                };


                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}