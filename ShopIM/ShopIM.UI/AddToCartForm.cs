

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
using ShopIM.Entity;

namespace ShopIM.UI
{
    public partial class AddToCartForm : MetroFramework.Forms.MetroForm
    {

        private List<MetroLabel> labels;
        private List<NumericUpDown> quantities;
        private List<NumericUpDown> prices;
        private readonly int _length;


        public AddToCartForm(List<Inventory> inventories )
        {
            InitializeComponent();
            _length = inventories.Count;
            labels = new List<MetroLabel>(_length);
            quantities = new List<NumericUpDown>(_length);
            prices = new List<NumericUpDown>(_length);

            TableLayout.AutoSize = true;
            TableLayout.AutoScrollMinSize = new Size(400, 500);

            for (int i = 0; i < _length; i++)
            {
                
                MetroLabel label = new MetroLabel {Text = inventories[i].ProductName};
                labels.Add(label);

                NumericUpDown quantity = new NumericUpDown();
                quantity.Maximum = inventories[i].Quantity;
                quantities.Add(quantity);

                NumericUpDown price = new NumericUpDown();
                price.Maximum = 999999;
                price.Minimum = (decimal) inventories[i].Price;
                price.Text =inventories[i].Price.ToString();
                prices.Add(price);


                TableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                TableLayout.RowCount = TableLayout.RowStyles.Count;

                TableLayout.Controls.Add(labels[i], 0, i+1);
                TableLayout.Controls.Add(quantities[i], 1, i + 1);
                TableLayout.Controls.Add(prices[i], 2, i + 1);

             



            }

            MetroButton submitButton= new MetroButton();
            submitButton.Height = 30;
            submitButton.Text = @"Submit";
            submitButton.Dock = DockStyle.Fill;

            TableLayout.Controls.Add(submitButton, 0,_length+1);
            TableLayout.SetColumnSpan(submitButton, 3);



        }

        private void TableLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
