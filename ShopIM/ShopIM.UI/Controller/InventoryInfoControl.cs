
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

            Type.Text = inventory.Product!= null ? inventory.Product.Type : "";
            Name.Text = inventory.ProductName;
            DueLable.Text = inventory.Due.ToString();
            Vendor.Text = inventory.Vendor;
            Quantity.Text = inventory.Quantity.ToString();
            Threashold.Text = inventory.Threashold.ToString();
            Price.Text=inventory.Cost.ToString(CultureInfo.InvariantCulture);
            SellingPrice.Text = inventory.SellingPrice.ToString(CultureInfo.InvariantCulture);
            PurchaseDate.Text = inventory.PurchaseDate.ToShortDateString();
            StockLocation.Text = inventory.StockLocation;
            StatusLable.Text = inventory.Status;
            switch (inventory.Status)
            {
                case "Due":
                    StatusLable.BackColor=Color.Blue;
                    break;
                case "Stock Short":
                    StatusLable.BackColor = Color.PaleVioletRed;
                    break;
                case "Out Of Stock":
                    StatusLable.BackColor = Color.DarkRed;
                    break;
                case "In Stock":
                    StatusLable.BackColor = Color.Green;
                    break;

            }
            


        }
    }
}
