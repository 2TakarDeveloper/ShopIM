using System;
using System.Drawing;

using System.IO;

using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using ShopIM.BLL;
using ShopIM.Entity;

namespace ShopIM.UI.Controller
{
    public partial class UserEditControl : UserControl
    {
        private User User { get; set; }
        public string FileName { get;  set; }
        public string SourceFile { get; set; }
        public string DesitnationFile { get;  set; }
        private MetroLink UserButton;

        public UserEditControl(User user,MetroLink userButton)
        {
            User = user;
            UserButton = userButton;
            InitializeComponent();
            NameTextBox.Text = User.UserName;
            try
            {
                using (var fileStream = new FileStream(User.ImageURL, FileMode.Open, FileAccess.Read))
                {
                    UserImage.Image = Image.FromStream(fileStream);
                }

            }
            catch (Exception)
            {
                UserImage.Image = UserImage.ErrorImage;
    
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
                        @"BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff| All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff",
                    FilterIndex = 6
                };
                if (fileDialog.ShowDialog() != DialogResult.OK) return;


                using (var fileStream = new FileStream(fileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    UserImage.Image = Image.FromStream(fileStream);
                }

                FileName = fileDialog.SafeFileName;
                SourceFile = fileDialog.FileName;
                ImageSubmit.Visible = true;
            }
            catch (Exception)
            {
                // ignored
            }
        }

       

        private void nameEdit_Click(object sender, EventArgs e)
        {
            NameTextBox.ReadOnly = false;
            NameTextBox.Text = "";
            NameSubmit.Visible = true;
        }

        private void ImageSubmit_Click(object sender, EventArgs e)
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


                if (FileName != null)
                    DesitnationFile = Path.Combine(destinationPath, FileName);


                //update Destination file in database of user
                User.ImageURL = DesitnationFile;
                //copy the file 1st then store in DB. it's a workaround don't mess with it.
                if (DesitnationFile != null && SourceFile != null)
                {
                    File.Copy(SourceFile, DesitnationFile, true);
                }

                if (new UserRepo().UpdateUser(User))
                {
                    ImageSubmit.Visible = false;
                }



            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void NameSubmit_Click(object sender, EventArgs e)
        {
            User.UserName = NameTextBox.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(User.UserName))
                {
                    throw  new Exception("Name can't be Empty");
                }
                if (new UserRepo().UpdateUser(User))
                {

                    NameSubmit.Visible = false;
                    NameTextBox.ReadOnly = true;
                    UserButton.Text = User.UserName;
                }
            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
