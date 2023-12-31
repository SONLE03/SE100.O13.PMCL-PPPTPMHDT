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
            PrintDocument printDoc = new PrintDocument();
            PaperSize paperSize = printDoc.DefaultPageSettings.PaperSize;
            int rowsPerPage = paperSize.Height;
            int rowCount = dataGrid.Rows.Count;
            if (rowIndex == 0)
            {
                string text = "THE COFFEE HOUSE";
                Font font = new Font("Arial", 14, FontStyle.Bold);

                // Lấy kích thước của văn bản
                SizeF textSize = e.Graphics.MeasureString(text, font);

                // Tính toán vị trí canh giữa theo chiều ngang
                int centerX = (e.PageBounds.Width - (int)textSize.Width) / 2;

                // Vẽ văn bản
                e.Graphics.DrawString(text, font, Brushes.Black, new Point(centerX, 80));

                // Định nghĩa vị trí x cho các thành phần
                int xLeft = 80;
                int xRight = centerX + 230;

                //Vẽ các thành phần khác

                e.Graphics.DrawString("No: " + bill.BillID, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(xLeft, 150));
                e.Graphics.DrawString("Date: " + bill.BillDate, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(xRight, 150));
                e.Graphics.DrawString("Table: " + (bill.TableID != null ? (bill.C_TABLE.AREA.AreaName + " | " + bill.C_TABLE.TableName.ToString()) : "Take away"), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(xLeft, 180));
                e.Graphics.DrawString("Customer: Walk-in guest", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(xRight, 180));
                e.Graphics.DrawString("Create by: " + bill.C_USER.UserID + " | " + bill.C_USER.UserFullName, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(xLeft, 210));


                e.Graphics.DrawString("Drink Name", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 310));
                e.Graphics.DrawString("Size", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(360, 310));
                e.Graphics.DrawString("Quantity", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(460, 310));
                e.Graphics.DrawString("Unit Price", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(580, 310));
                e.Graphics.DrawString("Total", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 310));
                x = 360;
            }
            while (rowIndex < rowCount)
            {
                DataGridViewRow row = dataGrid.Rows[rowIndex];
                string productName = row.Cells[0].Value.ToString();
                List<string> productNameParts = SplitString(productName, 30);
                foreach (var part in productNameParts)
                {
                    e.Graphics.DrawString(part, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, x));
                    x += 20;
                }
                //e.Graphics.DrawString(productName, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(110, x));
                e.Graphics.DrawString(row.Cells[1].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(360, x - productNameParts.Count * 20));
                e.Graphics.DrawString(row.Cells[2].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(460, x - productNameParts.Count * 20));
                e.Graphics.DrawString(row.Cells[3].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(580, x - productNameParts.Count * 20));
                e.Graphics.DrawString(row.Cells[4].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, x - productNameParts.Count * 20));
                x += 40;
                rowIndex++;
                if (rowsPerPage - x <= 100 && rowCount > rowIndex)
                {
                    x = 80;
                    e.HasMorePages = true;
                    return;
                }
            }

            e.Graphics.DrawString("Subtotal: " + bill.SubTotal + " VND", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(490, x + 20));
            e.Graphics.DrawString("Tax: " + bill.Tax + " VND", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(490, x + 50));
            e.Graphics.DrawString("Total: " + bill.Total + " VND", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(490, x + 80));
        }
    }
}
