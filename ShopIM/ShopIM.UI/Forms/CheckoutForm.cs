using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MetroFramework;
using ShopIM.BLL;
using ShopIM.Entity;
using Rectangle = iTextSharp.text.Rectangle;
namespace ShopIM.UI.Forms
{
    public partial class CheckoutForm : Form
    {
        private List<Inventory> Inventories { get; }
        private String UserName { get; set; }

        public CheckoutForm(List<Inventory> inventories,string userName )
        {
            UserName = userName;
            Inventories = inventories;
            InitializeComponent();
            CheckoutGrid.DataSource = Inventories;
            CheckoutGrid.Columns[0].Visible = false;
            CheckoutGrid.Columns[2].Visible = false;
            CheckoutGrid.Columns[3].Visible = false;
            
            CheckoutGrid.Columns[5].Visible = false;
            CheckoutGrid.Columns[6].Visible = false;
            CheckoutGrid.Columns[7].Visible = false;
            CheckoutGrid.Columns[9].Visible = false;
            CheckoutGrid.Columns[11].Visible = false;
            CheckoutGrid.Columns[12].Visible = false;
            CheckoutGrid.Columns[13].Visible = false;


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



        /// <summary>
        /// Only Works For My Client 
        /// </summary>
        private void CreatePDF()
        {
            //Create PDF
            string dummyFileName = "Invoice.pdf";


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

                    
                   
                    
                    //setupTable
                    PdfPTable table = new PdfPTable(5);
                    
                    PdfPCell cell = new PdfPCell(new Phrase("Abir Flower Shop"));        
                    cell.Colspan = 5;
                    cell.HorizontalAlignment = 1; 
                    table.AddCell(cell);


                    cell = new PdfPCell(new Phrase("Cash Memo"));
                    cell.Colspan = 5;
                    cell.HorizontalAlignment = 1;
                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase(DateTime.Now.ToString()));
                    cell.Colspan = 5;
                    cell.HorizontalAlignment = 1;
                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase("2/3 hazi Golamrosul Market(2nd floor), Tinpuler Matha,Jublee Road,Chittagong."));
                    cell.Colspan = 5;
                    cell.HorizontalAlignment = 1;
                    table.AddCell(cell);


                    cell = new PdfPCell(new Phrase("Mobile : 01818655875,01943364636 ,Telephone:621858"));
                    cell.Colspan = 5;
                    cell.HorizontalAlignment = 1;
                    table.AddCell(cell);




                    table.AddCell("#Sl");
                    table.AddCell("Product Name");
                    table.AddCell("Quantity");
                    table.AddCell("Unit Price");
                    table.AddCell("Total");
                    
                    

                    int counter = 0;
                    foreach (var inventory in Inventories)
                    {
                      
                        table.AddCell(counter++.ToString());
                        table.AddCell(inventory.ProductName);
                        table.AddCell(inventory.Quantity.ToString());
                        table.AddCell(inventory.SellingPrice.ToString());
                        table.AddCell(inventory.TotalPrice.ToString());
                    }

                    //Total
                    cell = new PdfPCell(new Phrase(TotalLable.Text))
                    {
                        Colspan = 5,
                        HorizontalAlignment = 2
                    };
                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase("N.B: Sold Products are not Eligble for Refund."));
                    cell.Colspan = 5;
                    cell.HorizontalAlignment = 1;
                    table.AddCell(cell);



                    doc.Add(table);

                    doc.Close();
                }
            }


         
        }
    }
}
