using DTO;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS.BUSPrint
{
    public class BUSPrintInvoice
    {
        private int rowIndex = 0;
        private int x = 80;
        private DataGridView dataGrid;
        private BILL bill;
        public BUSPrintInvoice(DataGridView dataGrid, BILL bill)
        {
            this.dataGrid = dataGrid;
            this.bill = bill;
        }
        public void PrintReport()
        {
            PrintDocument printPN = new PrintDocument();
            printPN.PrintPage += new PrintPageEventHandler(printPN_PrintPage);
            PaperSize paperSize = new PaperSize("CustomSize", (int)(80 / 25.4 * 100), (int)(100 / 25.4 * 100)); // 80mm x 297mm
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
            int tableHeaderY = 130;
            PrintDocument printDoc = new PrintDocument();
            PaperSize paperSize = printDoc.DefaultPageSettings.PaperSize;
            int rowsPerPage = paperSize.Height;
            int rowCount = dataGrid.Rows.Count;
            if (rowIndex == 0)
            {
                string text = "THE COFFEE HOUSE";
                Font font = new Font("Arial", 10, FontStyle.Bold);

                // Lấy kích thước của văn bản
                SizeF textSize = e.Graphics.MeasureString(text, font);

                // Tính toán vị trí canh giữa theo chiều ngang
                int centerX = (e.PageBounds.Width - (int)textSize.Width) / 2;

                // Vẽ văn bản
                e.Graphics.DrawString(text, font, Brushes.Black, new Point(centerX, 20));

                // Định nghĩa vị trí x cho các thành phần
                int xLeft = 20;

                //Vẽ các thành phần khác

                e.Graphics.DrawString("No: " + bill.BillID, new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(xLeft, 50));
                e.Graphics.DrawString("Date: " + bill.BillDate, new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(xLeft, 65));
                e.Graphics.DrawString("Table: " + (bill.TableID != null ? (bill.C_TABLE.AREA.AreaName + " | " + bill.C_TABLE.TableName.ToString()) : "Take away"), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(xLeft, 95));
                e.Graphics.DrawString("Customer: Walk-in guest", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(xLeft, 110));
                e.Graphics.DrawString("Create by: " + bill.C_USER.UserID + " | " + bill.C_USER.UserFullName, new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(xLeft, 80));

                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(20, tableHeaderY, 90, 20));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(110, tableHeaderY, 30, 20));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(140, tableHeaderY, 40, 20));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(180, tableHeaderY, 50, 20));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(230, tableHeaderY, 60, 20));
                e.Graphics.DrawString("Drink Name", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(22, 135));
                e.Graphics.DrawString("Size", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(117, 135));
                e.Graphics.DrawString("Quantity", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(142, 135));
                e.Graphics.DrawString("Unit Price", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(182, 135));
                e.Graphics.DrawString("Total", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(232, 135));
                x = 155;
            }
            while (rowIndex < rowCount)
            {
                DataGridViewRow row = dataGrid.Rows[rowIndex];
                string productName = row.Cells[0].Value.ToString();
                List<string> productNameParts = SplitString(productName, 25);
                foreach (var part in productNameParts)
                {
                    e.Graphics.DrawString(part, new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(22, x));
                    x += 10;
                }
                //e.Graphics.DrawString(productName, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(110, x));
                e.Graphics.DrawString(row.Cells[1].Value.ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(117, x - productNameParts.Count * 10));
                e.Graphics.DrawString(row.Cells[2].Value.ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(142, x - productNameParts.Count * 10));
                e.Graphics.DrawString(row.Cells[3].Value.ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(182, x - productNameParts.Count * 10));
                e.Graphics.DrawString(row.Cells[4].Value.ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(232, x - productNameParts.Count * 10));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(20, x - productNameParts.Count * 10 - 5, 90, 20 * productNameParts.Count));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(110, x - productNameParts.Count * 10 - 5, 30, 20 * productNameParts.Count));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(140, x - productNameParts.Count * 10 - 5, 40, 20 * productNameParts.Count));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(180, x - productNameParts.Count * 10 - 5, 50, 20 * productNameParts.Count));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(230, x - productNameParts.Count * 10 - 5, 60, 20 * productNameParts.Count));
                x += 10;
                rowIndex++;
                if (e.PageBounds.Height - x <= 20 && rowCount > rowIndex)
                {
                    x = 20;
                    e.HasMorePages = true;
                    return;
                }
            }

            e.Graphics.DrawString("Subtotal: " + bill.SubTotal + " VND", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(160, x + 20));
            e.Graphics.DrawString("Tax: " + bill.Tax + " VND", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(160, x + 40));
            e.Graphics.DrawString("Total: " + bill.Total + " VND", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(160, x + 60));
        }
    }
}
