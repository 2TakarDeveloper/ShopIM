using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using ShopIM.Entity;

namespace ShopIM.UI
{
    public partial class UserForm : Form
    {
        public string DesitnationFile;
        private string _fileName;
        public string SourceFile;

        public User User { get; set; }
        public UserForm()
        {
            InitializeComponent();
            Text = @"Create New User";
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                    throw new Exception("Name Can't be left Empty");
                if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
                {
                    throw new Exception("Password Can't be left Empty");
                }
                if (!ConfirmtextBox.Text.Equals(PasswordTextBox.Text))
                {
                    throw new Exception("Password Don't Match");
                }


                //Save the image in a local Directory
                //get appdata/local
                var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                //Folder location defined
                var destinationPath = Path.Combine(appDataPath, @"2takarDeveloper\IMSM\");
                if (!Directory.Exists(destinationPath))
                    Directory.CreateDirectory(destinationPath);


                if (_fileName != null)
                    DesitnationFile = Path.Combine(destinationPath, _fileName);


                User = new User
                {
                    UserName = NameTextBox.Text,
                    UserType = TypePicker.Text,
                    UserPassword = ConfirmtextBox.Text,
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
    }
}
