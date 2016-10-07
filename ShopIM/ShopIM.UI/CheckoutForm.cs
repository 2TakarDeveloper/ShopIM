using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using ShopIM.BLL;
using ShopIM.Entity;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ShopIM.UI
{
    public partial class CheckoutForm : Form
    {
        private List<Inventory> Inventories { get; set; }
        private String UserName { get; set; }

        public CheckoutForm(List<Inventory> inventories,string userName )
        {
            UserName = userName;
            Inventories = inventories;
            InitializeComponent();
            CheckoutGrid.DataSource = Inventories;
            CheckoutGrid.Columns[0].Visible = false;
            CheckoutGrid.Columns[2].Visible = false;
            CheckoutGrid.Columns[4].Visible = false;
            CheckoutGrid.Columns[9].Visible = false;
            CheckoutGrid.Columns[10].Visible = false;
            CheckoutGrid.Columns[11].Visible = false;

            double grandTotal=0;

            foreach (var inventory in Inventories)
            {
                grandTotal += inventory.TotalPrice;
            }

            TotalLable.Text = @"Total:"+grandTotal;
        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (new InventoryRepo().SellProduct(Inventories,UserName))
            {
                CreatePDF();
                DialogResult = DialogResult.OK;
                


            }
            else
            {
                MetroMessageBox.Show(this, "Database Error","Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
          
        }


        private void CreatePDF()
        {
            //Create PDF
            string dummyFileName = "Innovice.pdf";


            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = @"Portable Document Format (PDF)|*.pdf";

            // Feed the dummy name to the save dialog
            sf.FileName = dummyFileName;

            if (sf.ShowDialog() == DialogResult.OK)
            {
                // Now here's our save folder
                string savePath = Path.GetDirectoryName(sf.FileName);
                if (savePath == null) return;
                savePath = Path.Combine(savePath, sf.FileName);

                // Do whatever
                using (var fileStream = new FileStream(savePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {

                    Rectangle pageSize = new Rectangle(PageSize.A4);
                    Document doc = new Document(pageSize);
                    PdfWriter writer = PdfWriter.GetInstance(doc, fileStream);
                    doc.Open();


                    //Write in Doc
                    Paragraph paragraph = new Paragraph("---------Product----------------Quantity---------------Price----------");
                  
                    doc.Add(paragraph);
                    foreach (var inventory in Inventories)
                    {
                        paragraph = new Paragraph("------"+inventory.ProductName+"------------"+inventory.Quantity+"---------------"+inventory.TotalPrice+"----------");
                       
                        doc.Add(paragraph);
                    }
                    paragraph = new Paragraph(TotalLable.Text);

                    doc.Add(paragraph);


                    doc.Close();
                }
            }


         
        }
    }
}
