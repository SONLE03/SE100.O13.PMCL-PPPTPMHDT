using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS.BUSPrint
{
    public class BUSPrintImportOrder
    {
        private int rowIndex = 0;
        private int x = 80;
        private DataGridView dataGrid;
        private IMPORT_BILL importBill;
        public BUSPrintImportOrder(DataGridView dataGrid, IMPORT_BILL importBill)
        {
            this.dataGrid = dataGrid;
            this.importBill = importBill;
        }
        public void PrintReport()
        {
            PrintDocument printPN = new PrintDocument();
            printPN.PrintPage += new PrintPageEventHandler(printPN_PrintPage); 
            PaperSize paperSize = new PaperSize("A5", (int)(148 / 25.4 * 100), (int)(210 / 25.4 * 100)); //Size A5
            printPN.DefaultPageSettings.PaperSize = paperSize;
            DialogResult _result = MessageBox.Show("Do you want to export an invoice??", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_result == DialogResult.Yes)
            {
                PrintPreviewDialog printPreviewDialogPN = new PrintPreviewDialog();
                printPreviewDialogPN.Document = printPN;
                printPreviewDialogPN.ShowDialog();
            }
        }
        public List<string> SplitString(string input, int maxLength)
        {
            List<string> parts = new List<string>();
            string[] words = input.Split(' ');

            StringBuilder currentPart = new StringBuilder();

            foreach (string word in words)
            {
                if (currentPart.Length + word.Length <= maxLength)
                {
                    currentPart.Append(word + " ");
                }
                else
                {
                    parts.Add(currentPart.ToString().Trim());
                    currentPart.Clear();
                    currentPart.Append(word + " ");
                }
            }

            if (currentPart.Length > 0)
            {
                parts.Add(currentPart.ToString().Trim());
            }

            return parts;
        }

        private void printPN_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int tableHeaderY = 230;
            PrintDocument printDoc = new PrintDocument();
            PaperSize paperSize = printDoc.DefaultPageSettings.PaperSize;
            int rowsPerPage = paperSize.Height;
            int rowCount = dataGrid.Rows.Count;
            if (rowIndex == 0)
            {
                string text = "COMMERCIAL INVOICE";
                Font font = new Font("Arial", 12, FontStyle.Bold);
                SizeF textSize = e.Graphics.MeasureString(text, font);
                int centerX = (e.PageBounds.Width - (int)textSize.Width) / 2;
                e.Graphics.DrawString(text, font, Brushes.Black, new Point(centerX, 50));
                int xLeft = 50;
                e.Graphics.DrawString("No: " + importBill.ImportID, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(xLeft, 90));
                e.Graphics.DrawString("Date: " + importBill.ImportDate, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(xLeft, 120));
                e.Graphics.DrawString("Create by: " + importBill.C_USER.UserID + " | " + importBill.C_USER.UserFullName, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(xLeft, 150));
                e.Graphics.DrawString("Supplier: " + importBill.SUPPLIER.SupplierName, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(xLeft, 180));

                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(50, tableHeaderY, 40, 25));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(90, tableHeaderY, 130, 25));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(220, tableHeaderY, 65, 25));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(285, tableHeaderY, 65, 25));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(350, tableHeaderY, 90, 25));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(440, tableHeaderY, 100, 25));

                e.Graphics.DrawString("No", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(52, 230));
                e.Graphics.DrawString("Product Name", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(92, 230));
                e.Graphics.DrawString("Unit", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(222, 230));
                e.Graphics.DrawString("Quantity", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(287, 230));
                e.Graphics.DrawString("Unit Price", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(352, 230));
                e.Graphics.DrawString("Total", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(442, 230));
                x = 255;
            }
            while (rowIndex < rowCount)
            {
                DataGridViewRow row = dataGrid.Rows[rowIndex];
                e.Graphics.DrawString(row.Cells[0].Value.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(52, x));
                string productName = row.Cells[1].Value.ToString();
                List<string> productNameParts = SplitString(productName, 15);
                foreach (var part in productNameParts)
                {
                    e.Graphics.DrawString(part, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(92, x));
                    x += 20;
                }
                e.Graphics.DrawString(row.Cells[2].Value.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(222, x - productNameParts.Count * 20));
                e.Graphics.DrawString(row.Cells[3].Value.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(287, x - productNameParts.Count * 20));
                e.Graphics.DrawString(row.Cells[4].Value.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(352, x - productNameParts.Count * 20));
                e.Graphics.DrawString(row.Cells[5].Value.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(442, x - productNameParts.Count * 20));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(50, x - productNameParts.Count * 20, 40, 20 * productNameParts.Count + 20));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(90, x - productNameParts.Count * 20, 130, 20 * productNameParts.Count + 20));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(220, x - productNameParts.Count * 20, 65, 20 * productNameParts.Count + 20));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(285, x - productNameParts.Count * 20, 65, 20 * productNameParts.Count + 20));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(350, x - productNameParts.Count * 20, 90, 20 * productNameParts.Count + 20));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(440, x - productNameParts.Count * 20, 100, 20 * productNameParts.Count + 20));
                x += 20;
                rowIndex++;
                if (e.PageBounds.Height - x <= 50 && rowCount > rowIndex)
                {
                    x = 80;
                    e.HasMorePages = true;
                    return;
                }
            }

            string date = "..., " + DateTime.Now.ToString("dddd, MMMM d, yyyy");
            e.Graphics.DrawString($"Total: {importBill.Total} VND", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(350, x + 20));
            e.Graphics.DrawString(date, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(320, x + 60));
            e.Graphics.DrawString("Authorized signature", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(342, x + 90));
        }
    }
}
