using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using ShopIM.Entity;

namespace ShopIM.UI.Forms
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
            User = new User();
        }


        public UserForm(User user)
        {
            User = user;
            InitializeComponent();
            Text = @"Update User";
            NameTextBox.Text = user.UserName;
            NameTextBox.ReadOnly = true;
            TypePicker.Text = User.UserType;
            PasswordTextBox.Text = User.UserPassword;
            ConfirmtextBox.Text = User.UserPassword;



            try
            {
                using (var fileStream = new FileStream(user.ImageURL, FileMode.Open, FileAccess.Read))
                {
                    ProductImage.Image = Image.FromStream(fileStream);
                }

                DesitnationFile = user.ImageURL;
            }
            catch (Exception)
            {
                ProductImage.Image = ProductImage.ErrorImage;
                DesitnationFile = null;
            }
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


                

                User.UserName = NameTextBox.Text;
                User.UserType = TypePicker.Text;
                User.UserPassword = ConfirmtextBox.Text;
                User.ImageURL = DesitnationFile;


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
