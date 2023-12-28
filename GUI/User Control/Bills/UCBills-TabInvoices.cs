using BUS;
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
            gridviewInvoice.Rows.Clear();
            bills.ForEach(p =>
            {
                gridviewInvoice.Rows.Add(p.id, p.BillID, p.BillDate, p.C_USER.UserFullName, p.BILL_DETAIL.Count, p.Status, p.Total);
            });
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var list = new List<BILL>();
            foreach (var p in BUSOrder.Instance.GetAllBill())
            {
                if (p.BillID.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    list.Add(p);
                }
            }
            Binding(list);
            // Adđ createBy
        }

        private void gridviewInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
