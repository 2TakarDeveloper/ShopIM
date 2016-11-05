using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ShopIM.Entity;

namespace ShopIM.UI.Forms
{
    public partial class ModifyCartItem : Form
    {
        private Inventory Inventory { get; set; }
        private Inventory StockInventory { get; set; }
 

        public ModifyCartItem(Inventory inventory,Inventory sampleInventory)
        {
            Inventory = inventory;
            StockInventory = sampleInventory;
         
            InitializeComponent();
            NameLable.Text = inventory.ProductName;
            SellingPrice.Value = (decimal) inventory.SellingPrice;
            SellingPrice.Minimum = (decimal) sampleInventory.Cost;
            SellingQuantity.Value = Inventory.Quantity;
            SellingQuantity.Maximum = StockInventory.Quantity+Inventory.Quantity;
            SellingQuantity.Minimum = 1;
            try
            {
                using (
                    var fileStream = new FileStream(inventory.Product.ImageURL, FileMode.Open, FileAccess.Read))
                {
                    ProductImage.Image = Image.FromStream(fileStream);
                }
            }
            catch (Exception)
            {
                ProductImage.Image = ProductImage.ErrorImage;
            }


        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int difference = Inventory.Quantity; ;
             Inventory.Quantity = (int) SellingQuantity.Value;
            difference -= Inventory.Quantity;
            Inventory.SellingPrice = (double) SellingPrice.Value;
            Inventory.TotalCost = Inventory.Quantity*Inventory.Cost;
            Inventory.TotalPrice = Inventory.Quantity*Inventory.SellingPrice;
            StockInventory.Quantity += difference;
            
            DialogResult =DialogResult.OK;
        }
    }
}
