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
            Binding(BUSOrder.Instance.GetAllBill());
        }
        private void setBillFormality()
        {
            cbStatus.Items.AddRange(new string[] { "All", "On Spot", "Take Away" });
            cbStatus.SelectedIndex = 0;
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

        }

        private void gridviewInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
