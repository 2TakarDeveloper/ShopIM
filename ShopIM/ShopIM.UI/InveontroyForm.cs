using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using ShopIM.BLL;
using ShopIM.Entity;

namespace ShopIM.UI
{
    public partial class InveontroyForm : Form
    {
        public InveontroyForm()
        {
            var productRepo = new ProductRepo();
            InitializeComponent();
            ProductPicker.DataSource = productRepo.GetProducts();
        }


        public InveontroyForm(Inventory selectedInventory)
        {
          

            InitializeComponent();
            try
            {
                using (
                    var fileStream = new FileStream(selectedInventory.Product.ImageURL, FileMode.Open, FileAccess.Read))
                {
                    ProductImage.Image = Image.FromStream(fileStream);
                }
            }
            catch (Exception)
            {
                ProductImage.Image = ProductImage.ErrorImage;
            }
            ProductPicker.Dispose();
            MetroLabel label = new MetroLabel();
            label.Text = selectedInventory.ProductName;
            ProductNamePanel.Controls.Add(label);
            name.Text = selectedInventory.Product.Name;
            Type.Text = selectedInventory.Product.Type;
            VendorTextBox.Text = selectedInventory.Vendor;
            Quantity.Value = selectedInventory.Quantity;
            Threashold.Value = selectedInventory.Threashold;
            DatePicker.Value = selectedInventory.PurchaseDate;
            Price.Value = (decimal) selectedInventory.Cost;
            SellingPrice.Value = (decimal) selectedInventory.SellingPrice;
            StockLocation.Text = selectedInventory.StockLocation;
        }

        public Inventory Inventory { get; set; }


        private void metroLink1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = (Product) ProductPicker.SelectedItem;
            try
            {
                using (var fileStream = new FileStream(product.ImageURL, FileMode.Open, FileAccess.Read))
                {
                    ProductImage.Image = Image.FromStream(fileStream);
                }
            }
            catch (Exception)
            {
                ProductImage.Image = ProductImage.ErrorImage;
            }

            name.Text = product.Name;
            Type.Text = product.Type;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //create and load new inventory object

                Inventory = new Inventory
                {
                    Cost = (double) Price.Value,
                    ProductName = name.Text,
                    PurchaseDate = DatePicker.Value,
                    Quantity = (int) Quantity.Value,
                    SellingPrice = (double) SellingPrice.Value,
                    StockLocation = StockLocation.Text,
                    Threashold = (int) Threashold.Value,
                    Vendor = VendorTextBox.Text
                };
                Inventory.TotalCost = Inventory.Cost*Inventory.Quantity;
                Inventory.TotalPrice = Inventory.SellingPrice*Inventory.Quantity;

                DialogResult = DialogResult.OK;
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