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
            DialogResult _result = MessageBox.Show("Do you want to export an invoice??", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_result == DialogResult.Yes)
            {
                PrintPreviewDialog printPreviewDialogPN = new PrintPreviewDialog();
                printPreviewDialogPN.Document = printPN;
                printPreviewDialogPN.ShowDialog();
            }
        }
        private void printPN_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            PaperSize paperSize = printDoc.DefaultPageSettings.PaperSize;
            int rowsPerPage = paperSize.Height;
            int rowCount = dataGrid.Rows.Count;
            if (rowIndex == 0)
            {
                string text = "COMMERCIAL INVOICE";
                Font font = new Font("Arial", 14, FontStyle.Bold);

                // Lấy kích thước của văn bản
                SizeF textSize = e.Graphics.MeasureString(text, font);

                // Tính toán vị trí canh giữa theo chiều ngang
                int centerX = (e.PageBounds.Width - (int)textSize.Width) / 2;

                // Vẽ văn bản
                e.Graphics.DrawString(text, font, Brushes.Black, new Point(centerX, 80));

                // Định nghĩa vị trí x cho các thành phần
                int xLeft = 100;
                int xRight = centerX + 230;

                // Vẽ các thành phần khác
                e.Graphics.DrawString("No: " + importBill.ImportID, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(xLeft, 150));
                e.Graphics.DrawString("Date: " + importBill.ImportDate, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(xRight, 150));
                e.Graphics.DrawString("Reporter: " + importBill.C_USER.UserFullName, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(xLeft, 180));
                e.Graphics.DrawString("Total: " + importBill.Total, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(xRight, 180));
              


                e.Graphics.DrawString("No", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 310));
                e.Graphics.DrawString("Product Name", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 310));
                e.Graphics.DrawString("Unit", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(430, 310));
                e.Graphics.DrawString("Quantity", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 310));
                e.Graphics.DrawString("Unit Price", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, 310));
                e.Graphics.DrawString("Total", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(790, 310));
                x = 360;
            }
            while (rowIndex < rowCount)
            {
                DataGridViewRow row = dataGrid.Rows[rowIndex];
                e.Graphics.DrawString(row.Cells[0].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, x));
                string productName = row.Cells[1].Value.ToString();
                if (productName.Length > 30)
                {
                    productName = productName.Substring(0, 30) + "...";
                }
                e.Graphics.DrawString(productName, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, x));
                e.Graphics.DrawString(row.Cells[2].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(430, x));
                e.Graphics.DrawString(row.Cells[3].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, x));
                e.Graphics.DrawString(row.Cells[4].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, x));
                e.Graphics.DrawString(row.Cells[5].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, x));
                x += 40;
                rowIndex++;
                if (rowsPerPage - x <= 100 && rowCount > rowIndex)
                {
                    x = 80;
                    e.HasMorePages = true;
                    return;
                }
            }

            string date = "..., ngày " + DateTime.Now.Day + ", tháng " + DateTime.Now.Month + ", năm " + DateTime.Now.Year;
            e.Graphics.DrawString(date, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(480, x));
            e.Graphics.DrawString("Người lập phiếu", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(535, x + 40));
        }
    }
}
