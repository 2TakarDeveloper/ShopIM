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

namespace ShopIM.UI
{
    public partial class AddProductForm : MetroFramework.Forms.MetroForm
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddPictureBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "C:/Picture/";
                fileDialog.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    ProductImage.Image = Image.FromFile(fileDialog.FileName);
                    ProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
                  
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
