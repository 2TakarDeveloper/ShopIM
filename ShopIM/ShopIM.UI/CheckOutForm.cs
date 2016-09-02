

using System;
using System.Collections.Generic;
using MetroFramework.Controls;
using ShopIM.DAL;
using ShopIM.Entity;

namespace ShopIM.UI
{
    public partial class CheckOutForm : MetroFramework.Forms.MetroForm
    {
        private List<Inventory> cartInventories;

      

        public CheckOutForm(List<Inventory> cartInventories)
        {
            InitializeComponent();
            this.cartInventories = cartInventories;
            CheckoutGrid.DataSource = cartInventories;
            CheckoutGrid.Columns[4].Visible = false;
            double total=0;
            foreach (var inventory in cartInventories)
            {
                total += inventory.Quantity*inventory.Price;
            }
            TotalLable.Text = total.ToString();


        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
           var salesLogs = new List<SalesLog>();
            foreach (var inventory in cartInventories)
            {
               SalesLog salesLog = new SalesLog
                {
                    ProductName = inventory.ProductName,
                    Price = inventory.Price,
                    PurchaseDate = inventory.PurchaseDate,
                    SoldDate = DateTime.Now,
                    Quantity = inventory.Quantity,
                    UserName = SalesForm.UserName,
                    Cost = new InventoryContext().SalesUpdate(inventory)
                };
                salesLog.NetProfit=(salesLog.Price*salesLog.Quantity-salesLog.Cost*salesLog.Quantity);


                salesLogs.Add(salesLog);

            }
            new SalesLogContext().AddSalesLog(salesLogs);
            Close();
        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
