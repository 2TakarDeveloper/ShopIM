
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using ShopIM.Entity;

namespace ShopIM.UI.Controller
{
    public partial class InventoryInfoControl : UserControl
    {
        public InventoryInfoControl(Inventory inventory)
        {
            InitializeComponent();
            try
            {
                using (var fileStream = new FileStream(inventory.Product.ImageURL, FileMode.Open, FileAccess.Read))
                {
                    ProductImage.Image = Image.FromStream(fileStream);
                }
            }
            catch (Exception)
            {
                ProductImage.Image = ProductImage.ErrorImage;
            }

            Name.Text = inventory.ProductName;
            if (inventory.Product!= null)
            {
                Type.Text = inventory.Product.Type;
            }
            else
            {
                Type.Text = "";
            }
 
            Vendor.Text = inventory.Vendor;
            Quantity.Text = inventory.Quantity.ToString();
            Threashold.Text = inventory.Threashold.ToString();
            Price.Text=inventory.Price.ToString(CultureInfo.InvariantCulture);
            SellingPrice.Text = inventory.SellingPrice.ToString(CultureInfo.InvariantCulture);
            PurchaseDate.Text = inventory.PurchaseDate.ToShortDateString();
            StockLocation.Text = inventory.StockLocation;


        }
    }
}
