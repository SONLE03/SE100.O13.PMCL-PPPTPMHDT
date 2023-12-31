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
    public partial class InvoiceDetail : Form
    {
        BILL bill;
        public InvoiceDetail(int id)
        {
            InitializeComponent();
            Bind(id);
        }
        private void Bind(int id)
        {
            bill = BUSOrder.Instance.GetBillById(id);
            lbInvoiceID.Text = bill.BillID;
            lbInvoiceDate.Text = bill.BillDate.ToString();
            lbCreateBy.Text = bill.C_USER.UserID + " | " + bill.C_USER.UserFullName.ToString();
            lbTotal.Text = bill.Total.ToString() + " VND";
            lbTax.Text = bill.Tax.ToString() + " Percent";
            lbSubTotal.Text = bill.SubTotal.ToString() + " VND";
            lbTable.Text = bill.TableID != null  ? (bill.C_TABLE.AREA.AreaName + " | " + bill.C_TABLE.TableName.ToString()) : "Take away";
            foreach(var billDetail in bill.BILL_DETAIL)
            {
                gridInvoiceDetails.Rows.Add(billDetail.DRINK.DrinksName, billDetail.C_SIZE.SizeName, billDetail.Quantity, billDetail.Rate, billDetail.Amount);
            }
        }
    }
}
