using BUS;
using BUS.BUSPrint;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UCBills_TabInvoices : UserControl
    {
        private BUSPrintInvoice printInvoice;
        public UCBills_TabInvoices()
        {
            InitializeComponent();
            cbFilter.SelectedIndex = 0;
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbFilter.Text.Contains("All"))
            {
                lbRevenue.Visible = true;
                lbRevenueValue.Visible = true;
                Binding(BUSOrder.Instance.GetAllInvoicesForYourShift());
                lbRevenueValue.Text = BUSOrder.Instance.revenue.ToString() + " VND";
            }
            else
            {
                lbRevenue.Visible = false;
                lbRevenueValue.Visible = false;
                Binding(BUSOrder.Instance.GetAllBill());
            }
        }

        private void Binding(List<BILL> bills)
        {
            Image print_img = Properties.Resources.printer;
            print_img = (Image)(new Bitmap(print_img, new Size(25, 25)));
            gridviewInvoice.Rows.Clear();
            bills.ForEach(p =>
            {
                gridviewInvoice.Rows.Add(p.id, p.BillID, p.BillDate.ToString("dd/MM/yyyy HH:mm:ss"), p.C_USER.UserFullName, p.BILL_DETAIL.Count, p.Status, p.Total, print_img);
            });
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            Binding(BUSOrder.Instance.Search(searchText));
        }

        private void gridviewInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            int billId = Convert.ToInt32(gridviewInvoice.Rows[idx].Cells["ID"].Value);
            if (e.ColumnIndex == gridviewInvoice.Columns["pinvoice"].Index)
            {
                print(billId);
                return;
            }
            InvoiceDetail invoiceDetail = new InvoiceDetail(billId);
            invoiceDetail.ShowDialog();
        }
        private void print(int billID)
        {
            dataGridViewPrint.Rows.Clear();
            var invoice = BUSOrder.Instance.GetBillById(billID);
            var invoiceDetail = invoice.BILL_DETAIL.ToList();
            foreach (var ind in invoiceDetail)
            {
                dataGridViewPrint.Rows.Add(ind.DRINK.DrinksName, ind.C_SIZE.SizeName, ind.Quantity, ind.Rate, ind.Amount);
            }
            printInvoice = new BUSPrintInvoice(dataGridViewPrint, invoice);
            printInvoice.PrintReport();
        }
    }
}
